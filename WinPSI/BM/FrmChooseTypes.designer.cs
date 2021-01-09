namespace WinPSI.BM
{
    partial class FrmChooseTypes
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
                        this.btnCancel = new System.Windows.Forms.Button();
                        this.btnChoose = new System.Windows.Forms.Button();
                        this.panel1 = new System.Windows.Forms.Panel();
                        this.tvUTypes = new System.Windows.Forms.TreeView();
                        this.groupBox1.SuspendLayout();
                        this.panel1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // groupBox1
                        // 
                        this.groupBox1.Controls.Add(this.btnCancel);
                        this.groupBox1.Controls.Add(this.btnChoose);
                        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
                        this.groupBox1.Location = new System.Drawing.Point(0, 0);
                        this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.groupBox1.Name = "groupBox1";
                        this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.groupBox1.Size = new System.Drawing.Size(577, 78);
                        this.groupBox1.TabIndex = 0;
                        this.groupBox1.TabStop = false;
                        // 
                        // btnCancel
                        // 
                        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                        this.btnCancel.Location = new System.Drawing.Point(411, 36);
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
                        this.btnChoose.Location = new System.Drawing.Point(280, 36);
                        this.btnChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.btnChoose.Name = "btnChoose";
                        this.btnChoose.Size = new System.Drawing.Size(83, 29);
                        this.btnChoose.TabIndex = 0;
                        this.btnChoose.Text = "选择";
                        this.btnChoose.UseVisualStyleBackColor = true;
                        this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
                        // 
                        // panel1
                        // 
                        this.panel1.BackColor = System.Drawing.Color.White;
                        this.panel1.Controls.Add(this.tvUTypes);
                        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.panel1.Location = new System.Drawing.Point(0, 78);
                        this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.panel1.Name = "panel1";
                        this.panel1.Size = new System.Drawing.Size(577, 441);
                        this.panel1.TabIndex = 1;
                        // 
                        // tvUTypes
                        // 
                        this.tvUTypes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.tvUTypes.Location = new System.Drawing.Point(0, 0);
                        this.tvUTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.tvUTypes.Name = "tvUTypes";
                        this.tvUTypes.Size = new System.Drawing.Size(577, 441);
                        this.tvUTypes.TabIndex = 0;
                        // 
                        // FrmChooseTypes
                        // 
                        this.AcceptButton = this.btnChoose;
                        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.CancelButton = this.btnCancel;
                        this.ClientSize = new System.Drawing.Size(577, 519);
                        this.Controls.Add(this.panel1);
                        this.Controls.Add(this.groupBox1);
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                        this.MaximizeBox = false;
                        this.Name = "FrmChooseTypes";
                        this.ShowIcon = false;
                        this.Text = "请选择商品类别";
                        this.Load += new System.EventHandler(this.FrmChooseTypes_Load);
                        this.groupBox1.ResumeLayout(false);
                        this.panel1.ResumeLayout(false);
                        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvUTypes;
    }
}