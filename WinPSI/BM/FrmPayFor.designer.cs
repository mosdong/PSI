namespace WinPSI.BM
{
    partial class FrmPayFor
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
                        this.dgvPay = new System.Windows.Forms.DataGridView();
                        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.PMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.lblTotal = new System.Windows.Forms.Label();
                        this.btnCancel = new System.Windows.Forms.Button();
                        this.btnOK = new System.Windows.Forms.Button();
                        ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // dgvPay
                        // 
                        this.dgvPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                        this.dgvPay.BackgroundColor = System.Drawing.Color.White;
                        this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AccountName,
            this.PMoney});
                        this.dgvPay.Location = new System.Drawing.Point(17, 16);
                        this.dgvPay.Margin = new System.Windows.Forms.Padding(4);
                        this.dgvPay.Name = "dgvPay";
                        this.dgvPay.RowTemplate.Height = 23;
                        this.dgvPay.Size = new System.Drawing.Size(431, 369);
                        this.dgvPay.TabIndex = 0;
                        this.dgvPay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellValueChanged);
                        this.dgvPay.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPay_CurrentCellDirtyStateChanged);
                        // 
                        // Id
                        // 
                        this.Id.DataPropertyName = "PayId";
                        this.Id.HeaderText = "编号";
                        this.Id.Name = "Id";
                        this.Id.ReadOnly = true;
                        // 
                        // AccountName
                        // 
                        this.AccountName.DataPropertyName = "PayName";
                        this.AccountName.HeaderText = "账户名称";
                        this.AccountName.Name = "AccountName";
                        this.AccountName.ReadOnly = true;
                        // 
                        // PMoney
                        // 
                        this.PMoney.DataPropertyName = "PayMoney";
                        this.PMoney.HeaderText = "付款金额";
                        this.PMoney.Name = "PMoney";
                        // 
                        // lblTotal
                        // 
                        this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
                        this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.lblTotal.Location = new System.Drawing.Point(337, 400);
                        this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                        this.lblTotal.Name = "lblTotal";
                        this.lblTotal.Size = new System.Drawing.Size(110, 26);
                        this.lblTotal.TabIndex = 1;
                        this.lblTotal.Text = "0.00";
                        this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                        // 
                        // btnCancel
                        // 
                        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnCancel.Location = new System.Drawing.Point(467, 126);
                        this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
                        this.btnCancel.Name = "btnCancel";
                        this.btnCancel.Size = new System.Drawing.Size(83, 29);
                        this.btnCancel.TabIndex = 3;
                        this.btnCancel.Text = "取消";
                        this.btnCancel.UseVisualStyleBackColor = true;
                        // 
                        // btnOK
                        // 
                        this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnOK.Location = new System.Drawing.Point(467, 66);
                        this.btnOK.Margin = new System.Windows.Forms.Padding(4);
                        this.btnOK.Name = "btnOK";
                        this.btnOK.Size = new System.Drawing.Size(83, 29);
                        this.btnOK.TabIndex = 2;
                        this.btnOK.Text = "确定";
                        this.btnOK.UseVisualStyleBackColor = true;
                        this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
                        // 
                        // FrmPayFor
                        // 
                        this.AcceptButton = this.btnCancel;
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(575, 438);
                        this.Controls.Add(this.btnCancel);
                        this.Controls.Add(this.btnOK);
                        this.Controls.Add(this.lblTotal);
                        this.Controls.Add(this.dgvPay);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4);
                        this.MaximizeBox = false;
                        this.Name = "FrmPayFor";
                        this.ShowIcon = false;
                        this.Text = "多账户支付";
                        this.Load += new System.EventHandler(this.FrmPayFor_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMoney;
    }
}