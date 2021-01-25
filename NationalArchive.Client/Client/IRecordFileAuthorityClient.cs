using NationalArchive.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalArchive
{
    public interface IRecordFileAuthorityClient
    {
        Task<RecordFileAuthority> GetRecordByRecordId(string recordId);
        Task<IEnumerable<RecordFileAuthority>> GetAllDetailsRecord();
    }
}