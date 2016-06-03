using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFi_Connector
{
    public partial class Create_New_Network : Form
    {
        private Process newProcess = new Process();

        public Create_New_Network()
        {
            InitializeComponent();
            newProcess.StartInfo.UseShellExecute = false;
            newProcess.StartInfo.CreateNoWindow = true;
            newProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            InitializeComponent();
        }

        public bool isUserAdmin()
        {
            bool isAdmin;

            try
            {
                WindowsIdentity userIdentity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(userIdentity);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public void StopBroadcasting()
        {
            newProcess.StartInfo.FileName = "netsh";
            newProcess.StartInfo.Arguments = "wlan stop hostednetwork";

            try
            {
                using (Process execute = Process.Start(newProcess.StartInfo))
                    execute.WaitForExit();
                SetWlanDetails();
            }
            catch (Exception)
            {
            }
        }

        public void StartBroadcasting()
        {
            newProcess.StartInfo.FileName = "netsh";
            newProcess.StartInfo.Arguments = "wlan start hostednetwork";

            try
            {
                using (Process execute = Process.Start(newProcess.StartInfo))
                    execute.WaitForExit();
                button1.Text = "Stop";
            }
            catch (Exception)
            {
            }
        }

        public void SetWlanDetails()
        {
            newProcess.StartInfo.FileName = "netsh";
            newProcess.StartInfo.Arguments = "wlan set hostednetwork mode=allow" + textBox1.Text + " key=" + textBox2.Text;

            try
            {
                using (Process execute = Process.Start(newProcess.StartInfo))
                    execute.WaitForExit();
                StartBroadcasting();
            }
            catch (Exception)
            {
            }
        }

        public void StopProcess()
        {
            newProcess.StartInfo.FileName = "netsh";
            newProcess.StartInfo.Arguments = "wlan stop hostednetwork";

            try
            {
                using (Process execute = Process.Start(newProcess.StartInfo))
                    execute.WaitForExit();
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                StopBroadcasting();
                button1.Text = "Stop";
            }
            else
            {
                StopProcess();
                button1.Text = "Start";
            }
        }
    }
}