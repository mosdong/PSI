namespace WinPSI.BM
{
    partial class FrmStoreTypeList
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
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.gbInfo = new System.Windows.Forms.GroupBox();
                        this.btnSave = new System.Windows.Forms.Button();
                        this.txtSTOrder = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.txtSTPYNo = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.txtSTypeName = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.chkShowDel = new System.Windows.Forms.CheckBox();
                        this.dgvStoreTypeList = new System.Windows.Forms.DataGridView();
                        this.STypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.STypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StorePYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.STypeOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.tsList.SuspendLayout();
                        this.gbInfo.SuspendLayout();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvStoreTypeList)).BeginInit();
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
                        this.tsList.Size = new System.Drawing.Size(1431, 62);
                        this.tsList.TabIndex = 1;
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
                        this.gbInfo.Controls.Add(this.btnSave);
                        this.gbInfo.Controls.Add(this.txtSTOrder);
                        this.gbInfo.Controls.Add(this.label2);
                        this.gbInfo.Controls.Add(this.txtSTPYNo);
                        this.gbInfo.Controls.Add(this.label3);
                        this.gbInfo.Controls.Add(this.txtSTypeName);
                        this.gbInfo.Controls.Add(this.label1);
                        this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
                        this.gbInfo.Location = new System.Drawing.Point(0, 62);
                        this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
                        this.gbInfo.Name = "gbInfo";
                        this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
                        this.gbInfo.Size = new System.Drawing.Size(1431, 79);
                        this.gbInfo.TabIndex = 6;
                        this.gbInfo.TabStop = false;
                        this.gbInfo.Text = "仓库类别信息";
                        this.gbInfo.Visible = false;
                        // 
                        // btnSave
                        // 
                        this.btnSave.BackColor = System.Drawing.SystemColors.Control;
                        this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.btnSave.Location = new System.Drawing.Point(893, 28);
                        this.btnSave.Margin = new System.Windows.Forms.Padding(4);
                        this.btnSave.Name = "btnSave";
                        this.btnSave.Size = new System.Drawing.Size(67, 29);
                        this.btnSave.TabIndex = 37;
                        this.btnSave.Text = "添加";
                        this.btnSave.UseVisualStyleBackColor = false;
                        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
                        // 
                        // txtSTOrder
                        // 
                        this.txtSTOrder.Location = new System.Drawing.Point(683, 28);
                        this.txtSTOrder.Margin = new System.Windows.Forms.Padding(4);
                        this.txtSTOrder.Name = "txtSTOrder";
                        this.txtSTOrder.Size = new System.Drawing.Size(188, 25);
                        this.txtSTOrder.TabIndex = 36;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(612, 34);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(60, 15);
                        this.label2.TabIndex = 35;
                        this.label2.Text = "排序号:";
                        // 
                        // txtSTPYNo
                        // 
                        this.txtSTPYNo.Location = new System.Drawing.Point(399, 28);
                        this.txtSTPYNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtSTPYNo.Name = "txtSTPYNo";
                        this.txtSTPYNo.ReadOnly = true;
                        this.txtSTPYNo.Size = new System.Drawing.Size(188, 25);
                        this.txtSTPYNo.TabIndex = 32;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(328, 34);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(60, 15);
                        this.label3.TabIndex = 31;
                        this.label3.Text = "拼音码:";
                        // 
                        // txtSTypeName
                        // 
                        this.txtSTypeName.Location = new System.Drawing.Point(103, 28);
                        this.txtSTypeName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtSTypeName.Name = "txtSTypeName";
                        this.txtSTypeName.Size = new System.Drawing.Size(188, 25);
                        this.txtSTypeName.TabIndex = 30;
                        this.txtSTypeName.TextChanged += new System.EventHandler(this.txtSTypeName_TextChanged);
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(16, 34);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(75, 15);
                        this.label1.TabIndex = 29;
                        this.label1.Text = "仓库类别:";
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.chkShowDel);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 141);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1431, 35);
                        this.panel1.TabIndex = 7;
                        // 
                        // chkShowDel
                        // 
                        this.chkShowDel.AutoSize = true;
                        this.chkShowDel.Dock = System.Windows.Forms.DockStyle.Right;
                        this.chkShowDel.Location = new System.Drawing.Point(1327, 0);
                        this.chkShowDel.Margin = new System.Windows.Forms.Padding(4);
                        this.chkShowDel.Name = "chkShowDel";
                        this.chkShowDel.Size = new System.Drawing.Size(104, 35);
                        this.chkShowDel.TabIndex = 10;
                        this.chkShowDel.Text = "显示已删除";
                        this.chkShowDel.UseVisualStyleBackColor = true;
                        this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
                        // 
                        // dgvStoreTypeList
                        // 
                        this.dgvStoreTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvStoreTypeList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvStoreTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvStoreTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STypeId,
            this.STypeName,
            this.StorePYNo,
            this.STypeOrder,
            this.Edit,
            this.Del,
            this.Recover,
            this.Remove});
                        this.dgvStoreTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvStoreTypeList.Location = new System.Drawing.Point(0, 176);
                        this.dgvStoreTypeList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvStoreTypeList.Name = "dgvStoreTypeList";
                        this.dgvStoreTypeList.RowTemplate.Height = 23;
                        this.dgvStoreTypeList.Size = new System.Drawing.Size(1431, 448);
                        this.dgvStoreTypeList.TabIndex = 8;
                        this.dgvStoreTypeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreTypeList_CellContentClick);
                        // 
                        // STypeId
                        // 
                        this.STypeId.DataPropertyName = "STypeId";
                        this.STypeId.HeaderText = "编号";
                        this.STypeId.Name = "STypeId";
                        this.STypeId.ReadOnly = true;
                        // 
                        // STypeName
                        // 
                        this.STypeName.DataPropertyName = "STypeName";
                        this.STypeName.HeaderText = "类别名称";
                        this.STypeName.Name = "STypeName";
                        this.STypeName.ReadOnly = true;
                        // 
                        // StorePYNo
                        // 
                        this.StorePYNo.DataPropertyName = "STPYNo";
                        this.StorePYNo.HeaderText = "拼音码";
                        this.StorePYNo.Name = "StorePYNo";
                        this.StorePYNo.ReadOnly = true;
                        // 
                        // STypeOrder
                        // 
                        this.STypeOrder.DataPropertyName = "STypeOrder";
                        this.STypeOrder.HeaderText = "排序号";
                        this.STypeOrder.Name = "STypeOrder";
                        this.STypeOrder.ReadOnly = true;
                        // 
                        // Edit
                        // 
                        dataGridViewCellStyle3.NullValue = "修改";
                        this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
                        this.Edit.FillWeight = 50F;
                        this.Edit.HeaderText = "修改";
                        this.Edit.Name = "Edit";
                        this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        // 
                        // Del
                        // 
                        dataGridViewCellStyle4.NullValue = "删除";
                        this.Del.DefaultCellStyle = dataGridViewCellStyle4;
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
                        this.Remove.FillWeight = 50F;
                        this.Remove.HeaderText = "移除";
                        this.Remove.Name = "Remove";
                        this.Remove.Text = "移除";
                        this.Remove.UseColumnTextForLinkValue = true;
                        // 
                        // FrmStoreTypeList
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.BackColor = System.Drawing.Color.White;
                        this.ClientSize = new System.Drawing.Size(1431, 624);
                        this.Controls.Add(this.dgvStoreTypeList);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.gbInfo);
                        this.Controls.Add(this.tsList);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmStoreTypeList";
                        this.ShowIcon = false;
                        this.Text = "仓库类别管理";
                        this.Load += new System.EventHandler(this.FrmStoreTypeList_Load);
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.gbInfo.ResumeLayout(false);
                        this.gbInfo.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvStoreTypeList)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSTOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTPYNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.DataGridView dgvStoreTypeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn STypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn STypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STypeOrder;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
    }
}