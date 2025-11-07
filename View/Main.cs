using System;
using System.Windows.Forms;
using FireNetCSharp.Controller;
using FireNetCSharp.View;
using SharpPcap;

namespace FireNetCSharp
{
    public partial class Main : Form
    {
        private DeviceService _deviceService = new DeviceService();
        private Device _selectedDevice;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void LoadDevices()
        {
            try
            {
                var devices = _deviceService.GetAllDeviceInfo();

                cmbDevices.Items.Clear();

                if (devices.Count == 0)
                {
                    MessageBox.Show("No network devices found. Please install Npcap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var dev in devices)
                {
                    cmbDevices.Items.Add(dev.Name);
                }

                cmbDevices.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading devices: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var devices = _deviceService.GetAllDeviceInfo();
            if (cmbDevices.SelectedIndex >= 0)
            {
                _selectedDevice = devices[cmbDevices.SelectedIndex];
            }
        }

        private void propertiesClicked(object sender, EventArgs e)
        {
            if (_selectedDevice == null)
            {
                MessageBox.Show("Please select a device first.", "No Device Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeviceProperties deviceProperties = new DeviceProperties(_selectedDevice);
            deviceProperties.Show();
        }
    }
}
