using FireNetCSharp.Controller.Interface;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FireNetCSharp.Controller
{
    internal class DeviceService : IDeviceService
    {
        private readonly CaptureDeviceList _deviceList;

        public DeviceService()
        {
            // Initialize the device list from SharpPcap
            _deviceList = CaptureDeviceList.Instance;
        }

        public List<Device> GetAllDeviceInfo()
        {
            var devices = new List<Device>();
            foreach (var dev in _deviceList)
            {
                if (dev is LibPcapLiveDevice liveDev)
                {
                    try
                    {
                        liveDev.Open(); // Required before accessign some fields

                        var firstAddr = liveDev.Addresses.FirstOrDefault(a => a.Addr?.ipAddress != null);
                        devices.Add(new Device
                        {
                            Name = liveDev.Description,
                            Description = liveDev.Name,
                            MacAddress = liveDev.MacAddress?.ToString() ?? "N/A",
                            IpAddress = firstAddr?.Addr?.ipAddress?.ToString() ?? "N/A",
                            Netmask = firstAddr?.Netmask?.ipAddress?.ToString() ?? "N/A",
                            Broadcast = firstAddr?.Broadaddr?.ipAddress?.ToString() ?? "N/A",
                            LinkType = liveDev.LinkType.ToString() ?? "N/A",
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading {liveDev.Name}: {ex.Message}");
                    }
                    finally
                    {
                        if (liveDev.Opened)
                            liveDev.Close(); // Always close when done
                    }
                }
            }


            return devices;
        }
    }
}
