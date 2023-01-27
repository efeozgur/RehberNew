using Rehber.SINIFLAR;
using Rehber.VALIDATORS;
using System;

using System.Windows.Forms;
using System.Linq;

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RehberDal rehberdal = new RehberDal();
        UnvanDal unvandal = new UnvanDal();
        GorevYeriDal gorevyeridal = new GorevYeriDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile()
        {
            foreach (var item in unvandal.GetAll())
            {
                tbUnvani.Items.Add(item.Unvani);
            }
            foreach (var item in gorevyeridal.GetAll())
            {
                tbGorevYeri.Items.Add(item.gorevyaptigiyer);
            }
            
            dataGridView1.DataSource = rehberdal.GetAll();
        }

        public void temizle(Control[] control)
        {
            foreach (var item in control)
            {
                item.Text = "";
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            RehberValidator rv = new RehberValidator();

            SINIFLAR.Rehber rehber = new SINIFLAR.Rehber
            {
                Adi = tbAdi.Text,
                Soyadi = tbSoyadi.Text,
                CepTelefonu = tbCepTelefonu.Text,
                DahiliNo = tbDahiliNo.Text,
                GorevYeri = tbGorevYeri.Text,
                Unvani = tbUnvani.Text
            };
            var sonuc = rv.Validate(rehber);

            if (sonuc.IsValid)
            {
                rehberdal.Add(rehber);
                Yenile();

                Control[] controls = { tbAdi, tbSoyadi, tbCepTelefonu, tbDahiliNo, tbGorevYeri, tbUnvani };
                temizle(controls);
                tbAdi.Focus();
                MessageBox.Show("Kayıt Yapıldı!");

            }
            else
            {
                foreach (var item in sonuc.Errors)
                {
                    MessageBox.Show(item.ErrorMessage);
                }
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnAramaModu_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
                btnAramaModu.Text = "Arama Modunu Kapat";
                dataGridView1.Size = new System.Drawing.Size(801, 340);
            }
            else
            {
                groupBox1.Visible = false;
                btnAramaModu.Text = "Arama Modunu Aç";
                dataGridView1.Size = new System.Drawing.Size(801, 390);
                Yenile();
            }
        }


        private void tbfadsoyad_TextChanged(object sender, EventArgs e)
        {
            if (rdAdi.Checked)
            {
                dataGridView1.DataSource = rehberdal.GetAll().Where(p => p.Adi.ToLower().StartsWith(tbfadsoyad.Text)).ToList();

            }
            else if (rdSoyadi.Checked)
            {
                dataGridView1.DataSource = rehberdal.GetAll().Where(p => p.Soyadi.ToLower().StartsWith(tbfadsoyad.Text)).ToList();
            }
            else if (rdUnvani.Checked)
            {
                dataGridView1.DataSource = rehberdal.GetAll().Where(p => p.Unvani.ToLower().StartsWith(tbfadsoyad.Text)).ToList();
            }
            else if (rdGorevYeri.Checked)
            {
                dataGridView1.DataSource = rehberdal.GetAll().Where(p => p.GorevYeri.ToLower().StartsWith(tbfadsoyad.Text)).ToList();
            }
            else if (rdDahiliNo.Checked)
            {
                dataGridView1.DataSource = rehberdal.GetAll().Where(p => p.DahiliNo.ToLower().StartsWith(tbfadsoyad.Text)).ToList();
            }
            else if (rdCep.Checked)
            {
                dataGridView1.DataSource = rehberdal.GetAll().Where(p => p.CepTelefonu.ToLower().StartsWith(tbfadsoyad.Text)).ToList();
            }

        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            int kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var sonuc = MessageBox.Show((dataGridView1.CurrentRow.Cells[1].Value + " " + dataGridView1.CurrentRow.Cells[2].Value) + " kişisi silinecek! \nEmin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (sonuc == DialogResult.Yes)
            {
                rehberdal.Delete(kimlik);
                Yenile();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnGuncelle.Enabled == false)
            {
                tbAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tbUnvani.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tbCepTelefonu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tbDahiliNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tbGorevYeri.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                btnGuncelle.Enabled = true;
                btnEkle.Enabled = false;
                btnSil.Enabled = false;
                btnKapat.Enabled = false;
                btnAramaModu.Enabled = false;
                btnIptal.Visible = true;
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            rehberdal.Update(new SINIFLAR.Rehber
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Adi = tbAdi.Text,
                Soyadi = tbSoyadi.Text,
                CepTelefonu = tbCepTelefonu.Text,
                DahiliNo = tbDahiliNo.Text,
                GorevYeri = tbGorevYeri.Text,
                Unvani = tbUnvani.Text,
            });
            Control[] controls = { tbAdi, tbSoyadi, tbCepTelefonu, tbDahiliNo, tbGorevYeri, tbUnvani };
            temizle(controls);
            Yenile();

            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
            btnKapat.Enabled = true;
            btnAramaModu.Enabled = true;

            MessageBox.Show("Kayıt Güncellendi");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
            btnKapat.Enabled = true;
            btnAramaModu.Enabled = true;
            btnIptal.Visible = false;
            Control[] controls = { tbAdi, tbSoyadi, tbCepTelefonu, tbDahiliNo, tbGorevYeri, tbUnvani };
            temizle(controls);
        }
    }
}
