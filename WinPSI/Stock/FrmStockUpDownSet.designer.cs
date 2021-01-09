namespace WinPSI.Stock
{
    partial class FrmStockUpDownSet
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
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockUpDownSet));
                        this.label2 = new System.Windows.Forms.Label();
                        this.cboStores = new System.Windows.Forms.ComboBox();
                        this.label1 = new System.Windows.Forms.Label();
                        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
                        this.tsbtnSetMore = new System.Windows.Forms.ToolStripButton();
                        this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
                        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                        this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
                        this.tvGoodsType = new System.Windows.Forms.TreeView();
                        this.scQuery = new System.Windows.Forms.SplitContainer();
                        this.dgvList = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.GUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StockUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StockDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        panelWhere = new System.Windows.Forms.Panel();
                        panelWhere.SuspendLayout();
                        this.toolStrip1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.scQuery)).BeginInit();
                        this.scQuery.Panel1.SuspendLayout();
                        this.scQuery.Panel2.SuspendLayout();
                        this.scQuery.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // panelWhere
                        // 
                        panelWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        panelWhere.Controls.Add(this.label2);
                        panelWhere.Controls.Add(this.cboStores);
                        panelWhere.Controls.Add(this.label1);
                        panelWhere.Dock = System.Windows.Forms.DockStyle.Top;
                        panelWhere.Location = new System.Drawing.Point(0, 65);
                        panelWhere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        panelWhere.Name = "panelWhere";
                        panelWhere.Size = new System.Drawing.Size(1383, 70);
                        panelWhere.TabIndex = 3;
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
                        // cboStores
                        // 
                        this.cboStores.FormattingEnabled = true;
                        this.cboStores.Location = new System.Drawing.Point(375, 22);
                        this.cboStores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.cboStores.Name = "cboStores";
                        this.cboStores.Size = new System.Drawing.Size(180, 23);
                        this.cboStores.TabIndex = 3;
                        this.cboStores.SelectedIndexChanged += new System.EventHandler(this.cboStores_SelectedIndexChanged);
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(327, 26);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(52, 15);
                        this.label1.TabIndex = 0;
                        this.label1.Text = "仓库：";
                        // 
                        // toolStrip1
                        // 
                        this.toolStrip1.AutoSize = false;
                        this.toolStrip1.BackgroundImage = global::WinPSI.Properties.Resources.tlbg;
                        this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSetMore,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnRefresh,
            this.toolStripSeparator2,
            this.tsbtnClose});
                        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
                        this.toolStrip1.Name = "toolStrip1";
                        this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
                        this.toolStrip1.Size = new System.Drawing.Size(1383, 65);
                        this.toolStrip1.TabIndex = 2;
                        this.toolStrip1.Text = "toolStrip1";
                        // 
                        // tsbtnSetMore
                        // 
                        this.tsbtnSetMore.Image = global::WinPSI.Properties.Resources.xq;
                        this.tsbtnSetMore.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnSetMore.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnSetMore.Name = "tsbtnSetMore";
                        this.tsbtnSetMore.Size = new System.Drawing.Size(73, 56);
                        this.tsbtnSetMore.Text = "批量设置";
                        this.tsbtnSetMore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnSetMore.Click += new System.EventHandler(this.tsbtnSetMore_Click);
                        // 
                        // tsbtnSave
                        // 
                        this.tsbtnSave.Image = global::WinPSI.Properties.Resources.save;
                        this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnSave.Name = "tsbtnSave";
                        this.tsbtnSave.Size = new System.Drawing.Size(47, 56);
                        this.tsbtnSave.Text = " 保存";
                        this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
                        // 
                        // toolStripSeparator1
                        // 
                        this.toolStripSeparator1.Name = "toolStripSeparator1";
                        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
                        // 
                        // tsbtnRefresh
                        // 
                        this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
                        this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                        this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
                        this.tsbtnRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
                        this.tsbtnRefresh.Name = "tsbtnRefresh";
                        this.tsbtnRefresh.Size = new System.Drawing.Size(47, 53);
                        this.tsbtnRefresh.Text = " 刷新";
                        this.tsbtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                        this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                        this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
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
                        // tvGoodsType
                        // 
                        this.tvGoodsType.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.tvGoodsType.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvGoodsType.Location = new System.Drawing.Point(0, 0);
                        this.tvGoodsType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.tvGoodsType.Name = "tvGoodsType";
                        this.tvGoodsType.Size = new System.Drawing.Size(284, 518);
                        this.tvGoodsType.TabIndex = 0;
                        this.tvGoodsType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGoodsType_AfterSelect);
                        // 
                        // scQuery
                        // 
                        this.scQuery.BackColor = System.Drawing.Color.White;
                        this.scQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.scQuery.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.scQuery.Location = new System.Drawing.Point(0, 135);
                        this.scQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.scQuery.Name = "scQuery";
                        // 
                        // scQuery.Panel1
                        // 
                        this.scQuery.Panel1.Controls.Add(this.tvGoodsType);
                        // 
                        // scQuery.Panel2
                        // 
                        this.scQuery.Panel2.Controls.Add(this.dgvList);
                        this.scQuery.Size = new System.Drawing.Size(1383, 520);
                        this.scQuery.SplitterDistance = 286;
                        this.scQuery.SplitterWidth = 5;
                        this.scQuery.TabIndex = 5;
                        // 
                        // dgvList
                        // 
                        this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GoodsNo,
            this.GoodsName,
            this.GUnit,
            this.StockUp,
            this.StockDown});
                        this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvList.Location = new System.Drawing.Point(0, 0);
                        this.dgvList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.dgvList.Name = "dgvList";
                        this.dgvList.RowTemplate.Height = 23;
                        this.dgvList.Size = new System.Drawing.Size(1090, 518);
                        this.dgvList.TabIndex = 2;
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
                        // StockUp
                        // 
                        this.StockUp.DataPropertyName = "StockUp";
                        this.StockUp.HeaderText = "库存上限";
                        this.StockUp.Name = "StockUp";
                        // 
                        // StockDown
                        // 
                        this.StockDown.DataPropertyName = "StockDown";
                        this.StockDown.HeaderText = "库存下限";
                        this.StockDown.Name = "StockDown";
                        // 
                        // FrmStockUpDownSet
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1383, 655);
                        this.Controls.Add(this.scQuery);
                        this.Controls.Add(panelWhere);
                        this.Controls.Add(this.toolStrip1);
                        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.Name = "FrmStockUpDownSet";
                        this.Text = "库存上下限设置";
                        this.Load += new System.EventHandler(this.FrmStockUpDownSet_Load);
                        panelWhere.ResumeLayout(false);
                        panelWhere.PerformLayout();
                        this.toolStrip1.ResumeLayout(false);
                        this.toolStrip1.PerformLayout();
                        this.scQuery.Panel1.ResumeLayout(false);
                        this.scQuery.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.scQuery)).EndInit();
                        this.scQuery.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSetMore;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvGoodsType;
        private System.Windows.Forms.SplitContainer scQuery;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDown;
    }
}