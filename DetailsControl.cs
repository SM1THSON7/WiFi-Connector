using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFi_Connector
{
    public class DetailsControl
    {
        public DetailsControl(Form form)
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
        }
    }
}