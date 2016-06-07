using NativeWifi;
using SimpleWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFi_Connector
{
    public partial class Form1 : Form
    {
        private Wifi wifi;

        public Form1()
        {
            //Sets UI culture to French (France)
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            //Sets UI culture to German (Germany)
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            InitializeComponent();
        }

        private void lstNetworks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Connect connect = new Connect();
            connect.Show();
            //name.Text = lstNetworks.SelectedItems[0].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove((tabConnect));
            btnFind.Enabled = true;

            wifi = new Wifi();

            List<AccessPoint> aps = wifi.GetAccessPoints();
            foreach (AccessPoint ap in aps)
            {
                ListViewItem lvItem = new ListViewItem(ap.Name);
                lvItem.SubItems.Add(ap.SignalStrength + "%");
                lvItem.Tag = ap;

                lstNetworks.Items.Add(lvItem);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();

            btnRefresh.Enabled = true;

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();
            btnFind.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                MessageBox.Show("Please enter a network to search for");
            }
            else
            {
                foreach (ListViewItem item in lstNetworks.Items)
                {
                    if (item.Text.ToLower().StartsWith(txtSearch.Text.ToLower()))
                    {
                        item.Selected = true;
                        item.BackColor = Color.CornflowerBlue;
                        item.ForeColor = Color.Red;
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

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a network to search for");
                }
                else
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
        }

        private void lstNetworks_DoubleClick(object sender, EventArgs e)
        {
            int index = 1;
            tabControl1.TabPages.Insert(index, tabConnect);
            tabControl1.SelectTab(tabConnect);
            ConnectToNetwork();

            if (tabControl1.SelectedTab == tabFind)
            {
                tabControl1.TabPages.Remove(tabConnect);
            }
        }

        private void ConnectToNetwork()
        {
            textBox1.Text = lstNetworks.SelectedItems[0].ToString();
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Red;
            textBox1.Enabled = false;
        }
    }
}