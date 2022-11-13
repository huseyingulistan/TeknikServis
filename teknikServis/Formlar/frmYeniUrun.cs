using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikServis.Formlar
{
    public partial class frmYeniUrun : Form
    {
        public frmYeniUrun()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.tblKategori
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.Adi  

                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show(" Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();


            }
            else if (x == DialogResult.No)
            {
                //iptal edildi. 
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                tblUrun t = new tblUrun();
                t.Adi= txtUrunAdi.Text;
                t.Marka = txtMarka.Text;
                t.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                t.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                t.Stok = short.Parse(txtStok.Text);
                t.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.tblUrun.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürünler Başarı ile kaydedildi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUrunAdi_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtUrunAdi.Focus();
        }

        private void txtMarka_Click(object sender, EventArgs e)
        {
            txtMarka.Text = "";
            txtMarka.Focus();
        }

        private void txtAlisFiyat_Click(object sender, EventArgs e)
        {
            txtAlisFiyat.Text = "";
            txtAlisFiyat.Focus();
        }

        private void txtSatisFiyat_Click(object sender, EventArgs e)
        {
            txtSatisFiyat.Text = "";
            txtSatisFiyat.Focus();
        }

        private void txtStok_Click(object sender, EventArgs e)
        {
            txtStok.Text = "";
            txtStok.Focus();
        }
    }
}
