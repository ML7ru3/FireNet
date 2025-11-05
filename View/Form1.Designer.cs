namespace FireNetCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstDeviceInfo = new System.Windows.Forms.ListBox();
            this.networkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.networkChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(482, 12);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(247, 21);
            this.cmbDevices.TabIndex = 0;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(551, 550);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lstDeviceInfo
            // 
            this.lstDeviceInfo.FormattingEnabled = true;
            this.lstDeviceInfo.Location = new System.Drawing.Point(12, 46);
            this.lstDeviceInfo.Name = "lstDeviceInfo";
            this.lstDeviceInfo.Size = new System.Drawing.Size(266, 498);
            this.lstDeviceInfo.TabIndex = 2;
            // 
            // networkChart
            // 
            chartArea1.Name = "ChartArea1";
            this.networkChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.networkChart.Legends.Add(legend1);
            this.networkChart.Location = new System.Drawing.Point(326, 46);
            this.networkChart.Name = "networkChart";
            this.networkChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.networkChart.Series.Add(series1);
            this.networkChart.Size = new System.Drawing.Size(795, 498);
            this.networkChart.TabIndex = 3;
            this.networkChart.Text = "chart1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1150, 585);
            this.Controls.Add(this.networkChart);
            this.Controls.Add(this.lstDeviceInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbDevices);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.networkChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstDeviceInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart networkChart;
    }
}

