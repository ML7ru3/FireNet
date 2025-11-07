namespace FireNetCSharp
{
    /// <summary>
    /// device model
    /// </summary>
    public class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MacAddress { get; set; }
        public string IpAddress { get; set; }
        public string Netmask { get; set; }
        public string Broadcast { get; set; }
        public string LinkType { get; set; }
    }
}
