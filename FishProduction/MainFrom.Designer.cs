namespace FishProduction
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.BaseSettingstab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butProInfo = new System.Windows.Forms.Button();
            this.readPowerbut = new System.Windows.Forms.Button();
            this.powerCompensation = new System.Windows.Forms.Button();
            this.readIDButton = new System.Windows.Forms.Button();
            this.writeButtonID = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BaudComBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openSerialPort = new System.Windows.Forms.Button();
            this.scanPort = new System.Windows.Forms.Button();
            this.serialPortBox = new System.Windows.Forms.ComboBox();
            this.port = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.setMainportBut = new System.Windows.Forms.Button();
            this.readSimIDbutton = new System.Windows.Forms.Button();
            this.readVersionNumBut = new System.Windows.Forms.Button();
            this.getSparePortBut = new System.Windows.Forms.Button();
            this.readSpareServerBut = new System.Windows.Forms.Button();
            this.setKey2IdBut = new System.Windows.Forms.Button();
            this.setKey1IdBut = new System.Windows.Forms.Button();
            this.setIpSelectBut = new System.Windows.Forms.Button();
            this.ipSelectBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyId2Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyId1Box = new System.Windows.Forms.TextBox();
            this.readMainPortBut = new System.Windows.Forms.Button();
            this.sparePortBox = new System.Windows.Forms.TextBox();
            this.setmainPortBox = new System.Windows.Forms.TextBox();
            this.spareServerAddreBox = new System.Windows.Forms.TextBox();
            this.mainServerAddrBox = new System.Windows.Forms.TextBox();
            this.readMainServAddr = new System.Windows.Forms.Button();
            this.setSpareAddreButton = new System.Windows.Forms.Button();
            this.setMainServerAddress = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clearFlash = new System.Windows.Forms.Button();
            this.resetBoard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.boardidBox = new System.Windows.Forms.TextBox();
            this.setboardid = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BaseSettingstab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseSettingstab
            // 
            this.BaseSettingstab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseSettingstab.Controls.Add(this.tabPage1);
            this.BaseSettingstab.Controls.Add(this.tabPage2);
            this.BaseSettingstab.Controls.Add(this.tabPage3);
            this.BaseSettingstab.Location = new System.Drawing.Point(0, 0);
            this.BaseSettingstab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaseSettingstab.Name = "BaseSettingstab";
            this.BaseSettingstab.SelectedIndex = 0;
            this.BaseSettingstab.Size = new System.Drawing.Size(766, 374);
            this.BaseSettingstab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.BaseSettingstab.TabIndex = 0;
            this.BaseSettingstab.SelectedIndexChanged += new System.EventHandler(this.BaseSettingstab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(758, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基础设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.butProInfo);
            this.groupBox3.Controls.Add(this.readPowerbut);
            this.groupBox3.Controls.Add(this.powerCompensation);
            this.groupBox3.Controls.Add(this.readIDButton);
            this.groupBox3.Controls.Add(this.writeButtonID);
            this.groupBox3.Controls.Add(this.idLabel);
            this.groupBox3.Controls.Add(this.IdtextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 163);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(730, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // butProInfo
            // 
            this.butProInfo.Location = new System.Drawing.Point(100, 110);
            this.butProInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butProInfo.Name = "butProInfo";
            this.butProInfo.Size = new System.Drawing.Size(181, 35);
            this.butProInfo.TabIndex = 6;
            this.butProInfo.Text = "产品信息管理";
            this.butProInfo.UseVisualStyleBackColor = true;
            this.butProInfo.Visible = false;
            this.butProInfo.Click += new System.EventHandler(this.butProInfo_Click);
            // 
            // readPowerbut
            // 
            this.readPowerbut.Location = new System.Drawing.Point(566, 110);
            this.readPowerbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readPowerbut.Name = "readPowerbut";
            this.readPowerbut.Size = new System.Drawing.Size(112, 35);
            this.readPowerbut.TabIndex = 5;
            this.readPowerbut.Text = "读取电量";
            this.readPowerbut.UseVisualStyleBackColor = true;
            this.readPowerbut.Click += new System.EventHandler(this.readPowerbut_Click);
            // 
            // powerCompensation
            // 
            this.powerCompensation.Location = new System.Drawing.Point(566, 26);
            this.powerCompensation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerCompensation.Name = "powerCompensation";
            this.powerCompensation.Size = new System.Drawing.Size(112, 35);
            this.powerCompensation.TabIndex = 4;
            this.powerCompensation.Text = "电量补偿";
            this.powerCompensation.UseVisualStyleBackColor = true;
            this.powerCompensation.Click += new System.EventHandler(this.powerCompensation_Click);
            // 
            // readIDButton
            // 
            this.readIDButton.Location = new System.Drawing.Point(369, 110);
            this.readIDButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readIDButton.Name = "readIDButton";
            this.readIDButton.Size = new System.Drawing.Size(112, 35);
            this.readIDButton.TabIndex = 3;
            this.readIDButton.Text = "读取板子ID";
            this.readIDButton.UseVisualStyleBackColor = true;
            this.readIDButton.Click += new System.EventHandler(this.readIDButton_Click);
            // 
            // writeButtonID
            // 
            this.writeButtonID.Location = new System.Drawing.Point(369, 26);
            this.writeButtonID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.writeButtonID.Name = "writeButtonID";
            this.writeButtonID.Size = new System.Drawing.Size(112, 35);
            this.writeButtonID.TabIndex = 2;
            this.writeButtonID.Text = "写入ID";
            this.writeButtonID.UseVisualStyleBackColor = true;
            this.writeButtonID.Click += new System.EventHandler(this.writeButtonID_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(40, 35);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 18);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(100, 30);
            this.IdtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(180, 28);
            this.IdtextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BaudComBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.openSerialPort);
            this.groupBox1.Controls.Add(this.scanPort);
            this.groupBox1.Controls.Add(this.serialPortBox);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(730, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // BaudComBox
            // 
            this.BaudComBox.FormattingEnabled = true;
            this.BaudComBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "57600",
            "115200"});
            this.BaudComBox.Location = new System.Drawing.Point(100, 95);
            this.BaudComBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaudComBox.Name = "BaudComBox";
            this.BaudComBox.Size = new System.Drawing.Size(180, 26);
            this.BaudComBox.TabIndex = 6;
            this.BaudComBox.Text = "9600";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "波特率";
            // 
            // openSerialPort
            // 
            this.openSerialPort.Location = new System.Drawing.Point(566, 25);
            this.openSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openSerialPort.Name = "openSerialPort";
            this.openSerialPort.Size = new System.Drawing.Size(112, 35);
            this.openSerialPort.TabIndex = 4;
            this.openSerialPort.Text = "打开串口";
            this.openSerialPort.UseVisualStyleBackColor = true;
            this.openSerialPort.Click += new System.EventHandler(this.openSerialPort_Click);
            // 
            // scanPort
            // 
            this.scanPort.Location = new System.Drawing.Point(369, 25);
            this.scanPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanPort.Name = "scanPort";
            this.scanPort.Size = new System.Drawing.Size(112, 35);
            this.scanPort.TabIndex = 3;
            this.scanPort.Text = "扫描";
            this.scanPort.UseVisualStyleBackColor = true;
            this.scanPort.Click += new System.EventHandler(this.scanPort_Click);
            // 
            // serialPortBox
            // 
            this.serialPortBox.FormattingEnabled = true;
            this.serialPortBox.Location = new System.Drawing.Point(100, 30);
            this.serialPortBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serialPortBox.Name = "serialPortBox";
            this.serialPortBox.Size = new System.Drawing.Size(180, 26);
            this.serialPortBox.TabIndex = 2;
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(32, 35);
            this.port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(44, 18);
            this.port.TabIndex = 1;
            this.port.Text = "端口";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.setMainportBut);
            this.tabPage2.Controls.Add(this.readSimIDbutton);
            this.tabPage2.Controls.Add(this.readVersionNumBut);
            this.tabPage2.Controls.Add(this.getSparePortBut);
            this.tabPage2.Controls.Add(this.readSpareServerBut);
            this.tabPage2.Controls.Add(this.setKey2IdBut);
            this.tabPage2.Controls.Add(this.setKey1IdBut);
            this.tabPage2.Controls.Add(this.setIpSelectBut);
            this.tabPage2.Controls.Add(this.ipSelectBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.KeyId2Box);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.keyId1Box);
            this.tabPage2.Controls.Add(this.readMainPortBut);
            this.tabPage2.Controls.Add(this.sparePortBox);
            this.tabPage2.Controls.Add(this.setmainPortBox);
            this.tabPage2.Controls.Add(this.spareServerAddreBox);
            this.tabPage2.Controls.Add(this.mainServerAddrBox);
            this.tabPage2.Controls.Add(this.readMainServAddr);
            this.tabPage2.Controls.Add(this.setSpareAddreButton);
            this.tabPage2.Controls.Add(this.setMainServerAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(758, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "高级设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "设置备端口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setMainportBut
            // 
            this.setMainportBut.Location = new System.Drawing.Point(597, 250);
            this.setMainportBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setMainportBut.Name = "setMainportBut";
            this.setMainportBut.Size = new System.Drawing.Size(112, 35);
            this.setMainportBut.TabIndex = 26;
            this.setMainportBut.Text = "设置主端口";
            this.setMainportBut.UseVisualStyleBackColor = true;
            this.setMainportBut.Click += new System.EventHandler(this.setMainportBut_Click);
            // 
            // readSimIDbutton
            // 
            this.readSimIDbutton.Location = new System.Drawing.Point(436, 29);
            this.readSimIDbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readSimIDbutton.Name = "readSimIDbutton";
            this.readSimIDbutton.Size = new System.Drawing.Size(138, 35);
            this.readSimIDbutton.TabIndex = 25;
            this.readSimIDbutton.Text = "获取SIM卡号";
            this.readSimIDbutton.UseVisualStyleBackColor = true;
            this.readSimIDbutton.Click += new System.EventHandler(this.readSimIDbutton_Click_1);
            // 
            // readVersionNumBut
            // 
            this.readVersionNumBut.Location = new System.Drawing.Point(436, 74);
            this.readVersionNumBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readVersionNumBut.Name = "readVersionNumBut";
            this.readVersionNumBut.Size = new System.Drawing.Size(138, 35);
            this.readVersionNumBut.TabIndex = 24;
            this.readVersionNumBut.Text = "获取版本号";
            this.readVersionNumBut.UseVisualStyleBackColor = true;
            this.readVersionNumBut.Visible = false;
            this.readVersionNumBut.Click += new System.EventHandler(this.readVersionNumBut_Click);
            // 
            // getSparePortBut
            // 
            this.getSparePortBut.Location = new System.Drawing.Point(237, 74);
            this.getSparePortBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getSparePortBut.Name = "getSparePortBut";
            this.getSparePortBut.Size = new System.Drawing.Size(172, 35);
            this.getSparePortBut.TabIndex = 23;
            this.getSparePortBut.Text = "获取备服务器端口";
            this.getSparePortBut.UseVisualStyleBackColor = true;
            this.getSparePortBut.Click += new System.EventHandler(this.getSparePortBut_Click);
            // 
            // readSpareServerBut
            // 
            this.readSpareServerBut.Location = new System.Drawing.Point(12, 74);
            this.readSpareServerBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readSpareServerBut.Name = "readSpareServerBut";
            this.readSpareServerBut.Size = new System.Drawing.Size(159, 35);
            this.readSpareServerBut.TabIndex = 22;
            this.readSpareServerBut.Text = "获取备服务器";
            this.readSpareServerBut.UseVisualStyleBackColor = true;
            this.readSpareServerBut.Click += new System.EventHandler(this.readSpareServerBut_Click);
            // 
            // setKey2IdBut
            // 
            this.setKey2IdBut.Location = new System.Drawing.Point(436, 163);
            this.setKey2IdBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setKey2IdBut.Name = "setKey2IdBut";
            this.setKey2IdBut.Size = new System.Drawing.Size(138, 35);
            this.setKey2IdBut.TabIndex = 21;
            this.setKey2IdBut.Text = "设置Key2Id";
            this.setKey2IdBut.UseVisualStyleBackColor = true;
            this.setKey2IdBut.Click += new System.EventHandler(this.setKey2IdBut_Click);
            // 
            // setKey1IdBut
            // 
            this.setKey1IdBut.Location = new System.Drawing.Point(436, 115);
            this.setKey1IdBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setKey1IdBut.Name = "setKey1IdBut";
            this.setKey1IdBut.Size = new System.Drawing.Size(138, 35);
            this.setKey1IdBut.TabIndex = 20;
            this.setKey1IdBut.Text = "设置Key1ID";
            this.setKey1IdBut.UseVisualStyleBackColor = true;
            this.setKey1IdBut.Click += new System.EventHandler(this.setKey1IdBut_Click);
            // 
            // setIpSelectBut
            // 
            this.setIpSelectBut.Location = new System.Drawing.Point(436, 205);
            this.setIpSelectBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setIpSelectBut.Name = "setIpSelectBut";
            this.setIpSelectBut.Size = new System.Drawing.Size(138, 35);
            this.setIpSelectBut.TabIndex = 19;
            this.setIpSelectBut.Text = "设置选项";
            this.setIpSelectBut.UseVisualStyleBackColor = true;
            this.setIpSelectBut.Click += new System.EventHandler(this.setIpSelectBut_Click);
            // 
            // ipSelectBox
            // 
            this.ipSelectBox.FormattingEnabled = true;
            this.ipSelectBox.Location = new System.Drawing.Point(116, 210);
            this.ipSelectBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipSelectBox.Name = "ipSelectBox";
            this.ipSelectBox.Size = new System.Drawing.Size(292, 26);
            this.ipSelectBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "IP或域名：";
            // 
            // KeyId2Box
            // 
            this.KeyId2Box.Location = new System.Drawing.Point(116, 167);
            this.KeyId2Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KeyId2Box.Name = "KeyId2Box";
            this.KeyId2Box.Size = new System.Drawing.Size(292, 28);
            this.KeyId2Box.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "钥匙二ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "钥匙一ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "备服务器：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "主服务器：";
            // 
            // keyId1Box
            // 
            this.keyId1Box.Location = new System.Drawing.Point(116, 119);
            this.keyId1Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyId1Box.Name = "keyId1Box";
            this.keyId1Box.Size = new System.Drawing.Size(292, 28);
            this.keyId1Box.TabIndex = 10;
            // 
            // readMainPortBut
            // 
            this.readMainPortBut.Location = new System.Drawing.Point(237, 31);
            this.readMainPortBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readMainPortBut.Name = "readMainPortBut";
            this.readMainPortBut.Size = new System.Drawing.Size(172, 35);
            this.readMainPortBut.TabIndex = 9;
            this.readMainPortBut.Text = "获取主服务器端口";
            this.readMainPortBut.UseVisualStyleBackColor = true;
            this.readMainPortBut.Click += new System.EventHandler(this.readMainPort_Click);
            // 
            // sparePortBox
            // 
            this.sparePortBox.Location = new System.Drawing.Point(351, 295);
            this.sparePortBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sparePortBox.Name = "sparePortBox";
            this.sparePortBox.Size = new System.Drawing.Size(57, 28);
            this.sparePortBox.TabIndex = 7;
            this.sparePortBox.Text = "09988";
            // 
            // setmainPortBox
            // 
            this.setmainPortBox.Location = new System.Drawing.Point(351, 250);
            this.setmainPortBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setmainPortBox.Name = "setmainPortBox";
            this.setmainPortBox.Size = new System.Drawing.Size(57, 28);
            this.setmainPortBox.TabIndex = 5;
            this.setmainPortBox.Text = "09988";
            // 
            // spareServerAddreBox
            // 
            this.spareServerAddreBox.Location = new System.Drawing.Point(116, 295);
            this.spareServerAddreBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spareServerAddreBox.Name = "spareServerAddreBox";
            this.spareServerAddreBox.Size = new System.Drawing.Size(224, 28);
            this.spareServerAddreBox.TabIndex = 6;
            this.spareServerAddreBox.Text = "fishtest.yunshen918.com";
            // 
            // mainServerAddrBox
            // 
            this.mainServerAddrBox.Location = new System.Drawing.Point(116, 250);
            this.mainServerAddrBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainServerAddrBox.Name = "mainServerAddrBox";
            this.mainServerAddrBox.Size = new System.Drawing.Size(224, 28);
            this.mainServerAddrBox.TabIndex = 4;
            this.mainServerAddrBox.Text = "fishtest.yunshen918.com";
            // 
            // readMainServAddr
            // 
            this.readMainServAddr.Location = new System.Drawing.Point(15, 31);
            this.readMainServAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readMainServAddr.Name = "readMainServAddr";
            this.readMainServAddr.Size = new System.Drawing.Size(156, 35);
            this.readMainServAddr.TabIndex = 8;
            this.readMainServAddr.Text = "获取主服务器地址";
            this.readMainServAddr.Click += new System.EventHandler(this.readMainServAddr_Click);
            // 
            // setSpareAddreButton
            // 
            this.setSpareAddreButton.Location = new System.Drawing.Point(436, 295);
            this.setSpareAddreButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setSpareAddreButton.Name = "setSpareAddreButton";
            this.setSpareAddreButton.Size = new System.Drawing.Size(138, 35);
            this.setSpareAddreButton.TabIndex = 2;
            this.setSpareAddreButton.Text = "设置备服务器";
            this.setSpareAddreButton.UseVisualStyleBackColor = true;
            this.setSpareAddreButton.Click += new System.EventHandler(this.setSpareAddreButton_Click);
            // 
            // setMainServerAddress
            // 
            this.setMainServerAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setMainServerAddress.Location = new System.Drawing.Point(436, 250);
            this.setMainServerAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setMainServerAddress.Name = "setMainServerAddress";
            this.setMainServerAddress.Size = new System.Drawing.Size(138, 35);
            this.setMainServerAddress.TabIndex = 1;
            this.setMainServerAddress.Text = "设置主服务器";
            this.setMainServerAddress.UseVisualStyleBackColor = true;
            this.setMainServerAddress.Click += new System.EventHandler(this.setMainServerAddress_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clearFlash);
            this.tabPage3.Controls.Add(this.resetBoard);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.boardidBox);
            this.tabPage3.Controls.Add(this.setboardid);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(758, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "其他";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clearFlash
            // 
            this.clearFlash.Location = new System.Drawing.Point(468, 29);
            this.clearFlash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearFlash.Name = "clearFlash";
            this.clearFlash.Size = new System.Drawing.Size(112, 35);
            this.clearFlash.TabIndex = 4;
            this.clearFlash.Text = "重置Flash";
            this.clearFlash.UseVisualStyleBackColor = true;
            this.clearFlash.Click += new System.EventHandler(this.clearFlash_Click);
            // 
            // resetBoard
            // 
            this.resetBoard.Location = new System.Drawing.Point(630, 29);
            this.resetBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetBoard.Name = "resetBoard";
            this.resetBoard.Size = new System.Drawing.Size(112, 35);
            this.resetBoard.TabIndex = 3;
            this.resetBoard.Text = "重启板子";
            this.resetBoard.UseVisualStyleBackColor = true;
            this.resetBoard.Click += new System.EventHandler(this.resetBoard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID:";
            // 
            // boardidBox
            // 
            this.boardidBox.Location = new System.Drawing.Point(69, 31);
            this.boardidBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boardidBox.Name = "boardidBox";
            this.boardidBox.Size = new System.Drawing.Size(205, 28);
            this.boardidBox.TabIndex = 1;
            // 
            // setboardid
            // 
            this.setboardid.Location = new System.Drawing.Point(303, 30);
            this.setboardid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setboardid.Name = "setboardid";
            this.setboardid.Size = new System.Drawing.Size(112, 35);
            this.setboardid.TabIndex = 0;
            this.setboardid.Text = "设置板子id";
            this.setboardid.UseVisualStyleBackColor = true;
            this.setboardid.Click += new System.EventHandler(this.setboardid_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.WriteTimeout = 500;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.logTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 378);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(755, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logTextBox.Location = new System.Drawing.Point(4, 30);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(739, 195);
            this.logTextBox.TabIndex = 0;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(649, 623);
            this.clearLogButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(102, 42);
            this.clearLogButton.TabIndex = 2;
            this.clearLogButton.Text = "清空日志";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(766, 666);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BaseSettingstab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.Text = "Tool of Production";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrom_FormClosed);
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.BaseSettingstab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BaseSettingstab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scanPort;
        private System.Windows.Forms.ComboBox serialPortBox;
        private System.Windows.Forms.Label port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button openSerialPort;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button writeButtonID;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button powerCompensation;
        private System.Windows.Forms.Button readIDButton;
        private System.Windows.Forms.TextBox sparePortBox;
        private System.Windows.Forms.TextBox setmainPortBox;
        private System.Windows.Forms.TextBox spareServerAddreBox;
        private System.Windows.Forms.TextBox mainServerAddrBox;
        private System.Windows.Forms.Button readMainServAddr;
        private System.Windows.Forms.Button setSpareAddreButton;
        private System.Windows.Forms.Button setMainServerAddress;
        private System.Windows.Forms.Button readMainPortBut;
        private System.Windows.Forms.Button getSparePortBut;
        private System.Windows.Forms.Button readSpareServerBut;
        private System.Windows.Forms.Button setKey2IdBut;
        private System.Windows.Forms.Button setKey1IdBut;
        private System.Windows.Forms.Button setIpSelectBut;
        private System.Windows.Forms.ComboBox ipSelectBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KeyId2Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyId1Box;
        private System.Windows.Forms.Button readPowerbut;
        private System.Windows.Forms.Button readVersionNumBut;
        private System.Windows.Forms.Button readSimIDbutton;
        private System.Windows.Forms.ComboBox BaudComBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button setMainportBut;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boardidBox;
        private System.Windows.Forms.Button setboardid;
        private System.Windows.Forms.Button resetBoard;
        private System.Windows.Forms.Button clearFlash;
        private System.Windows.Forms.Button butProInfo;
    }
}

