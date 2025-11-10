using FireNetCSharp.Controller;
using FireNetCSharp.Controller.Interface;
using FireNetCSharp.View;
using SharpPcap;
using SharpPcap.LibPcap;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FireNetCSharp
{
    public partial class Main : Form
    {
        private IDeviceService _deviceService;
        private INetworkCaptureService _networkCaptureSerivice;
        private LibPcapLiveDevice _selectedDevice;
        public Main(IDeviceService deviceService)
        {
            InitializeComponent();
            _deviceService = deviceService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDevices();
            _updateTimer = new Timer();
            _updateTimer.Interval = 1000; // update every second
            _updateTimer.Tick += UpdateChart;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDevices();
            InitializeChart();
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

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var devices = _deviceService.GetAllDeviceInfo();
            if (cmbDevices.SelectedIndex >= 0)
            {
                _selectedDevice = devices[cmbDevices.SelectedIndex];
            }
            _selectedDevice.Open();
            _networkCaptureSerivice = new NetworkCaptureService(_selectedDevice);
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
                _networkCaptureSerivice.StartCapturing();
                startCaptureButton.Text = "Stop Capturing";
                CapturingState(true);

                _updateTimer.Start();
                InitializeChart();
            }
            else
            {
                _networkCaptureSerivice.StopCapturing();
                startCaptureButton.Text = "Start Capturing";
                CapturingState(false);

                _updateTimer.Stop();
            }
        }

        private void UpdateChart(object sender, EventArgs e)
        {
            if (_selectedDevice == null) return;

            double downloadSpeed = _networkCaptureSerivice.GetDownloadStatistic();
            double uploadSpeed = _networkCaptureSerivice.GetUploadStatistic();

            // Limit points to last 60
            if (networkChart.Series["downloadSpeed"].Points.Count > 60)
            {
                networkChart.Series["downloadSpeed"].Points.RemoveAt(0);
                networkChart.Series["uploadSpeed"].Points.RemoveAt(0);
            }

            string time = DateTime.Now.ToString("HH:mm:ss");
            networkChart.Series["downloadSpeed"].Points.AddXY(time, downloadSpeed);
            networkChart.Series["uploadSpeed"].Points.AddXY(time, uploadSpeed);

            // Tooltip
            networkChart.Series["downloadSpeed"].ToolTip = $"#VALY at {time}";
            networkChart.Series["uploadSpeed"].ToolTip = $"#VALY at {time}";
        }

        private void InitializeChart()
        {
            networkChart.Series["downloadSpeed"].Points.Clear();
            networkChart.Series["uploadSpeed"].Points.Clear();
        }

        private void CapturingState(bool started)
        {
            cmbDevices.Enabled = !started;
            btnRefresh.Enabled = !started; 
        }
    }
}
