namespace WinPSI.SM
{
    partial class FrmTMenuInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTMenuInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTMDesp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUrls = new System.Windows.Forms.ComboBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboParents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(633, 51);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(40, 48);
            this.tsbtnSave.Text = " 保存";
            this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClear.Image")));
            this.tsbtnClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.Size = new System.Drawing.Size(40, 48);
            this.tsbtnClear.Text = " 清空";
            this.tsbtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClose.Image")));
            this.tsbtnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(40, 48);
            this.tsbtnClose.Text = " 关闭";
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(283, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 62);
            this.label8.TabIndex = 44;
            this.label8.Text = "（针对个别特殊的没有关联页面执行命令的菜单项，英文表示，如：更换操作员:ChangeActor;退出系统:ExitSystem;刷新菜单:RefreshMenu";
            // 
            // txtTMDesp
            // 
            this.txtTMDesp.Location = new System.Drawing.Point(125, 247);
            this.txtTMDesp.Name = "txtTMDesp";
            this.txtTMDesp.Size = new System.Drawing.Size(142, 21);
            this.txtTMDesp.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "工具项描述:";
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(125, 207);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(72, 16);
            this.chkTop.TabIndex = 41;
            this.chkTop.Text = "顶级页面";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "顶级窗体:";
            // 
            // cboUrls
            // 
            this.cboUrls.FormattingEnabled = true;
            this.cboUrls.Location = new System.Drawing.Point(125, 162);
            this.cboUrls.Name = "cboUrls";
            this.cboUrls.Size = new System.Drawing.Size(293, 20);
            this.cboUrls.TabIndex = 39;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(371, 121);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(142, 21);
            this.txtOrder.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "排序:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "关联页面:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "图标:";
            // 
            // cboParents
            // 
            this.cboParents.FormattingEnabled = true;
            this.cboParents.Location = new System.Drawing.Point(125, 121);
            this.cboParents.Name = "cboParents";
            this.cboParents.Size = new System.Drawing.Size(142, 20);
            this.cboParents.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "组名:";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(125, 76);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(142, 21);
            this.txtMName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "工具菜单名:";
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(363, 76);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(16, 16);
            this.pbImg.TabIndex = 45;
            this.pbImg.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(399, 76);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(58, 21);
            this.btnChoose.TabIndex = 46;
            this.btnChoose.Text = "选择...";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // FrmTMenuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTMDesp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboUrls);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboParents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTMenuInfo";
            this.ShowIcon = false;
            this.Text = "工具项信息";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTMDesp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUrls;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboParents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnChoose;
    }
}