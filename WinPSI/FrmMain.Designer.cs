namespace WinPSI
{
    partial class FrmMain
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
                        this.gboxMenus = new System.Windows.Forms.GroupBox();
                        this.PSIMenus = new System.Windows.Forms.MenuStrip();
                        this.gboxTools = new System.Windows.Forms.GroupBox();
                        this.btnClose = new System.Windows.Forms.PictureBox();
                        this.PSITools = new System.Windows.Forms.ToolStrip();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.PSIStatus = new System.Windows.Forms.StatusStrip();
                        this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
                        this.lblUName = new System.Windows.Forms.ToolStripStatusLabel();
                        this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
                        this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
                        this.lblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
                        this.tcPages = new UControls.UserTabControl();
                        this.gboxMenus.SuspendLayout();
                        this.gboxTools.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
                        this.panel1.SuspendLayout();
                        this.PSIStatus.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // gboxMenus
                        // 
                        this.gboxMenus.Controls.Add(this.PSIMenus);
                        this.gboxMenus.Dock = System.Windows.Forms.DockStyle.Top;
                        this.gboxMenus.Location = new System.Drawing.Point(0, 0);
                        this.gboxMenus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.gboxMenus.Name = "gboxMenus";
                        this.gboxMenus.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.gboxMenus.Size = new System.Drawing.Size(1523, 51);
                        this.gboxMenus.TabIndex = 0;
                        this.gboxMenus.TabStop = false;
                        // 
                        // PSIMenus
                        // 
                        this.PSIMenus.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.PSIMenus.Location = new System.Drawing.Point(4, 18);
                        this.PSIMenus.Name = "PSIMenus";
                        this.PSIMenus.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
                        this.PSIMenus.Size = new System.Drawing.Size(1515, 24);
                        this.PSIMenus.TabIndex = 0;
                        this.PSIMenus.Text = "menuStrip1";
                        // 
                        // gboxTools
                        // 
                        this.gboxTools.Controls.Add(this.btnClose);
                        this.gboxTools.Controls.Add(this.PSITools);
                        this.gboxTools.Dock = System.Windows.Forms.DockStyle.Top;
                        this.gboxTools.Location = new System.Drawing.Point(0, 51);
                        this.gboxTools.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
                        this.gboxTools.Name = "gboxTools";
                        this.gboxTools.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
                        this.gboxTools.Size = new System.Drawing.Size(1523, 56);
                        this.gboxTools.TabIndex = 1;
                        this.gboxTools.TabStop = false;
                        // 
                        // btnClose
                        // 
                        this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
                        this.btnClose.Image = global::WinPSI.Properties.Resources.close;
                        this.btnClose.Location = new System.Drawing.Point(1484, 18);
                        this.btnClose.Margin = new System.Windows.Forms.Padding(4);
                        this.btnClose.Name = "btnClose";
                        this.btnClose.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
                        this.btnClose.Size = new System.Drawing.Size(35, 34);
                        this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.btnClose.TabIndex = 1;
                        this.btnClose.TabStop = false;
                        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
                        // 
                        // PSITools
                        // 
                        this.PSITools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.PSITools.AutoSize = false;
                        this.PSITools.Dock = System.Windows.Forms.DockStyle.None;
                        this.PSITools.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.PSITools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
                        this.PSITools.Location = new System.Drawing.Point(4, 18);
                        this.PSITools.Name = "PSITools";
                        this.PSITools.Size = new System.Drawing.Size(1477, 35);
                        this.PSITools.TabIndex = 0;
                        this.PSITools.Text = "toolStrip1";
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.tcPages);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel1.Location = new System.Drawing.Point(0, 107);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1523, 653);
                        this.panel1.TabIndex = 2;
                        // 
                        // PSIStatus
                        // 
                        this.PSIStatus.AutoSize = false;
                        this.PSIStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.PSIStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUName,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lblLoginTime});
                        this.PSIStatus.Location = new System.Drawing.Point(0, 760);
                        this.PSIStatus.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
                        this.PSIStatus.Name = "PSIStatus";
                        this.PSIStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
                        this.PSIStatus.Size = new System.Drawing.Size(1523, 31);
                        this.PSIStatus.TabIndex = 7;
                        this.PSIStatus.Text = "statusStrip1";
                        // 
                        // toolStripStatusLabel1
                        // 
                        this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
                        this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 26);
                        this.toolStripStatusLabel1.Text = "操作者：";
                        // 
                        // lblUName
                        // 
                        this.lblUName.Name = "lblUName";
                        this.lblUName.Size = new System.Drawing.Size(54, 26);
                        this.lblUName.Text = "admin";
                        // 
                        // toolStripStatusLabel3
                        // 
                        this.toolStripStatusLabel3.AutoSize = false;
                        this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
                        this.toolStripStatusLabel3.Size = new System.Drawing.Size(50, 26);
                        // 
                        // toolStripStatusLabel4
                        // 
                        this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
                        this.toolStripStatusLabel4.Size = new System.Drawing.Size(84, 26);
                        this.toolStripStatusLabel4.Text = "登录时间：";
                        // 
                        // lblLoginTime
                        // 
                        this.lblLoginTime.Name = "lblLoginTime";
                        this.lblLoginTime.Size = new System.Drawing.Size(137, 26);
                        this.lblLoginTime.Text = "2020-03-13 16:51";
                        // 
                        // tcPages
                        // 
                        this.tcPages.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tcPages.Location = new System.Drawing.Point(0, 0);
                        this.tcPages.Margin = new System.Windows.Forms.Padding(4);
                        this.tcPages.Name = "tcPages";
                        this.tcPages.Padding = new System.Drawing.Point(8, 4);
                        this.tcPages.SelectedIndex = 0;
                        this.tcPages.ShowToolTips = true;
                        this.tcPages.Size = new System.Drawing.Size(1523, 653);
                        this.tcPages.TabIndex = 0;
                        this.tcPages.SizeChanged += new System.EventHandler(this.tcPages_SizeChanged);
                        // 
                        // FrmMain
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1523, 791);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.gboxTools);
                        this.Controls.Add(this.gboxMenus);
                        this.Controls.Add(this.PSIStatus);
                        this.MainMenuStrip = this.PSIMenus;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.Name = "FrmMain";
                        this.Text = "进销存管理系统";
                        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
                        this.Load += new System.EventHandler(this.FrmMain_Load);
                        this.VisibleChanged += new System.EventHandler(this.FrmMain_VisibleChanged);
                        this.gboxMenus.ResumeLayout(false);
                        this.gboxMenus.PerformLayout();
                        this.gboxTools.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
                        this.panel1.ResumeLayout(false);
                        this.PSIStatus.ResumeLayout(false);
                        this.PSIStatus.PerformLayout();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMenus;
        private System.Windows.Forms.MenuStrip PSIMenus;
        private System.Windows.Forms.GroupBox gboxTools;
        private System.Windows.Forms.ToolStrip PSITools;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip PSIStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginTime;
                private WinPSI.UControls.UserTabControl tcPages;
        }
}