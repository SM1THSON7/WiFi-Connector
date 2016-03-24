using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Form Details = new Form();
            Label NetworkName = new Label();
            NetworkName.Text = "Network Name";
            TextBox name = new TextBox();
            Label signalLabel = new Label();
            signalLabel.Text = "Signal Strength";
            TextBox signal = new TextBox();
            Details.Controls.Add(NetworkName);
            Details.Controls.Add(name);
            Details.Controls.Add(signalLabel);
            Details.Controls.Add(signal);
            NetworkName.Location = new Point(10, 10);
            name.Location = new Point(10, 35);
            name.Size = new Size(199, 20);
            signalLabel.Location = new Point(10, 70);
            signal.Location = new Point(10, 95);
            signal.Size = new Size(199, 20);
            Button connect = new Button();
            connect.Location = new Point(170, 225);
            connect.Text = "Connect";
            Details.Controls.Add(connect);
            Details.ShowDialog();

            name.Text = lstNetworks.SelectedItems[0].ToString();
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
                btnSearch.Enter += btnSearch_Click;
            }
        }

        private void BtnSearch_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}