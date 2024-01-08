namespace OkulApp
{
    partial class frmOgrBul
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
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.lblNumara);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Örenci Bulma Ekranı";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(99, 69);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 22);
            this.txtNumara.TabIndex = 0;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(96, 50);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(115, 16);
            this.lblNumara.TabIndex = 1;
            this.lblNumara.Text = "Öğrenci Numarası";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(99, 97);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 34);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 239);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtNumara;
    }
}