namespace WinPSI.Stock
{
    partial class FrmSetMore
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.chkUp = new System.Windows.Forms.CheckBox();
            this.txtStockUp = new System.Windows.Forms.TextBox();
            this.txtStockDown = new System.Windows.Forms.TextBox();
            this.chkDown = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库:";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(68, 27);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(29, 12);
            this.lblStoreName.TabIndex = 1;
            this.lblStoreName.Text = "全部";
            // 
            // chkUp
            // 
            this.chkUp.AutoSize = true;
            this.chkUp.Location = new System.Drawing.Point(29, 59);
            this.chkUp.Name = "chkUp";
            this.chkUp.Size = new System.Drawing.Size(72, 16);
            this.chkUp.TabIndex = 2;
            this.chkUp.Text = "库存上限";
            this.chkUp.UseVisualStyleBackColor = true;
            this.chkUp.CheckedChanged += new System.EventHandler(this.chkUp_CheckedChanged);
            // 
            // txtStockUp
            // 
            this.txtStockUp.Location = new System.Drawing.Point(114, 58);
            this.txtStockUp.Name = "txtStockUp";
            this.txtStockUp.Size = new System.Drawing.Size(100, 21);
            this.txtStockUp.TabIndex = 3;
            // 
            // txtStockDown
            // 
            this.txtStockDown.Location = new System.Drawing.Point(114, 99);
            this.txtStockDown.Name = "txtStockDown";
            this.txtStockDown.Size = new System.Drawing.Size(100, 21);
            this.txtStockDown.TabIndex = 5;
            // 
            // chkDown
            // 
            this.chkDown.AutoSize = true;
            this.chkDown.Location = new System.Drawing.Point(29, 100);
            this.chkDown.Name = "chkDown";
            this.chkDown.Size = new System.Drawing.Size(72, 16);
            this.chkDown.TabIndex = 4;
            this.chkDown.Text = "库存下限";
            this.chkDown.UseVisualStyleBackColor = true;
            this.chkDown.CheckedChanged += new System.EventHandler(this.chkDown_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(51, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(146, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FromSetMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStockDown);
            this.Controls.Add(this.chkDown);
            this.Controls.Add(this.txtStockUp);
            this.Controls.Add(this.chkUp);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.label1);
            this.Name = "FromSetMore";
            this.Text = "批量设置库存上下限";
            this.Load += new System.EventHandler(this.FromSetMore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.CheckBox chkUp;
        private System.Windows.Forms.TextBox txtStockUp;
        private System.Windows.Forms.TextBox txtStockDown;
        private System.Windows.Forms.CheckBox chkDown;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}