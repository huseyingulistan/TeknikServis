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
    public partial class frmFaturaKalem : Form
    {
        public frmFaturaKalem()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.tblFaturaDetay
                           select new
                           {
                               u.FaturaDetayId,
                               u.Urun,
                               u.Adet,
                               u.Fiyat,
                               u.Tutar,
                               u.FaturaId
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblFaturaDetay t = new tblFaturaDetay();
           // t.Urun = txtUrunId.Text;
            t.Adet = short.Parse(txtAdet.Text);
            t.Fiyat = decimal.Parse(txtFiyat.Text);
            t.Tutar = decimal.Parse(txtTutar.Text);
            t.FaturaId = int.Parse(txtFaturaId.Text);
            db.tblFaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura ait Kalem Giriş Başarı İle Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.tblFaturaDetay
                           select new
                           {
                               u.FaturaDetayId,
                               u.Urun,
                               u.Adet,
                               u.Fiyat,
                               u.Tutar,
                               u.FaturaId
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
