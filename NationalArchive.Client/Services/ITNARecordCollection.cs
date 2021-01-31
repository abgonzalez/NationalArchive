using NationalArchive.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NationalArchive.Client
{
    public interface ITNARecordCollection
    {
        void Dispose();
        Task<IEnumerable<AssetCollectionViewModelOfInformationAssetIdentityViewModel>> GetAllDetailsRecord(string reference);
        string GetIdsWithoutTitleScopeContent(IEnumerable<AssetCollectionViewModelOfInformationAssetIdentityViewModel> data, string reference);
        string GetIdsWithoutTitleScopeContentByReference(string reference);
    }
}