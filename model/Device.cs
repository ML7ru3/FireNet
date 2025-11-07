
namespace FireNetCSharp
{

    /// <summary>
    /// device model
    /// </summary>
    internal class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? MacAddress { get; set; }
        public string? IpAddress { get; set; }
        public string? Netmask { get; set; }
        public string? Broadcast { get; set; }
        public string? LinkType { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\r\n" +
                   $"Description: {Description}\r\n" +
                   $"MAC: {MacAddress ?? "N/A"}\r\n" +
                   $"IP: {IpAddress ?? "N/A"}\r\n" +
                   $"Netmask: {Netmask ?? "N/A"}\r\n" +
                   $"Broadcast: {Broadcast ?? "N/A"}\r\n" +
                   $"LinkType: {LinkType ?? "N/A"}";
        }
    }
}
