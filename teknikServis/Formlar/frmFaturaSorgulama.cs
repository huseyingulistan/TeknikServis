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
    public partial class frmFaturaSorgulama : Form
    {
        public frmFaturaSorgulama()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmFaturaSorgulama_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtFaturaId.Text);
                var degerler = (from u in db.tblFaturaDetay
                                select new
                                {
                                    u.FaturaDetayId,
                                    u.Urun,
                                    u.Adet,
                                    u.Fiyat,
                                    u.Tutar,
                                    u.FaturaId
                                }).Where(x => x.FaturaId == id);
                gridControl1.DataSource = degerler.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Yeniden Deneyiniz.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
