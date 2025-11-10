namespace FireNetCSharp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.networkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.propertiesButton = new System.Windows.Forms.Button();
            this.packetCaptureGrid = new System.Windows.Forms.DataGridView();
            this.startCaptureButton = new System.Windows.Forms.Button();
            this.firewallTab = new System.Windows.Forms.TabControl();
            this.networkTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._updateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.networkChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetCaptureGrid)).BeginInit();
            this.firewallTab.SuspendLayout();
            this.networkTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(478, 23);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(247, 21);
            this.cmbDevices.TabIndex = 0;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1042, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // networkChart
            // 
            chartArea1.Name = "ChartArea1";
            this.networkChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.networkChart.Legends.Add(legend1);
            this.networkChart.Location = new System.Drawing.Point(324, 59);
            this.networkChart.Name = "networkChart";
            this.networkChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.networkChart.Series.Add(series1);
            this.networkChart.Size = new System.Drawing.Size(812, 527);
            this.networkChart.TabIndex = 3;
            this.networkChart.Text = "chart1";
            // 
            // propertiesButton
            // 
            this.propertiesButton.Location = new System.Drawing.Point(731, 21);
            this.propertiesButton.Name = "propertiesButton";
            this.propertiesButton.Size = new System.Drawing.Size(75, 23);
            this.propertiesButton.TabIndex = 4;
            this.propertiesButton.Text = "Properties";
            this.propertiesButton.UseVisualStyleBackColor = true;
            this.propertiesButton.Click += new System.EventHandler(this.propertiesClicked);
            // 
            // packetCaptureGrid
            // 
            this.packetCaptureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packetCaptureGrid.Location = new System.Drawing.Point(10, 59);
            this.packetCaptureGrid.Name = "packetCaptureGrid";
            this.packetCaptureGrid.Size = new System.Drawing.Size(308, 527);
            this.packetCaptureGrid.TabIndex = 5;
            // 
            // startCaptureButton
            // 
            this.startCaptureButton.Location = new System.Drawing.Point(356, 21);
            this.startCaptureButton.Name = "startCaptureButton";
            this.startCaptureButton.Size = new System.Drawing.Size(116, 23);
            this.startCaptureButton.TabIndex = 6;
            this.startCaptureButton.Text = "Start Capturing";
            this.startCaptureButton.UseVisualStyleBackColor = true;
            this.startCaptureButton.Click += new System.EventHandler(this.btnCaptureSelected);
            // 
            // firewallTab
            // 
            this.firewallTab.Controls.Add(this.networkTab);
            this.firewallTab.Controls.Add(this.tabPage2);
            this.firewallTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firewallTab.Location = new System.Drawing.Point(0, 0);
            this.firewallTab.Name = "firewallTab";
            this.firewallTab.SelectedIndex = 0;
            this.firewallTab.Size = new System.Drawing.Size(1150, 636);
            this.firewallTab.TabIndex = 7;
            // 
            // networkTab
            // 
            this.networkTab.Controls.Add(this.packetCaptureGrid);
            this.networkTab.Controls.Add(this.cmbDevices);
            this.networkTab.Controls.Add(this.networkChart);
            this.networkTab.Controls.Add(this.propertiesButton);
            this.networkTab.Controls.Add(this.btnRefresh);
            this.networkTab.Controls.Add(this.startCaptureButton);
            this.networkTab.Location = new System.Drawing.Point(4, 22);
            this.networkTab.Name = "networkTab";
            this.networkTab.Padding = new System.Windows.Forms.Padding(3);
            this.networkTab.Size = new System.Drawing.Size(1142, 610);
            this.networkTab.TabIndex = 0;
            this.networkTab.Text = "Network";
            this.networkTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Firewall";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1150, 636);
            this.Controls.Add(this.firewallTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FireNet";
            ((System.ComponentModel.ISupportInitialize)(this.networkChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetCaptureGrid)).EndInit();
            this.firewallTab.ResumeLayout(false);
            this.networkTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart networkChart;
        private System.Windows.Forms.Button propertiesButton;
        private System.Windows.Forms.DataGridView packetCaptureGrid;
        private System.Windows.Forms.Button startCaptureButton;
        private System.Windows.Forms.TabControl firewallTab;
        private System.Windows.Forms.TabPage networkTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer _updateTimer;
    }
}

