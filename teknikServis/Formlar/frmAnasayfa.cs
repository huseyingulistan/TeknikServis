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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        void UrunListesi()
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
                               Kategori = u.tblKategori.Adi
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        void musteriListesi()
        {

            gridControl2.DataSource = (from x in db.tblCari
                                       select new
                                       {
                                           x.ID,
                                           x.Adi,
                                           x.Soyadi,
                                           x.IL,
                                           x.ILCE

                                       }).ToList();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            UrunListesi();
            musteriListesi();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            Formlar.frmYeniKategori fr = new Formlar.frmYeniKategori();
            fr.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Formlar.frmYeniPersonel fr = new Formlar.frmYeniPersonel();
            fr.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Formlar.frmYeniUrun fr = new Formlar.frmYeniUrun();
            fr.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Formlar.frmYeniPersonel fr11 = new Formlar.frmYeniPersonel();
            fr11.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Formlar.frmYeniDepartman fr7 = new Formlar.frmYeniDepartman();
            fr7.Show();
        }
    }
}
