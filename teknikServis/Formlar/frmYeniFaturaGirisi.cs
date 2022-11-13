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
    public partial class frmYeniFaturaGirisi : Form
    {
        public frmYeniFaturaGirisi()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmYeniFaturaGirisi_Load(object sender, EventArgs e)
        {
            txtCari.Properties.DataSource = (from x in db.tblCari
                                             select new
                                             {
                                                 x.ID,
                                                 Ad = x.Adi + " " + x.Soyadi
                                             }).ToList();
            txtPersonel.Properties.DataSource = (from x in db.tblPersonel
                                                 select new
                                                 {
                                                     x.ID,
                                                     Ad = x.Adi + " " + x.Soyadı
                                                 }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tblFaturaBilgi f = new tblFaturaBilgi();
                f.Seri = txtSeri.Text;
                f.SiraNo = txtSiraNo.Text;
                f.Tarih = Convert.ToDateTime(txtTarih.Text);
                f.Saat = txtSaat.Text;
                f.VergiDaire = txtVergiDairesi.Text;
                f.Cari = int.Parse(txtCari.EditValue.ToString());
                f.Personel = short.Parse(txtPersonel.EditValue.ToString());
                db.tblFaturaBilgi.Add(f);
                db.SaveChanges();
                MessageBox.Show("Fatura Sisteme Kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
