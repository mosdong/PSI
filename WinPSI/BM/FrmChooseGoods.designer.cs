namespace WinPSI.BM
{
    partial class FrmChooseGoods
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
                        this.groupBox1 = new System.Windows.Forms.GroupBox();
                        this.btnQuery = new System.Windows.Forms.Button();
                        this.txtKeyWords = new System.Windows.Forms.TextBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.btnAdd = new System.Windows.Forms.Button();
                        this.btnCancel = new System.Windows.Forms.Button();
                        this.btnChoose = new System.Windows.Forms.Button();
                        this.splitContainer1 = new System.Windows.Forms.SplitContainer();
                        this.tvGoodsTypes = new System.Windows.Forms.TreeView();
                        this.dgvGoodsList = new System.Windows.Forms.DataGridView();
                        this.GoodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.IsStopped = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                        this.StorePYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
                        this.splitContainer1.Panel1.SuspendLayout();
                        this.splitContainer1.Panel2.SuspendLayout();
                        this.splitContainer1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // groupBox1
                        // 
                        this.groupBox1.Controls.Add(this.btnQuery);
                        this.groupBox1.Controls.Add(this.txtKeyWords);
                        this.groupBox1.Controls.Add(this.label1);
                        this.groupBox1.Controls.Add(this.btnAdd);
                        this.groupBox1.Controls.Add(this.btnCancel);
                        this.groupBox1.Controls.Add(this.btnChoose);
                        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.groupBox1.Location = new System.Drawing.Point(0, 0);
                        this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.groupBox1.Name = "groupBox1";
                        this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.groupBox1.Size = new System.Drawing.Size(1177, 78);
                        this.groupBox1.TabIndex = 3;
                        this.groupBox1.TabStop = false;
                        // 
                        // btnQuery
                        // 
                        this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnQuery.Location = new System.Drawing.Point(408, 31);
                        this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.btnQuery.Name = "btnQuery";
                        this.btnQuery.Size = new System.Drawing.Size(52, 29);
                        this.btnQuery.TabIndex = 5;
                        this.btnQuery.Text = "查询";
                        this.btnQuery.UseVisualStyleBackColor = true;
                        this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
                        // 
                        // txtKeyWords
                        // 
                        this.txtKeyWords.Location = new System.Drawing.Point(191, 31);
                        this.txtKeyWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.txtKeyWords.Name = "txtKeyWords";
                        this.txtKeyWords.Size = new System.Drawing.Size(208, 25);
                        this.txtKeyWords.TabIndex = 4;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(20, 38);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(158, 15);
                        this.label1.TabIndex = 3;
                        this.label1.Text = "按名称/编码/拼音码：";
                        // 
                        // btnAdd
                        // 
                        this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnAdd.Location = new System.Drawing.Point(904, 31);
                        this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.btnAdd.Name = "btnAdd";
                        this.btnAdd.Size = new System.Drawing.Size(83, 29);
                        this.btnAdd.TabIndex = 2;
                        this.btnAdd.Text = "新增";
                        this.btnAdd.UseVisualStyleBackColor = true;
                        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
                        // 
                        // btnCancel
                        // 
                        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnCancel.Location = new System.Drawing.Point(783, 31);
                        this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.btnCancel.Name = "btnCancel";
                        this.btnCancel.Size = new System.Drawing.Size(83, 29);
                        this.btnCancel.TabIndex = 1;
                        this.btnCancel.Text = "取消";
                        this.btnCancel.UseVisualStyleBackColor = true;
                        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
                        // 
                        // btnChoose
                        // 
                        this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnChoose.Location = new System.Drawing.Point(652, 31);
                        this.btnChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.btnChoose.Name = "btnChoose";
                        this.btnChoose.Size = new System.Drawing.Size(83, 29);
                        this.btnChoose.TabIndex = 0;
                        this.btnChoose.Text = "选择";
                        this.btnChoose.UseVisualStyleBackColor = true;
                        this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
                        // 
                        // splitContainer1
                        // 
                        this.splitContainer1.BackColor = System.Drawing.Color.White;
                        this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.splitContainer1.Location = new System.Drawing.Point(0, 78);
                        this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.splitContainer1.Name = "splitContainer1";
                        // 
                        // splitContainer1.Panel1
                        // 
                        this.splitContainer1.Panel1.Controls.Add(this.tvGoodsTypes);
                        // 
                        // splitContainer1.Panel2
                        // 
                        this.splitContainer1.Panel2.Controls.Add(this.dgvGoodsList);
                        this.splitContainer1.Size = new System.Drawing.Size(1177, 484);
                        this.splitContainer1.SplitterDistance = 262;
                        this.splitContainer1.SplitterWidth = 5;
                        this.splitContainer1.TabIndex = 4;
                        // 
                        // tvGoodsTypes
                        // 
                        this.tvGoodsTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.tvGoodsTypes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvGoodsTypes.ItemHeight = 25;
                        this.tvGoodsTypes.Location = new System.Drawing.Point(0, 0);
                        this.tvGoodsTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.tvGoodsTypes.Name = "tvGoodsTypes";
                        this.tvGoodsTypes.Size = new System.Drawing.Size(260, 482);
                        this.tvGoodsTypes.TabIndex = 0;
                        this.tvGoodsTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGoodsTypes_AfterSelect);
                        // 
                        // dgvGoodsList
                        // 
                        this.dgvGoodsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvGoodsList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvGoodsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsId,
            this.GoodsName,
            this.GoodsTName,
            this.RetailPrice,
            this.IsStopped,
            this.StorePYNo,
            this.Remark});
                        this.dgvGoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvGoodsList.Location = new System.Drawing.Point(0, 0);
                        this.dgvGoodsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.dgvGoodsList.Name = "dgvGoodsList";
                        this.dgvGoodsList.RowTemplate.Height = 23;
                        this.dgvGoodsList.Size = new System.Drawing.Size(908, 482);
                        this.dgvGoodsList.TabIndex = 1;
                        // 
                        // GoodsId
                        // 
                        this.GoodsId.DataPropertyName = "GoodsId";
                        this.GoodsId.HeaderText = "编号";
                        this.GoodsId.Name = "GoodsId";
                        this.GoodsId.ReadOnly = true;
                        // 
                        // GoodsName
                        // 
                        this.GoodsName.DataPropertyName = "GoodsName";
                        this.GoodsName.HeaderText = "商品名称";
                        this.GoodsName.Name = "GoodsName";
                        this.GoodsName.ReadOnly = true;
                        // 
                        // GoodsTName
                        // 
                        this.GoodsTName.DataPropertyName = "GTypeName";
                        this.GoodsTName.HeaderText = "商品类别";
                        this.GoodsTName.Name = "GoodsTName";
                        this.GoodsTName.ReadOnly = true;
                        // 
                        // RetailPrice
                        // 
                        this.RetailPrice.DataPropertyName = "RetailPrice";
                        this.RetailPrice.HeaderText = "零售价";
                        this.RetailPrice.Name = "RetailPrice";
                        this.RetailPrice.ReadOnly = true;
                        // 
                        // IsStopped
                        // 
                        this.IsStopped.DataPropertyName = "IsStopped";
                        this.IsStopped.FalseValue = "0";
                        this.IsStopped.HeaderText = "停用";
                        this.IsStopped.Name = "IsStopped";
                        this.IsStopped.ReadOnly = true;
                        this.IsStopped.TrueValue = "1";
                        // 
                        // StorePYNo
                        // 
                        this.StorePYNo.DataPropertyName = "GoodsPYNo";
                        this.StorePYNo.HeaderText = "拼音码";
                        this.StorePYNo.Name = "StorePYNo";
                        this.StorePYNo.ReadOnly = true;
                        // 
                        // Remark
                        // 
                        this.Remark.DataPropertyName = "Remark";
                        this.Remark.FillWeight = 200F;
                        this.Remark.HeaderText = "备注";
                        this.Remark.Name = "Remark";
                        this.Remark.ReadOnly = true;
                        // 
                        // FrmChooseGoods
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1177, 562);
                        this.Controls.Add(this.splitContainer1);
                        this.Controls.Add(this.groupBox1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.MaximizeBox = false;
                        this.Name = "FrmChooseGoods";
                        this.ShowIcon = false;
                        this.Text = "选择商品";
                        this.Load += new System.EventHandler(this.FrmChooseGoods_Load);
                        this.groupBox1.ResumeLayout(false);
                        this.groupBox1.PerformLayout();
                        this.splitContainer1.Panel1.ResumeLayout(false);
                        this.splitContainer1.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
                        this.splitContainer1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvGoodsTypes;
        private System.Windows.Forms.DataGridView dgvGoodsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsStopped;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}