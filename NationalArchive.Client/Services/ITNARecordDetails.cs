using NationalArchive.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalArchive
{
    public interface ITNARecordDetails
    {
        Task<String> GetConsoleInfoByRecordId(String recordId);
        Task<InformationAssetViewModel> GetRecordByRecordId(string recordId);
        Task<IEnumerable<InformationAssetViewModel>> GetAllDetailsRecord();
    }
}