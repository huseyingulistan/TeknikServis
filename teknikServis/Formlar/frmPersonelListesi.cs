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
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }
        void listele()
        {
            var degerler = from u in db.tblPersonel
                           select new
                           {
                               u.ID,
                               u.Adi,
                               u.Soyadı,
                               u.Mail,
                               u.Telefon
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        teknikServisEntities db = new teknikServisEntities();
            private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    listele();
            //    txtDepartman.Properties.DataSource = (from x in db.tblDepartman
            //                                                select new
            //                                                {
            //                                                    x.ID,
            //                                                    x.Adi
            //                                                }).ToList();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Sistemde bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                tblPersonel t = new tblPersonel();
                t.Adi = txtPersonAd.Text;
                t.Soyadı = txtPersonSoyad.Text;
                // t.Departman = byte.Parse(txtDepartman.Text);
                db.tblPersonel.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Sisteme Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Sistemde bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtPersonId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtPersonAd.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
                txtPersonSoyad.Text = gridView1.GetFocusedRowCellValue("Soyadı").ToString();
                //txtDepartman.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
                txtPersonTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            }
            catch (Exception)
            {

                //MessageBox.Show("hata");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtPersonId.Text);
                var deger = db.tblPersonel.Find(Id);
                db.tblPersonel.Remove(deger);
                db.SaveChanges();
                DialogResult x = MessageBox.Show("Bu Personeli Silmek İstediğinize Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {

                    MessageBox.Show("Personel Başarıyla Silindi");

                }
                else if (x == DialogResult.No)
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }

                listele();

            }
            catch (Exception)
            {
                MessageBox.Show("Sistemde bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtPersonId.Text);
                var deger = db.tblPersonel.Find(Id);
                deger.Adi = txtPersonAd.Text;
                db.SaveChanges();
                MessageBox.Show("Personel Başarı İle Güncellendi.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Sistemde bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtPersonId.Text = "";
            txtPersonAd.Text = "";
            txtPersonSoyad.Text = "";
            txtPersonAd.Text = "";
            txtPersonMail.Text = "";
            txtPersonTelefon.Text = "";
        }
    }
}
