using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class ReferenceType
    {
        string Key { get; set; }
        string Value { get; set; }

    }
    //public enum ReferenceType
    //{
    //    NRA_CATALOGUE,
    //    NRA_OTHER
    //}
}
