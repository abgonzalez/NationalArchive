using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class InformationAssetIdentityViewModel
    {
        public string accessConditions { get; set; }
        public int catalogueId { get; set; }
        public string citableReference { get; set; }
        public string closureCode { get; set; }
        public string closureStatus { get; set; }
        public string closureType { get; set; }
        public string coveringDates { get; set; }
        public int coveringFromDate { get; set; }
        public int coveringToDate { get; set; }
        public ScopeContentViewModel scopeContent { get; set; }
        public bool digitised { get; set; }
        public XReferenceViewModel[] heldBy { get; set; }
        public string id { get; set; }
        public bool isParent { get; set; }
        public int catalogueLevel { get; set; }
        public string parentId { get; set; }
        public string recordOpeningDate { get; set; }
        public string referencePart { get; set; }
        public string referenceParentId { get; set; }
        public string sortKey { get; set; }
        public string source { get; set; }
        public string title { get; set; }

    }
}
