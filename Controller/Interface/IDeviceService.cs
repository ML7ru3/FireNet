using FireNetCSharp.Model;
using SharpPcap;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FireNetCSharp.Controller.Interface
{
    internal interface IDeviceService
    {
        List<Device> GetAllDeviceInfo();
    }
}
