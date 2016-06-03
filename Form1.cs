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

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstNetworks.SelectedItems.Count > 0 && txtSearch.Text.Length > 0)
            {
                ListViewItem selectedItem = lstNetworks.SelectedItems[0];
                AccessPoint ap = (AccessPoint)selectedItem.Tag;

                if (connectToWifi(ap, txtSearch.Text))
                    label1.Text = "You connected successfully to the network" + ap.Name + ".";
                else
                    label1.Text = "Connection Failed";
            }
            else
                label1.Text = "Please select a network \nor enter a password";
            //lstNetworks.Items.Clear();

            //btnSearch.Enabled = true;

            //WlanClient client = new WlanClient();
            //foreach (WlanClient.WlanInterface wlanface in client.Interfaces)
            //{
            //    Wlan.WlanAvailableNetwork[] networks = wlanface.GetAvailableNetworkList(0);

            //    foreach (Wlan.WlanAvailableNetwork network in networks)
            //    {
            //        Wlan.Dot11Ssid ssid = network.dot11Ssid;
            //        string networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);

            //        ListViewItem item = new ListViewItem(networkName);
            //        item.SubItems.Add(network.dot11DefaultCipherAlgorithm.ToString());
            //        item.SubItems.Add(network.wlanSignalQuality + "%");
            //        lstNetworks.Items.Add(item);
            //        networks.FirstOrDefault();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();

            btnSearch.Enabled = false;
        }

        private void lstNetworks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Connect connect = new Connect();

            connect.Show();

            //Form Details = new Form();
            //Label NetworkName = new Label();
            //NetworkName.Text = "Network Name";
            //TextBox name = new TextBox();
            //Label signalLabel = new Label();
            //signalLabel.Text = "Signal Strength";
            //TextBox signal = new TextBox();
            //Details.Controls.Add(NetworkName);
            //Details.Controls.Add(name);
            //Details.Controls.Add(signalLabel);
            //Details.Controls.Add(signal);
            //NetworkName.Location = new Point(10, 10);
            //name.Location = new Point(10, 35);
            //name.Size = new Size(199, 20);
            //signalLabel.Location = new Point(10, 70);
            //signal.Location = new Point(10, 95);
            //signal.Size = new Size(199, 20);
            //Button connect = new Button();
            //connect.Location = new Point(170, 225);
            //connect.Text = "Connect";
            //Details.Text = lstNetworks.SelectedItems[0].Text;
            //Details.Controls.Add(connect);
            //Details.ShowDialog();

            //name.Text = lstNetworks.SelectedItems[0].ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in lstNetworks.Items)
            //{
            //    if (item.Text.ToLower().StartsWith(txtSearch.Text.ToLower()))
            //    {
            //        item.Selected = true;
            //        item.BackColor = Color.CornflowerBlue;
            //        item.ForeColor = Color.Red;
            //    }
            //    else
            //    {
            //        item.Selected = false;
            //        item.BackColor = Color.White;
            //        item.ForeColor = Color.Black;
            //    }
            //    if (lstNetworks.SelectedItems.Count == 1)
            //    {
            //        lstNetworks.Focus();
            //    }
            //}
        }

        private bool connectToWifi(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap);
            authRequest.Password = password;

            return ap.Connect(authRequest);
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
    }
}