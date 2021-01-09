namespace WinPSI.SM
{
    partial class FrmToolMenuList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToolMenuList));
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTMenus = new System.Windows.Forms.DataGridView();
            this.TMenuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGroupId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TMUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TMOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Recover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tsMenus = new System.Windows.Forms.ToolStrip();
            this.tsbtnToolGroup = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRecover = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            panelWhere = new System.Windows.Forms.Panel();
            panelWhere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTMenus)).BeginInit();
            this.tsMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWhere
            // 
            panelWhere.Controls.Add(this.button1);
            panelWhere.Controls.Add(this.chkShowDel);
            panelWhere.Controls.Add(this.btnQuery);
            panelWhere.Controls.Add(this.txtKeyWords);
            panelWhere.Controls.Add(this.label1);
            panelWhere.Dock = System.Windows.Forms.DockStyle.Top;
            panelWhere.Location = new System.Drawing.Point(0, 51);
            panelWhere.Name = "panelWhere";
            panelWhere.Size = new System.Drawing.Size(884, 56);
            panelWhere.TabIndex = 3;
            // 
            // chkShowDel
            // 
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Location = new System.Drawing.Point(624, 21);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(108, 16);
            this.chkShowDel.TabIndex = 3;
            this.chkShowDel.Text = "显示已删除数据";
            this.chkShowDel.UseVisualStyleBackColor = true;
            this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Location = new System.Drawing.Point(412, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(199, 17);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(160, 21);
            this.txtKeyWords.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入工具项名称：";
            // 
            // dgvTMenus
            // 
            this.dgvTMenus.AllowUserToAddRows = false;
            this.dgvTMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTMenus.BackgroundColor = System.Drawing.Color.White;
            this.dgvTMenus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TMenuId,
            this.TMenuName,
            this.TMPic,
            this.TGroupId,
            this.TMUrl,
            this.TMOrder,
            this.Edit,
            this.Del,
            this.Recover});
            this.dgvTMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTMenus.Location = new System.Drawing.Point(0, 107);
            this.dgvTMenus.Name = "dgvTMenus";
            this.dgvTMenus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTMenus.RowTemplate.Height = 23;
            this.dgvTMenus.Size = new System.Drawing.Size(884, 343);
            this.dgvTMenus.TabIndex = 4;
            this.dgvTMenus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTMenus_CellContentClick);
            // 
            // TMenuId
            // 
            this.TMenuId.DataPropertyName = "TMenuId";
            this.TMenuId.HeaderText = "编号";
            this.TMenuId.Name = "TMenuId";
            this.TMenuId.ReadOnly = true;
            // 
            // TMenuName
            // 
            this.TMenuName.DataPropertyName = "TMenuName";
            this.TMenuName.HeaderText = "名称";
            this.TMenuName.Name = "TMenuName";
            this.TMenuName.ReadOnly = true;
            // 
            // TMPic
            // 
            this.TMPic.DataPropertyName = "TMPic";
            this.TMPic.HeaderText = "图标地址";
            this.TMPic.Name = "TMPic";
            this.TMPic.ReadOnly = true;
            // 
            // TGroupId
            // 
            this.TGroupId.DataPropertyName = "TGroupId";
            this.TGroupId.HeaderText = "组名";
            this.TGroupId.Name = "TGroupId";
            this.TGroupId.ReadOnly = true;
            // 
            // TMUrl
            // 
            this.TMUrl.DataPropertyName = "TMUrl";
            this.TMUrl.FillWeight = 200F;
            this.TMUrl.HeaderText = "关联页面";
            this.TMUrl.Name = "TMUrl";
            this.TMUrl.ReadOnly = true;
            // 
            // TMOrder
            // 
            this.TMOrder.DataPropertyName = "TMOrder";
            this.TMOrder.HeaderText = "排序";
            this.TMOrder.Name = "TMOrder";
            this.TMOrder.ReadOnly = true;
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
            // 
            // Del
            // 
            dataGridViewCellStyle2.NullValue = "删除";
            this.Del.DefaultCellStyle = dataGridViewCellStyle2;
            this.Del.FillWeight = 50F;
            this.Del.HeaderText = "删除";
            this.Del.Name = "Del";
            // 
            // Recover
            // 
            this.Recover.HeaderText = "恢复";
            this.Recover.Name = "Recover";
            this.Recover.Text = "恢复";
            this.Recover.UseColumnTextForLinkValue = true;
            // 
            // tsMenus
            // 
            this.tsMenus.AutoSize = false;
            this.tsMenus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tsMenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenus.BackgroundImage")));
            this.tsMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnToolGroup,
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnRecover,
            this.tsbtnDelete,
            this.toolStripSeparator1,
            this.tsbtnInfo,
            this.toolStripSeparator2,
            this.tsbtnClose,
            this.toolStripSeparator3,
            this.tsbtnRefresh,
            this.toolStripSeparator4});
            this.tsMenus.Location = new System.Drawing.Point(0, 0);
            this.tsMenus.Name = "tsMenus";
            this.tsMenus.Padding = new System.Windows.Forms.Padding(0, 0, 1, 2);
            this.tsMenus.Size = new System.Drawing.Size(884, 51);
            this.tsMenus.TabIndex = 2;
            this.tsMenus.Text = "toolStrip1";
            // 
            // tsbtnToolGroup
            // 
            this.tsbtnToolGroup.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnToolGroup.Image")));
            this.tsbtnToolGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnToolGroup.Name = "tsbtnToolGroup";
            this.tsbtnToolGroup.Size = new System.Drawing.Size(60, 46);
            this.tsbtnToolGroup.Text = "工具栏组";
            this.tsbtnToolGroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnToolGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnToolGroup.Click += new System.EventHandler(this.tsbtnToolGroup_Click);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(48, 43);
            this.tsbtnAdd.Text = "  新增 ";
            this.tsbtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAdd.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = global::WinPSI.Properties.Resources.edit;
            this.tsbtnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tsbtnEdit.Size = new System.Drawing.Size(40, 43);
            this.tsbtnEdit.Text = " 修改";
            this.tsbtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnRecover
            // 
            this.tsbtnRecover.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRecover.Image")));
            this.tsbtnRecover.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRecover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRecover.Name = "tsbtnRecover";
            this.tsbtnRecover.Size = new System.Drawing.Size(36, 46);
            this.tsbtnRecover.Text = "恢复";
            this.tsbtnRecover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRecover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRecover.Click += new System.EventHandler(this.tsbtnRecover_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(40, 43);
            this.tsbtnDelete.Text = " 删除";
            this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // tsbtnInfo
            // 
            this.tsbtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInfo.Image")));
            this.tsbtnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInfo.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbtnInfo.Name = "tsbtnInfo";
            this.tsbtnInfo.Size = new System.Drawing.Size(40, 43);
            this.tsbtnInfo.Text = " 详情";
            this.tsbtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tsbtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClose.Image")));
            this.tsbtnClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(40, 43);
            this.tsbtnClose.Text = " 关闭";
            this.tsbtnClose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(40, 43);
            this.tsbtnRefresh.Text = " 刷新";
            this.tsbtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 49);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "隐藏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmToolMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.dgvTMenus);
            this.Controls.Add(panelWhere);
            this.Controls.Add(this.tsMenus);
            this.Name = "FrmToolMenuList";
            this.ShowIcon = false;
            this.Text = "工具栏菜单管理";
            this.Load += new System.EventHandler(this.FrmToolMenuList_Load);
            panelWhere.ResumeLayout(false);
            panelWhere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTMenus)).EndInit();
            this.tsMenus.ResumeLayout(false);
            this.tsMenus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenus;
        private System.Windows.Forms.ToolStripButton tsbtnToolGroup;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTMenus;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMenuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMPic;
        private System.Windows.Forms.DataGridViewComboBoxColumn TGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TMOrder;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewLinkColumn Recover;
        private System.Windows.Forms.ToolStripButton tsbtnRecover;
        private System.Windows.Forms.Button button1;
    }
}