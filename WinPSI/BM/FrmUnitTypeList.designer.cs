namespace WinPSI.BM
{
    partial class FrmUnitTypeList
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
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.gbInfo = new System.Windows.Forms.GroupBox();
                        this.txtUTypeNo = new System.Windows.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.cboParents = new System.Windows.Forms.ComboBox();
                        this.txtUTPYNo = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.btnSave = new System.Windows.Forms.Button();
                        this.txtUTOrder = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtUTypeName = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.btnFind = new System.Windows.Forms.Button();
                        this.txtKeywords = new System.Windows.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.chkShowDel = new System.Windows.Forms.CheckBox();
                        this.dgvUnitTypeList = new System.Windows.Forms.DataGridView();
                        this.UTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UTypeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UTParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UTPYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UTOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.AddChild = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.tsList.SuspendLayout();
                        this.gbInfo.SuspendLayout();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvUnitTypeList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // tsList
                        // 
                        this.tsList.AutoSize = false;
                        this.tsList.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.tsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.tsList.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.toolStripSeparator1,
            this.tsbtnRefresh,
            this.toolStripSeparator4,
            this.tsbtnClose});
                        this.tsList.Location = new System.Drawing.Point(0, 0);
                        this.tsList.Name = "tsList";
                        this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.tsList.Size = new System.Drawing.Size(1339, 62);
                        this.tsList.TabIndex = 3;
                        this.tsList.Text = "toolStrip1";
                        // 
                        // tsbtnAdd
                        // 
                        this.tsbtnAdd.Image = global::WinPSI.Properties.Resources.add;
                        this.tsbtnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnAdd.Name = "tsbtnAdd";
                        this.tsbtnAdd.Size = new System.Drawing.Size(47, 53);
                        this.tsbtnAdd.Text = " 新增";
                        this.tsbtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
                        // 
                        // tsbtnEdit
                        // 
                        this.tsbtnEdit.Image = global::WinPSI.Properties.Resources.edit;
                        this.tsbtnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnEdit.Name = "tsbtnEdit";
                        this.tsbtnEdit.Size = new System.Drawing.Size(47, 53);
                        this.tsbtnEdit.Text = " 修改";
                        this.tsbtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
                        // 
                        // tsbtnDelete
                        // 
                        this.tsbtnDelete.Image = global::WinPSI.Properties.Resources.delete;
                        this.tsbtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnDelete.Name = "tsbtnDelete";
                        this.tsbtnDelete.Size = new System.Drawing.Size(47, 53);
                        this.tsbtnDelete.Text = " 删除";
                        this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
                        // 
                        // tsbtnRefresh
                        // 
                        this.tsbtnRefresh.Image = global::WinPSI.Properties.Resources.refresh;
                        this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnRefresh.Name = "tsbtnRefresh";
                        this.tsbtnRefresh.Size = new System.Drawing.Size(47, 53);
                        this.tsbtnRefresh.Text = " 刷新";
                        this.tsbtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
                        // 
                        // toolStripSeparator4
                        // 
                        this.toolStripSeparator4.Name = "toolStripSeparator4";
                        this.toolStripSeparator4.Size = new System.Drawing.Size(6, 56);
                        // 
                        // tsbtnClose
                        // 
                        this.tsbtnClose.Image = global::WinPSI.Properties.Resources.close0;
                        this.tsbtnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnClose.Name = "tsbtnClose";
                        this.tsbtnClose.Size = new System.Drawing.Size(43, 53);
                        this.tsbtnClose.Text = "关闭";
                        this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
                        // 
                        // gbInfo
                        // 
                        this.gbInfo.Controls.Add(this.txtUTypeNo);
                        this.gbInfo.Controls.Add(this.label5);
                        this.gbInfo.Controls.Add(this.label3);
                        this.gbInfo.Controls.Add(this.cboParents);
                        this.gbInfo.Controls.Add(this.txtUTPYNo);
                        this.gbInfo.Controls.Add(this.label4);
                        this.gbInfo.Controls.Add(this.btnSave);
                        this.gbInfo.Controls.Add(this.txtUTOrder);
                        this.gbInfo.Controls.Add(this.label2);
                        this.gbInfo.Controls.Add(this.txtUTypeName);
                        this.gbInfo.Controls.Add(this.label1);
                        this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.gbInfo.Location = new System.Drawing.Point(0, 62);
                        this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
                        this.gbInfo.Name = "gbInfo";
                        this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
                        this.gbInfo.Size = new System.Drawing.Size(1339, 76);
                        this.gbInfo.TabIndex = 7;
                        this.gbInfo.TabStop = false;
                        this.gbInfo.Text = "往来单位类别信息";
                        this.gbInfo.Visible = false;
                        // 
                        // txtUTypeNo
                        // 
                        this.txtUTypeNo.Location = new System.Drawing.Point(845, 32);
                        this.txtUTypeNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUTypeNo.Name = "txtUTypeNo";
                        this.txtUTypeNo.Size = new System.Drawing.Size(159, 25);
                        this.txtUTypeNo.TabIndex = 50;
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(752, 39);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(75, 15);
                        this.label5.TabIndex = 49;
                        this.label5.Text = "类别编码:";
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(527, 36);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(60, 15);
                        this.label3.TabIndex = 31;
                        this.label3.Text = "拼音码:";
                        // 
                        // cboParents
                        // 
                        this.cboParents.FormattingEnabled = true;
                        this.cboParents.Location = new System.Drawing.Point(115, 32);
                        this.cboParents.Margin = new System.Windows.Forms.Padding(4);
                        this.cboParents.Name = "cboParents";
                        this.cboParents.Size = new System.Drawing.Size(131, 23);
                        this.cboParents.TabIndex = 48;
                        // 
                        // txtUTPYNo
                        // 
                        this.txtUTPYNo.Location = new System.Drawing.Point(597, 30);
                        this.txtUTPYNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUTPYNo.Name = "txtUTPYNo";
                        this.txtUTPYNo.ReadOnly = true;
                        this.txtUTPYNo.Size = new System.Drawing.Size(124, 25);
                        this.txtUTPYNo.TabIndex = 32;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(31, 39);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(75, 15);
                        this.label4.TabIndex = 38;
                        this.label4.Text = "父级类别:";
                        // 
                        // btnSave
                        // 
                        this.btnSave.BackColor = System.Drawing.SystemColors.Control;
                        this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.btnSave.Location = new System.Drawing.Point(1223, 30);
                        this.btnSave.Margin = new System.Windows.Forms.Padding(4);
                        this.btnSave.Name = "btnSave";
                        this.btnSave.Size = new System.Drawing.Size(67, 29);
                        this.btnSave.TabIndex = 37;
                        this.btnSave.Text = "添加";
                        this.btnSave.UseVisualStyleBackColor = false;
                        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
                        // 
                        // txtUTOrder
                        // 
                        this.txtUTOrder.Location = new System.Drawing.Point(1096, 32);
                        this.txtUTOrder.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUTOrder.Name = "txtUTOrder";
                        this.txtUTOrder.Size = new System.Drawing.Size(96, 25);
                        this.txtUTOrder.TabIndex = 36;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(1025, 39);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(60, 15);
                        this.label2.TabIndex = 35;
                        this.label2.Text = "排序号:";
                        // 
                        // txtUTypeName
                        // 
                        this.txtUTypeName.Location = new System.Drawing.Point(355, 32);
                        this.txtUTypeName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUTypeName.Name = "txtUTypeName";
                        this.txtUTypeName.Size = new System.Drawing.Size(145, 25);
                        this.txtUTypeName.TabIndex = 30;
                        this.txtUTypeName.TextChanged += new System.EventHandler(this.txtUTypeName_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(268, 39);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(75, 15);
                        this.label1.TabIndex = 29;
                        this.label1.Text = "类别名称:";
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.btnFind);
                        this.panel1.Controls.Add(this.txtKeywords);
                        this.panel1.Controls.Add(this.label6);
                        this.panel1.Controls.Add(this.chkShowDel);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 138);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1339, 46);
                        this.panel1.TabIndex = 8;
                        // 
                        // btnFind
                        // 
                        this.btnFind.BackColor = System.Drawing.SystemColors.Control;
                        this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnFind.Location = new System.Drawing.Point(717, 10);
                        this.btnFind.Margin = new System.Windows.Forms.Padding(4);
                        this.btnFind.Name = "btnFind";
                        this.btnFind.Size = new System.Drawing.Size(100, 25);
                        this.btnFind.TabIndex = 3;
                        this.btnFind.Text = "查询";
                        this.btnFind.UseVisualStyleBackColor = false;
                        this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
                        // 
                        // txtKeywords
                        // 
                        this.txtKeywords.Location = new System.Drawing.Point(385, 11);
                        this.txtKeywords.Margin = new System.Windows.Forms.Padding(4);
                        this.txtKeywords.Name = "txtKeywords";
                        this.txtKeywords.Size = new System.Drawing.Size(231, 25);
                        this.txtKeywords.TabIndex = 2;
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(59, 16);
                        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(301, 15);
                        this.label6.TabIndex = 1;
                        this.label6.Text = "按类别名称/父类别名称/拼音码/类别编码：";
                        // 
                        // chkShowDel
                        // 
                        this.chkShowDel.AutoSize = true;
                        this.chkShowDel.Dock = System.Windows.Forms.DockStyle.Right;
                        this.chkShowDel.Location = new System.Drawing.Point(1235, 0);
                        this.chkShowDel.Margin = new System.Windows.Forms.Padding(4);
                        this.chkShowDel.Name = "chkShowDel";
                        this.chkShowDel.Size = new System.Drawing.Size(104, 46);
                        this.chkShowDel.TabIndex = 0;
                        this.chkShowDel.Text = "显示已删除";
                        this.chkShowDel.UseVisualStyleBackColor = true;
                        this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
                        // 
                        // dgvUnitTypeList
                        // 
                        this.dgvUnitTypeList.AllowUserToAddRows = false;
                        this.dgvUnitTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvUnitTypeList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvUnitTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvUnitTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UTypeId,
            this.UTypeNo,
            this.UTypeName,
            this.UTParent,
            this.UTPYNo,
            this.UTOrder,
            this.AddChild,
            this.Edit,
            this.Del,
            this.Recover,
            this.Remove});
                        this.dgvUnitTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvUnitTypeList.Location = new System.Drawing.Point(0, 184);
                        this.dgvUnitTypeList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvUnitTypeList.Name = "dgvUnitTypeList";
                        this.dgvUnitTypeList.RowTemplate.Height = 23;
                        this.dgvUnitTypeList.Size = new System.Drawing.Size(1339, 397);
                        this.dgvUnitTypeList.TabIndex = 9;
                        this.dgvUnitTypeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitTypeList_CellContentClick);
                        // 
                        // UTypeId
                        // 
                        this.UTypeId.DataPropertyName = "UTypeId";
                        this.UTypeId.HeaderText = "编号";
                        this.UTypeId.Name = "UTypeId";
                        this.UTypeId.ReadOnly = true;
                        // 
                        // UTypeNo
                        // 
                        this.UTypeNo.DataPropertyName = "UTypeNo";
                        this.UTypeNo.HeaderText = "类别编码";
                        this.UTypeNo.Name = "UTypeNo";
                        this.UTypeNo.ReadOnly = true;
                        // 
                        // UTypeName
                        // 
                        this.UTypeName.DataPropertyName = "UTypeName";
                        this.UTypeName.HeaderText = "单位类别";
                        this.UTypeName.Name = "UTypeName";
                        this.UTypeName.ReadOnly = true;
                        // 
                        // UTParent
                        // 
                        this.UTParent.DataPropertyName = "ParentName";
                        this.UTParent.HeaderText = "父级类别";
                        this.UTParent.Name = "UTParent";
                        this.UTParent.ReadOnly = true;
                        // 
                        // UTPYNo
                        // 
                        this.UTPYNo.DataPropertyName = "UTPYNo";
                        this.UTPYNo.HeaderText = "拼音码";
                        this.UTPYNo.Name = "UTPYNo";
                        this.UTPYNo.ReadOnly = true;
                        // 
                        // UTOrder
                        // 
                        this.UTOrder.DataPropertyName = "UTOrder";
                        this.UTOrder.HeaderText = "排序号";
                        this.UTOrder.Name = "UTOrder";
                        this.UTOrder.ReadOnly = true;
                        // 
                        // AddChild
                        // 
                        dataGridViewCellStyle4.NullValue = "添加子类别";
                        this.AddChild.DefaultCellStyle = dataGridViewCellStyle4;
                        this.AddChild.HeaderText = "添加子类别";
                        this.AddChild.Name = "AddChild";
                        // 
                        // Edit
                        // 
                        dataGridViewCellStyle5.NullValue = "修改";
                        this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
                        this.Edit.FillWeight = 50F;
                        this.Edit.HeaderText = "修改";
                        this.Edit.Name = "Edit";
                        this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        // 
                        // Del
                        // 
                        dataGridViewCellStyle6.NullValue = "删除";
                        this.Del.DefaultCellStyle = dataGridViewCellStyle6;
                        this.Del.FillWeight = 50F;
                        this.Del.HeaderText = "删除";
                        this.Del.Name = "Del";
                        // 
                        // Recover
                        // 
                        this.Recover.FillWeight = 50F;
                        this.Recover.HeaderText = "恢复";
                        this.Recover.Name = "Recover";
                        this.Recover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        this.Recover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                        this.Recover.Text = "恢复";
                        this.Recover.UseColumnTextForLinkValue = true;
                        // 
                        // Remove
                        // 
                        this.Remove.FillWeight = 50F;
                        this.Remove.HeaderText = "移除";
                        this.Remove.Name = "Remove";
                        this.Remove.Text = "移除";
                        this.Remove.UseColumnTextForLinkValue = true;
                        // 
                        // FrmUnitTypeList
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1339, 581);
                        this.Controls.Add(this.dgvUnitTypeList);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.gbInfo);
                        this.Controls.Add(this.tsList);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmUnitTypeList";
                        this.ShowIcon = false;
                        this.Text = "往来单位类别管理页面";
                        this.Load += new System.EventHandler(this.FrmUnitTypeList_Load);
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.gbInfo.ResumeLayout(false);
                        this.gbInfo.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvUnitTypeList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtUTypeNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboParents;
        private System.Windows.Forms.TextBox txtUTPYNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUTOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.DataGridView dgvUnitTypeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTypeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTPYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTOrder;
        private System.Windows.Forms.DataGridViewLinkColumn AddChild;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
    }
}