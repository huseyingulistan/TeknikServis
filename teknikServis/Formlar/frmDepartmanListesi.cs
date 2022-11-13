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
    public partial class frmDepartmanListesi : Form
    {
        public frmDepartmanListesi()
        {
            InitializeComponent();
        }
        void listele()
        {
            var degerler = from u in db.tblDepartman
                           select new
                           {
                               u.ID,
                               u.Adi,
                               u.Aciklama
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmDepartmanListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepartmanAdı.Text.Length <= 50 && txtDepartmanAdı.Text != "")
                {
                    tblDepartman t = new tblDepartman();
                    t.Adi = txtDepartmanAdı.Text;
                    t.Aciklama = txtAciklama.Text;
                    db.tblDepartman.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Departman Kayıt Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                else
                {
                    MessageBox.Show("Departman Kayıt Edilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtDepartmanId.Text);
                var deger = db.tblDepartman.Find(Id);
                db.tblDepartman.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Departman Başarı İle Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtDepartmanId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtDepartmanAdı.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtDepartmanId.Text);
                var deger = db.tblDepartman.Find(Id);
                deger.Adi = txtDepartmanAdı.Text;
                deger.Aciklama = txtAciklama.Text;
                db.SaveChanges();
                MessageBox.Show("Departman Başarı İle Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
