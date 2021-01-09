namespace WinPSI.Stock
{
    partial class FrmGoodsStockChangeList
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoodsStockChangeList));
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnOutToExcel = new System.Windows.Forms.ToolStripButton();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.lblStoreName = new System.Windows.Forms.Label();
                        this.lblStoreDesp = new System.Windows.Forms.Label();
                        this.lblGoodsName = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.dgvList = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.SheetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.ShTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.InCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.OutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CurCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CheckState = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.DealPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.tsList.SuspendLayout();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // tsList
                        // 
                        this.tsList.AutoSize = false;
                        this.tsList.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.tsList.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbtnClose,
            this.toolStripSeparator2,
            this.tsbtnOutToExcel});
                        this.tsList.Location = new System.Drawing.Point(0, 0);
                        this.tsList.Name = "tsList";
                        this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.tsList.Size = new System.Drawing.Size(1827, 58);
                        this.tsList.TabIndex = 5;
                        this.tsList.Text = "toolStrip1";
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
                        // 
                        // tsbtnClose
                        // 
                        this.tsbtnClose.Image = global::WinPSI.Properties.Resources.close0;
                        this.tsbtnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnClose.Name = "tsbtnClose";
                        this.tsbtnClose.Size = new System.Drawing.Size(43, 49);
                        this.tsbtnClose.Text = "关闭";
                        this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
                        // 
                        // toolStripSeparator2
                        // 
                        this.toolStripSeparator2.Name = "toolStripSeparator2";
                        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
                        // 
                        // tsbtnOutToExcel
                        // 
                        this.tsbtnOutToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                        this.tsbtnOutToExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOutToExcel.Image")));
                        this.tsbtnOutToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnOutToExcel.Name = "tsbtnOutToExcel";
                        this.tsbtnOutToExcel.Size = new System.Drawing.Size(73, 49);
                        this.tsbtnOutToExcel.Text = "导出数据";
                        this.tsbtnOutToExcel.Click += new System.EventHandler(this.tsbtnOutToExcel_Click);
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.lblStoreName);
                        this.panel1.Controls.Add(this.lblStoreDesp);
                        this.panel1.Controls.Add(this.lblGoodsName);
                        this.panel1.Controls.Add(this.label3);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 58);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1827, 51);
                        this.panel1.TabIndex = 6;
                        // 
                        // lblStoreName
                        // 
                        this.lblStoreName.AutoSize = true;
                        this.lblStoreName.Location = new System.Drawing.Point(424, 22);
                        this.lblStoreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblStoreName.Name = "lblStoreName";
                        this.lblStoreName.Size = new System.Drawing.Size(0, 15);
                        this.lblStoreName.TabIndex = 7;
                        // 
                        // lblStoreDesp
                        // 
                        this.lblStoreDesp.AutoSize = true;
                        this.lblStoreDesp.Location = new System.Drawing.Point(353, 22);
                        this.lblStoreDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblStoreDesp.Name = "lblStoreDesp";
                        this.lblStoreDesp.Size = new System.Drawing.Size(45, 15);
                        this.lblStoreDesp.TabIndex = 6;
                        this.lblStoreDesp.Text = "仓库:";
                        // 
                        // lblGoodsName
                        // 
                        this.lblGoodsName.AutoSize = true;
                        this.lblGoodsName.Location = new System.Drawing.Point(183, 22);
                        this.lblGoodsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblGoodsName.Name = "lblGoodsName";
                        this.lblGoodsName.Size = new System.Drawing.Size(0, 15);
                        this.lblGoodsName.TabIndex = 5;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(128, 22);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(45, 15);
                        this.label3.TabIndex = 4;
                        this.label3.Text = "商品:";
                        // 
                        // dgvList
                        // 
                        this.dgvList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SheetNo,
            this.ShTypeName,
            this.CreateTime,
            this.CheckTime,
            this.StoreName,
            this.GoodsNo,
            this.GoodsName,
            this.GUnit,
            this.InCount,
            this.OutCount,
            this.Price,
            this.Amount,
            this.CurCount,
            this.CheckState,
            this.StPrice,
            this.StAmount,
            this.DealPerson});
                        this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvList.Location = new System.Drawing.Point(0, 109);
                        this.dgvList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.dgvList.Name = "dgvList";
                        this.dgvList.RowTemplate.Height = 23;
                        this.dgvList.Size = new System.Drawing.Size(1827, 592);
                        this.dgvList.TabIndex = 7;
                        // 
                        // Id
                        // 
                        this.Id.DataPropertyName = "Id";
                        this.Id.Frozen = true;
                        this.Id.HeaderText = "编号";
                        this.Id.Name = "Id";
                        this.Id.ReadOnly = true;
                        // 
                        // SheetNo
                        // 
                        this.SheetNo.DataPropertyName = "SheetNo";
                        this.SheetNo.Frozen = true;
                        this.SheetNo.HeaderText = "单据编号";
                        this.SheetNo.Name = "SheetNo";
                        this.SheetNo.ReadOnly = true;
                        // 
                        // ShTypeName
                        // 
                        this.ShTypeName.DataPropertyName = "ShTypeName";
                        this.ShTypeName.Frozen = true;
                        this.ShTypeName.HeaderText = "单据类型";
                        this.ShTypeName.Name = "ShTypeName";
                        this.ShTypeName.ReadOnly = true;
                        // 
                        // CreateTime
                        // 
                        this.CreateTime.DataPropertyName = "CreateTime";
                        this.CreateTime.HeaderText = "单据日期";
                        this.CreateTime.Name = "CreateTime";
                        this.CreateTime.ReadOnly = true;
                        // 
                        // CheckTime
                        // 
                        this.CheckTime.DataPropertyName = "CheckTime";
                        this.CheckTime.HeaderText = "审核日期";
                        this.CheckTime.Name = "CheckTime";
                        this.CheckTime.ReadOnly = true;
                        // 
                        // StoreName
                        // 
                        this.StoreName.DataPropertyName = "StoreName";
                        this.StoreName.HeaderText = "仓库";
                        this.StoreName.Name = "StoreName";
                        this.StoreName.ReadOnly = true;
                        // 
                        // GoodsNo
                        // 
                        this.GoodsNo.DataPropertyName = "GoodsNo";
                        this.GoodsNo.HeaderText = "商品编号";
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
                        this.GUnit.HeaderText = "单位";
                        this.GUnit.Name = "GUnit";
                        this.GUnit.ReadOnly = true;
                        // 
                        // InCount
                        // 
                        this.InCount.DataPropertyName = "InCount";
                        this.InCount.HeaderText = "入库数量";
                        this.InCount.Name = "InCount";
                        this.InCount.ReadOnly = true;
                        // 
                        // OutCount
                        // 
                        this.OutCount.DataPropertyName = "OutCount";
                        this.OutCount.HeaderText = "出库数量";
                        this.OutCount.Name = "OutCount";
                        this.OutCount.ReadOnly = true;
                        // 
                        // Price
                        // 
                        this.Price.DataPropertyName = "Price";
                        this.Price.HeaderText = "单价";
                        this.Price.Name = "Price";
                        this.Price.ReadOnly = true;
                        // 
                        // Amount
                        // 
                        this.Amount.DataPropertyName = "Amount";
                        this.Amount.HeaderText = "金额";
                        this.Amount.Name = "Amount";
                        this.Amount.ReadOnly = true;
                        // 
                        // CurCount
                        // 
                        this.CurCount.DataPropertyName = "CurCount";
                        this.CurCount.HeaderText = "库存余量";
                        this.CurCount.Name = "CurCount";
                        // 
                        // CheckState
                        // 
                        this.CheckState.DataPropertyName = "CheckState";
                        this.CheckState.HeaderText = "审核状态";
                        this.CheckState.Name = "CheckState";
                        this.CheckState.ReadOnly = true;
                        // 
                        // StPrice
                        // 
                        this.StPrice.DataPropertyName = "StPrice";
                        this.StPrice.HeaderText = "成本价";
                        this.StPrice.Name = "StPrice";
                        this.StPrice.ReadOnly = true;
                        // 
                        // StAmount
                        // 
                        this.StAmount.DataPropertyName = "StAmount";
                        this.StAmount.HeaderText = "成本金额";
                        this.StAmount.Name = "StAmount";
                        this.StAmount.ReadOnly = true;
                        // 
                        // DealPerson
                        // 
                        this.DealPerson.DataPropertyName = "DealPerson";
                        this.DealPerson.HeaderText = "经手人";
                        this.DealPerson.Name = "DealPerson";
                        this.DealPerson.ReadOnly = true;
                        // 
                        // FrmGoodsStockChangeList
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1827, 701);
                        this.Controls.Add(this.dgvList);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.tsList);
                        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.Name = "FrmGoodsStockChangeList";
                        this.ShowIcon = false;
                        this.Text = "查看库存变动明细";
                        this.Load += new System.EventHandler(this.FrmGoodsStockChangeList_Load);
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnOutToExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreDesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn InCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckState;
        private System.Windows.Forms.DataGridViewTextBoxColumn StPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealPerson;
    }
}