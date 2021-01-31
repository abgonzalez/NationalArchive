using Microsoft.Extensions.Logging;
using NationalArchive;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NationalArchive
{
    public class Menu : IMenu
    {
        private readonly ILogger<Menu> _logger;
        private readonly ITNARecordDetails _recordFileAuthority;
        public Menu(ILogger<Menu> logger,
                        ITNARecordDetails recordFileAuthority)
        {
            _logger = logger;
            _recordFileAuthority = recordFileAuthority;
        }
        public string GetRecord(string recordId)
        {
            return _recordFileAuthority.GetConsoleInfoByRecordId(recordId).Result;
        }
    }
}
