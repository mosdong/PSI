namespace WinPSI.Perchase
{
    partial class FrmPerchaseQueryByGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerchaseQueryByGoods));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.suppliersList = new System.Windows.Forms.PictureBox();
            this.storeList = new System.Windows.Forms.PictureBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtDealPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scQuery = new System.Windows.Forms.SplitContainer();
            this.tvGoodsType = new System.Windows.Forms.TreeView();
            this.dgvGoodsList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsList = new System.Windows.Forms.ToolStrip();
            this.tsbtnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOutToExcel = new System.Windows.Forms.ToolStripButton();
            this.ucPager1 = new WinPSI.UControls.ucPager();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scQuery)).BeginInit();
            this.scQuery.Panel1.SuspendLayout();
            this.scQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
            this.tsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1737, 69);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "采购查询(按商品)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.suppliersList);
            this.groupBox1.Controls.Add(this.storeList);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.txtDealPerson);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGoodsName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSupplyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1737, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // suppliersList
            // 
            this.suppliersList.Image = global::WinPSI.Properties.Resources.kh;
            this.suppliersList.Location = new System.Drawing.Point(347, 35);
            this.suppliersList.Margin = new System.Windows.Forms.Padding(4);
            this.suppliersList.Name = "suppliersList";
            this.suppliersList.Size = new System.Drawing.Size(19, 20);
            this.suppliersList.TabIndex = 15;
            this.suppliersList.TabStop = false;
            this.suppliersList.Click += new System.EventHandler(this.suppliersList_Click);
            // 
            // storeList
            // 
            this.storeList.Image = global::WinPSI.Properties.Resources.book;
            this.storeList.Location = new System.Drawing.Point(741, 35);
            this.storeList.Margin = new System.Windows.Forms.Padding(4);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(21, 19);
            this.storeList.TabIndex = 14;
            this.storeList.TabStop = false;
            this.storeList.Click += new System.EventHandler(this.storeList_Click);
            // 
            // txtStore
            // 
            this.txtStore.BackColor = System.Drawing.Color.White;
            this.txtStore.Location = new System.Drawing.Point(524, 31);
            this.txtStore.Margin = new System.Windows.Forms.Padding(4);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(208, 25);
            this.txtStore.TabIndex = 13;
            this.txtStore.TextChanged += new System.EventHandler(this.txtStore_TextChanged);
            // 
            // txtDealPerson
            // 
            this.txtDealPerson.Location = new System.Drawing.Point(1247, 31);
            this.txtDealPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtDealPerson.Name = "txtDealPerson";
            this.txtDealPerson.Size = new System.Drawing.Size(208, 25);
            this.txtDealPerson.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1176, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "经手人:";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(891, 31);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(208, 25);
            this.txtGoodsName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "商品名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "仓    库:";
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Location = new System.Drawing.Point(129, 31);
            this.txtSupplyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(208, 25);
            this.txtSupplyName.TabIndex = 1;
            this.txtSupplyName.TextChanged += new System.EventHandler(this.txtSupplyName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "供应商:";
            // 
            // scQuery
            // 
            this.scQuery.BackColor = System.Drawing.Color.White;
            this.scQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scQuery.Location = new System.Drawing.Point(0, 215);
            this.scQuery.Margin = new System.Windows.Forms.Padding(4);
            this.scQuery.Name = "scQuery";
            // 
            // scQuery.Panel1
            // 
            this.scQuery.Panel1.Controls.Add(this.tvGoodsType);
            this.scQuery.Size = new System.Drawing.Size(1737, 503);
            this.scQuery.SplitterDistance = 301;
            this.scQuery.SplitterWidth = 5;
            this.scQuery.TabIndex = 4;
            // 
            // tvGoodsType
            // 
            this.tvGoodsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGoodsType.Location = new System.Drawing.Point(0, 0);
            this.tvGoodsType.Margin = new System.Windows.Forms.Padding(4);
            this.tvGoodsType.Name = "tvGoodsType";
            this.tvGoodsType.Size = new System.Drawing.Size(299, 501);
            this.tvGoodsType.TabIndex = 0;
            this.tvGoodsType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGoodsType_AfterSelect);
            // 
            // dgvGoodsList
            // 
            this.dgvGoodsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoodsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GoodsName,
            this.GoodsNo,
            this.GUnit,
            this.TotalCount,
            this.AvgPrice,
            this.TotalAmount});
            this.dgvGoodsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvGoodsList.Location = new System.Drawing.Point(0, 0);
            this.dgvGoodsList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGoodsList.Name = "dgvGoodsList";
            this.dgvGoodsList.RowHeadersWidth = 51;
            this.dgvGoodsList.RowTemplate.Height = 23;
            this.dgvGoodsList.Size = new System.Drawing.Size(1429, 439);
            this.dgvGoodsList.TabIndex = 0;
            this.dgvGoodsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsList_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "商品名称";
            this.GoodsName.MinimumWidth = 6;
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // GoodsNo
            // 
            this.GoodsNo.DataPropertyName = "GoodsNo";
            this.GoodsNo.HeaderText = "商品编码";
            this.GoodsNo.MinimumWidth = 6;
            this.GoodsNo.Name = "GoodsNo";
            this.GoodsNo.ReadOnly = true;
            // 
            // GUnit
            // 
            this.GUnit.DataPropertyName = "GUnit";
            this.GUnit.HeaderText = "单位";
            this.GUnit.MinimumWidth = 6;
            this.GUnit.Name = "GUnit";
            this.GUnit.ReadOnly = true;
            // 
            // TotalCount
            // 
            this.TotalCount.DataPropertyName = "TotalCount";
            this.TotalCount.HeaderText = "采购数量";
            this.TotalCount.MinimumWidth = 6;
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.ReadOnly = true;
            // 
            // AvgPrice
            // 
            this.AvgPrice.DataPropertyName = "AvgPrice";
            this.AvgPrice.HeaderText = "采购价格";
            this.AvgPrice.MinimumWidth = 6;
            this.AvgPrice.Name = "AvgPrice";
            this.AvgPrice.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "采购金额";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // tsList
            // 
            this.tsList.AutoSize = false;
            this.tsList.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
            this.tsList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnQuery,
            this.toolStripSeparator1,
            this.tsbtnClose,
            this.toolStripSeparator2,
            this.tsbtnOutToExcel});
            this.tsList.Location = new System.Drawing.Point(0, 0);
            this.tsList.Name = "tsList";
            this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
            this.tsList.Size = new System.Drawing.Size(1737, 58);
            this.tsList.TabIndex = 1;
            this.tsList.Text = "toolStrip1";
            // 
            // tsbtnQuery
            // 
            this.tsbtnQuery.Image = global::WinPSI.Properties.Resources.cx;
            this.tsbtnQuery.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuery.Name = "tsbtnQuery";
            this.tsbtnQuery.Size = new System.Drawing.Size(43, 49);
            this.tsbtnQuery.Text = "查询";
            this.tsbtnQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnQuery.Click += new System.EventHandler(this.tsbtnQuery_Click);
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
            // FrmPerchaseQueryByGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 718);
            this.Controls.Add(this.scQuery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPerchaseQueryByGoods";
            this.ShowIcon = false;
            this.Text = "采购查询页面--按商品";
            this.Load += new System.EventHandler(this.FrmPerchaseQueryByGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeList)).EndInit();
            this.scQuery.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scQuery)).EndInit();
            this.scQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
            this.tsList.ResumeLayout(false);
            this.tsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripButton tsbtnQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnOutToExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDealPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer scQuery;
        private System.Windows.Forms.TreeView tvGoodsType;
        private UControls.ucPager ucPager1;
        private System.Windows.Forms.DataGridView dgvGoodsList;
        private System.Windows.Forms.PictureBox storeList;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.PictureBox suppliersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}