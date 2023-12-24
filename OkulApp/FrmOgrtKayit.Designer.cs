namespace OkulApp
{
    partial class FrmOgrtKayit
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
            this.lblAdOgrt = new System.Windows.Forms.Label();
            this.lblSoyadOgrt = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtAdOgrt = new System.Windows.Forms.TextBox();
            this.txtSoyadOgrt = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnKaydetOgrt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtSoyadOgrt);
            this.groupBox1.Controls.Add(this.txtAdOgrt);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.lblSoyadOgrt);
            this.groupBox1.Controls.Add(this.lblAdOgrt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bilgileri";
            // 
            // lblAdOgrt
            // 
            this.lblAdOgrt.AutoSize = true;
            this.lblAdOgrt.Location = new System.Drawing.Point(93, 110);
            this.lblAdOgrt.Name = "lblAdOgrt";
            this.lblAdOgrt.Size = new System.Drawing.Size(24, 16);
            this.lblAdOgrt.TabIndex = 0;
            this.lblAdOgrt.Text = "Ad";
            // 
            // lblSoyadOgrt
            // 
            this.lblSoyadOgrt.AutoSize = true;
            this.lblSoyadOgrt.Location = new System.Drawing.Point(93, 136);
            this.lblSoyadOgrt.Name = "lblSoyadOgrt";
            this.lblSoyadOgrt.Size = new System.Drawing.Size(47, 16);
            this.lblSoyadOgrt.TabIndex = 1;
            this.lblSoyadOgrt.Text = "Soyad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(93, 84);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(46, 16);
            this.lblTc.TabIndex = 2;
            this.lblTc.Text = "TC No";
            // 
            // txtAdOgrt
            // 
            this.txtAdOgrt.Location = new System.Drawing.Point(143, 108);
            this.txtAdOgrt.Name = "txtAdOgrt";
            this.txtAdOgrt.Size = new System.Drawing.Size(100, 22);
            this.txtAdOgrt.TabIndex = 3;
            // 
            // txtSoyadOgrt
            // 
            this.txtSoyadOgrt.Location = new System.Drawing.Point(143, 136);
            this.txtSoyadOgrt.Name = "txtSoyadOgrt";
            this.txtSoyadOgrt.Size = new System.Drawing.Size(100, 22);
            this.txtSoyadOgrt.TabIndex = 4;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(143, 80);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 5;
            // 
            // btnKaydetOgrt
            // 
            this.btnKaydetOgrt.Location = new System.Drawing.Point(108, 267);
            this.btnKaydetOgrt.Name = "btnKaydetOgrt";
            this.btnKaydetOgrt.Size = new System.Drawing.Size(147, 35);
            this.btnKaydetOgrt.TabIndex = 1;
            this.btnKaydetOgrt.Text = "Kaydet";
            this.btnKaydetOgrt.UseVisualStyleBackColor = true;
            this.btnKaydetOgrt.Click += new System.EventHandler(this.btnKaydetOgrt_Click);
            // 
            // FrmOgrtKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 366);
            this.Controls.Add(this.btnKaydetOgrt);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgrtKayit";
            this.Text = "Öğretmen Kayıt İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyadOgrt;
        private System.Windows.Forms.TextBox txtAdOgrt;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyadOgrt;
        private System.Windows.Forms.Label lblAdOgrt;
        private System.Windows.Forms.Button btnKaydetOgrt;
    }
}