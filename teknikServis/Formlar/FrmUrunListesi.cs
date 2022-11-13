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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        void method1()
        {
            var degerler = from u in db.tblUrun
                          select new
                          {
                              u.ID,
                              u.Adi,
                              u.Marka,
                              u.Stok,
                              u.AlisFiyat,
                              u.SatisFiyat,
                             Kategori=u.tblKategori.Adi
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //Listeleme ToList add remove 
            method1();
             lookUpEdit1.Properties.DataSource = db.tblKategori.ToList();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tblUrun t = new tblUrun();
                t.Adi = txtUrunAdi.Text;
                t.Marka = txtMarka.Text;
                t.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                t.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                t.Stok = short.Parse(txtStok.Text);
                t.Durum = false;
                t.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.tblUrun.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarı ile kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün kayıt edilemedi bir hata oluştu","Hata mesajı", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            method1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
            txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlisFiyat").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatisFiyat").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtUrunId.Text);
                var deger = db.tblUrun.Find(id);
                db.tblUrun.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla silindi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                int id = int.Parse(txtUrunId.Text);
                var deger = db.tblUrun.Find(id);
                deger.Adi = txtUrunAdi.Text;
                deger.Stok = short.Parse(txtStok.Text);
                deger.Marka = txtMarka.ToString();
                deger.AlisFiyat = decimal.Parse(txtAlisFiyat.Text);
                deger.SatisFiyat = decimal.Parse(txtSatisFiyat.Text);
                deger.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla Güncellendi!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu Lütfen tekrar deneyiniz!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
    }
}
