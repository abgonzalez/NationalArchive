using System.Threading.Tasks;

namespace NationalArchive
{
    public interface IMenu
    {
        string GetRecord(string recordId);
    }
}