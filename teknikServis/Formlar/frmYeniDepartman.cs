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
    public partial class frmYeniDepartman : Form
    {
        public frmYeniDepartman()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAdi.Text.Length <= 50 && txtDepartmanAdi.Text != "")
            {
                tblDepartman t = new tblDepartman();
                t.Adi = txtDepartmanAdi.Text;
                db.tblDepartman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kayıt Edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departman Kayıt Edilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
