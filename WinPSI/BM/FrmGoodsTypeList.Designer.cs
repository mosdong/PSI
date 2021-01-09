namespace WinPSI.BM
{
    partial class FrmGoodsTypeList
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
                        this.tsStoreType = new System.Windows.Forms.ToolStrip();
                        this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.gbInfo = new System.Windows.Forms.GroupBox();
                        this.txtGTypeNo = new System.Windows.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.cboParents = new System.Windows.Forms.ComboBox();
                        this.txtGTPYNo = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.btnSave = new System.Windows.Forms.Button();
                        this.txtGTOrder = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtGTypeName = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.btnFind = new System.Windows.Forms.Button();
                        this.txtKeywords = new System.Windows.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.chkShowDel = new System.Windows.Forms.CheckBox();
                        this.dgvGoodsTypeList = new System.Windows.Forms.DataGridView();
                        this.GTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GTypeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.ParentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GTPYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.STOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.AddChilds = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.tsStoreType.SuspendLayout();
                        this.gbInfo.SuspendLayout();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsTypeList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // tsStoreType
                        // 
                        this.tsStoreType.AutoSize = false;
                        this.tsStoreType.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.tsStoreType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.tsStoreType.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.tsStoreType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.toolStripSeparator1,
            this.tsbtnRefresh,
            this.toolStripSeparator4,
            this.tsbtnClose});
                        this.tsStoreType.Location = new System.Drawing.Point(0, 0);
                        this.tsStoreType.Name = "tsStoreType";
                        this.tsStoreType.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.tsStoreType.Size = new System.Drawing.Size(1407, 62);
                        this.tsStoreType.TabIndex = 3;
                        this.tsStoreType.Text = "toolStrip1";
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
                        this.gbInfo.Controls.Add(this.txtGTypeNo);
                        this.gbInfo.Controls.Add(this.label5);
                        this.gbInfo.Controls.Add(this.label3);
                        this.gbInfo.Controls.Add(this.cboParents);
                        this.gbInfo.Controls.Add(this.txtGTPYNo);
                        this.gbInfo.Controls.Add(this.label4);
                        this.gbInfo.Controls.Add(this.btnSave);
                        this.gbInfo.Controls.Add(this.txtGTOrder);
                        this.gbInfo.Controls.Add(this.label2);
                        this.gbInfo.Controls.Add(this.txtGTypeName);
                        this.gbInfo.Controls.Add(this.label1);
                        this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.gbInfo.Location = new System.Drawing.Point(0, 62);
                        this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
                        this.gbInfo.Name = "gbInfo";
                        this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
                        this.gbInfo.Size = new System.Drawing.Size(1407, 76);
                        this.gbInfo.TabIndex = 6;
                        this.gbInfo.TabStop = false;
                        this.gbInfo.Text = "商品类别信息";
                        this.gbInfo.Visible = false;
                        // 
                        // txtGTypeNo
                        // 
                        this.txtGTypeNo.Location = new System.Drawing.Point(845, 32);
                        this.txtGTypeNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGTypeNo.Name = "txtGTypeNo";
                        this.txtGTypeNo.Size = new System.Drawing.Size(159, 25);
                        this.txtGTypeNo.TabIndex = 50;
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
                        // txtGTPYNo
                        // 
                        this.txtGTPYNo.Location = new System.Drawing.Point(597, 30);
                        this.txtGTPYNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGTPYNo.Name = "txtGTPYNo";
                        this.txtGTPYNo.ReadOnly = true;
                        this.txtGTPYNo.Size = new System.Drawing.Size(124, 25);
                        this.txtGTPYNo.TabIndex = 32;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(31, 39);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(75, 15);
                        this.label4.TabIndex = 38;
                        this.label4.Text = "上级类别:";
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
                        // txtGTOrder
                        // 
                        this.txtGTOrder.Location = new System.Drawing.Point(1096, 32);
                        this.txtGTOrder.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGTOrder.Name = "txtGTOrder";
                        this.txtGTOrder.Size = new System.Drawing.Size(96, 25);
                        this.txtGTOrder.TabIndex = 36;
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
                        // txtGTypeName
                        // 
                        this.txtGTypeName.Location = new System.Drawing.Point(355, 32);
                        this.txtGTypeName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGTypeName.Name = "txtGTypeName";
                        this.txtGTypeName.Size = new System.Drawing.Size(145, 25);
                        this.txtGTypeName.TabIndex = 30;
                        this.txtGTypeName.TextChanged += new System.EventHandler(this.txtGTypeName_TextChanged);
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
                        this.panel1.Size = new System.Drawing.Size(1407, 46);
                        this.panel1.TabIndex = 7;
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
                        this.chkShowDel.Location = new System.Drawing.Point(1303, 0);
                        this.chkShowDel.Margin = new System.Windows.Forms.Padding(4);
                        this.chkShowDel.Name = "chkShowDel";
                        this.chkShowDel.Size = new System.Drawing.Size(104, 46);
                        this.chkShowDel.TabIndex = 0;
                        this.chkShowDel.Text = "显示已删除";
                        this.chkShowDel.UseVisualStyleBackColor = true;
                        this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
                        // 
                        // dgvGoodsTypeList
                        // 
                        this.dgvGoodsTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvGoodsTypeList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvGoodsTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvGoodsTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvGoodsTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GTypeId,
            this.GTypeName,
            this.GTypeNo,
            this.ParentName,
            this.GTPYNo,
            this.STOrder,
            this.AddChilds,
            this.Edit,
            this.Del,
            this.Recover,
            this.Remove});
                        this.dgvGoodsTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvGoodsTypeList.Location = new System.Drawing.Point(0, 184);
                        this.dgvGoodsTypeList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvGoodsTypeList.Name = "dgvGoodsTypeList";
                        this.dgvGoodsTypeList.RowTemplate.Height = 23;
                        this.dgvGoodsTypeList.Size = new System.Drawing.Size(1407, 402);
                        this.dgvGoodsTypeList.TabIndex = 8;
                        this.dgvGoodsTypeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsTypeList_CellContentClick);
                        // 
                        // GTypeId
                        // 
                        this.GTypeId.DataPropertyName = "GTypeId";
                        this.GTypeId.HeaderText = "编号";
                        this.GTypeId.Name = "GTypeId";
                        this.GTypeId.ReadOnly = true;
                        // 
                        // GTypeName
                        // 
                        this.GTypeName.DataPropertyName = "GTypeName";
                        this.GTypeName.HeaderText = "商品类别";
                        this.GTypeName.Name = "GTypeName";
                        this.GTypeName.ReadOnly = true;
                        // 
                        // GTypeNo
                        // 
                        this.GTypeNo.DataPropertyName = "GTypeNo";
                        this.GTypeNo.HeaderText = "类别编码";
                        this.GTypeNo.Name = "GTypeNo";
                        this.GTypeNo.ReadOnly = true;
                        // 
                        // ParentName
                        // 
                        this.ParentName.DataPropertyName = "ParentName";
                        this.ParentName.HeaderText = "父级类别";
                        this.ParentName.Name = "ParentName";
                        this.ParentName.ReadOnly = true;
                        // 
                        // GTPYNo
                        // 
                        this.GTPYNo.DataPropertyName = "GTPYNo";
                        this.GTPYNo.HeaderText = "拼音码";
                        this.GTPYNo.Name = "GTPYNo";
                        this.GTPYNo.ReadOnly = true;
                        // 
                        // STOrder
                        // 
                        this.STOrder.DataPropertyName = "GTOrder";
                        this.STOrder.HeaderText = "排序号";
                        this.STOrder.Name = "STOrder";
                        this.STOrder.ReadOnly = true;
                        // 
                        // AddChilds
                        // 
                        dataGridViewCellStyle4.NullValue = "添加子类别";
                        this.AddChilds.DefaultCellStyle = dataGridViewCellStyle4;
                        this.AddChilds.HeaderText = "添加子类别";
                        this.AddChilds.Name = "AddChilds";
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
                        this.Recover.Text = "恢复";
                        this.Recover.UseColumnTextForLinkValue = true;
                        // 
                        // Remove
                        // 
                        this.Remove.HeaderText = "永久删除";
                        this.Remove.Name = "Remove";
                        this.Remove.Text = "永久删除";
                        this.Remove.UseColumnTextForLinkValue = true;
                        // 
                        // FrmGoodsTypeList
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.White;
                        this.ClientSize = new System.Drawing.Size(1407, 586);
                        this.Controls.Add(this.dgvGoodsTypeList);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.gbInfo);
                        this.Controls.Add(this.tsStoreType);
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.Name = "FrmGoodsTypeList";
                        this.ShowIcon = false;
                        this.Text = "商品类别管理";
                        this.Load += new System.EventHandler(this.FrmGoodsTypeList_Load);
                        this.tsStoreType.ResumeLayout(false);
                        this.tsStoreType.PerformLayout();
                        this.gbInfo.ResumeLayout(false);
                        this.gbInfo.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsTypeList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsStoreType;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtGTOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGTPYNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGTypeNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboParents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.DataGridView dgvGoodsTypeList;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTypeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTPYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOrder;
        private System.Windows.Forms.DataGridViewLinkColumn AddChilds;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
    }
}