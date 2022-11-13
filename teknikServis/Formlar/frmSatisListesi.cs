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
    public partial class frmSatisListesi : Form
    {
        public frmSatisListesi()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmSatisListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.tblUrunHareket
                           select new
                           {
                               x.HareketId,
                               x.tblUrun.Adi,
                               Musteri = x.tblCari.Adi + " " + x.tblCari.Soyadi,
                               Personel = x.tblPersonel.Adi + " " + x.tblPersonel.Soyadı,
                               x.Tarih,
                               x.Adet,
                               x.Fiyat,
                              // x.UrunSeriNo
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
