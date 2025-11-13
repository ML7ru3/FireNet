namespace FireNetCSharp.Model
{
    /// <summary>
    /// model for process ID
    /// </summary>
    public class ProcessID
    {
        public string PID { get; set; }
        public string Name { get; set; }   
        public double DownloadRate{ get; set; }
        public double UploadRate { get; set; }
    }
}
