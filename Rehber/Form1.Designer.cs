namespace Rehber
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.tbGorevYeri = new System.Windows.Forms.ComboBox();
            this.tbUnvani = new System.Windows.Forms.ComboBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnAramaModu = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDahiliNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCepTelefonu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGorevYeri = new System.Windows.Forms.RadioButton();
            this.tbfadsoyad = new System.Windows.Forms.TextBox();
            this.rdDahiliNo = new System.Windows.Forms.RadioButton();
            this.rdCep = new System.Windows.Forms.RadioButton();
            this.rdUnvani = new System.Windows.Forms.RadioButton();
            this.rdSoyadi = new System.Windows.Forms.RadioButton();
            this.rdAdi = new System.Windows.Forms.RadioButton();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 390);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbox.Controls.Add(this.tbGorevYeri);
            this.gbox.Controls.Add(this.tbUnvani);
            this.gbox.Controls.Add(this.btnKapat);
            this.gbox.Controls.Add(this.btnAramaModu);
            this.gbox.Controls.Add(this.btnSil);
            this.gbox.Controls.Add(this.btnIptal);
            this.gbox.Controls.Add(this.btnGuncelle);
            this.gbox.Controls.Add(this.btnEkle);
            this.gbox.Controls.Add(this.label6);
            this.gbox.Controls.Add(this.tbDahiliNo);
            this.gbox.Controls.Add(this.label5);
            this.gbox.Controls.Add(this.tbCepTelefonu);
            this.gbox.Controls.Add(this.label4);
            this.gbox.Controls.Add(this.label3);
            this.gbox.Controls.Add(this.tbSoyadi);
            this.gbox.Controls.Add(this.label2);
            this.gbox.Controls.Add(this.tbAdi);
            this.gbox.Controls.Add(this.label1);
            this.gbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbox.Location = new System.Drawing.Point(13, 407);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(800, 193);
            this.gbox.TabIndex = 1;
            this.gbox.TabStop = false;
            this.gbox.Text = "Kayıt İşlemleri";
            // 
            // tbGorevYeri
            // 
            this.tbGorevYeri.FormattingEnabled = true;
            this.tbGorevYeri.Location = new System.Drawing.Point(101, 158);
            this.tbGorevYeri.Name = "tbGorevYeri";
            this.tbGorevYeri.Size = new System.Drawing.Size(167, 21);
            this.tbGorevYeri.TabIndex = 5;
            // 
            // tbUnvani
            // 
            this.tbUnvani.FormattingEnabled = true;
            this.tbUnvani.Location = new System.Drawing.Point(101, 79);
            this.tbUnvani.Name = "tbUnvani";
            this.tbUnvani.Size = new System.Drawing.Size(167, 21);
            this.tbUnvani.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(429, 126);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(116, 44);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "&Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAramaModu
            // 
            this.btnAramaModu.Location = new System.Drawing.Point(429, 26);
            this.btnAramaModu.Name = "btnAramaModu";
            this.btnAramaModu.Size = new System.Drawing.Size(116, 44);
            this.btnAramaModu.TabIndex = 8;
            this.btnAramaModu.Text = "Arama Modunu Aç";
            this.btnAramaModu.UseVisualStyleBackColor = true;
            this.btnAramaModu.Click += new System.EventHandler(this.btnAramaModu_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(307, 126);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 44);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(307, 76);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 44);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "&Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(307, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 44);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "&Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Görev Yeri";
            // 
            // tbDahiliNo
            // 
            this.tbDahiliNo.Location = new System.Drawing.Point(101, 132);
            this.tbDahiliNo.Name = "tbDahiliNo";
            this.tbDahiliNo.Size = new System.Drawing.Size(167, 20);
            this.tbDahiliNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dahili No";
            // 
            // tbCepTelefonu
            // 
            this.tbCepTelefonu.Location = new System.Drawing.Point(101, 106);
            this.tbCepTelefonu.Name = "tbCepTelefonu";
            this.tbCepTelefonu.Size = new System.Drawing.Size(167, 20);
            this.tbCepTelefonu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cep Telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ünvanı";
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Location = new System.Drawing.Point(101, 54);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(167, 20);
            this.tbSoyadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(101, 28);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(167, 20);
            this.tbAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGorevYeri);
            this.groupBox1.Controls.Add(this.tbfadsoyad);
            this.groupBox1.Controls.Add(this.rdDahiliNo);
            this.groupBox1.Controls.Add(this.rdCep);
            this.groupBox1.Controls.Add(this.rdUnvani);
            this.groupBox1.Controls.Add(this.rdSoyadi);
            this.groupBox1.Controls.Add(this.rdAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 43);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriteri";
            this.groupBox1.Visible = false;
            // 
            // rdGorevYeri
            // 
            this.rdGorevYeri.AutoSize = true;
            this.rdGorevYeri.Location = new System.Drawing.Point(682, 16);
            this.rdGorevYeri.Name = "rdGorevYeri";
            this.rdGorevYeri.Size = new System.Drawing.Size(113, 17);
            this.rdGorevYeri.TabIndex = 12;
            this.rdGorevYeri.TabStop = true;
            this.rdGorevYeri.Text = "Görev Yerine Göre";
            this.rdGorevYeri.UseVisualStyleBackColor = true;
            // 
            // tbfadsoyad
            // 
            this.tbfadsoyad.Location = new System.Drawing.Point(7, 16);
            this.tbfadsoyad.Name = "tbfadsoyad";
            this.tbfadsoyad.Size = new System.Drawing.Size(147, 20);
            this.tbfadsoyad.TabIndex = 10;
            this.tbfadsoyad.TextChanged += new System.EventHandler(this.tbfadsoyad_TextChanged);
            // 
            // rdDahiliNo
            // 
            this.rdDahiliNo.AutoSize = true;
            this.rdDahiliNo.Location = new System.Drawing.Point(569, 16);
            this.rdDahiliNo.Name = "rdDahiliNo";
            this.rdDahiliNo.Size = new System.Drawing.Size(107, 17);
            this.rdDahiliNo.TabIndex = 13;
            this.rdDahiliNo.TabStop = true;
            this.rdDahiliNo.Text = "Dahili No\'ya Göre";
            this.rdDahiliNo.UseVisualStyleBackColor = true;
            // 
            // rdCep
            // 
            this.rdCep.AutoSize = true;
            this.rdCep.Location = new System.Drawing.Point(436, 15);
            this.rdCep.Name = "rdCep";
            this.rdCep.Size = new System.Drawing.Size(127, 17);
            this.rdCep.TabIndex = 14;
            this.rdCep.TabStop = true;
            this.rdCep.Text = "Cep Telefonuna Göre";
            this.rdCep.UseVisualStyleBackColor = true;
            // 
            // rdUnvani
            // 
            this.rdUnvani.AutoSize = true;
            this.rdUnvani.Location = new System.Drawing.Point(341, 15);
            this.rdUnvani.Name = "rdUnvani";
            this.rdUnvani.Size = new System.Drawing.Size(89, 17);
            this.rdUnvani.TabIndex = 15;
            this.rdUnvani.TabStop = true;
            this.rdUnvani.Text = "Ünvana Göre";
            this.rdUnvani.UseVisualStyleBackColor = true;
            // 
            // rdSoyadi
            // 
            this.rdSoyadi.AutoSize = true;
            this.rdSoyadi.Location = new System.Drawing.Point(248, 15);
            this.rdSoyadi.Name = "rdSoyadi";
            this.rdSoyadi.Size = new System.Drawing.Size(87, 17);
            this.rdSoyadi.TabIndex = 16;
            this.rdSoyadi.TabStop = true;
            this.rdSoyadi.Text = "Soyada Göre";
            this.rdSoyadi.UseVisualStyleBackColor = true;
            // 
            // rdAdi
            // 
            this.rdAdi.AutoSize = true;
            this.rdAdi.Checked = true;
            this.rdAdi.Location = new System.Drawing.Point(172, 16);
            this.rdAdi.Name = "rdAdi";
            this.rdAdi.Size = new System.Drawing.Size(70, 17);
            this.rdAdi.TabIndex = 17;
            this.rdAdi.TabStop = true;
            this.rdAdi.Text = "Ada Göre";
            this.rdAdi.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(429, 76);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(116, 44);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.TextBox tbCepTelefonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDahiliNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnAramaModu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGorevYeri;
        private System.Windows.Forms.RadioButton rdDahiliNo;
        private System.Windows.Forms.RadioButton rdCep;
        private System.Windows.Forms.RadioButton rdUnvani;
        private System.Windows.Forms.RadioButton rdSoyadi;
        private System.Windows.Forms.RadioButton rdAdi;
        private System.Windows.Forms.TextBox tbfadsoyad;
        private System.Windows.Forms.ComboBox tbUnvani;
        private System.Windows.Forms.ComboBox tbGorevYeri;
        private System.Windows.Forms.Button btnIptal;
    }
}

