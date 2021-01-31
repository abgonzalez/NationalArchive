using System;
using System.Collections.Generic;
using System.Text;

namespace NationalArchive.Models
{
    [Serializable()]
    public class Accessregulation
    {
        public string[] ClosureCriteria { get; set; }
        public int ClosureSetId { get; set; }
        public DateTime SignedDate { get; set; }
        public DateTime ReviewDate { get; set; }
        public DateTime ReconsiderDueInDate { get; set; }
        public string LordChancellorsInstrument { get; set; }
        public string Explanation { get; set; }
        public string ProcatTitleText { get; set; }
    }
}
