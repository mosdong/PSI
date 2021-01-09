namespace WinPSI.BM
{
        partial class FrmStoreInfo
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreInfo));
                        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                        this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.lblDesp = new System.Windows.Forms.Label();
                        this.panelInfo = new System.Windows.Forms.Panel();
                        this.txtRemark = new System.Windows.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.picList = new System.Windows.Forms.PictureBox();
                        this.cboSTypes = new System.Windows.Forms.ComboBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtStoreNo = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.txtStoreOrder = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtStorePYNo = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.txtStoreName = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.toolStrip1.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.panelInfo.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
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
                        this.toolStrip1.Location = new System.Drawing.Point(0, 61);
                        this.toolStrip1.Name = "toolStrip1";
                        this.toolStrip1.Size = new System.Drawing.Size(1069, 58);
                        this.toolStrip1.TabIndex = 32;
                        this.toolStrip1.Text = "toolStrip1";
                        // 
                        // tsbtnSave
                        // 
                        this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
                        this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnSave.Name = "tsbtnSave";
                        this.tsbtnSave.Size = new System.Drawing.Size(47, 55);
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
                        this.tsbtnClear.Size = new System.Drawing.Size(47, 55);
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
                        this.tsbtnClose.Size = new System.Drawing.Size(47, 55);
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
                        this.panel1.Size = new System.Drawing.Size(1069, 61);
                        this.panel1.TabIndex = 31;
                        // 
                        // lblDesp
                        // 
                        this.lblDesp.AutoSize = true;
                        this.lblDesp.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        this.lblDesp.ForeColor = System.Drawing.Color.Black;
                        this.lblDesp.Location = new System.Drawing.Point(4, 29);
                        this.lblDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblDesp.Name = "lblDesp";
                        this.lblDesp.Size = new System.Drawing.Size(244, 27);
                        this.lblDesp.TabIndex = 0;
                        this.lblDesp.Text = "仓库信息新增页面";
                        // 
                        // panelInfo
                        // 
                        this.panelInfo.BackColor = System.Drawing.Color.White;
                        this.panelInfo.Controls.Add(this.txtRemark);
                        this.panelInfo.Controls.Add(this.label6);
                        this.panelInfo.Controls.Add(this.picList);
                        this.panelInfo.Controls.Add(this.cboSTypes);
                        this.panelInfo.Controls.Add(this.label5);
                        this.panelInfo.Controls.Add(this.txtStoreNo);
                        this.panelInfo.Controls.Add(this.label4);
                        this.panelInfo.Controls.Add(this.txtStoreOrder);
                        this.panelInfo.Controls.Add(this.label2);
                        this.panelInfo.Controls.Add(this.txtStorePYNo);
                        this.panelInfo.Controls.Add(this.label3);
                        this.panelInfo.Controls.Add(this.txtStoreName);
                        this.panelInfo.Controls.Add(this.label1);
                        this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panelInfo.Location = new System.Drawing.Point(0, 119);
                        this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
                        this.panelInfo.Name = "panelInfo";
                        this.panelInfo.Size = new System.Drawing.Size(1069, 399);
                        this.panelInfo.TabIndex = 33;
                        // 
                        // txtRemark
                        // 
                        this.txtRemark.Location = new System.Drawing.Point(155, 136);
                        this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
                        this.txtRemark.Multiline = true;
                        this.txtRemark.Name = "txtRemark";
                        this.txtRemark.Size = new System.Drawing.Size(851, 220);
                        this.txtRemark.TabIndex = 52;
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(68, 142);
                        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(77, 15);
                        this.label6.TabIndex = 51;
                        this.label6.Text = "备    注:";
                        // 
                        // picList
                        // 
                        this.picList.Image = global::WinPSI.Properties.Resources.book;
                        this.picList.Location = new System.Drawing.Point(433, 91);
                        this.picList.Margin = new System.Windows.Forms.Padding(4);
                        this.picList.Name = "picList";
                        this.picList.Size = new System.Drawing.Size(21, 19);
                        this.picList.TabIndex = 50;
                        this.picList.TabStop = false;
                        this.picList.Click += new System.EventHandler(this.picList_Click);
                        // 
                        // cboSTypes
                        // 
                        this.cboSTypes.FormattingEnabled = true;
                        this.cboSTypes.Location = new System.Drawing.Point(155, 88);
                        this.cboSTypes.Margin = new System.Windows.Forms.Padding(4);
                        this.cboSTypes.Name = "cboSTypes";
                        this.cboSTypes.Size = new System.Drawing.Size(269, 23);
                        this.cboSTypes.TabIndex = 49;
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(68, 94);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(83, 15);
                        this.label5.TabIndex = 48;
                        this.label5.Text = "*仓库类别:";
                        // 
                        // txtStoreNo
                        // 
                        this.txtStoreNo.Location = new System.Drawing.Point(615, 41);
                        this.txtStoreNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtStoreNo.Name = "txtStoreNo";
                        this.txtStoreNo.Size = new System.Drawing.Size(391, 25);
                        this.txtStoreNo.TabIndex = 47;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(528, 48);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(75, 15);
                        this.label4.TabIndex = 46;
                        this.label4.Text = "仓库编码:";
                        // 
                        // txtStoreOrder
                        // 
                        this.txtStoreOrder.Location = new System.Drawing.Point(897, 85);
                        this.txtStoreOrder.Margin = new System.Windows.Forms.Padding(4);
                        this.txtStoreOrder.Name = "txtStoreOrder";
                        this.txtStoreOrder.Size = new System.Drawing.Size(108, 25);
                        this.txtStoreOrder.TabIndex = 45;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(827, 91);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(60, 15);
                        this.label2.TabIndex = 44;
                        this.label2.Text = "排序号:";
                        // 
                        // txtStorePYNo
                        // 
                        this.txtStorePYNo.Location = new System.Drawing.Point(615, 84);
                        this.txtStorePYNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtStorePYNo.Name = "txtStorePYNo";
                        this.txtStorePYNo.ReadOnly = true;
                        this.txtStorePYNo.Size = new System.Drawing.Size(161, 25);
                        this.txtStorePYNo.TabIndex = 43;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(544, 90);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(60, 15);
                        this.label3.TabIndex = 42;
                        this.label3.Text = "拼音码:";
                        // 
                        // txtStoreName
                        // 
                        this.txtStoreName.Location = new System.Drawing.Point(155, 44);
                        this.txtStoreName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtStoreName.Name = "txtStoreName";
                        this.txtStoreName.Size = new System.Drawing.Size(269, 25);
                        this.txtStoreName.TabIndex = 41;
                        this.txtStoreName.TextChanged += new System.EventHandler(this.txtStoreName_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(68, 50);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(83, 15);
                        this.label1.TabIndex = 40;
                        this.label1.Text = "*仓库名称:";
                        // 
                        // FrmStoreInfo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1069, 518);
                        this.Controls.Add(this.panelInfo);
                        this.Controls.Add(this.toolStrip1);
                        this.Controls.Add(this.panel1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmStoreInfo";
                        this.ShowIcon = false;
                        this.Text = "仓库信息页面";
                        this.Load += new System.EventHandler(this.FrmStoreInfo_Load);
                        this.toolStrip1.ResumeLayout(false);
                        this.toolStrip1.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        this.panelInfo.ResumeLayout(false);
                        this.panelInfo.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
                        this.ResumeLayout(false);

                }

                #endregion
                private System.Windows.Forms.ToolStrip toolStrip1;
                private System.Windows.Forms.ToolStripButton tsbtnSave;
                private System.Windows.Forms.ToolStripButton tsbtnClear;
                private System.Windows.Forms.ToolStripButton tsbtnClose;
                private System.Windows.Forms.Panel panel1;
                private System.Windows.Forms.Label lblDesp;
                private System.Windows.Forms.Panel panelInfo;
                private System.Windows.Forms.PictureBox picList;
                private System.Windows.Forms.ComboBox cboSTypes;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.TextBox txtStoreNo;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.TextBox txtStoreOrder;
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.TextBox txtStorePYNo;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.TextBox txtStoreName;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.TextBox txtRemark;
                private System.Windows.Forms.Label label6;
        }
}