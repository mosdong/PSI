namespace WinPSI.SM
{
    partial class FrmToolGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.btnRecover = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.TGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkShowDel);
            this.panel1.Controls.Add(this.btnRecover);
            this.panel1.Controls.Add(this.panelInfo);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 58);
            this.panel1.TabIndex = 8;
            // 
            // chkShowDel
            // 
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Location = new System.Drawing.Point(495, 26);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(84, 16);
            this.chkShowDel.TabIndex = 14;
            this.chkShowDel.Text = "显示已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
            // 
            // btnRecover
            // 
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecover.Location = new System.Drawing.Point(687, 21);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(56, 23);
            this.btnRecover.TabIndex = 13;
            this.btnRecover.Text = "恢复";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.btnOk);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.txtGroupName);
            this.panelInfo.Location = new System.Drawing.Point(144, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(327, 40);
            this.panelInfo.TabIndex = 12;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(235, 8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "提交";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "组名：";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(90, 9);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(129, 21);
            this.txtGroupName.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Location = new System.Drawing.Point(606, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(39, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TGroupId,
            this.TGroupName,
            this.Edit,
            this.Delete,
            this.Recover,
            this.Remove});
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(0, 58);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowTemplate.Height = 23;
            this.dgvGroups.Size = new System.Drawing.Size(785, 293);
            this.dgvGroups.TabIndex = 9;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            // 
            // TGroupId
            // 
            this.TGroupId.DataPropertyName = "TGroupId";
            this.TGroupId.FillWeight = 60F;
            this.TGroupId.HeaderText = "编号";
            this.TGroupId.Name = "TGroupId";
            this.TGroupId.ReadOnly = true;
            // 
            // TGroupName
            // 
            this.TGroupName.DataPropertyName = "TGroupName";
            this.TGroupName.HeaderText = "名称";
            this.TGroupName.Name = "TGroupName";
            this.TGroupName.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.NullValue = "修改";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "修改";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "修改";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.NullValue = "删除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "删除";
            this.Delete.Name = "Delete";
            this.Delete.Text = "删除";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // Recover
            // 
            this.Recover.FillWeight = 50F;
            this.Recover.HeaderText = "恢复";
            this.Recover.Name = "Recover";
            this.Recover.Text = "恢复";
            this.Recover.UseColumnTextForLinkValue = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "永久删除";
            this.Remove.Name = "Remove";
            this.Remove.Text = "永久删除";
            this.Remove.UseColumnTextForLinkValue = true;
            // 
            // FrmToolGroup
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 351);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.panel1);
            this.Name = "FrmToolGroup";
            this.ShowIcon = false;
            this.Text = "工具栏组管理";
            this.Load += new System.EventHandler(this.FrmToolGroup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGroupName;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
    }
}