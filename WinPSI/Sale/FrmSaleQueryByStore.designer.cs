namespace WinPSI.Sale
{
        partial class FrmSaleQueryByStore
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleQueryByStore));
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.tsbtnQuery = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnOutToExcel = new System.Windows.Forms.ToolStripButton();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.label1 = new System.Windows.Forms.Label();
                        this.groupBox1 = new System.Windows.Forms.GroupBox();
                        this.storeList = new System.Windows.Forms.PictureBox();
                        this.txtStore = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.suppliersList = new System.Windows.Forms.PictureBox();
                        this.txtCustomerName = new System.Windows.Forms.TextBox();
                        this.txtDealPerson = new System.Windows.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtGoodsName = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.label2 = new System.Windows.Forms.Label();
                        this.panel2 = new System.Windows.Forms.Panel();
                        this.dgvSaleList = new System.Windows.Forms.DataGridView();
                        this.ucPager1 = new WinPSI.UControls.ucPager();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.TotalStAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.tsList.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.suppliersList)).BeginInit();
                        this.panel2.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).BeginInit();
                        this.SuspendLayout();
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
                        this.tsList.Size = new System.Drawing.Size(1577, 58);
                        this.tsList.TabIndex = 3;
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
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.label1);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 58);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1577, 69);
                        this.panel1.TabIndex = 4;
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
                        this.label1.Text = "销售查询(按仓库)";
                        // 
                        // groupBox1
                        // 
                        this.groupBox1.Controls.Add(this.storeList);
                        this.groupBox1.Controls.Add(this.txtStore);
                        this.groupBox1.Controls.Add(this.label3);
                        this.groupBox1.Controls.Add(this.suppliersList);
                        this.groupBox1.Controls.Add(this.txtCustomerName);
                        this.groupBox1.Controls.Add(this.txtDealPerson);
                        this.groupBox1.Controls.Add(this.label5);
                        this.groupBox1.Controls.Add(this.txtGoodsName);
                        this.groupBox1.Controls.Add(this.label4);
                        this.groupBox1.Controls.Add(this.label2);
                        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.groupBox1.Location = new System.Drawing.Point(0, 127);
                        this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
                        this.groupBox1.Name = "groupBox1";
                        this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
                        this.groupBox1.Size = new System.Drawing.Size(1577, 79);
                        this.groupBox1.TabIndex = 5;
                        this.groupBox1.TabStop = false;
                        // 
                        // storeList
                        // 
                        this.storeList.Image = global::WinPSI.Properties.Resources.book;
                        this.storeList.Location = new System.Drawing.Point(666, 37);
                        this.storeList.Margin = new System.Windows.Forms.Padding(4);
                        this.storeList.Name = "storeList";
                        this.storeList.Size = new System.Drawing.Size(21, 19);
                        this.storeList.TabIndex = 18;
                        this.storeList.TabStop = false;
                        this.storeList.Click += new System.EventHandler(this.storeList_Click);
                        // 
                        // txtStore
                        // 
                        this.txtStore.BackColor = System.Drawing.Color.White;
                        this.txtStore.Location = new System.Drawing.Point(449, 33);
                        this.txtStore.Margin = new System.Windows.Forms.Padding(4);
                        this.txtStore.Name = "txtStore";
                        this.txtStore.Size = new System.Drawing.Size(208, 25);
                        this.txtStore.TabIndex = 17;
                        this.txtStore.TextChanged += new System.EventHandler(this.txtStore_TextChanged);
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(362, 37);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(77, 15);
                        this.label3.TabIndex = 16;
                        this.label3.Text = "仓    库:";
                        // 
                        // suppliersList
                        // 
                        this.suppliersList.Image = global::WinPSI.Properties.Resources.kh;
                        this.suppliersList.Location = new System.Drawing.Point(305, 38);
                        this.suppliersList.Margin = new System.Windows.Forms.Padding(4);
                        this.suppliersList.Name = "suppliersList";
                        this.suppliersList.Size = new System.Drawing.Size(19, 20);
                        this.suppliersList.TabIndex = 14;
                        this.suppliersList.TabStop = false;
                        this.suppliersList.Click += new System.EventHandler(this.suppliersList_Click);
                        // 
                        // txtCustomerName
                        // 
                        this.txtCustomerName.Location = new System.Drawing.Point(88, 31);
                        this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCustomerName.Name = "txtCustomerName";
                        this.txtCustomerName.Size = new System.Drawing.Size(208, 25);
                        this.txtCustomerName.TabIndex = 13;
                        this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
                        // 
                        // txtDealPerson
                        // 
                        this.txtDealPerson.Location = new System.Drawing.Point(1150, 35);
                        this.txtDealPerson.Margin = new System.Windows.Forms.Padding(4);
                        this.txtDealPerson.Name = "txtDealPerson";
                        this.txtDealPerson.Size = new System.Drawing.Size(208, 25);
                        this.txtDealPerson.TabIndex = 7;
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(1059, 39);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(60, 15);
                        this.label5.TabIndex = 6;
                        this.label5.Text = "经手人:";
                        // 
                        // txtGoodsName
                        // 
                        this.txtGoodsName.Location = new System.Drawing.Point(810, 36);
                        this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGoodsName.Name = "txtGoodsName";
                        this.txtGoodsName.Size = new System.Drawing.Size(208, 25);
                        this.txtGoodsName.TabIndex = 5;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(718, 39);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(75, 15);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "商品名称:";
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(33, 38);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(45, 15);
                        this.label2.TabIndex = 0;
                        this.label2.Text = "客户:";
                        // 
                        // panel2
                        // 
                        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.panel2.Controls.Add(this.dgvSaleList);
                        this.panel2.Controls.Add(this.ucPager1);
                        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel2.Location = new System.Drawing.Point(0, 206);
                        this.panel2.Margin = new System.Windows.Forms.Padding(4);
                        this.panel2.Name = "panel2";
                        this.panel2.Size = new System.Drawing.Size(1577, 528);
                        this.panel2.TabIndex = 7;
                        // 
                        // dgvSaleList
                        // 
                        this.dgvSaleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvSaleList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvSaleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StoreId,
            this.StoreName,
            this.TotalCount,
            this.TotalAmount,
            this.TotalStAmount});
                        this.dgvSaleList.Dock = System.Windows.Forms.DockStyle.Top;
                        this.dgvSaleList.Location = new System.Drawing.Point(0, 0);
                        this.dgvSaleList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvSaleList.Name = "dgvSaleList";
                        this.dgvSaleList.RowTemplate.Height = 23;
                        this.dgvSaleList.Size = new System.Drawing.Size(1575, 462);
                        this.dgvSaleList.TabIndex = 7;
                        this.dgvSaleList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleList_CellDoubleClick);
                        // 
                        // ucPager1
                        // 
                        this.ucPager1.CurrentPage = 1;
                        this.ucPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.ucPager1.Location = new System.Drawing.Point(0, 462);
                        this.ucPager1.Margin = new System.Windows.Forms.Padding(5);
                        this.ucPager1.Name = "ucPager1";
                        this.ucPager1.PageSize = 20;
                        this.ucPager1.Record = 0;
                        this.ucPager1.Size = new System.Drawing.Size(1575, 64);
                        this.ucPager1.StartRecord = 1;
                        this.ucPager1.TabIndex = 2;
                        this.ucPager1.BindSource += new WinPSI.UControls.ucPager.BindHandle(this.ucPager1_BindSource);
                        // 
                        // Id
                        // 
                        this.Id.DataPropertyName = "Id";
                        this.Id.HeaderText = "编号";
                        this.Id.Name = "Id";
                        this.Id.ReadOnly = true;
                        // 
                        // StoreId
                        // 
                        this.StoreId.DataPropertyName = "StoreId";
                        this.StoreId.HeaderText = "仓库编号";
                        this.StoreId.Name = "StoreId";
                        this.StoreId.ReadOnly = true;
                        // 
                        // StoreName
                        // 
                        this.StoreName.DataPropertyName = "StoreName";
                        this.StoreName.HeaderText = "仓库名称";
                        this.StoreName.Name = "StoreName";
                        this.StoreName.ReadOnly = true;
                        // 
                        // TotalCount
                        // 
                        this.TotalCount.DataPropertyName = "TotalCount";
                        this.TotalCount.HeaderText = "销售数量";
                        this.TotalCount.Name = "TotalCount";
                        this.TotalCount.ReadOnly = true;
                        // 
                        // TotalAmount
                        // 
                        this.TotalAmount.DataPropertyName = "TotalAmount";
                        this.TotalAmount.HeaderText = "销售金额";
                        this.TotalAmount.Name = "TotalAmount";
                        this.TotalAmount.ReadOnly = true;
                        // 
                        // TotalStAmount
                        // 
                        this.TotalStAmount.DataPropertyName = "TotalStAmount";
                        this.TotalStAmount.HeaderText = "成本金额";
                        this.TotalStAmount.Name = "TotalStAmount";
                        this.TotalStAmount.ReadOnly = true;
                        // 
                        // FrmSaleQueryByStore
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1577, 734);
                        this.Controls.Add(this.panel2);
                        this.Controls.Add(this.groupBox1);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.tsList);
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.Name = "FrmSaleQueryByStore";
                        this.ShowIcon = false;
                        this.Text = "销售查询页面--按仓库";
                        this.Load += new System.EventHandler(this.FrmSaleQueryByStore_Load);
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        this.groupBox1.ResumeLayout(false);
                        this.groupBox1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.suppliersList)).EndInit();
                        this.panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvSaleList)).EndInit();
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
                private System.Windows.Forms.Label label2;
                private System.Windows.Forms.Panel panel2;
                private UControls.ucPager ucPager1;
                private System.Windows.Forms.PictureBox suppliersList;
                private System.Windows.Forms.TextBox txtCustomerName;
                private System.Windows.Forms.DataGridView dgvSaleList;
                private System.Windows.Forms.PictureBox storeList;
                private System.Windows.Forms.TextBox txtStore;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.DataGridViewTextBoxColumn Id;
                private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
                private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
                private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
                private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
                private System.Windows.Forms.DataGridViewTextBoxColumn TotalStAmount;
        }
}