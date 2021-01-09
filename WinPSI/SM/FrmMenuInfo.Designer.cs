namespace WinPSI.SM
{
    partial class FrmMenuInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUrls = new System.Windows.Forms.ComboBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboParents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMDesp = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsbtnClear,
            this.tsbtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 51);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(38, 48);
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
            this.tsbtnClear.Size = new System.Drawing.Size(38, 48);
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
            this.tsbtnClose.Size = new System.Drawing.Size(38, 48);
            this.tsbtnClose.Text = " 关闭";
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(102, 226);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(72, 16);
            this.chkTop.TabIndex = 26;
            this.chkTop.Text = "顶级页面";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "顶级窗体:";
            // 
            // cboUrls
            // 
            this.cboUrls.FormattingEnabled = true;
            this.cboUrls.Location = new System.Drawing.Point(102, 181);
            this.cboUrls.Name = "cboUrls";
            this.cboUrls.Size = new System.Drawing.Size(293, 20);
            this.cboUrls.TabIndex = 24;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(348, 140);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(142, 21);
            this.txtOrder.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "排序:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "关联页面:";
            // 
            // txtMKey
            // 
            this.txtMKey.Location = new System.Drawing.Point(348, 95);
            this.txtMKey.Name = "txtMKey";
            this.txtMKey.Size = new System.Drawing.Size(142, 21);
            this.txtMKey.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "快捷键:";
            // 
            // cboParents
            // 
            this.cboParents.FormattingEnabled = true;
            this.cboParents.Location = new System.Drawing.Point(102, 140);
            this.cboParents.Name = "cboParents";
            this.cboParents.Size = new System.Drawing.Size(142, 20);
            this.cboParents.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "父菜单:";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(102, 95);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(142, 21);
            this.txtMName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "菜单名:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "菜单描述:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(260, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 62);
            this.label8.TabIndex = 29;
            this.label8.Text = "（针对个别特殊的没有关联页面执行命令的菜单项，英文表示，如：修改密码：ModifyPwd;退出系统：ExitSystem；开账：OpenSys；反开账：UnOpe" +
    "nSys）";
            // 
            // txtMDesp
            // 
            this.txtMDesp.Location = new System.Drawing.Point(102, 266);
            this.txtMDesp.Name = "txtMDesp";
            this.txtMDesp.Size = new System.Drawing.Size(142, 21);
            this.txtMDesp.TabIndex = 28;
            // 
            // FrmMenuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 346);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMDesp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboUrls);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboParents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMenuInfo";
            this.ShowIcon = false;
            this.Text = "菜单信息";
            this.Load += new System.EventHandler(this.FrmMenuInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUrls;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboParents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMDesp;
    }
}