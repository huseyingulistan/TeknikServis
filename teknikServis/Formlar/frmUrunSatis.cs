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
    public partial class frmUrunSatis : Form
    {
        public frmUrunSatis()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmUrunSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.tblUrun
                                                 select new
                                                 {
                                                     x.ID,
                                                     Ad = x.Adi + "-" + x.Marka
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.tblCari
                                                 select new
                                                 {
                                                     x.ID,
                                                     Ad = x.Adi + " " + x.Soyadi
                                                 }).ToList();

            lookUpEdit3.Properties.DataSource = (from x in db.tblPersonel
                                                 select new
                                                 {
                                                     x.ID,
                                                     Ad = x.Adi + " " + x.Soyadı
                                                 }).ToList();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                tblUrunHareket h = new tblUrunHareket();
                h.Urun = int.Parse(lookUpEdit1.EditValue.ToString());
                h.Musteri = int.Parse(lookUpEdit2.EditValue.ToString());
                h.Personel = short.Parse(lookUpEdit3.EditValue.ToString());
                h.Tarih = DateTime.Parse(txtTarih.Text);
                h.Adet = short.Parse(txtAdet.Text);
                h.Fiyat = decimal.Parse(txtSatisFiyati.Text);
              //  h.UrunSeriNo = txtSeriNo.Text;
                db.tblUrunHareket.Add(h);
                db.SaveChanges();
                MessageBox.Show("Ürün Satışı Başarı İle Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
