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
    public class TNARecordDetails : ITNARecordDetails, IDisposable
    {
        private static HttpClient _client = new HttpClient();
        private readonly ILogger<TNARecordDetails> _logger;
        private string detailsRecord_endpoint = "/API/records/v1/details/";
        private string baseAddress = "http://discovery.nationalarchives.gov.uk";
        bool disposed;
        public TNARecordDetails(ILogger<TNARecordDetails> logger)
        {
            _logger = logger;
        }
      
     
        public async Task<String> GetConsoleInfoByRecordId(String recordId)
        {

            try
            {
                string url = baseAddress + detailsRecord_endpoint + recordId;
                var response = await _client.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<InformationAssetViewModel>(json);
                    //var result2= (InformationAssetViewModel)Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(InformationAssetViewModel));
                    return parseRecordDetails(result);
                }
                else if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    _logger.LogDebug($"Not found content : {recordId}");
                    return "no record found";
                }
                else
                {
                    _logger.LogDebug($"Unexpected Response HttpStatusCode: {response.StatusCode}");
                }
            }
            catch (Exception exception)
            {
                _logger.LogError($"Exception when retrieving record id {exception}");
            }
            return null;
        }
        public async Task<IEnumerable<InformationAssetViewModel>> GetAllDetailsRecord()
        {
            try
            {
                var request = new HttpRequestMessage(
                    HttpMethod.Get, detailsRecord_endpoint);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await _client.SendAsync(request,
                  HttpCompletionOption.ResponseHeadersRead))
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    response.EnsureSuccessStatusCode();
                    return stream.ReadAndDeserializeFromJson<List<InformationAssetViewModel>>();
                }

            }
            catch ( Exception exception)
            {
                _logger.LogError($"Exception when retrieving record id {exception}");
            }
            return null;
        }
        public async Task<InformationAssetViewModel> GetRecordByRecordId(String recordId)
        {

            try
            {
                string url = baseAddress + detailsRecord_endpoint + recordId;
                var response = await _client.GetAsync(url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<InformationAssetViewModel>(json);
                    return result;
                }
                else if (response.StatusCode == HttpStatusCode.NoContent)
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
        #region internal
        public String parseRecordDetails(InformationAssetViewModel record)
        {
            if (!String.IsNullOrEmpty(record.Title))
            {
                return record.Title;
            }
            else if (!String.IsNullOrEmpty(record.ScopeContent.Description))
            {
                return record.ScopeContent.Description;
            }
            else if (!String.IsNullOrEmpty(record.CitableReference))
            {
                return record.CitableReference;
            }
            else
                return "not sufficent information";
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
        #endregion
    }
}
