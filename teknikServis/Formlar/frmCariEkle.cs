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
    public partial class frmCariEkle : Form
    {
        public frmCariEkle()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
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
                tblCari t = new tblCari();
                t.Adi = txtCariAdi.Text;
                t.Soyadi = txtCariSoyadi.Text;
                t.Telefon = txtTelefon.Text;
                t.Mail = txtMail.Text;
                t.IL = txtİl.Text;
                t.ILCE = txtİlce.Text;
                t.Banka = txtBanka.Text;
                t.VergiDairesi = txtVergiDairesi.Text;
                t.VergiNo = txtVergiNo.Text;
                t.Statu = txtStatu.Text;
                t.Adres = txtAdres.Text;
                db.tblCari.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Sisteme Başarı Bir Şekilde Kayıt Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
