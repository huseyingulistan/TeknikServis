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
    public partial class frmYeniArizaliUrunKaydi : Form
    {
        public frmYeniArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                tblUrunKabul u = new tblUrunKabul();
                u.Cari = int.Parse(lookUpEdit1.EditValue.ToString());
                u.Personel = short.Parse(lookUpEdit2.EditValue.ToString());
                u.GelisTarihi = DateTime.Parse(txtTarih.Text);
              //  u.UrunSeriNo = txtSeriNo.Text;
               // u.UrunDurumDetay = "Ürün Kayıt Oldu";
                db.tblUrunKabul.Add(u);
                db.SaveChanges();
                MessageBox.Show("Ürün Arıza Girişi Başarı ile Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmYeniArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //müşteri
            lookUpEdit1.Properties.DataSource = (from x in db.tblCari
                                                 select new
                                                 {
                                                     x.ID,
                                                     Adi = x.Adi + " " + x.Soyadi

                                                 }).ToList();

            //Personel
            lookUpEdit2.Properties.DataSource = (from y in db.tblPersonel
                                                 select new
                                                 {
                                                     y.ID,
                                                     Adi = y.Adi + " " + y.Soyadı

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
    }
}
