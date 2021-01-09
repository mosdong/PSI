namespace WinPSI.Stock
{
    partial class FrmGoodsStockInfo
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
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.btnExcel = new System.Windows.Forms.Button();
                        this.btnClose = new System.Windows.Forms.Button();
                        this.lblGUnit = new System.Windows.Forms.Label();
                        this.label3 = new System.Windows.Forms.Label();
                        this.lblGoodsName = new System.Windows.Forms.Label();
                        this.label1 = new System.Windows.Forms.Label();
                        this.dgvList = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.CurCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.lblTotalCount = new System.Windows.Forms.Label();
                        this.lblTotalAmount = new System.Windows.Forms.Label();
                        this.panel1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // panel1
                        // 
                        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        this.panel1.Controls.Add(this.btnExcel);
                        this.panel1.Controls.Add(this.btnClose);
                        this.panel1.Controls.Add(this.lblGUnit);
                        this.panel1.Controls.Add(this.label3);
                        this.panel1.Controls.Add(this.lblGoodsName);
                        this.panel1.Controls.Add(this.label1);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.panel1.Location = new System.Drawing.Point(0, 0);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(824, 73);
                        this.panel1.TabIndex = 0;
                        // 
                        // btnExcel
                        // 
                        this.btnExcel.Location = new System.Drawing.Point(577, 22);
                        this.btnExcel.Name = "btnExcel";
                        this.btnExcel.Size = new System.Drawing.Size(87, 29);
                        this.btnExcel.TabIndex = 5;
                        this.btnExcel.Text = "导出";
                        this.btnExcel.UseVisualStyleBackColor = true;
                        this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
                        // 
                        // btnClose
                        // 
                        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnClose.Location = new System.Drawing.Point(699, 22);
                        this.btnClose.Margin = new System.Windows.Forms.Padding(4);
                        this.btnClose.Name = "btnClose";
                        this.btnClose.Size = new System.Drawing.Size(85, 29);
                        this.btnClose.TabIndex = 4;
                        this.btnClose.Text = "关闭";
                        this.btnClose.UseVisualStyleBackColor = true;
                        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
                        // 
                        // lblGUnit
                        // 
                        this.lblGUnit.AutoSize = true;
                        this.lblGUnit.Location = new System.Drawing.Point(359, 29);
                        this.lblGUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblGUnit.Name = "lblGUnit";
                        this.lblGUnit.Size = new System.Drawing.Size(22, 15);
                        this.lblGUnit.TabIndex = 3;
                        this.lblGUnit.Text = "件";
                        // 
                        // label3
                        // 
                        this.label3.AutoSize = true;
                        this.label3.Location = new System.Drawing.Point(304, 29);
                        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label3.Name = "label3";
                        this.label3.Size = new System.Drawing.Size(45, 15);
                        this.label3.TabIndex = 2;
                        this.label3.Text = "单位:";
                        // 
                        // lblGoodsName
                        // 
                        this.lblGoodsName.AutoSize = true;
                        this.lblGoodsName.Location = new System.Drawing.Point(129, 29);
                        this.lblGoodsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblGoodsName.Name = "lblGoodsName";
                        this.lblGoodsName.Size = new System.Drawing.Size(52, 15);
                        this.lblGoodsName.TabIndex = 1;
                        this.lblGoodsName.Text = "调味品";
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(43, 29);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(75, 15);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "商品名称:";
                        // 
                        // dgvList
                        // 
                        this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StoreName,
            this.CurCount,
            this.StPrice,
            this.StockAmount});
                        this.dgvList.Dock = System.Windows.Forms.DockStyle.Top;
                        this.dgvList.Location = new System.Drawing.Point(0, 73);
                        this.dgvList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvList.Name = "dgvList";
                        this.dgvList.RowTemplate.Height = 23;
                        this.dgvList.Size = new System.Drawing.Size(824, 320);
                        this.dgvList.TabIndex = 1;
                        // 
                        // Id
                        // 
                        this.Id.DataPropertyName = "Id";
                        this.Id.HeaderText = "编号";
                        this.Id.Name = "Id";
                        this.Id.ReadOnly = true;
                        // 
                        // StoreName
                        // 
                        this.StoreName.DataPropertyName = "StoreName";
                        this.StoreName.HeaderText = "仓库名称";
                        this.StoreName.Name = "StoreName";
                        this.StoreName.ReadOnly = true;
                        // 
                        // CurCount
                        // 
                        this.CurCount.DataPropertyName = "CurCount";
                        this.CurCount.HeaderText = "库存数量";
                        this.CurCount.Name = "CurCount";
                        this.CurCount.ReadOnly = true;
                        // 
                        // StPrice
                        // 
                        this.StPrice.DataPropertyName = "StPrice";
                        this.StPrice.HeaderText = "成本价";
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
                        // lblTotalCount
                        // 
                        this.lblTotalCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
                        this.lblTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.lblTotalCount.Location = new System.Drawing.Point(371, 401);
                        this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblTotalCount.Name = "lblTotalCount";
                        this.lblTotalCount.Size = new System.Drawing.Size(94, 31);
                        this.lblTotalCount.TabIndex = 2;
                        this.lblTotalCount.Text = "0";
                        this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // lblTotalAmount
                        // 
                        this.lblTotalAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
                        this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.lblTotalAmount.Location = new System.Drawing.Point(701, 401);
                        this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblTotalAmount.Name = "lblTotalAmount";
                        this.lblTotalAmount.Size = new System.Drawing.Size(93, 31);
                        this.lblTotalAmount.TabIndex = 3;
                        this.lblTotalAmount.Text = "0.00";
                        this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        // 
                        // FrmGoodsStockInfo
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(824, 451);
                        this.Controls.Add(this.lblTotalAmount);
                        this.Controls.Add(this.lblTotalCount);
                        this.Controls.Add(this.dgvList);
                        this.Controls.Add(this.panel1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmGoodsStockInfo";
                        this.ShowIcon = false;
                        this.Text = "商品仓库分布";
                        this.Load += new System.EventHandler(this.FrmGoodsStockInfo_Load);
                        this.panel1.ResumeLayout(false);
                        this.panel1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblGUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
                private System.Windows.Forms.Button btnExcel;
        }
}