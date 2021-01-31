using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class ScopeContentViewModel
    {
        public string[] PlaceNames { get; set; }
        public string Description { get; set; }
        public string Ephemera { get; set; }
        public string Schema { get; set; }
    }
}
