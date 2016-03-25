using NativeWifi;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiFi_Connector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();

            btnSearch.Enabled = true;

            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanface in client.Interfaces)
            {
                Wlan.WlanAvailableNetwork[] networks = wlanface.GetAvailableNetworkList(0);

                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    Wlan.Dot11Ssid ssid = network.dot11Ssid;
                    string networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);

                    ListViewItem item = new ListViewItem(networkName);
                    item.SubItems.Add(network.dot11DefaultCipherAlgorithm.ToString());
                    item.SubItems.Add(network.wlanSignalQuality + "%");
                    lstNetworks.Items.Add(item);
                    networks.FirstOrDefault();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();

            btnSearch.Enabled = false;
        }

        private void lstNetworks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DetailsForm tf = new DetailsForm();
            tf.ShowDialog();

            //DetailsControl dc = new DetailsControl(this);

            //name.Text = lstNetworks.SelectedItems[0].ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstNetworks.Items)
            {
                if (item.Text.ToLower().StartsWith(txtSearch.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = Color.CornflowerBlue;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.Selected = false;
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                if (lstNetworks.SelectedItems.Count == 1)
                {
                    lstNetworks.Focus();
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (ListViewItem item in lstNetworks.Items)
                {
                    if (item.Text.ToLower().StartsWith(txtSearch.Text.ToLower()))
                    {
                        item.Selected = true;
                        item.BackColor = Color.CornflowerBlue;
                        item.ForeColor = Color.White;
                    }
                    else
                    {
                        item.Selected = false;
                        item.BackColor = Color.White;
                        item.ForeColor = Color.Black;
                    }
                    if (lstNetworks.SelectedItems.Count == 1)
                    {
                        lstNetworks.Focus();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}