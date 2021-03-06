﻿namespace WinPSI.BM
{
    partial class FrmStoreList
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
                        System.Windows.Forms.Panel panelWhere;
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
                        this.chkShowDel = new System.Windows.Forms.CheckBox();
                        this.btnQuery = new System.Windows.Forms.Button();
                        this.txtKeyWords = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.tsbtnType = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnInfo = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.spContainterStore = new System.Windows.Forms.SplitContainer();
                        this.tvSTypes = new System.Windows.Forms.TreeView();
                        this.dgvStoreList = new System.Windows.Forms.DataGridView();
                        this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StorePYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
                        panelWhere = new System.Windows.Forms.Panel();
                        panelWhere.SuspendLayout();
                        this.tsList.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.spContainterStore)).BeginInit();
                        this.spContainterStore.Panel1.SuspendLayout();
                        this.spContainterStore.Panel2.SuspendLayout();
                        this.spContainterStore.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // panelWhere
                        // 
                        panelWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        panelWhere.Controls.Add(this.chkShowDel);
                        panelWhere.Controls.Add(this.btnQuery);
                        panelWhere.Controls.Add(this.txtKeyWords);
                        panelWhere.Controls.Add(this.label1);
                        panelWhere.Dock = System.Windows.Forms.DockStyle.Top;
                        panelWhere.Location = new System.Drawing.Point(0, 62);
                        panelWhere.Margin = new System.Windows.Forms.Padding(4);
                        panelWhere.Name = "panelWhere";
                        panelWhere.Size = new System.Drawing.Size(1359, 63);
                        panelWhere.TabIndex = 2;
                        // 
                        // chkShowDel
                        // 
                        this.chkShowDel.AutoSize = true;
                        this.chkShowDel.Dock = System.Windows.Forms.DockStyle.Right;
                        this.chkShowDel.Location = new System.Drawing.Point(1253, 0);
                        this.chkShowDel.Margin = new System.Windows.Forms.Padding(4);
                        this.chkShowDel.Name = "chkShowDel";
                        this.chkShowDel.Size = new System.Drawing.Size(104, 61);
                        this.chkShowDel.TabIndex = 3;
                        this.chkShowDel.Text = "显示已删除";
                        this.chkShowDel.UseVisualStyleBackColor = true;
                        this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
                        // 
                        // btnQuery
                        // 
                        this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnQuery.Location = new System.Drawing.Point(792, 15);
                        this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
                        this.btnQuery.Name = "btnQuery";
                        this.btnQuery.Size = new System.Drawing.Size(100, 29);
                        this.btnQuery.TabIndex = 2;
                        this.btnQuery.Text = "查询";
                        this.btnQuery.UseVisualStyleBackColor = true;
                        this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
                        // 
                        // txtKeyWords
                        // 
                        this.txtKeyWords.Location = new System.Drawing.Point(508, 15);
                        this.txtKeyWords.Margin = new System.Windows.Forms.Padding(4);
                        this.txtKeyWords.Name = "txtKeyWords";
                        this.txtKeyWords.Size = new System.Drawing.Size(212, 25);
                        this.txtKeyWords.TabIndex = 1;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(269, 21);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(218, 15);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "请输入仓库名称/编码/拼音码：";
                        // 
                        // tsList
                        // 
                        this.tsList.AutoSize = false;
                        this.tsList.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.tsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        this.tsList.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnType,
            this.toolStripSeparator1,
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.toolStripSeparator2,
            this.tsbtnInfo,
            this.toolStripSeparator3,
            this.tsbtnRefresh,
            this.toolStripSeparator4,
            this.tsbtnClose});
                        this.tsList.Location = new System.Drawing.Point(0, 0);
                        this.tsList.Name = "tsList";
                        this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.tsList.Size = new System.Drawing.Size(1359, 62);
                        this.tsList.TabIndex = 0;
                        this.tsList.Text = "toolStrip1";
                        // 
                        // tsbtnType
                        // 
                        this.tsbtnType.Image = global::WinPSI.Properties.Resources.type;
                        this.tsbtnType.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnType.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnType.Name = "tsbtnType";
                        this.tsbtnType.Size = new System.Drawing.Size(77, 53);
                        this.tsbtnType.Text = " 仓库类别";
                        this.tsbtnType.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                        this.tsbtnType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnType.Click += new System.EventHandler(this.tsbtnType_Click);
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
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
                        // toolStripSeparator2
                        // 
                        this.toolStripSeparator2.Name = "toolStripSeparator2";
                        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
                        // 
                        // tsbtnInfo
                        // 
                        this.tsbtnInfo.Image = global::WinPSI.Properties.Resources.xq;
                        this.tsbtnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnInfo.Name = "tsbtnInfo";
                        this.tsbtnInfo.Size = new System.Drawing.Size(47, 53);
                        this.tsbtnInfo.Text = " 详情";
                        this.tsbtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
                        // 
                        // toolStripSeparator3
                        // 
                        this.toolStripSeparator3.Name = "toolStripSeparator3";
                        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
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
                        // spContainterStore
                        // 
                        this.spContainterStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.spContainterStore.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.spContainterStore.Location = new System.Drawing.Point(0, 125);
                        this.spContainterStore.Margin = new System.Windows.Forms.Padding(4);
                        this.spContainterStore.Name = "spContainterStore";
                        // 
                        // spContainterStore.Panel1
                        // 
                        this.spContainterStore.Panel1.Controls.Add(this.tvSTypes);
                        // 
                        // spContainterStore.Panel2
                        // 
                        this.spContainterStore.Panel2.BackColor = System.Drawing.Color.White;
                        this.spContainterStore.Panel2.Controls.Add(this.dgvStoreList);
                        this.spContainterStore.Size = new System.Drawing.Size(1359, 460);
                        this.spContainterStore.SplitterDistance = 257;
                        this.spContainterStore.SplitterWidth = 5;
                        this.spContainterStore.TabIndex = 3;
                        // 
                        // tvSTypes
                        // 
                        this.tvSTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.tvSTypes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvSTypes.Location = new System.Drawing.Point(0, 0);
                        this.tvSTypes.Margin = new System.Windows.Forms.Padding(4);
                        this.tvSTypes.Name = "tvSTypes";
                        this.tvSTypes.Size = new System.Drawing.Size(255, 458);
                        this.tvSTypes.TabIndex = 0;
                        this.tvSTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSTypes_AfterSelect);
                        // 
                        // dgvStoreList
                        // 
                        this.dgvStoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvStoreList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvStoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvStoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreId,
            this.StoreNo,
            this.StoreName,
            this.StoreTName,
            this.StorePYNo,
            this.StoreOrder,
            this.Remark,
            this.Edit,
            this.Del,
            this.Recover,
            this.Remove});
                        this.dgvStoreList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvStoreList.Location = new System.Drawing.Point(0, 0);
                        this.dgvStoreList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvStoreList.Name = "dgvStoreList";
                        this.dgvStoreList.RowTemplate.Height = 23;
                        this.dgvStoreList.Size = new System.Drawing.Size(1095, 458);
                        this.dgvStoreList.TabIndex = 0;
                        this.dgvStoreList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreList_CellContentClick);
                        // 
                        // StoreId
                        // 
                        this.StoreId.DataPropertyName = "StoreId";
                        this.StoreId.HeaderText = "编号";
                        this.StoreId.Name = "StoreId";
                        this.StoreId.ReadOnly = true;
                        // 
                        // StoreNo
                        // 
                        this.StoreNo.DataPropertyName = "StoreNo";
                        this.StoreNo.HeaderText = "仓库编码";
                        this.StoreNo.Name = "StoreNo";
                        this.StoreNo.ReadOnly = true;
                        // 
                        // StoreName
                        // 
                        this.StoreName.DataPropertyName = "StoreName";
                        this.StoreName.HeaderText = "仓库名称";
                        this.StoreName.Name = "StoreName";
                        this.StoreName.ReadOnly = true;
                        // 
                        // StoreTName
                        // 
                        this.StoreTName.DataPropertyName = "STypeName";
                        this.StoreTName.HeaderText = "仓库类别";
                        this.StoreTName.Name = "StoreTName";
                        this.StoreTName.ReadOnly = true;
                        // 
                        // StorePYNo
                        // 
                        this.StorePYNo.DataPropertyName = "StorePYNo";
                        this.StorePYNo.HeaderText = "拼音码";
                        this.StorePYNo.Name = "StorePYNo";
                        this.StorePYNo.ReadOnly = true;
                        // 
                        // StoreOrder
                        // 
                        this.StoreOrder.DataPropertyName = "StoreOrder";
                        this.StoreOrder.HeaderText = "排序号";
                        this.StoreOrder.Name = "StoreOrder";
                        this.StoreOrder.ReadOnly = true;
                        // 
                        // Remark
                        // 
                        this.Remark.DataPropertyName = "StoreRemark";
                        this.Remark.FillWeight = 200F;
                        this.Remark.HeaderText = "备注";
                        this.Remark.Name = "Remark";
                        this.Remark.ReadOnly = true;
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
                        this.Remove.FillWeight = 50F;
                        this.Remove.HeaderText = "移除";
                        this.Remove.Name = "Remove";
                        this.Remove.Text = "移除";
                        this.Remove.UseColumnTextForLinkValue = true;
                        // 
                        // FrmStoreList
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1359, 585);
                        this.Controls.Add(this.spContainterStore);
                        this.Controls.Add(panelWhere);
                        this.Controls.Add(this.tsList);
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmStoreList";
                        this.ShowIcon = false;
                        this.Text = "仓库信息管理页面";
                        this.Load += new System.EventHandler(this.FrmStoreList_Load);
                        panelWhere.ResumeLayout(false);
                        panelWhere.PerformLayout();
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.spContainterStore.Panel1.ResumeLayout(false);
                        this.spContainterStore.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.spContainterStore)).EndInit();
                        this.spContainterStore.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripButton tsbtnType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer spContainterStore;
        private System.Windows.Forms.TreeView tvSTypes;
        private System.Windows.Forms.DataGridView dgvStoreList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.CheckBox chkShowDel;
    }
}