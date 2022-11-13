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
    public partial class btnHaberler : Form
    {
        public btnHaberler()
        {
            InitializeComponent();
        }

        private void btnHaberler_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bbc.com/turkce/topics/ckdxn2xk95gt");
        }
    }
}
