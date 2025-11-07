using FireNetCSharp.Controller.Interface;
using SharpPcap;
using System;
using System.Threading.Tasks;

namespace FireNetCSharp.Controller
{
    internal class NetworkStatisticService(ICaptureDevice device) : INetworkStatisticService
    {

        private ICaptureDevice _device = device;
        private long _byteReceived = 0;
        
        public Task<int> GetDownloadStatistic()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetUploadStatistic()
        {
            throw new NotImplementedException();
        }
    }
}
