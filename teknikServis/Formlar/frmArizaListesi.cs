using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace teknikServis.Formlar
{
    public partial class frmArizaListesi : Form
    {
        public frmArizaListesi()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.tblUrunKabul
                           select new
                           {
                               x.IslemId,
                               Cari = x.tblCari.Adi + " " + x.tblCari.Soyadi,
                               Personel = x.tblPersonel.Adi + " " + x.tblPersonel.Soyadı,
                               x.GelisTarihi,
                               x.CikisTarihi
                              };
            gridControl1.DataSource = degerler.ToList();
                       
            //SqlConnection baglanti = new SqlConnection(@"Data Source=HUSEYIN;Initial Catalog=teknikServis;Integrated Security=True");
            //baglanti.Open();
            //SqlCommand cmd = new SqlCommand("select UrunDurumDetay, COUNT(*) from tblUrunKabul group by UrunDurumDetay ", baglanti);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            //}
            //baglanti.Close();
        }
    }
}
