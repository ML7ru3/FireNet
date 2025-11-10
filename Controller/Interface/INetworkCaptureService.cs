using SharpPcap.LibPcap;
using System.Threading.Tasks;

namespace FireNetCSharp.Controller.Interface
{
    internal interface INetworkCaptureService
    {
        Task StartCapturing();
        Task StopCapturing();
        double GetDownloadStatistic();
        double GetUploadStatistic();
    }
}
