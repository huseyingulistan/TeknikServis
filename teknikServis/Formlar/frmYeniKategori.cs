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
    public partial class frmYeniKategori : Form
    {
        public frmYeniKategori()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblKategori t = new tblKategori();
            t.Adi = txtKategoriAdi.Text;
            db.tblKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarı İle Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtKategoriAdi_Click(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = "";
            txtKategoriAdi.Focus();
        }
    }
}
