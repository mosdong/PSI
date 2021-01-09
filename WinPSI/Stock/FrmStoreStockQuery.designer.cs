namespace WinPSI.Stock
{
    partial class FrmStoreStockQuery
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreStockQuery));
                        this.storeList = new System.Windows.Forms.PictureBox();
                        this.txtInStore = new System.Windows.Forms.TextBox();
                        this.txtGoodsName = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.dgvList = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CurCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.tvGoodsType = new System.Windows.Forms.TreeView();
                        this.scQuery = new System.Windows.Forms.SplitContainer();
                        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                        this.tsbtnQuery = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnStoreDistribute = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnOutToExcel = new System.Windows.Forms.ToolStripButton();
                        panelWhere = new System.Windows.Forms.Panel();
                        panelWhere.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.scQuery)).BeginInit();
                        this.scQuery.Panel1.SuspendLayout();
                        this.scQuery.Panel2.SuspendLayout();
                        this.scQuery.SuspendLayout();
                        this.toolStrip1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // panelWhere
                        // 
                        panelWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        panelWhere.Controls.Add(this.storeList);
                        panelWhere.Controls.Add(this.txtInStore);
                        panelWhere.Controls.Add(this.txtGoodsName);
                        panelWhere.Controls.Add(this.label3);
                        panelWhere.Controls.Add(this.label2);
                        panelWhere.Controls.Add(this.label1);
                        panelWhere.Dock = System.Windows.Forms.DockStyle.Top;
                        panelWhere.Location = new System.Drawing.Point(0, 65);
                        panelWhere.Margin = new System.Windows.Forms.Padding(4);
                        panelWhere.Name = "panelWhere";
                        panelWhere.Size = new System.Drawing.Size(1827, 70);
                        panelWhere.TabIndex = 4;
                        // 
                        // storeList
                        // 
                        this.storeList.Image = global::WinPSI.Properties.Resources.book;
                        this.storeList.Location = new System.Drawing.Point(616, 32);
                        this.storeList.Margin = new System.Windows.Forms.Padding(4);
                        this.storeList.Name = "storeList";
                        this.storeList.Size = new System.Drawing.Size(21, 19);
                        this.storeList.TabIndex = 9;
                        this.storeList.TabStop = false;
                        this.storeList.Click += new System.EventHandler(this.storeList_Click);
                        // 
                        // txtInStore
                        // 
                        this.txtInStore.Location = new System.Drawing.Point(367, 26);
                        this.txtInStore.Margin = new System.Windows.Forms.Padding(4);
                        this.txtInStore.Name = "txtInStore";
                        this.txtInStore.Size = new System.Drawing.Size(240, 25);
                        this.txtInStore.TabIndex = 8;
                        this.txtInStore.TextChanged += new System.EventHandler(this.txtInStore_TextChanged);
                        // 
                        // txtGoodsName
                        // 
                        this.txtGoodsName.Location = new System.Drawing.Point(784, 26);
                        this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGoodsName.Name = "txtGoodsName";
                        this.txtGoodsName.Size = new System.Drawing.Size(243, 25);
                        this.txtGoodsName.TabIndex = 6;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(694, 32);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(82, 15);
                        this.label3.TabIndex = 5;
                        this.label3.Text = "商品名称：";
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(64, 32);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(75, 15);
                        this.label2.TabIndex = 4;
                        this.label2.Text = "商品分类:";
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(305, 32);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(52, 15);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "仓库：";
                        // 
                        // dgvList
                        // 
                        this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GoodsNo,
            this.GoodsName,
            this.GUnit,
            this.GTypeName,
            this.StCount,
            this.StAmount,
            this.CurCount,
            this.StPrice,
            this.StockAmount});
                        this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvList.Location = new System.Drawing.Point(0, 0);
                        this.dgvList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvList.MultiSelect = false;
                        this.dgvList.Name = "dgvList";
                        this.dgvList.RowTemplate.Height = 23;
                        this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.dgvList.Size = new System.Drawing.Size(1544, 535);
                        this.dgvList.TabIndex = 2;
                        this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
                        // 
                        // Id
                        // 
                        this.Id.DataPropertyName = "Id";
                        this.Id.HeaderText = "编号";
                        this.Id.Name = "Id";
                        this.Id.ReadOnly = true;
                        // 
                        // GoodsNo
                        // 
                        this.GoodsNo.DataPropertyName = "GoodsNo";
                        this.GoodsNo.HeaderText = "商品编码";
                        this.GoodsNo.Name = "GoodsNo";
                        this.GoodsNo.ReadOnly = true;
                        // 
                        // GoodsName
                        // 
                        this.GoodsName.DataPropertyName = "GoodsName";
                        this.GoodsName.HeaderText = "商品名称";
                        this.GoodsName.Name = "GoodsName";
                        this.GoodsName.ReadOnly = true;
                        // 
                        // GUnit
                        // 
                        this.GUnit.DataPropertyName = "GUnit";
                        this.GUnit.HeaderText = "基本单位";
                        this.GUnit.Name = "GUnit";
                        this.GUnit.ReadOnly = true;
                        // 
                        // GTypeName
                        // 
                        this.GTypeName.DataPropertyName = "GTypeName";
                        this.GTypeName.HeaderText = "商品类别";
                        this.GTypeName.Name = "GTypeName";
                        this.GTypeName.ReadOnly = true;
                        // 
                        // StCount
                        // 
                        this.StCount.DataPropertyName = "StCount";
                        this.StCount.HeaderText = "期初数量";
                        this.StCount.Name = "StCount";
                        this.StCount.ReadOnly = true;
                        // 
                        // StAmount
                        // 
                        this.StAmount.DataPropertyName = "StAmount";
                        this.StAmount.HeaderText = "期初金额";
                        this.StAmount.Name = "StAmount";
                        this.StAmount.ReadOnly = true;
                        // 
                        // CurCount
                        // 
                        this.CurCount.DataPropertyName = "CurCount";
                        this.CurCount.HeaderText = "当前库存";
                        this.CurCount.Name = "CurCount";
                        this.CurCount.ReadOnly = true;
                        // 
                        // StPrice
                        // 
                        this.StPrice.DataPropertyName = "StPrice";
                        this.StPrice.HeaderText = "成本单价";
                        this.StPrice.Name = "StPrice";
                        this.StPrice.ReadOnly = true;
                        // 
                        // StockAmount
                        // 
                        this.StockAmount.DataPropertyName = "StockAmount";
                        this.StockAmount.HeaderText = "库存金额";
                        this.StockAmount.Name = "StockAmount";
                        this.StockAmount.ReadOnly = true;
                        // 
                        // tvGoodsType
                        // 
                        this.tvGoodsType.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvGoodsType.Location = new System.Drawing.Point(0, 0);
                        this.tvGoodsType.Margin = new System.Windows.Forms.Padding(4);
                        this.tvGoodsType.Name = "tvGoodsType";
                        this.tvGoodsType.Size = new System.Drawing.Size(274, 535);
                        this.tvGoodsType.TabIndex = 0;
                        this.tvGoodsType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGoodsType_AfterSelect);
                        // 
                        // scQuery
                        // 
                        this.scQuery.BackColor = System.Drawing.Color.White;
                        this.scQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.scQuery.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.scQuery.Location = new System.Drawing.Point(0, 135);
                        this.scQuery.Margin = new System.Windows.Forms.Padding(4);
                        this.scQuery.Name = "scQuery";
                        // 
                        // scQuery.Panel1
                        // 
                        this.scQuery.Panel1.Controls.Add(this.tvGoodsType);
                        // 
                        // scQuery.Panel2
                        // 
                        this.scQuery.Panel2.Controls.Add(this.dgvList);
                        this.scQuery.Size = new System.Drawing.Size(1827, 537);
                        this.scQuery.SplitterDistance = 276;
                        this.scQuery.SplitterWidth = 5;
                        this.scQuery.TabIndex = 6;
                        // 
                        // toolStrip1
                        // 
                        this.toolStrip1.AutoSize = false;
                        this.toolStrip1.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnQuery,
            this.toolStripSeparator1,
            this.tsbtnStoreDistribute,
            this.toolStripSeparator2,
            this.tsbtnClose,
            this.toolStripSeparator3,
            this.tsbtnOutToExcel});
                        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
                        this.toolStrip1.Name = "toolStrip1";
                        this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.toolStrip1.Size = new System.Drawing.Size(1827, 65);
                        this.toolStrip1.TabIndex = 3;
                        this.toolStrip1.Text = "toolStrip1";
                        // 
                        // tsbtnQuery
                        // 
                        this.tsbtnQuery.Image = global::WinPSI.Properties.Resources.cx;
                        this.tsbtnQuery.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnQuery.Name = "tsbtnQuery";
                        this.tsbtnQuery.Size = new System.Drawing.Size(43, 56);
                        this.tsbtnQuery.Text = "查询";
                        this.tsbtnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnQuery.Click += new System.EventHandler(this.tsbtnQuery_Click);
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
                        // 
                        // tsbtnStoreDistribute
                        // 
                        this.tsbtnStoreDistribute.Image = global::WinPSI.Properties.Resources.scfb;
                        this.tsbtnStoreDistribute.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnStoreDistribute.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnStoreDistribute.Name = "tsbtnStoreDistribute";
                        this.tsbtnStoreDistribute.Size = new System.Drawing.Size(73, 56);
                        this.tsbtnStoreDistribute.Text = "库存分布";
                        this.tsbtnStoreDistribute.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnStoreDistribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnStoreDistribute.Click += new System.EventHandler(this.tsbtnStoreDistribute_Click);
                        // 
                        // toolStripSeparator2
                        // 
                        this.toolStripSeparator2.Name = "toolStripSeparator2";
                        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
                        // 
                        // tsbtnClose
                        // 
                        this.tsbtnClose.Image = global::WinPSI.Properties.Resources.close0;
                        this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnClose.Name = "tsbtnClose";
                        this.tsbtnClose.Size = new System.Drawing.Size(43, 56);
                        this.tsbtnClose.Text = "关闭";
                        this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
                        // 
                        // toolStripSeparator3
                        // 
                        this.toolStripSeparator3.Name = "toolStripSeparator3";
                        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 59);
                        // 
                        // tsbtnOutToExcel
                        // 
                        this.tsbtnOutToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                        this.tsbtnOutToExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOutToExcel.Image")));
                        this.tsbtnOutToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnOutToExcel.Name = "tsbtnOutToExcel";
                        this.tsbtnOutToExcel.Size = new System.Drawing.Size(73, 56);
                        this.tsbtnOutToExcel.Text = "导出数据";
                        this.tsbtnOutToExcel.Click += new System.EventHandler(this.tsbtnOutToExcel_Click);
                        // 
                        // FrmStoreStockQuery
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1827, 672);
                        this.Controls.Add(this.scQuery);
                        this.Controls.Add(panelWhere);
                        this.Controls.Add(this.toolStrip1);
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.Name = "FrmStoreStockQuery";
                        this.Text = "仓库库存查询";
                        this.Load += new System.EventHandler(this.FrmStoreStockQuery_Load);
                        panelWhere.ResumeLayout(false);
                        panelWhere.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
                        this.scQuery.Panel1.ResumeLayout(false);
                        this.scQuery.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.scQuery)).EndInit();
                        this.scQuery.ResumeLayout(false);
                        this.toolStrip1.ResumeLayout(false);
                        this.toolStrip1.PerformLayout();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TreeView tvGoodsType;
        private System.Windows.Forms.SplitContainer scQuery;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsbtnStoreDistribute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnOutToExcel;
        private System.Windows.Forms.PictureBox storeList;
        private System.Windows.Forms.TextBox txtInStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
    }
}