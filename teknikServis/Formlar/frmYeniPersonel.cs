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
    public partial class frmYeniPersonel : Form
    {
        public frmYeniPersonel()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmYeniPersonel_Load(object sender, EventArgs e)
        {
            txtPersonDepartman.Properties.DataSource = (from x in db.tblDepartman
                                                        select new
                                                        {
                                                            x.ID,
                                                            x.Adi
                                                        }).ToList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tblPersonel t = new tblPersonel();
                t.Adi = txtPersonAd.Text;
                t.Soyadı = txtPersonSoyad.Text;
                t.Departman = byte.Parse(txtPersonDepartman.EditValue.ToString());
                t.Mail = txtPersonMail.Text;
                t.Telefon = txtPersonTelefon.Text;
                db.tblPersonel.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Sisteme Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Sistemde bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show(" Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();


            }
            else if (x == DialogResult.No)
            {
                //iptal edildi. 
            }
        }
    }
}
