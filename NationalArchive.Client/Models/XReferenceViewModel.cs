using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class XReferenceViewModel
    {
            public string XReferenceId { get; set; }
            public string XReferenceCode { get; set; }
            public string XReferenceName { get; set; }
            public string XReferenceType { get; set; }
            public string XReferenceURL { get; set; }
            public string XReferenceDescription { get; set; }
            public string XReferenceSortWord { get; set; }
    }
}
