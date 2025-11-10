using FireNetCSharp.Controller.Interface;
using FireNetCSharp.Model;
using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireNetCSharp.Controller
{
    public class NetworkCaptureService(LibPcapLiveDevice device) : INetworkCaptureService
    {
        private RawCapture rawPacket;
        public readonly List<PacketDetail> listProcessedPackets = new List<PacketDetail>();
        private LibPcapLiveDevice _device = device;
        
        private long _downloadBytes = 0;
        private long _uploadBytes = 0;
        private DateTime _captureStartTime;

        public Task StartCapturing()
        {
            _downloadBytes = 0;
            _uploadBytes = 0;
            _captureStartTime = DateTime.UtcNow;

            _device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
            _device.StartCapture();
            return Task.CompletedTask;
        }

        public Task StopCapturing()
        {
            _device.StopCapture();
            return Task.CompletedTask;  
        }

        public double GetDownloadStatistic()
        {
            double seconds = (DateTime.UtcNow - _captureStartTime).TotalSeconds;
            if (seconds <= 0) return 0;

            double megabits = (_downloadBytes * 8.0) / (1024); // bytes → kilo bits
            double mbps = megabits / seconds;
            return Math.Round(mbps, 2);
        }

        public double GetUploadStatistic()
        {
            double seconds = (DateTime.UtcNow - _captureStartTime).TotalSeconds;
            if (seconds <= 0) return 0;

            double megabits = (_uploadBytes * 8.0) / (1024);
            double mbps = megabits / seconds;
            return Math.Round(mbps, 2);
        }

        private void OnPacketArrival(object sender, PacketCapture e)
        {
            try
            {
                rawPacket = e.GetPacket();
                PacketDetail newPacket = new PacketDetail();
                
                newPacket.Time = rawPacket.Timeval.Date;

                var packet = PacketDotNet.Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);
                var ipPacket = packet.Extract<IPPacket>();

                if (ipPacket != null)
                {
                    newPacket.Source = ipPacket.SourceAddress.ToString();
                    newPacket.Destination = ipPacket.DestinationAddress.ToString();
                    newPacket.Length = ipPacket.TotalLength;
                    newPacket.Protocol = ipPacket.Protocol.ToString();

                    if (newPacket.Source == _device.Addresses.FirstOrDefault().Addr.ipAddress.ToString())
                    {
                        _uploadBytes += newPacket.Length;
                    }
                    else
                    {
                        _downloadBytes += newPacket.Length;
                    }

                    //listProcessedPackets.Add(newPacket);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing packet: {ex.Message}");
            }
        }
    }
}
