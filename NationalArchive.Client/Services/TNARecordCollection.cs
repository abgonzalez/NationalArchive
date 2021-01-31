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

namespace NationalArchive.Client
{
    public class TNARecordCollection : ITNARecordCollection, IDisposable
    {
        private static HttpClient _client = new HttpClient();
        private readonly ILogger<TNARecordCollection> _logger;
        private readonly TNARecordDetails _TNARecordDetails;
        private string detailsRecord_endpoint = "/API/records/v1/collection/";
        private string baseAddress = "http://discovery.nationalarchives.gov.uk";
        bool disposed;
        public TNARecordCollection(ILogger<TNARecordCollection> logger, TNARecordDetails TNARecordDetails)
        {
            _logger = logger;
            _TNARecordDetails = TNARecordDetails;
        }
        public async Task<IEnumerable<AssetCollectionViewModelOfInformationAssetIdentityViewModel>> GetAllDetailsRecord(String reference)
        {
            try { 
            string assetsCollection_endpoint = baseAddress + detailsRecord_endpoint + reference;
            var request = new HttpRequestMessage(
                HttpMethod.Get, assetsCollection_endpoint);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = await _client.GetAsync(assetsCollection_endpoint))
            {
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<AssetCollectionViewModelOfInformationAssetIdentityViewModel>>(json);
                return result;
            }
            }
            catch(Exception exception)
            {
                _logger.LogError($"Exception when retrieving record id {exception}");
            }
            return null;
        }
        public String GetIdsWithoutTitleScopeContent(IEnumerable<AssetCollectionViewModelOfInformationAssetIdentityViewModel> data, String reference)
        {
            try
            {
                foreach (AssetCollectionViewModelOfInformationAssetIdentityViewModel item in data)
                {
                    foreach (InformationAssetIdentityViewModel itemCollection in item)
                    {
                        var result = _TNARecordDetails.GetConsoleInfoByRecordId(itemCollection.id).Result;
                        if (result == reference)
                        {
                            return itemCollection.id;
                        }
                    }
                }
            }
            catch ( Exception exception)
            {
                _logger.LogError($"Exception when retrieving record id {exception}");
            }
            return null;
        }
        public String GetIdsWithoutTitleScopeContentByReference(String reference)
        {
            var records = GetAllDetailsRecord(reference).Result;
            
            return GetIdsWithoutTitleScopeContent(records, reference);
        }
        #region internal

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
