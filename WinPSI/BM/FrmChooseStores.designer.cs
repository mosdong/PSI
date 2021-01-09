namespace WinPSI.BM
{
    partial class FrmChooseStores
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
                        this.tvStoreTypes = new System.Windows.Forms.TreeView();
                        this.dgvStoreList = new System.Windows.Forms.DataGridView();
                        this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StoreTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.StorePYNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
                        this.splitContainer1.Panel1.SuspendLayout();
                        this.splitContainer1.Panel2.SuspendLayout();
                        this.splitContainer1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).BeginInit();
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
                        this.groupBox1.Size = new System.Drawing.Size(1067, 78);
                        this.groupBox1.TabIndex = 2;
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
                        this.splitContainer1.Panel1.Controls.Add(this.tvStoreTypes);
                        // 
                        // splitContainer1.Panel2
                        // 
                        this.splitContainer1.Panel2.Controls.Add(this.dgvStoreList);
                        this.splitContainer1.Size = new System.Drawing.Size(1067, 484);
                        this.splitContainer1.SplitterDistance = 266;
                        this.splitContainer1.SplitterWidth = 5;
                        this.splitContainer1.TabIndex = 3;
                        // 
                        // tvStoreTypes
                        // 
                        this.tvStoreTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.tvStoreTypes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvStoreTypes.ItemHeight = 25;
                        this.tvStoreTypes.Location = new System.Drawing.Point(0, 0);
                        this.tvStoreTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.tvStoreTypes.Name = "tvStoreTypes";
                        this.tvStoreTypes.Size = new System.Drawing.Size(264, 482);
                        this.tvStoreTypes.TabIndex = 0;
                        this.tvStoreTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStoreTypes_AfterSelect);
                        // 
                        // dgvStoreList
                        // 
                        this.dgvStoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvStoreList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvStoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvStoreList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        this.dgvStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvStoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreId,
            this.StoreNo,
            this.StoreName,
            this.StoreTName,
            this.StorePYNo,
            this.Remark});
                        this.dgvStoreList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvStoreList.Location = new System.Drawing.Point(0, 0);
                        this.dgvStoreList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.dgvStoreList.MultiSelect = false;
                        this.dgvStoreList.Name = "dgvStoreList";
                        this.dgvStoreList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        this.dgvStoreList.RowTemplate.Height = 23;
                        this.dgvStoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.dgvStoreList.Size = new System.Drawing.Size(794, 482);
                        this.dgvStoreList.TabIndex = 1;
                        // 
                        // StoreId
                        // 
                        this.StoreId.DataPropertyName = "StoreId";
                        this.StoreId.HeaderText = "编号";
                        this.StoreId.Name = "StoreId";
                        this.StoreId.ReadOnly = true;
                        // 
                        // StoreNo
                        // 
                        this.StoreNo.DataPropertyName = "StoreNo";
                        this.StoreNo.HeaderText = "仓库编码";
                        this.StoreNo.Name = "StoreNo";
                        this.StoreNo.ReadOnly = true;
                        // 
                        // StoreName
                        // 
                        this.StoreName.DataPropertyName = "StoreName";
                        this.StoreName.HeaderText = "仓库名称";
                        this.StoreName.Name = "StoreName";
                        this.StoreName.ReadOnly = true;
                        // 
                        // StoreTName
                        // 
                        this.StoreTName.DataPropertyName = "STypeName";
                        this.StoreTName.HeaderText = "仓库类别";
                        this.StoreTName.Name = "StoreTName";
                        this.StoreTName.ReadOnly = true;
                        // 
                        // StorePYNo
                        // 
                        this.StorePYNo.DataPropertyName = "StorePYNo";
                        this.StorePYNo.HeaderText = "拼音码";
                        this.StorePYNo.Name = "StorePYNo";
                        this.StorePYNo.ReadOnly = true;
                        // 
                        // Remark
                        // 
                        this.Remark.DataPropertyName = "StoreRemark";
                        this.Remark.FillWeight = 200F;
                        this.Remark.HeaderText = "备注";
                        this.Remark.Name = "Remark";
                        this.Remark.ReadOnly = true;
                        // 
                        // FrmChooseStores
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1067, 562);
                        this.Controls.Add(this.splitContainer1);
                        this.Controls.Add(this.groupBox1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.MaximizeBox = false;
                        this.Name = "FrmChooseStores";
                        this.ShowIcon = false;
                        this.Text = "选择仓库";
                        this.Load += new System.EventHandler(this.FrmChooseStores_Load);
                        this.groupBox1.ResumeLayout(false);
                        this.groupBox1.PerformLayout();
                        this.splitContainer1.Panel1.ResumeLayout(false);
                        this.splitContainer1.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
                        this.splitContainer1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).EndInit();
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
        private System.Windows.Forms.TreeView tvStoreTypes;
        private System.Windows.Forms.DataGridView dgvStoreList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePYNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}