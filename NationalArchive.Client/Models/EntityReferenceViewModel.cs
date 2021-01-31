using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class EntityReferenceViewModel
    {
            public string Description { get; set; }
            public int EndDate { get; set; }
            public string FirstName { get; set; }
            public string PreTitle { get; set; }
            public int StartDate { get; set; }
            public string Surname { get; set; }
            public string Title { get; set; }
            public string XReferenceId { get; set; }
            public string XReferenceCode { get; set; }
            public string XReferenceName { get; set; }
            public string XReferenceType { get; set; }
            public string XReferenceURL { get; set; }
            public string XReferenceDescription { get; set; }
            public string XReferenceSortWord { get; set; }
    }
}
