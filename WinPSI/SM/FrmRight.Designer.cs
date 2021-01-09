namespace WinPSI.SM
{
    partial class FrmRight
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.tcRights = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.tvMenus = new System.Windows.Forms.TreeView();
            this.tpTool = new System.Windows.Forms.TabPage();
            this.tvTMenus = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.tcRights.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.tpTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboRoles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 70);
            this.panel1.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(395, 25);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "提交设置";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "角色:";
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(100, 27);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(154, 20);
            this.cboRoles.TabIndex = 10;
            this.cboRoles.SelectedIndexChanged += new System.EventHandler(this.cboRoles_SelectedIndexChanged);
            // 
            // tcRights
            // 
            this.tcRights.Controls.Add(this.tpMenu);
            this.tcRights.Controls.Add(this.tpTool);
            this.tcRights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcRights.Location = new System.Drawing.Point(0, 70);
            this.tcRights.Name = "tcRights";
            this.tcRights.SelectedIndex = 0;
            this.tcRights.Size = new System.Drawing.Size(582, 409);
            this.tcRights.TabIndex = 10;
            // 
            // tpMenu
            // 
            this.tpMenu.AutoScroll = true;
            this.tpMenu.Controls.Add(this.tvMenus);
            this.tpMenu.Location = new System.Drawing.Point(4, 22);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(574, 383);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "菜单";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // tvMenus
            // 
            this.tvMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMenus.ItemHeight = 20;
            this.tvMenus.Location = new System.Drawing.Point(11, 15);
            this.tvMenus.Name = "tvMenus";
            this.tvMenus.Size = new System.Drawing.Size(548, 356);
            this.tvMenus.TabIndex = 0;
            this.tvMenus.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMenus_AfterCheck);
            // 
            // tpTool
            // 
            this.tpTool.AutoScroll = true;
            this.tpTool.Controls.Add(this.tvTMenus);
            this.tpTool.Location = new System.Drawing.Point(4, 22);
            this.tpTool.Name = "tpTool";
            this.tpTool.Padding = new System.Windows.Forms.Padding(3);
            this.tpTool.Size = new System.Drawing.Size(574, 383);
            this.tpTool.TabIndex = 1;
            this.tpTool.Text = "工具栏";
            this.tpTool.UseVisualStyleBackColor = true;
            // 
            // tvTMenus
            // 
            this.tvTMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvTMenus.ItemHeight = 20;
            this.tvTMenus.Location = new System.Drawing.Point(10, 14);
            this.tvTMenus.Name = "tvTMenus";
            this.tvTMenus.Size = new System.Drawing.Size(553, 358);
            this.tvTMenus.TabIndex = 0;
            this.tvTMenus.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvTMenus_AfterCheck);
            // 
            // FrmRight
            // 
            this.ClientSize = new System.Drawing.Size(582, 479);
            this.Controls.Add(this.tcRights);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRight";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmRight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcRights.ResumeLayout(false);
            this.tpMenu.ResumeLayout(false);
            this.tpTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.TabControl tcRights;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TreeView tvMenus;
        private System.Windows.Forms.TabPage tpTool;
        private System.Windows.Forms.TreeView tvTMenus;
    }
}