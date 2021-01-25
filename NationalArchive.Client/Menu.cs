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
        private readonly IRecordFileAuthorityClient _recordFileAuthority;
        public Menu(ILogger<Menu> logger,
                        IRecordFileAuthorityClient recordFileAuthority)
        {
            _logger = logger;
            _recordFileAuthority = recordFileAuthority;
        }
        public string GetRecord(string recordId)
        {
            var record = _recordFileAuthority.GetRecordByRecordId(recordId).Result;
            if (record == null)
            {
                return "Not found content";
            }
            // If the Title is not null return Title
            else if (!(string.IsNullOrWhiteSpace(record.Title)))
            {
                return record.Title;
            }
            else if (!(string.IsNullOrWhiteSpace(record.ScopeContent.Description)))
            {
                return record.ScopeContent.Description;
            }
            else if (!(string.IsNullOrWhiteSpace(record.CitableReference)))
            {
                return record.CitableReference;
            }
            else if (string.IsNullOrWhiteSpace(record.ReferenceParentId))
            {
                return "Not sufficient information";
            }
            return "Error";
        }
    }
}
