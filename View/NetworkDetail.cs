using System.Windows.Forms;

namespace FireNetCSharp.View
{
    public partial class NetworkDetail : Form
    {
        public NetworkDetail()
        {
            InitializeComponent();
        }

        private void NetworkDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
