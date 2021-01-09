namespace WinPSI.QM
{
    partial class FrmSheetQuery
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSheetQuery));
                        System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("采购入库单");
                        System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("销售出库单");
                        System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("期初入库单");
                        this.tsList = new System.Windows.Forms.ToolStrip();
                        this.tsbtnQuery = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsddbtnToExcel = new System.Windows.Forms.ToolStripDropDownButton();
                        this.tsmiQueryToExcel = new System.Windows.Forms.ToolStripMenuItem();
                        this.tsmiAllToExcel = new System.Windows.Forms.ToolStripMenuItem();
                        this.groupBox1 = new System.Windows.Forms.GroupBox();
                        this.storeList = new System.Windows.Forms.PictureBox();
                        this.customersList = new System.Windows.Forms.PictureBox();
                        this.cboChecked = new System.Windows.Forms.ComboBox();
                        this.label9 = new System.Windows.Forms.Label();
                        this.txtShNo = new System.Windows.Forms.TextBox();
                        this.label8 = new System.Windows.Forms.Label();
                        this.txtDealPerson = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.txtCreator = new System.Windows.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.txtCheckPerson = new System.Windows.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtStore = new System.Windows.Forms.TextBox();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtGoodsName = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.txtUnitName = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.scQuery = new System.Windows.Forms.SplitContainer();
                        this.tvSheetType = new System.Windows.Forms.TreeView();
                        this.ucPager1 = new WinPSI.UControls.ucPager();
                        this.dgvList = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CheckState = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.SheetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.ShTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.YHAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.DealPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CheckPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.label1 = new System.Windows.Forms.Label();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.tsList.SuspendLayout();
                        this.groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.scQuery)).BeginInit();
                        this.scQuery.Panel1.SuspendLayout();
                        this.scQuery.Panel2.SuspendLayout();
                        this.scQuery.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
                        this.panel1.SuspendLayout();
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
            this.tsddbtnToExcel});
                        this.tsList.Location = new System.Drawing.Point(0, 0);
                        this.tsList.Name = "tsList";
                        this.tsList.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.tsList.Size = new System.Drawing.Size(1827, 58);
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
                        // 
                        // toolStripSeparator2
                        // 
                        this.toolStripSeparator2.Name = "toolStripSeparator2";
                        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
                        // 
                        // tsddbtnToExcel
                        // 
                        this.tsddbtnToExcel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQueryToExcel,
            this.tsmiAllToExcel});
                        this.tsddbtnToExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtnToExcel.Image")));
                        this.tsddbtnToExcel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsddbtnToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsddbtnToExcel.Name = "tsddbtnToExcel";
                        this.tsddbtnToExcel.Size = new System.Drawing.Size(53, 49);
                        this.tsddbtnToExcel.Text = "导出";
                        this.tsddbtnToExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsddbtnToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        // 
                        // tsmiQueryToExcel
                        // 
                        this.tsmiQueryToExcel.Name = "tsmiQueryToExcel";
                        this.tsmiQueryToExcel.Size = new System.Drawing.Size(216, 26);
                        this.tsmiQueryToExcel.Text = "导出查询单据";
                        this.tsmiQueryToExcel.Click += new System.EventHandler(this.tsmiQueryToExcel_Click);
                        // 
                        // tsmiAllToExcel
                        // 
                        this.tsmiAllToExcel.Name = "tsmiAllToExcel";
                        this.tsmiAllToExcel.Size = new System.Drawing.Size(216, 26);
                        this.tsmiAllToExcel.Text = "导出所有单据";
                        this.tsmiAllToExcel.Click += new System.EventHandler(this.tsmiAllToExcel_Click);
                        // 
                        // groupBox1
                        // 
                        this.groupBox1.Controls.Add(this.storeList);
                        this.groupBox1.Controls.Add(this.customersList);
                        this.groupBox1.Controls.Add(this.cboChecked);
                        this.groupBox1.Controls.Add(this.label9);
                        this.groupBox1.Controls.Add(this.txtShNo);
                        this.groupBox1.Controls.Add(this.label8);
                        this.groupBox1.Controls.Add(this.txtDealPerson);
                        this.groupBox1.Controls.Add(this.label3);
                        this.groupBox1.Controls.Add(this.txtCreator);
                        this.groupBox1.Controls.Add(this.label6);
                        this.groupBox1.Controls.Add(this.txtCheckPerson);
                        this.groupBox1.Controls.Add(this.label7);
                        this.groupBox1.Controls.Add(this.txtStore);
                        this.groupBox1.Controls.Add(this.label5);
                        this.groupBox1.Controls.Add(this.txtGoodsName);
                        this.groupBox1.Controls.Add(this.label4);
                        this.groupBox1.Controls.Add(this.txtUnitName);
                        this.groupBox1.Controls.Add(this.label2);
                        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        this.groupBox1.Location = new System.Drawing.Point(0, 127);
                        this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
                        this.groupBox1.Name = "groupBox1";
                        this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
                        this.groupBox1.Size = new System.Drawing.Size(1827, 126);
                        this.groupBox1.TabIndex = 5;
                        this.groupBox1.TabStop = false;
                        // 
                        // storeList
                        // 
                        this.storeList.Image = global::WinPSI.Properties.Resources.book;
                        this.storeList.Location = new System.Drawing.Point(1437, 44);
                        this.storeList.Margin = new System.Windows.Forms.Padding(4);
                        this.storeList.Name = "storeList";
                        this.storeList.Size = new System.Drawing.Size(21, 19);
                        this.storeList.TabIndex = 19;
                        this.storeList.TabStop = false;
                        this.storeList.Click += new System.EventHandler(this.storeList_Click);
                        // 
                        // customersList
                        // 
                        this.customersList.Image = global::WinPSI.Properties.Resources.kh;
                        this.customersList.Location = new System.Drawing.Point(363, 40);
                        this.customersList.Margin = new System.Windows.Forms.Padding(4);
                        this.customersList.Name = "customersList";
                        this.customersList.Size = new System.Drawing.Size(19, 20);
                        this.customersList.TabIndex = 18;
                        this.customersList.TabStop = false;
                        this.customersList.Click += new System.EventHandler(this.customersList_Click);
                        // 
                        // cboChecked
                        // 
                        this.cboChecked.FormattingEnabled = true;
                        this.cboChecked.Location = new System.Drawing.Point(1220, 88);
                        this.cboChecked.Margin = new System.Windows.Forms.Padding(4);
                        this.cboChecked.Name = "cboChecked";
                        this.cboChecked.Size = new System.Drawing.Size(208, 23);
                        this.cboChecked.TabIndex = 17;
                        this.cboChecked.SelectedIndexChanged += new System.EventHandler(this.cboChecked_SelectedIndexChanged);
                        // 
                        // label9
                        // 
                        this.label9.AutoSize = true;
                        this.label9.Location = new System.Drawing.Point(1133, 91);
                        this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(75, 15);
                        this.label9.TabIndex = 16;
                        this.label9.Text = "审核状态:";
                        // 
                        // txtShNo
                        // 
                        this.txtShNo.Location = new System.Drawing.Point(520, 40);
                        this.txtShNo.Margin = new System.Windows.Forms.Padding(4);
                        this.txtShNo.Name = "txtShNo";
                        this.txtShNo.Size = new System.Drawing.Size(208, 25);
                        this.txtShNo.TabIndex = 15;
                        // 
                        // label8
                        // 
                        this.label8.AutoSize = true;
                        this.label8.Location = new System.Drawing.Point(433, 44);
                        this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(75, 15);
                        this.label8.TabIndex = 14;
                        this.label8.Text = "单据编号:";
                        // 
                        // txtDealPerson
                        // 
                        this.txtDealPerson.Location = new System.Drawing.Point(860, 86);
                        this.txtDealPerson.Margin = new System.Windows.Forms.Padding(4);
                        this.txtDealPerson.Name = "txtDealPerson";
                        this.txtDealPerson.Size = new System.Drawing.Size(208, 25);
                        this.txtDealPerson.TabIndex = 13;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(773, 91);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(60, 15);
                        this.label3.TabIndex = 12;
                        this.label3.Text = "经手人:";
                        // 
                        // txtCreator
                        // 
                        this.txtCreator.Location = new System.Drawing.Point(520, 86);
                        this.txtCreator.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCreator.Name = "txtCreator";
                        this.txtCreator.Size = new System.Drawing.Size(208, 25);
                        this.txtCreator.TabIndex = 11;
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(449, 91);
                        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(60, 15);
                        this.label6.TabIndex = 10;
                        this.label6.Text = "制单人:";
                        // 
                        // txtCheckPerson
                        // 
                        this.txtCheckPerson.Location = new System.Drawing.Point(145, 86);
                        this.txtCheckPerson.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCheckPerson.Name = "txtCheckPerson";
                        this.txtCheckPerson.Size = new System.Drawing.Size(208, 25);
                        this.txtCheckPerson.TabIndex = 9;
                        // 
                        // label7
                        // 
                        this.label7.AutoSize = true;
                        this.label7.Location = new System.Drawing.Point(75, 90);
                        this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(60, 15);
                        this.label7.TabIndex = 8;
                        this.label7.Text = "审核人:";
                        // 
                        // txtStore
                        // 
                        this.txtStore.BackColor = System.Drawing.Color.White;
                        this.txtStore.Location = new System.Drawing.Point(1220, 40);
                        this.txtStore.Margin = new System.Windows.Forms.Padding(4);
                        this.txtStore.Name = "txtStore";
                        this.txtStore.Size = new System.Drawing.Size(208, 25);
                        this.txtStore.TabIndex = 7;
                        this.txtStore.TextChanged += new System.EventHandler(this.txtStore_TextChanged);
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(1129, 44);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(75, 15);
                        this.label5.TabIndex = 6;
                        this.label5.Text = "仓库名称:";
                        // 
                        // txtGoodsName
                        // 
                        this.txtGoodsName.Location = new System.Drawing.Point(860, 36);
                        this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtGoodsName.Name = "txtGoodsName";
                        this.txtGoodsName.Size = new System.Drawing.Size(208, 25);
                        this.txtGoodsName.TabIndex = 5;
                        this.txtGoodsName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsName_KeyPress);
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(773, 44);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(75, 15);
                        this.label4.TabIndex = 4;
                        this.label4.Text = "商品名称:";
                        // 
                        // txtUnitName
                        // 
                        this.txtUnitName.BackColor = System.Drawing.Color.White;
                        this.txtUnitName.Location = new System.Drawing.Point(145, 36);
                        this.txtUnitName.Margin = new System.Windows.Forms.Padding(4);
                        this.txtUnitName.Name = "txtUnitName";
                        this.txtUnitName.Size = new System.Drawing.Size(208, 25);
                        this.txtUnitName.TabIndex = 1;
                        this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(59, 40);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(75, 15);
                        this.label2.TabIndex = 0;
                        this.label2.Text = "单位名称:";
                        // 
                        // scQuery
                        // 
                        this.scQuery.BackColor = System.Drawing.Color.White;
                        this.scQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.scQuery.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.scQuery.Location = new System.Drawing.Point(0, 253);
                        this.scQuery.Margin = new System.Windows.Forms.Padding(4);
                        this.scQuery.Name = "scQuery";
                        // 
                        // scQuery.Panel1
                        // 
                        this.scQuery.Panel1.Controls.Add(this.tvSheetType);
                        // 
                        // scQuery.Panel2
                        // 
                        this.scQuery.Panel2.AutoScroll = true;
                        this.scQuery.Panel2.Controls.Add(this.ucPager1);
                        this.scQuery.Panel2.Controls.Add(this.dgvList);
                        this.scQuery.Size = new System.Drawing.Size(1827, 459);
                        this.scQuery.SplitterDistance = 178;
                        this.scQuery.SplitterWidth = 5;
                        this.scQuery.TabIndex = 6;
                        // 
                        // tvSheetType
                        // 
                        this.tvSheetType.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvSheetType.HideSelection = false;
                        this.tvSheetType.ItemHeight = 25;
                        this.tvSheetType.Location = new System.Drawing.Point(0, 0);
                        this.tvSheetType.Margin = new System.Windows.Forms.Padding(4);
                        this.tvSheetType.Name = "tvSheetType";
                        treeNode1.Name = "1";
                        treeNode1.Text = "采购入库单";
                        treeNode2.Name = "2";
                        treeNode2.Text = "销售出库单";
                        treeNode3.Name = "3";
                        treeNode3.Text = "期初入库单";
                        this.tvSheetType.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
                        this.tvSheetType.Size = new System.Drawing.Size(176, 457);
                        this.tvSheetType.TabIndex = 0;
                        this.tvSheetType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSheetType_AfterSelect);
                        // 
                        // ucPager1
                        // 
                        this.ucPager1.CurrentPage = 1;
                        this.ucPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
                        this.ucPager1.Location = new System.Drawing.Point(0, 402);
                        this.ucPager1.Margin = new System.Windows.Forms.Padding(5);
                        this.ucPager1.Name = "ucPager1";
                        this.ucPager1.PageSize = 20;
                        this.ucPager1.Record = 0;
                        this.ucPager1.Size = new System.Drawing.Size(1642, 55);
                        this.ucPager1.StartRecord = 1;
                        this.ucPager1.TabIndex = 3;
                        this.ucPager1.BindSource += new WinPSI.UControls.ucPager.BindHandle(this.ucPager1_BindSource);
                        // 
                        // dgvList
                        // 
                        this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CheckState,
            this.SheetNo,
            this.ShTypeName,
            this.CreateTime,
            this.UnitName,
            this.YHAmount,
            this.DealPerson,
            this.Creator,
            this.CheckPerson,
            this.CheckTime});
                        this.dgvList.Dock = System.Windows.Forms.DockStyle.Top;
                        this.dgvList.Location = new System.Drawing.Point(0, 0);
                        this.dgvList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvList.Name = "dgvList";
                        this.dgvList.RowTemplate.Height = 23;
                        this.dgvList.Size = new System.Drawing.Size(1642, 391);
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
                        // CheckState
                        // 
                        this.CheckState.DataPropertyName = "CheckState";
                        this.CheckState.HeaderText = "审核状态";
                        this.CheckState.Name = "CheckState";
                        this.CheckState.ReadOnly = true;
                        // 
                        // SheetNo
                        // 
                        this.SheetNo.DataPropertyName = "SheetNo";
                        this.SheetNo.HeaderText = "单据编号";
                        this.SheetNo.Name = "SheetNo";
                        this.SheetNo.ReadOnly = true;
                        // 
                        // ShTypeName
                        // 
                        this.ShTypeName.DataPropertyName = "ShTypeName";
                        this.ShTypeName.HeaderText = "单据类型";
                        this.ShTypeName.Name = "ShTypeName";
                        this.ShTypeName.ReadOnly = true;
                        // 
                        // CreateTime
                        // 
                        this.CreateTime.DataPropertyName = "CreateTime";
                        this.CreateTime.HeaderText = "制单日期";
                        this.CreateTime.Name = "CreateTime";
                        this.CreateTime.ReadOnly = true;
                        // 
                        // UnitName
                        // 
                        this.UnitName.DataPropertyName = "UnitName";
                        this.UnitName.HeaderText = "供应商/客户名称";
                        this.UnitName.Name = "UnitName";
                        this.UnitName.ReadOnly = true;
                        // 
                        // YHAmount
                        // 
                        this.YHAmount.DataPropertyName = "YHAmount";
                        this.YHAmount.HeaderText = "应付金额";
                        this.YHAmount.Name = "YHAmount";
                        this.YHAmount.ReadOnly = true;
                        // 
                        // DealPerson
                        // 
                        this.DealPerson.DataPropertyName = "DealPerson";
                        this.DealPerson.HeaderText = "经手人";
                        this.DealPerson.Name = "DealPerson";
                        this.DealPerson.ReadOnly = true;
                        // 
                        // Creator
                        // 
                        this.Creator.DataPropertyName = "Creator";
                        this.Creator.HeaderText = "制单人";
                        this.Creator.Name = "Creator";
                        this.Creator.ReadOnly = true;
                        // 
                        // CheckPerson
                        // 
                        this.CheckPerson.DataPropertyName = "CheckPerson";
                        this.CheckPerson.HeaderText = "审核人";
                        this.CheckPerson.Name = "CheckPerson";
                        this.CheckPerson.ReadOnly = true;
                        // 
                        // CheckTime
                        // 
                        this.CheckTime.DataPropertyName = "CheckTime";
                        this.CheckTime.HeaderText = "审核日期";
                        this.CheckTime.Name = "CheckTime";
                        this.CheckTime.ReadOnly = true;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        this.label1.ForeColor = System.Drawing.Color.Green;
                        this.label1.Location = new System.Drawing.Point(16, 22);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(169, 37);
                        this.label1.TabIndex = 1;
                        this.label1.Text = "单据查询";
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.label1);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 58);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1827, 69);
                        this.panel1.TabIndex = 4;
                        // 
                        // FrmSheetQuery
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.AutoScroll = true;
                        this.AutoSize = true;
                        this.ClientSize = new System.Drawing.Size(1827, 712);
                        this.Controls.Add(this.scQuery);
                        this.Controls.Add(this.groupBox1);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.tsList);
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.Name = "FrmSheetQuery";
                        this.ShowIcon = false;
                        this.Text = "单据查询页面";
                        this.Load += new System.EventHandler(this.FrmSheetQuery_Load);
                        this.tsList.ResumeLayout(false);
                        this.tsList.PerformLayout();
                        this.groupBox1.ResumeLayout(false);
                        this.groupBox1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
                        this.scQuery.Panel1.ResumeLayout(false);
                        this.scQuery.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.scQuery)).EndInit();
                        this.scQuery.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripButton tsbtnQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDealPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheckPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboChecked;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer scQuery;
        private System.Windows.Forms.TreeView tvSheetType;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckState;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YHAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckTime;
        private System.Windows.Forms.PictureBox customersList;
        private System.Windows.Forms.PictureBox storeList;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnToExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmiQueryToExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllToExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private UControls.ucPager ucPager1;
    }
}