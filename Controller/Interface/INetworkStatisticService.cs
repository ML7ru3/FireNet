using SharpPcap.LibPcap;
using System.Threading.Tasks;

namespace FireNetCSharp.Controller.Interface
{
    internal interface INetworkStatisticService
    {
        Task StartCapturing(LibPcapLiveDevice device);

        Task StopCapturing(LibPcapLiveDevice device);
    }
}
