using FireNetCSharp.Controller.Interface;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Threading.Tasks;

namespace FireNetCSharp.Controller
{
    public class NetworkStatisticService() : INetworkStatisticService
    {
        public Task StartCapturing(LibPcapLiveDevice device)
        {
            device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
            device.StartCapture();
            return Task.CompletedTask;
        }

        public Task StopCapturing(LibPcapLiveDevice device)
        {
            device.StopCapture();
            return Task.CompletedTask;  
        }

        private void OnPacketArrival(object sender, PacketCapture e)
        {
            try
            {
                var rawPacket = e.GetPacket();
                var time = rawPacket.Timeval.Date;
                var length = rawPacket.Data.Length;
                Console.WriteLine($"{time.ToLongTimeString()} Len={length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing packet: {ex.Message}");
            }
        }
    }
}
