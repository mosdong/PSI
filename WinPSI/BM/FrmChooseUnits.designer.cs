namespace WinPSI.BM
{
    partial class FrmChooseUnits
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
                        this.tvUnitTypes = new System.Windows.Forms.TreeView();
                        this.dgvUnitList = new System.Windows.Forms.DataGridView();
                        this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
                        this.splitContainer1.Panel1.SuspendLayout();
                        this.splitContainer1.Panel2.SuspendLayout();
                        this.splitContainer1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvUnitList)).BeginInit();
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
                        this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
                        this.groupBox1.Name = "groupBox1";
                        this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
                        this.groupBox1.Size = new System.Drawing.Size(1176, 78);
                        this.groupBox1.TabIndex = 1;
                        this.groupBox1.TabStop = false;
                        // 
                        // btnQuery
                        // 
                        this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnQuery.Location = new System.Drawing.Point(408, 31);
                        this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
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
                        this.txtKeyWords.Margin = new System.Windows.Forms.Padding(4);
                        this.txtKeyWords.Name = "txtKeyWords";
                        this.txtKeyWords.Size = new System.Drawing.Size(208, 25);
                        this.txtKeyWords.TabIndex = 4;
                        // 
                        // label1
                        // 
                        this.label1.AutoSize = true;
                        this.label1.Location = new System.Drawing.Point(56, 38);
                        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.label1.Name = "label1";
                        this.label1.Size = new System.Drawing.Size(120, 15);
                        this.label1.TabIndex = 3;
                        this.label1.Text = "按名称/拼音码：";
                        // 
                        // btnAdd
                        // 
                        this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnAdd.Location = new System.Drawing.Point(904, 31);
                        this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
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
                        this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
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
                        this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
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
                        this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
                        this.splitContainer1.Name = "splitContainer1";
                        // 
                        // splitContainer1.Panel1
                        // 
                        this.splitContainer1.Panel1.Controls.Add(this.tvUnitTypes);
                        // 
                        // splitContainer1.Panel2
                        // 
                        this.splitContainer1.Panel2.Controls.Add(this.dgvUnitList);
                        this.splitContainer1.Size = new System.Drawing.Size(1176, 458);
                        this.splitContainer1.SplitterDistance = 293;
                        this.splitContainer1.SplitterWidth = 5;
                        this.splitContainer1.TabIndex = 2;
                        // 
                        // tvUnitTypes
                        // 
                        this.tvUnitTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.tvUnitTypes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvUnitTypes.ItemHeight = 25;
                        this.tvUnitTypes.Location = new System.Drawing.Point(0, 0);
                        this.tvUnitTypes.Margin = new System.Windows.Forms.Padding(4);
                        this.tvUnitTypes.Name = "tvUnitTypes";
                        this.tvUnitTypes.Size = new System.Drawing.Size(291, 456);
                        this.tvUnitTypes.TabIndex = 0;
                        this.tvUnitTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUnitTypes_AfterSelect);
                        // 
                        // dgvUnitList
                        // 
                        this.dgvUnitList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvUnitList.BackgroundColor = System.Drawing.Color.White;
                        this.dgvUnitList.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.dgvUnitList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        this.dgvUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvUnitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitId,
            this.UnitName,
            this.ContactPerson,
            this.PhoneNumber,
            this.Telephone,
            this.Address});
                        this.dgvUnitList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.dgvUnitList.Location = new System.Drawing.Point(0, 0);
                        this.dgvUnitList.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvUnitList.MultiSelect = false;
                        this.dgvUnitList.Name = "dgvUnitList";
                        this.dgvUnitList.RowTemplate.Height = 23;
                        this.dgvUnitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                        this.dgvUnitList.Size = new System.Drawing.Size(876, 456);
                        this.dgvUnitList.TabIndex = 1;
                        // 
                        // UnitId
                        // 
                        this.UnitId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                        this.UnitId.DataPropertyName = "UnitId";
                        this.UnitId.HeaderText = "编号";
                        this.UnitId.Name = "UnitId";
                        this.UnitId.ReadOnly = true;
                        // 
                        // UnitName
                        // 
                        this.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                        this.UnitName.DataPropertyName = "UnitName";
                        this.UnitName.FillWeight = 150F;
                        this.UnitName.HeaderText = "单位名称";
                        this.UnitName.Name = "UnitName";
                        this.UnitName.ReadOnly = true;
                        // 
                        // ContactPerson
                        // 
                        this.ContactPerson.DataPropertyName = "ContactPerson";
                        this.ContactPerson.HeaderText = "联系人";
                        this.ContactPerson.Name = "ContactPerson";
                        this.ContactPerson.ReadOnly = true;
                        // 
                        // PhoneNumber
                        // 
                        this.PhoneNumber.DataPropertyName = "PhoneNumber";
                        this.PhoneNumber.HeaderText = "联系电话";
                        this.PhoneNumber.Name = "PhoneNumber";
                        this.PhoneNumber.ReadOnly = true;
                        // 
                        // Telephone
                        // 
                        this.Telephone.DataPropertyName = "Telephone";
                        this.Telephone.HeaderText = "手机";
                        this.Telephone.Name = "Telephone";
                        this.Telephone.ReadOnly = true;
                        // 
                        // Address
                        // 
                        this.Address.DataPropertyName = "FullAddress";
                        this.Address.FillWeight = 200F;
                        this.Address.HeaderText = "地址";
                        this.Address.Name = "Address";
                        this.Address.ReadOnly = true;
                        // 
                        // FrmChooseUnits
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(1176, 536);
                        this.Controls.Add(this.splitContainer1);
                        this.Controls.Add(this.groupBox1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmChooseUnits";
                        this.ShowIcon = false;
                        this.Text = "选择供应商";
                        this.Load += new System.EventHandler(this.FrmChooseUnits_Load);
                        this.groupBox1.ResumeLayout(false);
                        this.groupBox1.PerformLayout();
                        this.splitContainer1.Panel1.ResumeLayout(false);
                        this.splitContainer1.Panel2.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
                        this.splitContainer1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvUnitList)).EndInit();
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
        private System.Windows.Forms.TreeView tvUnitTypes;
        private System.Windows.Forms.DataGridView dgvUnitList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}