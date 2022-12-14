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
    public partial class frmCariListesi : Form
    {
        public frmCariListesi()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            
            
                gridControl1.DataSource = (from x in db.tblCari
                                           select new
                                           {
                                               x.ID,
                                               x.Adi,
                                               x.Soyadi,
                                               x.IL,
                                               x.ILCE

                                           }).ToList();

            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblCari
                                      select new
                                      {
                                          x.ID,
                                          x.Adi,
                                          x.Soyadi,
                                          x.IL,
                                          x.ILCE

                                      }).ToList();
        }
    }
}
