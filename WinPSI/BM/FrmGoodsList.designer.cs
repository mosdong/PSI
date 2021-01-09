namespace WinPSI.BM
{
    partial class FrmGoodsList
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
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
                        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
                        this.chkShowDel = new System.Windows.Forms.CheckBox();
                        this.chkStop = new System.Windows.Forms.CheckBox();
                        this.btnQuery = new System.Windows.Forms.Button();
                        this.txtKeyWords = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
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
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.spContainterStore = new System.Windows.Forms.SplitContainer();
                        this.tvGTypes = new System.Windows.Forms.TreeView();
                        this.dgvGoodsList = new System.Windows.Forms.DataGridView();
                        this.ucPager1 = new WinPSI.UControls.ucPager();
                        this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.GoodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsTXNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.IsStopped = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                        this.StorePYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.RecoverCol = new System.Windows.Forms.DataGridViewLinkColumn();
                        this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
                        panelWhere = new System.Windows.Forms.Panel();
                        panelWhere.SuspendLayout();
                        this.tsList.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.spContainterStore)).BeginInit();
                        this.spContainterStore.Panel1.SuspendLayout();
                        this.spContainterStore.Panel2.SuspendLayout();
                        this.spContainterStore.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // panelWhere
                        // 
                        panelWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        panelWhere.Controls.Add(this.chkShowDel);
                        panelWhere.Controls.Add(this.chkStop);
                        panelWhere.Controls.Add(this.btnQuery);
                        panelWhere.Controls.Add(this.txtKeyWords);
                        panelWhere.Controls.Add(this.label1);
                        panelWhere.Dock = System.Windows.Forms.DockStyle.Top;
                        panelWhere.Location = new System.Drawing.Point(0, 50);
                        panelWhere.Name = "panelWhere";
                        panelWhere.Size = new System.Drawing.Size(1281, 56);
                        panelWhere.TabIndex = 3;
                        // 
                        // chkShowDel
                        // 
                        this.chkShowDel.AutoSize = true;
                        this.chkShowDel.Location = new System.Drawing.Point(832, 25);
                        this.chkShowDel.Name = "chkShowDel";
                        this.chkShowDel.Size = new System.Drawing.Size(104, 19);
                        this.chkShowDel.TabIndex = 4;
                        this.chkShowDel.Text = "显示已删除";
                        this.chkShowDel.UseVisualStyleBackColor = true;
                        this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
                        // 
                        // chkStop
                        // 
                        this.chkStop.AutoSize = true;
                        this.chkStop.Location = new System.Drawing.Point(643, 26);
                        this.chkStop.Name = "chkStop";
                        this.chkStop.Size = new System.Drawing.Size(134, 19);
                        this.chkStop.TabIndex = 3;
                        this.chkStop.Text = "仅显示停用商品";
                        this.chkStop.UseVisualStyleBackColor = true;
                        this.chkStop.CheckedChanged += new System.EventHandler(this.chkStop_CheckedChanged);
                        // 
                        // btnQuery
                        // 
                        this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnQuery.Location = new System.Drawing.Point(468, 21);
                        this.btnQuery.Name = "btnQuery";
                        this.btnQuery.Size = new System.Drawing.Size(75, 23);
                        this.btnQuery.TabIndex = 2;
                        this.btnQuery.Text = "查询";
                        this.btnQuery.UseVisualStyleBackColor = true;
                        this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
                        // 
                        // txtKeyWords
                        // 
                        this.txtKeyWords.Location = new System.Drawing.Point(269, 20);
                        this.txtKeyWords.Name = "txtKeyWords";
                        this.txtKeyWords.Size = new System.Drawing.Size(179, 25);
                        this.txtKeyWords.TabIndex = 1;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(43, 26);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(218, 15);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "请输入商品名称/编码/拼音码：";
                        // 
                        // tsbtnType
                        // 
                        this.tsbtnType.Image = global::WinPSI.Properties.Resources.type;
                        this.tsbtnType.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnType.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnType.Name = "tsbtnType";
                        this.tsbtnType.Size = new System.Drawing.Size(73, 42);
                        this.tsbtnType.Text = "商品类别";
                        this.tsbtnType.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                        this.tsbtnType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnType.Click += new System.EventHandler(this.tsbtnType_Click);
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
                        // 
                        // tsbtnAdd
                        // 
                        this.tsbtnAdd.Image = global::WinPSI.Properties.Resources.add;
                        this.tsbtnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnAdd.Name = "tsbtnAdd";
                        this.tsbtnAdd.Size = new System.Drawing.Size(47, 42);
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
                        this.tsbtnEdit.Size = new System.Drawing.Size(47, 42);
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
                        this.tsbtnDelete.Size = new System.Drawing.Size(47, 42);
                        this.tsbtnDelete.Text = " 删除";
                        this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
                        // 
                        // toolStripSeparator2
                        // 
                        this.toolStripSeparator2.Name = "toolStripSeparator2";
                        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
                        // 
                        // tsbtnInfo
                        // 
                        this.tsbtnInfo.Image = global::WinPSI.Properties.Resources.xq;
                        this.tsbtnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnInfo.Name = "tsbtnInfo";
                        this.tsbtnInfo.Size = new System.Drawing.Size(47, 42);
                        this.tsbtnInfo.Text = " 详情";
                        this.tsbtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
                        // 
                        // toolStripSeparator3
                        // 
                        this.toolStripSeparator3.Name = "toolStripSeparator3";
                        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
                        // 
                        // tsbtnRefresh
                        // 
                        this.tsbtnRefresh.Image = global::WinPSI.Properties.Resources.refresh;
                        this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnRefresh.Name = "tsbtnRefresh";
                        this.tsbtnRefresh.Size = new System.Drawing.Size(47, 42);
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
                        this.tsbtnClose.Size = new System.Drawing.Size(43, 42);
                        this.tsbtnClose.Text = "关闭";
                        this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
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
                        this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 5);
                        this.tsList.Size = new System.Drawing.Size(1281, 50);
                        this.tsList.TabIndex = 1;
                        this.tsList.Text = "toolStrip1";
                        // 
                        // spContainterStore
                        // 
                        this.spContainterStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.spContainterStore.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.spContainterStore.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
                        this.spContainterStore.Location = new System.Drawing.Point(0, 106);
                        this.spContainterStore.Name = "spContainterStore";
                        // 
                        // spContainterStore.Panel1
                        // 
                        this.spContainterStore.Panel1.Controls.Add(this.tvGTypes);
                        // 
                        // spContainterStore.Panel2
                        // 
                        this.spContainterStore.Panel2.BackColor = System.Drawing.Color.White;
                        this.spContainterStore.Panel2.Controls.Add(this.dgvGoodsList);
                        this.spContainterStore.Panel2.Controls.Add(this.ucPager1);
                        this.spContainterStore.Size = new System.Drawing.Size(1281, 549);
                        this.spContainterStore.SplitterDistance = 217;
                        this.spContainterStore.TabIndex = 4;
                        // 
                        // tvGTypes
                        // 
                        this.tvGTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                        this.tvGTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.tvGTypes.HideSelection = false;
                        this.tvGTypes.ItemHeight = 20;
                        this.tvGTypes.Location = new System.Drawing.Point(9, 8);
                        this.tvGTypes.Name = "tvGTypes";
                        this.tvGTypes.Size = new System.Drawing.Size(198, 530);
                        this.tvGTypes.TabIndex = 0;
                        this.tvGTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGTypes_AfterSelect);
                        // 
                        // dgvGoodsList
                        // 
                        this.dgvGoodsList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvGoodsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvGoodsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        this.dgvGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsId,
            this.GoodsNo,
            this.GoodsName,
            this.GoodsTName,
            this.GoodsTXNo,
            this.GUnit,
            this.GoodsProperties,
            this.RetailPrice,
            this.IsStopped,
            this.StorePYNo,
            this.Remark,
            this.Edit,
            this.Del,
            this.RecoverCol,
            this.Remove});
                        this.dgvGoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvGoodsList.Location = new System.Drawing.Point(0, 0);
                        this.dgvGoodsList.Name = "dgvGoodsList";
                        this.dgvGoodsList.RowTemplate.Height = 23;
                        this.dgvGoodsList.Size = new System.Drawing.Size(1058, 496);
                        this.dgvGoodsList.TabIndex = 2;
                        this.dgvGoodsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsList_CellContentClick);
                        // 
                        // ucPager1
                        // 
                        this.ucPager1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.ucPager1.CurrentPage = 1;
                        this.ucPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.ucPager1.Location = new System.Drawing.Point(0, 496);
                        this.ucPager1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.ucPager1.Name = "ucPager1";
                        this.ucPager1.PageSize = 5;
                        this.ucPager1.Record = 0;
                        this.ucPager1.Size = new System.Drawing.Size(1058, 51);
                        this.ucPager1.StartRecord = 1;
                        this.ucPager1.TabIndex = 1;
                        this.ucPager1.BindSource += new WinPSI.UControls.ucPager.BindHandle(this.ucPager1_BindSource);
                        // 
                        // Recover
                        // 
                        this.Recover.FillWeight = 50F;
                        this.Recover.HeaderText = "恢复";
                        this.Recover.Name = "Recover";
                        this.Recover.Text = "恢复";
                        this.Recover.UseColumnTextForLinkValue = true;
                        // 
                        // GoodsId
                        // 
                        this.GoodsId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.GoodsId.DataPropertyName = "GoodsId";
                        this.GoodsId.HeaderText = "编号";
                        this.GoodsId.Name = "GoodsId";
                        this.GoodsId.ReadOnly = true;
                        this.GoodsId.Width = 66;
                        // 
                        // GoodsNo
                        // 
                        this.GoodsNo.DataPropertyName = "GoodsNo";
                        this.GoodsNo.HeaderText = "商品编码";
                        this.GoodsNo.Name = "GoodsNo";
                        this.GoodsNo.ReadOnly = true;
                        this.GoodsNo.Width = 78;
                        // 
                        // GoodsName
                        // 
                        this.GoodsName.DataPropertyName = "GoodsName";
                        this.GoodsName.HeaderText = "商品名称";
                        this.GoodsName.Name = "GoodsName";
                        this.GoodsName.ReadOnly = true;
                        this.GoodsName.Width = 78;
                        // 
                        // GoodsTName
                        // 
                        this.GoodsTName.DataPropertyName = "GTypeName";
                        this.GoodsTName.HeaderText = "商品类别";
                        this.GoodsTName.Name = "GoodsTName";
                        this.GoodsTName.ReadOnly = true;
                        this.GoodsTName.Width = 78;
                        // 
                        // GoodsTXNo
                        // 
                        this.GoodsTXNo.DataPropertyName = "GoodsTXNo";
                        this.GoodsTXNo.HeaderText = "条形码";
                        this.GoodsTXNo.Name = "GoodsTXNo";
                        this.GoodsTXNo.Width = 66;
                        // 
                        // GUnit
                        // 
                        this.GUnit.DataPropertyName = "GUnit";
                        this.GUnit.HeaderText = "基本单位";
                        this.GUnit.Name = "GUnit";
                        this.GUnit.ReadOnly = true;
                        this.GUnit.Width = 78;
                        // 
                        // GoodsProperties
                        // 
                        this.GoodsProperties.DataPropertyName = "GProperties";
                        this.GoodsProperties.HeaderText = "商品性质";
                        this.GoodsProperties.Name = "GoodsProperties";
                        this.GoodsProperties.ReadOnly = true;
                        this.GoodsProperties.Width = 78;
                        // 
                        // RetailPrice
                        // 
                        this.RetailPrice.DataPropertyName = "RetailPrice";
                        this.RetailPrice.HeaderText = "零售价";
                        this.RetailPrice.Name = "RetailPrice";
                        this.RetailPrice.ReadOnly = true;
                        this.RetailPrice.Width = 66;
                        // 
                        // IsStopped
                        // 
                        this.IsStopped.DataPropertyName = "IsStopped";
                        this.IsStopped.FalseValue = "0";
                        this.IsStopped.HeaderText = "停用";
                        this.IsStopped.Name = "IsStopped";
                        this.IsStopped.ReadOnly = true;
                        this.IsStopped.TrueValue = "1";
                        this.IsStopped.Width = 35;
                        // 
                        // StorePYNo
                        // 
                        this.StorePYNo.DataPropertyName = "GoodsPYNo";
                        this.StorePYNo.HeaderText = "拼音码";
                        this.StorePYNo.Name = "StorePYNo";
                        this.StorePYNo.ReadOnly = true;
                        this.StorePYNo.Width = 66;
                        // 
                        // Remark
                        // 
                        this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.Remark.DataPropertyName = "Remark";
                        this.Remark.FillWeight = 200F;
                        this.Remark.HeaderText = "备注";
                        this.Remark.Name = "Remark";
                        this.Remark.ReadOnly = true;
                        this.Remark.Width = 62;
                        // 
                        // Edit
                        // 
                        dataGridViewCellStyle5.NullValue = "修改";
                        this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
                        this.Edit.FillWeight = 50F;
                        this.Edit.HeaderText = "修改";
                        this.Edit.Name = "Edit";
                        this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        this.Edit.Width = 35;
                        // 
                        // Del
                        // 
                        dataGridViewCellStyle6.NullValue = "删除";
                        this.Del.DefaultCellStyle = dataGridViewCellStyle6;
                        this.Del.FillWeight = 50F;
                        this.Del.HeaderText = "删除";
                        this.Del.Name = "Del";
                        this.Del.Width = 35;
                        // 
                        // RecoverCol
                        // 
                        this.RecoverCol.HeaderText = "恢复";
                        this.RecoverCol.Name = "RecoverCol";
                        this.RecoverCol.Text = "恢复";
                        this.RecoverCol.UseColumnTextForLinkValue = true;
                        this.RecoverCol.Width = 35;
                        // 
                        // Remove
                        // 
                        this.Remove.FillWeight = 50F;
                        this.Remove.HeaderText = "移除";
                        this.Remove.Name = "Remove";
                        this.Remove.Text = "移除";
                        this.Remove.UseColumnTextForLinkValue = true;
                        this.Remove.Width = 35;
                        // 
                        // FrmGoodsList
                        // 
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                        this.ClientSize = new System.Drawing.Size(1281, 655);
                        this.Controls.Add(this.spContainterStore);
                        this.Controls.Add(panelWhere);
                        this.Controls.Add(this.tsList);
                        this.Name = "FrmGoodsList";
                        this.ShowIcon = false;
                        this.Text = "商品信息管理页面";
                        this.Load += new System.EventHandler(this.FrmGoodsList_Load);
                        panelWhere.ResumeLayout(false);
                        panelWhere.PerformLayout();
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.spContainterStore.Panel1.ResumeLayout(false);
                        this.spContainterStore.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.spContainterStore)).EndInit();
                        this.spContainterStore.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox chkStop;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.SplitContainer spContainterStore;
        private System.Windows.Forms.TreeView tvGTypes;
        private UControls.ucPager ucPager1;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
                private System.Windows.Forms.DataGridView dgvGoodsList;
                private System.Windows.Forms.DataGridViewTextBoxColumn GoodsId;
                private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNo;
                private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
                private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTName;
                private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTXNo;
                private System.Windows.Forms.DataGridViewTextBoxColumn GUnit;
                private System.Windows.Forms.DataGridViewTextBoxColumn GoodsProperties;
                private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
                private System.Windows.Forms.DataGridViewCheckBoxColumn IsStopped;
                private System.Windows.Forms.DataGridViewTextBoxColumn StorePYNo;
                private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
                private System.Windows.Forms.DataGridViewLinkColumn Edit;
                private System.Windows.Forms.DataGridViewLinkColumn Del;
                private System.Windows.Forms.DataGridViewLinkColumn RecoverCol;
                private System.Windows.Forms.DataGridViewLinkColumn Remove;
        }
}