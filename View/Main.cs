using System;
using System.Windows.Forms;
using FireNetCSharp.Controller;
using FireNetCSharp.Controller.Interface;
using FireNetCSharp.View;
using SharpPcap;
using SharpPcap.LibPcap;

namespace FireNetCSharp
{
    public partial class Main : Form
    {
        private IDeviceService _deviceService;
        private INetworkStatisticService _networkStatisticService;
        private LibPcapLiveDevice _selectedDevice;

        public Main(IDeviceService deviceService)
        {
            InitializeComponent();
            _deviceService = deviceService;
            _networkStatisticService = new NetworkStatisticService();
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
                    cmbDevices.Items.Add(dev.Description); // The name of the device
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
            _selectedDevice.Open();
        }

        private void propertiesClicked(object sender, EventArgs e)
        {
            if (_selectedDevice == null)
            {
                MessageBox.Show("Please select a device first.", "No Device Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeviceProperties deviceProperties = new DeviceProperties(new Device(_selectedDevice));
            deviceProperties.Show();
        }

        private void btnCaptureSelected(object sender, EventArgs e)
        {
            if (_selectedDevice == null)
            {
                MessageBox.Show("Please select a device first.", "No Device Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startCaptureButton.Text == "Start Capturing")
            {
                _networkStatisticService.StartCapturing(_selectedDevice);
                startCaptureButton.Text = "Stop Capturing";
                cmbDevices.Enabled = false;
            }
            else
            {
                _networkStatisticService.StopCapturing(_selectedDevice);
                startCaptureButton.Text = "Start Capturing";
                cmbDevices.Enabled = true; 
            }
        }
    }
}
