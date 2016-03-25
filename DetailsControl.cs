using System.Drawing;
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

            Label WpsState = new Label();
            WpsState.Text = "Wps State";
            TextBox txtWpsState = new TextBox();

            Label WpsVersion = new Label();
            WpsVersion.Text = "Wps Version";
            TextBox txtWpsVersion = new TextBox();

            Label ResponseType = new Label();
            ResponseType.Text = "Response Type";
            TextBox txtResponseType = new TextBox();

            Label ModelName = new Label();
            ModelName.Text = "Model Name";
            TextBox txtModelName = new TextBox();

            Label ModelNumber = new Label();
            ModelNumber.Text = "Model Number";
            TextBox txtModelNumber = new TextBox();

            Label SerialNumber = new Label();
            SerialNumber.Text = "Serial Number";
            TextBox txtSerialNumber = new TextBox();

            Label DeviceName = new Label();
            DeviceName.Text = "Device Name";
            TextBox txtDeviceName = new TextBox();

            Label DeviceType = new Label();
            DeviceType.Text = "Device Type";
            TextBox txtDeviceType = new TextBox();

            Label ManuFacturer = new Label();
            ManuFacturer.Text = "Manufacturer";
            TextBox txtManufacturer = new TextBox();

            Label UUIDEnrolle = new Label();
            UUIDEnrolle.Text = "UUID Enrolle";
            TextBox txtUUIDEnrolle = new TextBox();

            Label SupportedRates = new Label();
            SupportedRates.Text = "Supported Rates";
            TextBox txtSupportedRates = new TextBox();

            Label Band = new Label();
            Band.Text = "Band";
            TextBox txtBand = new TextBox();

            Label Authentication = new Label();
            Authentication.Text = "Authentication";
            TextBox txtAuthentication = new TextBox();

            Label Cipher = new Label();
            Cipher.Text = "Cipher";
            TextBox txtCipher = new TextBox();

            Label PacketSize = new Label();
            PacketSize.Text = "Packet Size";
            TextBox txtPacketSize = new TextBox();

            Details.Controls.Add(connect);
            Details.ShowDialog();
        }
    }
}