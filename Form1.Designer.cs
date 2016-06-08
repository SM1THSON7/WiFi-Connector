namespace WiFi_Connector
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstNetworks = new System.Windows.Forms.ListView();
            this.SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Encryption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Signal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConnect = new System.Windows.Forms.TabPage();
            this.chkPW = new System.Windows.Forms.CheckBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNetworkName = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblIP = new System.Windows.Forms.Label();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.tabFind.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Double click a Connection to view the details";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.btnClear);
            this.tabFind.Controls.Add(this.btnRefresh);
            this.tabFind.Controls.Add(this.lstNetworks);
            this.tabFind.Controls.Add(this.btnFind);
            this.tabFind.Controls.Add(this.txtSearch);
            resources.ApplyResources(this.tabFind, "tabFind");
            this.tabFind.Name = "tabFind";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lstNetworks
            // 
            this.lstNetworks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SSID,
            this.Encryption,
            this.Signal});
            this.lstNetworks.FullRowSelect = true;
            resources.ApplyResources(this.lstNetworks, "lstNetworks");
            this.lstNetworks.Name = "lstNetworks";
            this.lstNetworks.UseCompatibleStateImageBehavior = false;
            this.lstNetworks.View = System.Windows.Forms.View.Details;
            this.lstNetworks.DoubleClick += new System.EventHandler(this.lstNetworks_DoubleClick);
            // 
            // SSID
            // 
            resources.ApplyResources(this.SSID, "SSID");
            // 
            // Encryption
            // 
            resources.ApplyResources(this.Encryption, "Encryption");
            // 
            // Signal
            // 
            resources.ApplyResources(this.Signal, "Signal");
            // 
            // btnFind
            // 
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.Name = "btnFind";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFind);
            this.tabControl1.Controls.Add(this.tabConnect);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabConnect
            // 
            this.tabConnect.Controls.Add(this.lblNetwork);
            this.tabConnect.Controls.Add(this.chkDetails);
            this.tabConnect.Controls.Add(this.pnl1);
            this.tabConnect.Controls.Add(this.chkPW);
            this.tabConnect.Controls.Add(this.lblPassword);
            this.tabConnect.Controls.Add(this.lblNetworkName);
            this.tabConnect.Controls.Add(this.btnConnect);
            this.tabConnect.Controls.Add(this.textBox2);
            resources.ApplyResources(this.tabConnect, "tabConnect");
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.UseVisualStyleBackColor = true;
            // 
            // chkPW
            // 
            resources.ApplyResources(this.chkPW, "chkPW");
            this.chkPW.Name = "chkPW";
            this.chkPW.UseVisualStyleBackColor = true;
            this.chkPW.CheckedChanged += new System.EventHandler(this.chkPW_CheckedChanged);
            // 
            // lblConfirm
            // 
            resources.ApplyResources(this.lblConfirm, "lblConfirm");
            this.lblConfirm.Name = "lblConfirm";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblNetworkName
            // 
            resources.ApplyResources(this.lblNetworkName, "lblNetworkName");
            this.lblNetworkName.Name = "lblNetworkName";
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.lblIP);
            this.pnl1.Controls.Add(this.lblConfirm);
            resources.ApplyResources(this.pnl1, "pnl1");
            this.pnl1.Name = "pnl1";
            // 
            // lblIP
            // 
            resources.ApplyResources(this.lblIP, "lblIP");
            this.lblIP.Name = "lblIP";
            // 
            // chkDetails
            // 
            resources.ApplyResources(this.chkDetails, "chkDetails");
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.CheckedChanged += new System.EventHandler(this.chkDetails_CheckedChanged);
            // 
            // lblNetwork
            // 
            resources.ApplyResources(this.lblNetwork, "lblNetwork");
            this.lblNetwork.Name = "lblNetwork";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabFind.ResumeLayout(false);
            this.tabFind.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabConnect.ResumeLayout(false);
            this.tabConnect.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lstNetworks;
        private System.Windows.Forms.ColumnHeader SSID;
        private System.Windows.Forms.ColumnHeader Encryption;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ColumnHeader Signal;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNetworkName;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.CheckBox chkPW;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblNetwork;
    }
}

