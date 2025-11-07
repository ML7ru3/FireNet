using System.Threading.Tasks;

namespace FireNetCSharp.Controller.Interface
{
    internal interface INetworkStatisticService
    {
        Task<int> GetDownloadStatistic();

        Task<int> GetUploadStatistic();
    }
}
