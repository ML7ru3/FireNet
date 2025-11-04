using SharpPcap;
using System;

namespace FireNetCSharp
{
    public class NetworkCaptureService
    {
        public void ListDevices()
        {
            var devices = CaptureDeviceList.Instance;
            foreach (var dev in devices)
            {
                Console.WriteLine("{0}\n", dev.ToString());
            }
        }
    }
}
