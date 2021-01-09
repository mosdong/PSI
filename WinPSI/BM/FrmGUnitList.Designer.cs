namespace WinPSI.BM
{
    partial class FrmGUnitList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtGUnitOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGUnitPYNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsList = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.dgvGUnitList = new System.Windows.Forms.DataGridView();
            this.GUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUnitPYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUnitOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbInfo.SuspendLayout();
            this.tsList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUnitList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnSave);
            this.gbInfo.Controls.Add(this.txtGUnitOrder);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtGUnitPYNo);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtGUnitName);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Location = new System.Drawing.Point(0, 50);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(909, 64);
            this.gbInfo.TabIndex = 5;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "单位信息";
            this.gbInfo.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(670, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "添加";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGUnitOrder
            // 
            this.txtGUnitOrder.Location = new System.Drawing.Point(512, 22);
            this.txtGUnitOrder.Name = "txtGUnitOrder";
            this.txtGUnitOrder.Size = new System.Drawing.Size(142, 21);
            this.txtGUnitOrder.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "排序号:";
            // 
            // txtGUnitPYNo
            // 
            this.txtGUnitPYNo.Location = new System.Drawing.Point(299, 22);
            this.txtGUnitPYNo.Name = "txtGUnitPYNo";
            this.txtGUnitPYNo.ReadOnly = true;
            this.txtGUnitPYNo.Size = new System.Drawing.Size(142, 21);
            this.txtGUnitPYNo.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "拼音码:";
            // 
            // txtGUnitName
            // 
            this.txtGUnitName.Location = new System.Drawing.Point(77, 22);
            this.txtGUnitName.Name = "txtGUnitName";
            this.txtGUnitName.Size = new System.Drawing.Size(142, 21);
            this.txtGUnitName.TabIndex = 30;
            this.txtGUnitName.TextChanged += new System.EventHandler(this.txtGUnitName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "商品单位:";
            // 
            // tsList
            // 
            this.tsList.AutoSize = false;
            this.tsList.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
            this.tsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 5);
            this.tsList.Size = new System.Drawing.Size(909, 50);
            this.tsList.TabIndex = 4;
            this.tsList.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::WinPSI.Properties.Resources.add;
            this.tsbtnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(40, 42);
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
            this.tsbtnEdit.Size = new System.Drawing.Size(40, 42);
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
            this.tsbtnDelete.Size = new System.Drawing.Size(40, 42);
            this.tsbtnDelete.Text = " 删除";
            this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = global::WinPSI.Properties.Resources.refresh;
            this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(40, 42);
            this.tsbtnRefresh.Text = " 刷新";
            this.tsbtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = global::WinPSI.Properties.Resources.close0;
            this.tsbtnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(36, 42);
            this.tsbtnClose.Text = "关闭";
            this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkShowDel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 25);
            this.panel1.TabIndex = 7;
            // 
            // chkShowDel
            // 
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkShowDel.Location = new System.Drawing.Point(825, 0);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(84, 25);
            this.chkShowDel.TabIndex = 8;
            this.chkShowDel.Text = "显示已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
            // 
            // dgvGUnitList
            // 
            this.dgvGUnitList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGUnitList.BackgroundColor = System.Drawing.Color.White;
            this.dgvGUnitList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGUnitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUnitId,
            this.GUnitName,
            this.GUnitPYNo,
            this.GUnitOrder,
            this.Edit,
            this.Del,
            this.Recover,
            this.Remove});
            this.dgvGUnitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGUnitList.Location = new System.Drawing.Point(0, 139);
            this.dgvGUnitList.Name = "dgvGUnitList";
            this.dgvGUnitList.RowTemplate.Height = 23;
            this.dgvGUnitList.Size = new System.Drawing.Size(909, 316);
            this.dgvGUnitList.TabIndex = 8;
            this.dgvGUnitList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGUnitList_CellContentClick);
            // 
            // GUnitId
            // 
            this.GUnitId.DataPropertyName = "GUnitId";
            this.GUnitId.HeaderText = "编号";
            this.GUnitId.Name = "GUnitId";
            this.GUnitId.ReadOnly = true;
            // 
            // GUnitName
            // 
            this.GUnitName.DataPropertyName = "GUnitName";
            this.GUnitName.HeaderText = "商品单位";
            this.GUnitName.Name = "GUnitName";
            this.GUnitName.ReadOnly = true;
            // 
            // GUnitPYNo
            // 
            this.GUnitPYNo.DataPropertyName = "GUnitPYNo";
            this.GUnitPYNo.HeaderText = "拼音码";
            this.GUnitPYNo.Name = "GUnitPYNo";
            this.GUnitPYNo.ReadOnly = true;
            // 
            // GUnitOrder
            // 
            this.GUnitOrder.DataPropertyName = "GUnitOrder";
            this.GUnitOrder.HeaderText = "排序号";
            this.GUnitOrder.Name = "GUnitOrder";
            this.GUnitOrder.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.NullValue = "修改";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "修改";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Del
            // 
            dataGridViewCellStyle2.NullValue = "删除";
            this.Del.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.Remove.FillWeight = 80F;
            this.Remove.HeaderText = "永久删除";
            this.Remove.Name = "Remove";
            this.Remove.Text = "永久删除";
            this.Remove.UseColumnTextForLinkValue = true;
            // 
            // FrmGUnitList
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 455);
            this.Controls.Add(this.dgvGUnitList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.tsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGUnitList";
            this.ShowIcon = false;
            this.Text = "计量单位管理";
            this.Load += new System.EventHandler(this.FrmGUnitList_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tsList.ResumeLayout(false);
            this.tsList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUnitList)).EndInit();
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
        private System.Windows.Forms.TextBox txtGUnitOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGUnitPYNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.DataGridView dgvGUnitList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnitPYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnitOrder;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
    }
}