using System;
using System.Windows.Forms;
using SharpPcap;

namespace FireNetCSharp
{
    public partial class Form1 : Form
    {
        private CaptureDeviceList devices;

        public Form1()
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
                devices = CaptureDeviceList.Instance;

                cmbDevices.Items.Clear();

                if (devices.Count == 0)
                {
                    MessageBox.Show("No network devices found. Please install Npcap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var dev in devices)
                {
                    cmbDevices.Items.Add(dev.Description);
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
            if (cmbDevices.SelectedIndex >= 0)
            {
                var device = devices[cmbDevices.SelectedIndex];
                lstDeviceInfo.Items.Clear();
                lstDeviceInfo.Items.Add(device.ToString());
            }
        }
    }
}
