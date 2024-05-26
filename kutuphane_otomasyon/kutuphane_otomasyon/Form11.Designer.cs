namespace kutuphane_otomasyon
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKaydetKitap = new System.Windows.Forms.Button();
            this.textBox6sayi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4tur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3yayinev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2yazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1kitap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Image = global::kutuphane_otomasyon.Properties.Resources.close;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(242, 321);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 75);
            this.btnCikis.TabIndex = 50;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKaydetKitap
            // 
            this.btnKaydetKitap.Image = global::kutuphane_otomasyon.Properties.Resources.diskette;
            this.btnKaydetKitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydetKitap.Location = new System.Drawing.Point(101, 321);
            this.btnKaydetKitap.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydetKitap.Name = "btnKaydetKitap";
            this.btnKaydetKitap.Size = new System.Drawing.Size(95, 75);
            this.btnKaydetKitap.TabIndex = 49;
            this.btnKaydetKitap.Text = "Kaydet";
            this.btnKaydetKitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydetKitap.UseVisualStyleBackColor = true;
            this.btnKaydetKitap.Click += new System.EventHandler(this.btnKaydetKitap_Click);
            // 
            // textBox6sayi
            // 
            this.textBox6sayi.Location = new System.Drawing.Point(218, 208);
            this.textBox6sayi.Name = "textBox6sayi";
            this.textBox6sayi.Size = new System.Drawing.Size(135, 22);
            this.textBox6sayi.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Stok Sayısı ";
            // 
            // textBox4tur
            // 
            this.textBox4tur.Location = new System.Drawing.Point(218, 167);
            this.textBox4tur.Name = "textBox4tur";
            this.textBox4tur.Size = new System.Drawing.Size(135, 22);
            this.textBox4tur.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Kitap Türü";
            // 
            // textBox3yayinev
            // 
            this.textBox3yayinev.Location = new System.Drawing.Point(218, 126);
            this.textBox3yayinev.Name = "textBox3yayinev";
            this.textBox3yayinev.Size = new System.Drawing.Size(135, 22);
            this.textBox3yayinev.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Yayın Evi ";
            // 
            // textBox2yazar
            // 
            this.textBox2yazar.Location = new System.Drawing.Point(218, 82);
            this.textBox2yazar.Name = "textBox2yazar";
            this.textBox2yazar.Size = new System.Drawing.Size(135, 22);
            this.textBox2yazar.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Yazar Adı ";
            // 
            // textBox1kitap
            // 
            this.textBox1kitap.Location = new System.Drawing.Point(218, 36);
            this.textBox1kitap.Name = "textBox1kitap";
            this.textBox1kitap.Size = new System.Drawing.Size(135, 22);
            this.textBox1kitap.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kitap Adı ";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 469);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydetKitap);
            this.Controls.Add(this.textBox6sayi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4tur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3yayinev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2yazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1kitap);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Kitap Bilgileri Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKaydetKitap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox6sayi;
        public System.Windows.Forms.TextBox textBox4tur;
        public System.Windows.Forms.TextBox textBox3yayinev;
        public System.Windows.Forms.TextBox textBox2yazar;
        public System.Windows.Forms.TextBox textBox1kitap;
    }
}