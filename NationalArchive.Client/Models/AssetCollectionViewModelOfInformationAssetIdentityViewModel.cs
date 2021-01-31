using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace NationalArchive.Models
{
    [Serializable()]
    public class AssetCollectionViewModelOfInformationAssetIdentityViewModel : IEnumerable
    {
        
        public List<Attribute> assets { get; set; }
        public bool hasMoreAfterLast { get; set; }
        public bool hasMoreBeforeFirst { get; set; }

        public class Value
        {
            [JsonProperty("Value")]
            public string value { get; set; }
            public List<string> Values { get; set; }
        }

        public class Attribute
        {
            public string Key { get; set; }
            public Value Value { get; set; }
        }
        #region private
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this; 
        }

        #endregion
    }
}
