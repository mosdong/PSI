namespace WinPSI.BM
{
    partial class FrmUnitInfo
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnitInfo));
                        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                        this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.lblDesp = new System.Windows.Forms.Label();
                        this.panel2 = new System.Windows.Forms.Panel();
                        this.tcUnit = new System.Windows.Forms.TabControl();
                        this.tpBasic = new System.Windows.Forms.TabPage();
                        this.txtUnitNo = new System.Windows.Forms.TextBox();
                        this.label11 = new System.Windows.Forms.Label();
                        this.txtAddress = new System.Windows.Forms.TextBox();
                        this.label10 = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.cboCountries = new System.Windows.Forms.ComboBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.cboCitys = new System.Windows.Forms.ComboBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtNation = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.picUType = new System.Windows.Forms.PictureBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.cboUnitProperties = new System.Windows.Forms.ComboBox();
                        this.cboProvinces = new System.Windows.Forms.ComboBox();
                        this.txtRemark = new System.Windows.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.txtUnitType = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.txtUnitPYNo = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.txtUnitName = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.tpContact = new System.Windows.Forms.TabPage();
                        this.txtPostalCode = new System.Windows.Forms.TextBox();
                        this.label16 = new System.Windows.Forms.Label();
                        this.txtEmail = new System.Windows.Forms.TextBox();
                        this.label17 = new System.Windows.Forms.Label();
                        this.txtFax = new System.Windows.Forms.TextBox();
                        this.label14 = new System.Windows.Forms.Label();
                        this.txtTelephone = new System.Windows.Forms.TextBox();
                        this.label15 = new System.Windows.Forms.Label();
                        this.txtPhoneNumber = new System.Windows.Forms.TextBox();
                        this.label13 = new System.Windows.Forms.Label();
                        this.txtContactPerson = new System.Windows.Forms.TextBox();
                        this.label12 = new System.Windows.Forms.Label();
                        this.toolStrip1.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.tcUnit.SuspendLayout();
                        this.tpBasic.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.picUType)).BeginInit();
                        this.tpContact.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // toolStrip1
                        // 
                        this.toolStrip1.AutoSize = false;
                        this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsbtnClear,
            this.tsbtnClose});
                        this.toolStrip1.Location = new System.Drawing.Point(0, 45);
                        this.toolStrip1.Name = "toolStrip1";
                        this.toolStrip1.Size = new System.Drawing.Size(1116, 52);
                        this.toolStrip1.TabIndex = 38;
                        this.toolStrip1.Text = "toolStrip1";
                        // 
                        // tsbtnSave
                        // 
                        this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
                        this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnSave.Name = "tsbtnSave";
                        this.tsbtnSave.Size = new System.Drawing.Size(47, 49);
                        this.tsbtnSave.Text = " 保存";
                        this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
                        // 
                        // tsbtnClear
                        // 
                        this.tsbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClear.Image")));
                        this.tsbtnClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnClear.Name = "tsbtnClear";
                        this.tsbtnClear.Size = new System.Drawing.Size(47, 49);
                        this.tsbtnClear.Text = " 清空";
                        this.tsbtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
                        // 
                        // tsbtnClose
                        // 
                        this.tsbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClose.Image")));
                        this.tsbtnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnClose.Name = "tsbtnClose";
                        this.tsbtnClose.Size = new System.Drawing.Size(47, 49);
                        this.tsbtnClose.Text = " 关闭";
                        this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.lblDesp);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 0);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1116, 45);
                        this.panel1.TabIndex = 37;
                        // 
                        // lblDesp
                        // 
                        this.lblDesp.AutoSize = true;
                        this.lblDesp.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        this.lblDesp.ForeColor = System.Drawing.Color.Black;
                        this.lblDesp.Location = new System.Drawing.Point(4, 11);
                        this.lblDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblDesp.Name = "lblDesp";
                        this.lblDesp.Size = new System.Drawing.Size(244, 27);
                        this.lblDesp.TabIndex = 0;
                        this.lblDesp.Text = "单位信息新增页面";
                        // 
                        // panel2
                        // 
                        this.panel2.BackColor = System.Drawing.Color.White;
                        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel2.Location = new System.Drawing.Point(0, 0);
                        this.panel2.Margin = new System.Windows.Forms.Padding(4);
                        this.panel2.Name = "panel2";
                        this.panel2.Size = new System.Drawing.Size(1116, 581);
                        this.panel2.TabIndex = 39;
                        // 
                        // tcUnit
                        // 
                        this.tcUnit.Controls.Add(this.tpBasic);
                        this.tcUnit.Controls.Add(this.tpContact);
                        this.tcUnit.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tcUnit.Location = new System.Drawing.Point(0, 97);
                        this.tcUnit.Margin = new System.Windows.Forms.Padding(4);
                        this.tcUnit.Name = "tcUnit";
                        this.tcUnit.SelectedIndex = 0;
                        this.tcUnit.Size = new System.Drawing.Size(1116, 484);
                        this.tcUnit.TabIndex = 62;
                        // 
                        // tpBasic
                        // 
                        this.tpBasic.Controls.Add(this.txtUnitNo);
                        this.tpBasic.Controls.Add(this.label11);
                        this.tpBasic.Controls.Add(this.txtAddress);
                        this.tpBasic.Controls.Add(this.label10);
                        this.tpBasic.Controls.Add(this.label9);
                        this.tpBasic.Controls.Add(this.cboCountries);
                        this.tpBasic.Controls.Add(this.label7);
                        this.tpBasic.Controls.Add(this.cboCitys);
                        this.tpBasic.Controls.Add(this.label5);
                        this.tpBasic.Controls.Add(this.txtNation);
                        this.tpBasic.Controls.Add(this.label2);
                        this.tpBasic.Controls.Add(this.picUType);
                        this.tpBasic.Controls.Add(this.label8);
                        this.tpBasic.Controls.Add(this.cboUnitProperties);
                        this.tpBasic.Controls.Add(this.cboProvinces);
                        this.tpBasic.Controls.Add(this.txtRemark);
                        this.tpBasic.Controls.Add(this.label6);
                        this.tpBasic.Controls.Add(this.txtUnitType);
                        this.tpBasic.Controls.Add(this.label4);
                        this.tpBasic.Controls.Add(this.txtUnitPYNo);
                        this.tpBasic.Controls.Add(this.label3);
                        this.tpBasic.Controls.Add(this.txtUnitName);
                        this.tpBasic.Controls.Add(this.label1);
                        this.tpBasic.Location = new System.Drawing.Point(4, 25);
                        this.tpBasic.Margin = new System.Windows.Forms.Padding(4);
                        this.tpBasic.Name = "tpBasic";
                        this.tpBasic.Padding = new System.Windows.Forms.Padding(4);
                        this.tpBasic.Size = new System.Drawing.Size(1108, 455);
                        this.tpBasic.TabIndex = 0;
                        this.tpBasic.Text = "基本信息";
                        this.tpBasic.UseVisualStyleBackColor = true;
                        // 
                        // txtUnitNo
                        // 
                        this.txtUnitNo.Location = new System.Drawing.Point(660, 152);
                        this.txtUnitNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUnitNo.Name = "txtUnitNo";
                        this.txtUnitNo.Size = new System.Drawing.Size(241, 25);
                        this.txtUnitNo.TabIndex = 104;
                        // 
                        // label11
                        // 
                        this.label11.AutoSize = true;
                        this.label11.Location = new System.Drawing.Point(573, 160);
                        this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(75, 15);
                        this.label11.TabIndex = 103;
                        this.label11.Text = "单位编码:";
                        // 
                        // txtAddress
                        // 
                        this.txtAddress.Location = new System.Drawing.Point(149, 152);
                        this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
                        this.txtAddress.Name = "txtAddress";
                        this.txtAddress.Size = new System.Drawing.Size(363, 25);
                        this.txtAddress.TabIndex = 102;
                        // 
                        // label10
                        // 
                        this.label10.AutoSize = true;
                        this.label10.Location = new System.Drawing.Point(92, 159);
                        this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(45, 15);
                        this.label10.TabIndex = 101;
                        this.label10.Text = "地址:";
                        // 
                        // label9
                        // 
                        this.label9.AutoSize = true;
                        this.label9.Location = new System.Drawing.Point(881, 114);
                        this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(45, 15);
                        this.label9.TabIndex = 100;
                        this.label9.Text = "区/县";
                        // 
                        // cboCountries
                        // 
                        this.cboCountries.FormattingEnabled = true;
                        this.cboCountries.Location = new System.Drawing.Point(755, 110);
                        this.cboCountries.Margin = new System.Windows.Forms.Padding(4);
                        this.cboCountries.Name = "cboCountries";
                        this.cboCountries.Size = new System.Drawing.Size(117, 23);
                        this.cboCountries.TabIndex = 99;
                        // 
                        // label7
                        // 
                        this.label7.AutoSize = true;
                        this.label7.Location = new System.Drawing.Point(691, 114);
                        this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(22, 15);
                        this.label7.TabIndex = 98;
                        this.label7.Text = "市";
                        // 
                        // cboCitys
                        // 
                        this.cboCitys.FormattingEnabled = true;
                        this.cboCitys.Location = new System.Drawing.Point(531, 109);
                        this.cboCitys.Margin = new System.Windows.Forms.Padding(4);
                        this.cboCitys.Name = "cboCitys";
                        this.cboCitys.Size = new System.Drawing.Size(147, 23);
                        this.cboCitys.TabIndex = 97;
                        this.cboCitys.SelectedIndexChanged += new System.EventHandler(this.cboCitys_SelectedIndexChanged);
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(469, 114);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(22, 15);
                        this.label5.TabIndex = 96;
                        this.label5.Text = "省";
                        // 
                        // txtNation
                        // 
                        this.txtNation.Location = new System.Drawing.Point(149, 109);
                        this.txtNation.Margin = new System.Windows.Forms.Padding(4);
                        this.txtNation.Name = "txtNation";
                        this.txtNation.ReadOnly = true;
                        this.txtNation.Size = new System.Drawing.Size(132, 25);
                        this.txtNation.TabIndex = 95;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(95, 114);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(45, 15);
                        this.label2.TabIndex = 94;
                        this.label2.Text = "国家:";
                        // 
                        // picUType
                        // 
                        this.picUType.Image = global::WinPSI.Properties.Resources.zh;
                        this.picUType.Location = new System.Drawing.Point(468, 69);
                        this.picUType.Margin = new System.Windows.Forms.Padding(4);
                        this.picUType.Name = "picUType";
                        this.picUType.Size = new System.Drawing.Size(21, 19);
                        this.picUType.TabIndex = 93;
                        this.picUType.TabStop = false;
                        this.picUType.Click += new System.EventHandler(this.picUType_Click);
                        // 
                        // label8
                        // 
                        this.label8.AutoSize = true;
                        this.label8.Location = new System.Drawing.Point(573, 26);
                        this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(75, 15);
                        this.label8.TabIndex = 92;
                        this.label8.Text = "单位性质:";
                        // 
                        // cboUnitProperties
                        // 
                        this.cboUnitProperties.FormattingEnabled = true;
                        this.cboUnitProperties.Location = new System.Drawing.Point(660, 22);
                        this.cboUnitProperties.Margin = new System.Windows.Forms.Padding(4);
                        this.cboUnitProperties.Name = "cboUnitProperties";
                        this.cboUnitProperties.Size = new System.Drawing.Size(241, 23);
                        this.cboUnitProperties.TabIndex = 91;
                        // 
                        // cboProvinces
                        // 
                        this.cboProvinces.FormattingEnabled = true;
                        this.cboProvinces.Location = new System.Drawing.Point(312, 110);
                        this.cboProvinces.Margin = new System.Windows.Forms.Padding(4);
                        this.cboProvinces.Name = "cboProvinces";
                        this.cboProvinces.Size = new System.Drawing.Size(147, 23);
                        this.cboProvinces.TabIndex = 90;
                        this.cboProvinces.SelectedIndexChanged += new System.EventHandler(this.cboProvinces_SelectedIndexChanged);
                        // 
                        // txtRemark
                        // 
                        this.txtRemark.Location = new System.Drawing.Point(149, 195);
                        this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
                        this.txtRemark.Multiline = true;
                        this.txtRemark.Name = "txtRemark";
                        this.txtRemark.Size = new System.Drawing.Size(777, 212);
                        this.txtRemark.TabIndex = 89;
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(63, 201);
                        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(77, 15);
                        this.label6.TabIndex = 88;
                        this.label6.Text = "备    注:";
                        // 
                        // txtUnitType
                        // 
                        this.txtUnitType.Location = new System.Drawing.Point(149, 62);
                        this.txtUnitType.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUnitType.Name = "txtUnitType";
                        this.txtUnitType.Size = new System.Drawing.Size(309, 25);
                        this.txtUnitType.TabIndex = 87;
                        this.txtUnitType.TextChanged += new System.EventHandler(this.txtUnitType_TextChanged);
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(54, 69);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(83, 15);
                        this.label4.TabIndex = 86;
                        this.label4.Text = "*单位类别:";
                        // 
                        // txtUnitPYNo
                        // 
                        this.txtUnitPYNo.Location = new System.Drawing.Point(660, 64);
                        this.txtUnitPYNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUnitPYNo.Name = "txtUnitPYNo";
                        this.txtUnitPYNo.ReadOnly = true;
                        this.txtUnitPYNo.Size = new System.Drawing.Size(241, 25);
                        this.txtUnitPYNo.TabIndex = 85;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(589, 68);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(60, 15);
                        this.label3.TabIndex = 84;
                        this.label3.Text = "拼音码:";
                        // 
                        // txtUnitName
                        // 
                        this.txtUnitName.Location = new System.Drawing.Point(149, 22);
                        this.txtUnitName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUnitName.Name = "txtUnitName";
                        this.txtUnitName.Size = new System.Drawing.Size(339, 25);
                        this.txtUnitName.TabIndex = 83;
                        this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(55, 26);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(83, 15);
                        this.label1.TabIndex = 82;
                        this.label1.Text = "*单位名称:";
                        // 
                        // tpContact
                        // 
                        this.tpContact.Controls.Add(this.txtPostalCode);
                        this.tpContact.Controls.Add(this.label16);
                        this.tpContact.Controls.Add(this.txtEmail);
                        this.tpContact.Controls.Add(this.label17);
                        this.tpContact.Controls.Add(this.txtFax);
                        this.tpContact.Controls.Add(this.label14);
                        this.tpContact.Controls.Add(this.txtTelephone);
                        this.tpContact.Controls.Add(this.label15);
                        this.tpContact.Controls.Add(this.txtPhoneNumber);
                        this.tpContact.Controls.Add(this.label13);
                        this.tpContact.Controls.Add(this.txtContactPerson);
                        this.tpContact.Controls.Add(this.label12);
                        this.tpContact.Location = new System.Drawing.Point(4, 25);
                        this.tpContact.Margin = new System.Windows.Forms.Padding(4);
                        this.tpContact.Name = "tpContact";
                        this.tpContact.Padding = new System.Windows.Forms.Padding(4);
                        this.tpContact.Size = new System.Drawing.Size(1108, 455);
                        this.tpContact.TabIndex = 1;
                        this.tpContact.Text = "联系人";
                        this.tpContact.UseVisualStyleBackColor = true;
                        // 
                        // txtPostalCode
                        // 
                        this.txtPostalCode.Location = new System.Drawing.Point(603, 156);
                        this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4);
                        this.txtPostalCode.Name = "txtPostalCode";
                        this.txtPostalCode.Size = new System.Drawing.Size(241, 25);
                        this.txtPostalCode.TabIndex = 97;
                        // 
                        // label16
                        // 
                        this.label16.AutoSize = true;
                        this.label16.Location = new System.Drawing.Point(519, 164);
                        this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label16.Name = "label16";
                        this.label16.Size = new System.Drawing.Size(77, 15);
                        this.label16.TabIndex = 96;
                        this.label16.Text = "邮    编:";
                        // 
                        // txtEmail
                        // 
                        this.txtEmail.Location = new System.Drawing.Point(204, 156);
                        this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
                        this.txtEmail.Name = "txtEmail";
                        this.txtEmail.Size = new System.Drawing.Size(241, 25);
                        this.txtEmail.TabIndex = 95;
                        // 
                        // label17
                        // 
                        this.label17.AutoSize = true;
                        this.label17.Location = new System.Drawing.Point(119, 161);
                        this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label17.Name = "label17";
                        this.label17.Size = new System.Drawing.Size(77, 15);
                        this.label17.TabIndex = 94;
                        this.label17.Text = "邮    箱:";
                        // 
                        // txtFax
                        // 
                        this.txtFax.Location = new System.Drawing.Point(603, 94);
                        this.txtFax.Margin = new System.Windows.Forms.Padding(4);
                        this.txtFax.Name = "txtFax";
                        this.txtFax.Size = new System.Drawing.Size(241, 25);
                        this.txtFax.TabIndex = 93;
                        // 
                        // label14
                        // 
                        this.label14.AutoSize = true;
                        this.label14.Location = new System.Drawing.Point(516, 99);
                        this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(77, 15);
                        this.label14.TabIndex = 92;
                        this.label14.Text = "传    真:";
                        // 
                        // txtTelephone
                        // 
                        this.txtTelephone.Location = new System.Drawing.Point(205, 94);
                        this.txtTelephone.Margin = new System.Windows.Forms.Padding(4);
                        this.txtTelephone.Name = "txtTelephone";
                        this.txtTelephone.Size = new System.Drawing.Size(241, 25);
                        this.txtTelephone.TabIndex = 91;
                        // 
                        // label15
                        // 
                        this.label15.AutoSize = true;
                        this.label15.Location = new System.Drawing.Point(119, 99);
                        this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label15.Name = "label15";
                        this.label15.Size = new System.Drawing.Size(75, 15);
                        this.label15.TabIndex = 90;
                        this.label15.Text = "手机号码:";
                        // 
                        // txtPhoneNumber
                        // 
                        this.txtPhoneNumber.Location = new System.Drawing.Point(603, 32);
                        this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
                        this.txtPhoneNumber.Name = "txtPhoneNumber";
                        this.txtPhoneNumber.Size = new System.Drawing.Size(241, 25);
                        this.txtPhoneNumber.TabIndex = 89;
                        // 
                        // label13
                        // 
                        this.label13.AutoSize = true;
                        this.label13.Location = new System.Drawing.Point(519, 38);
                        this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(75, 15);
                        this.label13.TabIndex = 88;
                        this.label13.Text = "联系电话:";
                        // 
                        // txtContactPerson
                        // 
                        this.txtContactPerson.Location = new System.Drawing.Point(204, 34);
                        this.txtContactPerson.Margin = new System.Windows.Forms.Padding(4);
                        this.txtContactPerson.Name = "txtContactPerson";
                        this.txtContactPerson.Size = new System.Drawing.Size(241, 25);
                        this.txtContactPerson.TabIndex = 87;
                        // 
                        // label12
                        // 
                        this.label12.AutoSize = true;
                        this.label12.Location = new System.Drawing.Point(133, 38);
                        this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label12.Name = "label12";
                        this.label12.Size = new System.Drawing.Size(60, 15);
                        this.label12.TabIndex = 86;
                        this.label12.Text = "联系人:";
                        // 
                        // FrmUnitInfo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1116, 581);
                        this.Controls.Add(this.tcUnit);
                        this.Controls.Add(this.toolStrip1);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.panel2);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmUnitInfo";
                        this.ShowIcon = false;
                        this.Text = "往来单位信息页面";
                        this.Load += new System.EventHandler(this.FrmUnitInfo_Load);
                        this.toolStrip1.ResumeLayout(false);
                        this.toolStrip1.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        this.tcUnit.ResumeLayout(false);
                        this.tpBasic.ResumeLayout(false);
                        this.tpBasic.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.picUType)).EndInit();
                        this.tpContact.ResumeLayout(false);
                        this.tpContact.PerformLayout();
                        this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDesp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcUnit;
        private System.Windows.Forms.TabPage tpBasic;
        private System.Windows.Forms.TextBox txtUnitNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCitys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picUType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUnitProperties;
        private System.Windows.Forms.ComboBox cboProvinces;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPYNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpContact;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label12;
    }
}