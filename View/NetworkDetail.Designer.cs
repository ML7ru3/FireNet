namespace FireNetCSharp.View
{
    partial class NetworkDetail
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
            this.applicationList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // applicationList
            // 
            this.applicationList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.applicationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationList.HideSelection = false;
            this.applicationList.Location = new System.Drawing.Point(0, 0);
            this.applicationList.Name = "applicationList";
            this.applicationList.Size = new System.Drawing.Size(242, 429);
            this.applicationList.TabIndex = 0;
            this.applicationList.UseCompatibleStateImageBehavior = false;
            // 
            // NetworkDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 429);
            this.Controls.Add(this.applicationList);
            this.MaximizeBox = false;
            this.Name = "NetworkDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Network Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkDetail_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView applicationList;
    }
}