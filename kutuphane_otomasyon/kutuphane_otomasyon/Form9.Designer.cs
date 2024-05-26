namespace kutuphane_otomasyon
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1UyeAd = new System.Windows.Forms.TextBox();
            this.textBox2kitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1geri = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(181, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Adı  ";
            // 
            // textBox1UyeAd
            // 
            this.textBox1UyeAd.Enabled = false;
            this.textBox1UyeAd.Location = new System.Drawing.Point(264, 46);
            this.textBox1UyeAd.Name = "textBox1UyeAd";
            this.textBox1UyeAd.Size = new System.Drawing.Size(141, 22);
            this.textBox1UyeAd.TabIndex = 1;
            // 
            // textBox2kitapAd
            // 
            this.textBox2kitapAd.Enabled = false;
            this.textBox2kitapAd.Location = new System.Drawing.Point(264, 92);
            this.textBox2kitapAd.Name = "textBox2kitapAd";
            this.textBox2kitapAd.Size = new System.Drawing.Size(141, 22);
            this.textBox2kitapAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(181, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı ";
            // 
            // comboBox1geri
            // 
            this.comboBox1geri.FormattingEnabled = true;
            this.comboBox1geri.Items.AddRange(new object[] {
            "Hasarlı",
            "Hasarsız"});
            this.comboBox1geri.Location = new System.Drawing.Point(264, 140);
            this.comboBox1geri.Name = "comboBox1geri";
            this.comboBox1geri.Size = new System.Drawing.Size(141, 24);
            this.comboBox1geri.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = global::kutuphane_otomasyon.Properties.Resources.check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(185, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 75);
            this.button1.TabIndex = 37;
            this.button1.Text = "Tamam";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = global::kutuphane_otomasyon.Properties.Resources.close;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(310, 255);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 75);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.Text = "İptal";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.comboBox1geri);
            this.Controls.Add(this.textBox2kitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1UyeAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "Emanet Teslim";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1UyeAd;
        public System.Windows.Forms.TextBox textBox2kitapAd;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1geri;
    }
}