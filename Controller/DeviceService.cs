using FireNetCSharp.Controller.Interface;
using FireNetCSharp.Model;
using SharpPcap;
using System.Collections.Generic;

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
            _deviceList.Refresh();

            var devices = new List<Device>();

            foreach (var dev in _deviceList)
            {
                devices.Add(new Device
                {
                    Name = dev.Name,
                    Description = dev.Description,
                });
            }

            return devices;
        }
    }
}
