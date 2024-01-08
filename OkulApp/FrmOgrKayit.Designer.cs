namespace OkulApp
{
    partial class FrmOgrKayit
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
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIdSil = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpOgrenci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.BackColor = System.Drawing.Color.PowderBlue;
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(257, 171);
            this.grpOgrenci.TabIndex = 0;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(35, 126);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 5;
            this.lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(35, 91);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(35, 62);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(97, 120);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 22);
            this.txtNumara.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(97, 88);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 56);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKaydet.Location = new System.Drawing.Point(12, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 32);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIdSil
            // 
            this.btnIdSil.BackColor = System.Drawing.Color.Tomato;
            this.btnIdSil.Location = new System.Drawing.Point(336, 118);
            this.btnIdSil.Name = "btnIdSil";
            this.btnIdSil.Size = new System.Drawing.Size(100, 32);
            this.btnIdSil.TabIndex = 7;
            this.btnIdSil.Text = "Idye göre Sil";
            this.btnIdSil.UseVisualStyleBackColor = false;
            this.btnIdSil.Click += new System.EventHandler(this.btnIdSil_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(61, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(275, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Silme İşlemi";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(336, 156);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(108, 41);
            this.btnBul.TabIndex = 9;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(118, 189);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 32);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(189, 189);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 432);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIdSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt İşlemleri";
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.TextBox txtNumara;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIdSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

