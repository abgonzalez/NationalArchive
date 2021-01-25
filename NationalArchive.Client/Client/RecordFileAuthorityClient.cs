using Marvin.StreamExtensions;
using NationalArchive.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace NationalArchive
{
    public class RecordFileAuthorityClient : IRecordFileAuthorityClient, IDisposable
    {
        private static HttpClient _client = new HttpClient();
        private readonly ILogger<RecordFileAuthorityClient> _logger;
        private string detailsRecord_endpoint = "/API/records/v1/details/";
        private string baseAddress = "http://discovery.nationalarchives.gov.uk";
        bool disposed;
        public RecordFileAuthorityClient(ILogger<RecordFileAuthorityClient> logger)
        {
            _logger = logger;
        }
      
        public async Task<RecordFileAuthority> GetRecordByRecordId(String recordId)
        {

            try
            {
                string url = baseAddress + detailsRecord_endpoint + recordId;
                var response = await _client.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<RecordFileAuthority>(json);
                    return result;
                }
                else if(response.StatusCode== HttpStatusCode.NoContent)
                {
                    _logger.LogDebug($"Not found content : {recordId}");
                    return null;
                }
                else
                {
                    _logger.LogDebug($"Response HttpStatusCode: {response.StatusCode}");
                }
            }
            catch (Exception exception)
            {
                _logger.LogError($"Exception when retrieving record id {exception}");
            }
            return null;
        }
        public async Task<IEnumerable<RecordFileAuthority>> GetAllDetailsRecord()
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get, detailsRecord_endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = await _client.SendAsync(request,
              HttpCompletionOption.ResponseHeadersRead))
            {
                var stream = await response.Content.ReadAsStreamAsync();
                response.EnsureSuccessStatusCode();
                return stream.ReadAndDeserializeFromJson<List<RecordFileAuthority>>();
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
