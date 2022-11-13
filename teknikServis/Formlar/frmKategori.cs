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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.tblKategori
                           select new
                           {
                               k.ID,
                               k.Adi
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblKategori t = new tblKategori();
            t.Adi = txtAdi.Text;
            db.tblKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarı İle Kayıt Edildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.tblKategori
                           select new
                           {
                               k.ID,
                               k.Adi
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAdi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.tblKategori.Find(id);
                db.tblKategori.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu lütfen tekrar deneyiniz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var deger = db.tblKategori.Find(id);
                deger.Adi = txtAdi.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla Güncellendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu Lütfen tekrar deneyiniz!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
    }
}
