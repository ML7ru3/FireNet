using System;
using System.Windows.Forms;

namespace FireNetCSharp.View
{
    public partial class DeviceProperties : Form
    {

        private readonly Device _device;
        public DeviceProperties(Device device)
        {
            InitializeComponent();
            _device = device;
            nameLabel.Text = _device.Name;
            descriptionLabel.Text = _device.Description;
            IpLabel.Text = _device.IpAddress;
            MacLabel.Text = _device.MacAddress;
            netmaskLabel.Text = _device.Netmask; 
            broadcastLabel.Text = _device.Broadcast;
            linkLabel.Text = _device.LinkType;
        }

        private void DeviceProperties_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
