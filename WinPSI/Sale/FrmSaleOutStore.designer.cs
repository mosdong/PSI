namespace WinPSI.Sale
{
    partial class FrmSaleOutStore
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
                        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                        this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnCheck = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsddbtnAct = new System.Windows.Forms.ToolStripDropDownButton();
                        this.tsmiNoUse = new System.Windows.Forms.ToolStripMenuItem();
                        this.tsmiRedChecked = new System.Windows.Forms.ToolStripMenuItem();
                        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.lblUnOpenDesp = new System.Windows.Forms.Label();
                        this.label9 = new System.Windows.Forms.Label();
                        this.lblSaleNo = new System.Windows.Forms.Label();
                        this.lblCheckState = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.panel2 = new System.Windows.Forms.Panel();
                        this.picPayType = new System.Windows.Forms.PictureBox();
                        this.txtCollectType = new System.Windows.Forms.TextBox();
                        this.txtCreateTime = new System.Windows.Forms.TextBox();
                        this.label11 = new System.Windows.Forms.Label();
                        this.txtCreator = new System.Windows.Forms.TextBox();
                        this.label14 = new System.Windows.Forms.Label();
                        this.txtYHAmount = new System.Windows.Forms.TextBox();
                        this.label13 = new System.Windows.Forms.Label();
                        this.txtTotalAmount = new System.Windows.Forms.TextBox();
                        this.label10 = new System.Windows.Forms.Label();
                        this.panel3 = new System.Windows.Forms.Panel();
                        this.lblTotalAmount = new System.Windows.Forms.Label();
                        this.lblTotalCount = new System.Windows.Forms.Label();
                        this.lblTotalDesp = new System.Windows.Forms.Label();
                        this.btnDelete = new System.Windows.Forms.Button();
                        this.btnAddGoods = new System.Windows.Forms.Button();
                        this.dgvGoods = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsTXNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.label8 = new System.Windows.Forms.Label();
                        this.txtRemark = new System.Windows.Forms.TextBox();
                        this.label7 = new System.Windows.Forms.Label();
                        this.txtThisAmount = new System.Windows.Forms.TextBox();
                        this.label6 = new System.Windows.Forms.Label();
                        this.label5 = new System.Windows.Forms.Label();
                        this.txtDealPerson = new System.Windows.Forms.TextBox();
                        this.label4 = new System.Windows.Forms.Label();
                        this.storeList = new System.Windows.Forms.PictureBox();
                        this.txtOutStore = new System.Windows.Forms.TextBox();
                        this.label3 = new System.Windows.Forms.Label();
                        this.customersList = new System.Windows.Forms.PictureBox();
                        this.txtCustomers = new System.Windows.Forms.TextBox();
                        this.label2 = new System.Windows.Forms.Label();
                        this.toolStrip1.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.panel2.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.picPayType)).BeginInit();
                        this.panel3.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // toolStrip1
                        // 
                        this.toolStrip1.AutoSize = false;
                        this.toolStrip1.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnCheck,
            this.toolStripSeparator2,
            this.tsddbtnAct,
            this.toolStripSeparator3,
            this.tsbtnClose});
                        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
                        this.toolStrip1.Name = "toolStrip1";
                        this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 1, 2);
                        this.toolStrip1.Size = new System.Drawing.Size(1525, 52);
                        this.toolStrip1.TabIndex = 1;
                        this.toolStrip1.Text = "toolStrip1";
                        // 
                        // tsbtnAdd
                        // 
                        this.tsbtnAdd.Image = global::WinPSI.Properties.Resources.add;
                        this.tsbtnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnAdd.Name = "tsbtnAdd";
                        this.tsbtnAdd.Size = new System.Drawing.Size(43, 45);
                        this.tsbtnAdd.Text = "新单";
                        this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
                        // 
                        // tsbtnSave
                        // 
                        this.tsbtnSave.Image = global::WinPSI.Properties.Resources.save;
                        this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnSave.Name = "tsbtnSave";
                        this.tsbtnSave.Size = new System.Drawing.Size(47, 45);
                        this.tsbtnSave.Text = " 保存";
                        this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
                        // 
                        // tsbtnCheck
                        // 
                        this.tsbtnCheck.Image = global::WinPSI.Properties.Resources.check;
                        this.tsbtnCheck.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnCheck.Name = "tsbtnCheck";
                        this.tsbtnCheck.Size = new System.Drawing.Size(47, 45);
                        this.tsbtnCheck.Text = " 审核";
                        this.tsbtnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnCheck.Click += new System.EventHandler(this.tsbtnCheck_Click);
                        // 
                        // toolStripSeparator2
                        // 
                        this.toolStripSeparator2.Name = "toolStripSeparator2";
                        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
                        // 
                        // tsddbtnAct
                        // 
                        this.tsddbtnAct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNoUse,
            this.tsmiRedChecked});
                        this.tsddbtnAct.Image = global::WinPSI.Properties.Resources.action;
                        this.tsddbtnAct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsddbtnAct.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsddbtnAct.Name = "tsddbtnAct";
                        this.tsddbtnAct.Size = new System.Drawing.Size(57, 45);
                        this.tsddbtnAct.Text = " 操作";
                        this.tsddbtnAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        // 
                        // tsmiNoUse
                        // 
                        this.tsmiNoUse.Name = "tsmiNoUse";
                        this.tsmiNoUse.Size = new System.Drawing.Size(216, 26);
                        this.tsmiNoUse.Text = "作废";
                        this.tsmiNoUse.Click += new System.EventHandler(this.tsmiNoUse_Click);
                        // 
                        // tsmiRedChecked
                        // 
                        this.tsmiRedChecked.Name = "tsmiRedChecked";
                        this.tsmiRedChecked.Size = new System.Drawing.Size(216, 26);
                        this.tsmiRedChecked.Text = "红冲";
                        this.tsmiRedChecked.Click += new System.EventHandler(this.tsmiRedChecked_Click);
                        // 
                        // toolStripSeparator3
                        // 
                        this.toolStripSeparator3.Name = "toolStripSeparator3";
                        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
                        // 
                        // tsbtnClose
                        // 
                        this.tsbtnClose.Image = global::WinPSI.Properties.Resources.close0;
                        this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnClose.Name = "tsbtnClose";
                        this.tsbtnClose.Size = new System.Drawing.Size(43, 45);
                        this.tsbtnClose.Text = "关闭";
                        this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
                        // 
                        // panel1
                        // 
                        this.panel1.Controls.Add(this.lblUnOpenDesp);
                        this.panel1.Controls.Add(this.label9);
                        this.panel1.Controls.Add(this.lblSaleNo);
                        this.panel1.Controls.Add(this.lblCheckState);
                        this.panel1.Controls.Add(this.label1);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 52);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(1525, 45);
                        this.panel1.TabIndex = 2;
                        // 
                        // lblUnOpenDesp
                        // 
                        this.lblUnOpenDesp.AutoSize = true;
                        this.lblUnOpenDesp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        this.lblUnOpenDesp.ForeColor = System.Drawing.Color.Blue;
                        this.lblUnOpenDesp.Location = new System.Drawing.Point(419, 15);
                        this.lblUnOpenDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblUnOpenDesp.Name = "lblUnOpenDesp";
                        this.lblUnOpenDesp.Size = new System.Drawing.Size(295, 15);
                        this.lblUnOpenDesp.TabIndex = 6;
                        this.lblUnOpenDesp.Text = "未开账，只能查看，不能进行编辑与保存";
                        // 
                        // label9
                        // 
                        this.label9.AutoSize = true;
                        this.label9.Location = new System.Drawing.Point(859, 18);
                        this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label9.Name = "label9";
                        this.label9.Size = new System.Drawing.Size(82, 15);
                        this.label9.TabIndex = 5;
                        this.label9.Text = "销售单号：";
                        // 
                        // lblSaleNo
                        // 
                        this.lblSaleNo.BackColor = System.Drawing.Color.White;
                        this.lblSaleNo.Location = new System.Drawing.Point(971, 10);
                        this.lblSaleNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblSaleNo.Name = "lblSaleNo";
                        this.lblSaleNo.Size = new System.Drawing.Size(281, 30);
                        this.lblSaleNo.TabIndex = 4;
                        this.lblSaleNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        // 
                        // lblCheckState
                        // 
                        this.lblCheckState.AutoSize = true;
                        this.lblCheckState.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        this.lblCheckState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                        this.lblCheckState.Location = new System.Drawing.Point(263, 25);
                        this.lblCheckState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblCheckState.Name = "lblCheckState";
                        this.lblCheckState.Size = new System.Drawing.Size(65, 18);
                        this.lblCheckState.TabIndex = 1;
                        this.lblCheckState.Text = "待审核";
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        this.label1.ForeColor = System.Drawing.Color.Green;
                        this.label1.Location = new System.Drawing.Point(44, 6);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(202, 37);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "销售出库单";
                        // 
                        // panel2
                        // 
                        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.panel2.Controls.Add(this.picPayType);
                        this.panel2.Controls.Add(this.txtCollectType);
                        this.panel2.Controls.Add(this.txtCreateTime);
                        this.panel2.Controls.Add(this.label11);
                        this.panel2.Controls.Add(this.txtCreator);
                        this.panel2.Controls.Add(this.label14);
                        this.panel2.Controls.Add(this.txtYHAmount);
                        this.panel2.Controls.Add(this.label13);
                        this.panel2.Controls.Add(this.txtTotalAmount);
                        this.panel2.Controls.Add(this.label10);
                        this.panel2.Controls.Add(this.panel3);
                        this.panel2.Controls.Add(this.btnDelete);
                        this.panel2.Controls.Add(this.btnAddGoods);
                        this.panel2.Controls.Add(this.dgvGoods);
                        this.panel2.Controls.Add(this.label8);
                        this.panel2.Controls.Add(this.txtRemark);
                        this.panel2.Controls.Add(this.label7);
                        this.panel2.Controls.Add(this.txtThisAmount);
                        this.panel2.Controls.Add(this.label6);
                        this.panel2.Controls.Add(this.label5);
                        this.panel2.Controls.Add(this.txtDealPerson);
                        this.panel2.Controls.Add(this.label4);
                        this.panel2.Controls.Add(this.storeList);
                        this.panel2.Controls.Add(this.txtOutStore);
                        this.panel2.Controls.Add(this.label3);
                        this.panel2.Controls.Add(this.customersList);
                        this.panel2.Controls.Add(this.txtCustomers);
                        this.panel2.Controls.Add(this.label2);
                        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel2.Location = new System.Drawing.Point(0, 97);
                        this.panel2.Margin = new System.Windows.Forms.Padding(4);
                        this.panel2.Name = "panel2";
                        this.panel2.Size = new System.Drawing.Size(1525, 555);
                        this.panel2.TabIndex = 3;
                        // 
                        // picPayType
                        // 
                        this.picPayType.Image = global::WinPSI.Properties.Resources.zh;
                        this.picPayType.Location = new System.Drawing.Point(391, 55);
                        this.picPayType.Margin = new System.Windows.Forms.Padding(4);
                        this.picPayType.Name = "picPayType";
                        this.picPayType.Size = new System.Drawing.Size(20, 18);
                        this.picPayType.TabIndex = 36;
                        this.picPayType.TabStop = false;
                        this.picPayType.Click += new System.EventHandler(this.picPayType_Click);
                        // 
                        // txtCollectType
                        // 
                        this.txtCollectType.Location = new System.Drawing.Point(136, 48);
                        this.txtCollectType.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCollectType.Name = "txtCollectType";
                        this.txtCollectType.ReadOnly = true;
                        this.txtCollectType.Size = new System.Drawing.Size(240, 25);
                        this.txtCollectType.TabIndex = 35;
                        // 
                        // txtCreateTime
                        // 
                        this.txtCreateTime.Location = new System.Drawing.Point(1013, 486);
                        this.txtCreateTime.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCreateTime.Name = "txtCreateTime";
                        this.txtCreateTime.Size = new System.Drawing.Size(128, 25);
                        this.txtCreateTime.TabIndex = 32;
                        // 
                        // label11
                        // 
                        this.label11.AutoSize = true;
                        this.label11.Location = new System.Drawing.Point(919, 491);
                        this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label11.Name = "label11";
                        this.label11.Size = new System.Drawing.Size(83, 15);
                        this.label11.TabIndex = 31;
                        this.label11.Text = "制单时间: ";
                        // 
                        // txtCreator
                        // 
                        this.txtCreator.Location = new System.Drawing.Point(736, 486);
                        this.txtCreator.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCreator.Name = "txtCreator";
                        this.txtCreator.Size = new System.Drawing.Size(128, 25);
                        this.txtCreator.TabIndex = 30;
                        // 
                        // label14
                        // 
                        this.label14.AutoSize = true;
                        this.label14.Location = new System.Drawing.Point(641, 491);
                        this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label14.Name = "label14";
                        this.label14.Size = new System.Drawing.Size(68, 15);
                        this.label14.TabIndex = 29;
                        this.label14.Text = "制单人: ";
                        // 
                        // txtYHAmount
                        // 
                        this.txtYHAmount.Location = new System.Drawing.Point(391, 486);
                        this.txtYHAmount.Margin = new System.Windows.Forms.Padding(4);
                        this.txtYHAmount.Name = "txtYHAmount";
                        this.txtYHAmount.Size = new System.Drawing.Size(128, 25);
                        this.txtYHAmount.TabIndex = 28;
                        // 
                        // label13
                        // 
                        this.label13.AutoSize = true;
                        this.label13.Location = new System.Drawing.Point(296, 491);
                        this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label13.Name = "label13";
                        this.label13.Size = new System.Drawing.Size(83, 15);
                        this.label13.TabIndex = 27;
                        this.label13.Text = "应收金额: ";
                        // 
                        // txtTotalAmount
                        // 
                        this.txtTotalAmount.Location = new System.Drawing.Point(125, 485);
                        this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
                        this.txtTotalAmount.Name = "txtTotalAmount";
                        this.txtTotalAmount.Size = new System.Drawing.Size(128, 25);
                        this.txtTotalAmount.TabIndex = 22;
                        // 
                        // label10
                        // 
                        this.label10.AutoSize = true;
                        this.label10.Location = new System.Drawing.Point(31, 490);
                        this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label10.Name = "label10";
                        this.label10.Size = new System.Drawing.Size(83, 15);
                        this.label10.TabIndex = 21;
                        this.label10.Text = "合计金额: ";
                        // 
                        // panel3
                        // 
                        this.panel3.Controls.Add(this.lblTotalAmount);
                        this.panel3.Controls.Add(this.lblTotalCount);
                        this.panel3.Controls.Add(this.lblTotalDesp);
                        this.panel3.Location = new System.Drawing.Point(29, 428);
                        this.panel3.Margin = new System.Windows.Forms.Padding(4);
                        this.panel3.Name = "panel3";
                        this.panel3.Size = new System.Drawing.Size(1355, 46);
                        this.panel3.TabIndex = 20;
                        // 
                        // lblTotalAmount
                        // 
                        this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.lblTotalAmount.Location = new System.Drawing.Point(1068, 3);
                        this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblTotalAmount.Name = "lblTotalAmount";
                        this.lblTotalAmount.Size = new System.Drawing.Size(102, 24);
                        this.lblTotalAmount.TabIndex = 2;
                        // 
                        // lblTotalCount
                        // 
                        this.lblTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.lblTotalCount.Location = new System.Drawing.Point(800, 3);
                        this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblTotalCount.Name = "lblTotalCount";
                        this.lblTotalCount.Size = new System.Drawing.Size(102, 24);
                        this.lblTotalCount.TabIndex = 1;
                        // 
                        // lblTotalDesp
                        // 
                        this.lblTotalDesp.AutoSize = true;
                        this.lblTotalDesp.Location = new System.Drawing.Point(4, 12);
                        this.lblTotalDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblTotalDesp.Name = "lblTotalDesp";
                        this.lblTotalDesp.Size = new System.Drawing.Size(75, 15);
                        this.lblTotalDesp.TabIndex = 0;
                        this.lblTotalDesp.Text = "共0条明细";
                        // 
                        // btnDelete
                        // 
                        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
                        this.btnDelete.Location = new System.Drawing.Point(1407, 182);
                        this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
                        this.btnDelete.Name = "btnDelete";
                        this.btnDelete.Size = new System.Drawing.Size(85, 35);
                        this.btnDelete.TabIndex = 19;
                        this.btnDelete.Text = "删除";
                        this.btnDelete.UseVisualStyleBackColor = true;
                        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
                        // 
                        // btnAddGoods
                        // 
                        this.btnAddGoods.FlatStyle = System.Windows.Forms.FlatStyle.System;
                        this.btnAddGoods.Location = new System.Drawing.Point(1407, 122);
                        this.btnAddGoods.Margin = new System.Windows.Forms.Padding(4);
                        this.btnAddGoods.Name = "btnAddGoods";
                        this.btnAddGoods.Size = new System.Drawing.Size(85, 35);
                        this.btnAddGoods.TabIndex = 18;
                        this.btnAddGoods.Text = "添加";
                        this.btnAddGoods.UseVisualStyleBackColor = true;
                        this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
                        // 
                        // dgvGoods
                        // 
                        this.dgvGoods.AllowUserToAddRows = false;
                        this.dgvGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvGoods.BackgroundColor = System.Drawing.Color.White;
                        this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GoodsNo,
            this.GoodsTXNo,
            this.GoodsName,
            this.GUnit,
            this.Count,
            this.SalePrice,
            this.Amount,
            this.Remark});
                        this.dgvGoods.Location = new System.Drawing.Point(29, 111);
                        this.dgvGoods.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvGoods.Name = "dgvGoods";
                        this.dgvGoods.RowTemplate.Height = 23;
                        this.dgvGoods.Size = new System.Drawing.Size(1355, 314);
                        this.dgvGoods.TabIndex = 17;
                        this.dgvGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellDoubleClick);
                        this.dgvGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellEndEdit);
                        // 
                        // Id
                        // 
                        this.Id.DataPropertyName = "Id";
                        this.Id.HeaderText = "编号";
                        this.Id.Name = "Id";
                        // 
                        // GoodsNo
                        // 
                        this.GoodsNo.DataPropertyName = "GoodsName";
                        this.GoodsNo.HeaderText = "商品编码";
                        this.GoodsNo.Name = "GoodsNo";
                        // 
                        // GoodsTXNo
                        // 
                        this.GoodsTXNo.DataPropertyName = "GoodsTXNo";
                        this.GoodsTXNo.HeaderText = "条形码";
                        this.GoodsTXNo.Name = "GoodsTXNo";
                        // 
                        // GoodsName
                        // 
                        this.GoodsName.DataPropertyName = "GoodsName";
                        this.GoodsName.HeaderText = "商品名称";
                        this.GoodsName.Name = "GoodsName";
                        // 
                        // GUnit
                        // 
                        this.GUnit.DataPropertyName = "GUnit";
                        this.GUnit.HeaderText = "单位";
                        this.GUnit.Name = "GUnit";
                        // 
                        // Count
                        // 
                        this.Count.DataPropertyName = "Count";
                        this.Count.HeaderText = "数量";
                        this.Count.Name = "Count";
                        // 
                        // SalePrice
                        // 
                        this.SalePrice.DataPropertyName = "SalePrice";
                        this.SalePrice.HeaderText = "销售单价";
                        this.SalePrice.Name = "SalePrice";
                        // 
                        // Amount
                        // 
                        this.Amount.DataPropertyName = "Amount";
                        this.Amount.HeaderText = "金额";
                        this.Amount.Name = "Amount";
                        // 
                        // Remark
                        // 
                        this.Remark.DataPropertyName = "Remark";
                        this.Remark.HeaderText = "备注";
                        this.Remark.Name = "Remark";
                        // 
                        // label8
                        // 
                        this.label8.AutoSize = true;
                        this.label8.Location = new System.Drawing.Point(27, 89);
                        this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label8.Name = "label8";
                        this.label8.Size = new System.Drawing.Size(90, 15);
                        this.label8.TabIndex = 16;
                        this.label8.Text = "出库单明细:";
                        // 
                        // txtRemark
                        // 
                        this.txtRemark.Location = new System.Drawing.Point(969, 48);
                        this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
                        this.txtRemark.Name = "txtRemark";
                        this.txtRemark.Size = new System.Drawing.Size(240, 25);
                        this.txtRemark.TabIndex = 15;
                        // 
                        // label7
                        // 
                        this.label7.AutoSize = true;
                        this.label7.Location = new System.Drawing.Point(891, 54);
                        this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label7.Name = "label7";
                        this.label7.Size = new System.Drawing.Size(69, 15);
                        this.label7.TabIndex = 14;
                        this.label7.Text = "备  注: ";
                        // 
                        // txtThisAmount
                        // 
                        this.txtThisAmount.Location = new System.Drawing.Point(567, 48);
                        this.txtThisAmount.Margin = new System.Windows.Forms.Padding(4);
                        this.txtThisAmount.Name = "txtThisAmount";
                        this.txtThisAmount.Size = new System.Drawing.Size(240, 25);
                        this.txtThisAmount.TabIndex = 13;
                        this.txtThisAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThisAmount_KeyPress);
                        // 
                        // label6
                        // 
                        this.label6.AutoSize = true;
                        this.label6.Location = new System.Drawing.Point(472, 52);
                        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label6.Name = "label6";
                        this.label6.Size = new System.Drawing.Size(83, 15);
                        this.label6.TabIndex = 12;
                        this.label6.Text = "本次收款: ";
                        // 
                        // label5
                        // 
                        this.label5.AutoSize = true;
                        this.label5.Location = new System.Drawing.Point(44, 56);
                        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label5.Name = "label5";
                        this.label5.Size = new System.Drawing.Size(83, 15);
                        this.label5.TabIndex = 9;
                        this.label5.Text = "收款账户: ";
                        // 
                        // txtDealPerson
                        // 
                        this.txtDealPerson.Location = new System.Drawing.Point(969, 12);
                        this.txtDealPerson.Margin = new System.Windows.Forms.Padding(4);
                        this.txtDealPerson.Name = "txtDealPerson";
                        this.txtDealPerson.Size = new System.Drawing.Size(240, 25);
                        this.txtDealPerson.TabIndex = 7;
                        // 
                        // label4
                        // 
                        this.label4.AutoSize = true;
                        this.label4.Location = new System.Drawing.Point(891, 24);
                        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label4.Name = "label4";
                        this.label4.Size = new System.Drawing.Size(68, 15);
                        this.label4.TabIndex = 6;
                        this.label4.Text = "经手人: ";
                        // 
                        // storeList
                        // 
                        this.storeList.Image = global::WinPSI.Properties.Resources.book;
                        this.storeList.Location = new System.Drawing.Point(816, 21);
                        this.storeList.Margin = new System.Windows.Forms.Padding(4);
                        this.storeList.Name = "storeList";
                        this.storeList.Size = new System.Drawing.Size(21, 19);
                        this.storeList.TabIndex = 5;
                        this.storeList.TabStop = false;
                        this.storeList.Click += new System.EventHandler(this.storeList_Click);
                        // 
                        // txtOutStore
                        // 
                        this.txtOutStore.Location = new System.Drawing.Point(567, 15);
                        this.txtOutStore.Margin = new System.Windows.Forms.Padding(4);
                        this.txtOutStore.Name = "txtOutStore";
                        this.txtOutStore.Size = new System.Drawing.Size(240, 25);
                        this.txtOutStore.TabIndex = 4;
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(464, 21);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(91, 15);
                        this.label3.TabIndex = 3;
                        this.label3.Text = "出货仓库: *";
                        // 
                        // customersList
                        // 
                        this.customersList.Image = global::WinPSI.Properties.Resources.kh;
                        this.customersList.Location = new System.Drawing.Point(387, 19);
                        this.customersList.Margin = new System.Windows.Forms.Padding(4);
                        this.customersList.Name = "customersList";
                        this.customersList.Size = new System.Drawing.Size(19, 20);
                        this.customersList.TabIndex = 2;
                        this.customersList.TabStop = false;
                        this.customersList.Click += new System.EventHandler(this.customersList_Click);
                        // 
                        // txtCustomers
                        // 
                        this.txtCustomers.Location = new System.Drawing.Point(137, 15);
                        this.txtCustomers.Margin = new System.Windows.Forms.Padding(4);
                        this.txtCustomers.Name = "txtCustomers";
                        this.txtCustomers.Size = new System.Drawing.Size(240, 25);
                        this.txtCustomers.TabIndex = 1;
                        // 
                        // label2
                        // 
                        this.label2.AutoSize = true;
                        this.label2.Location = new System.Drawing.Point(49, 20);
                        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label2.Name = "label2";
                        this.label2.Size = new System.Drawing.Size(77, 15);
                        this.label2.TabIndex = 0;
                        this.label2.Text = "客  户: *";
                        // 
                        // FrmSaleOutStore
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1525, 652);
                        this.Controls.Add(this.panel2);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.toolStrip1);
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MinimumSize = new System.Drawing.Size(1541, 688);
                        this.Name = "FrmSaleOutStore";
                        this.ShowIcon = false;
                        this.Text = "销售出库单";
                        this.Load += new System.EventHandler(this.FrmSaleOutStore_Load);
                        this.toolStrip1.ResumeLayout(false);
                        this.toolStrip1.PerformLayout();
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        this.panel2.ResumeLayout(false);
                        this.panel2.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.picPayType)).EndInit();
                        this.panel3.ResumeLayout(false);
                        this.panel3.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.storeList)).EndInit();
                        ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtnAct;
        private System.Windows.Forms.ToolStripMenuItem tsmiNoUse;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedChecked;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCheckState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCreateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtYHAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalDesp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThisAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDealPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox storeList;
        private System.Windows.Forms.TextBox txtOutStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox customersList;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPayType;
        private System.Windows.Forms.TextBox txtCollectType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaleNo;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTXNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.Label lblUnOpenDesp;
    }
}