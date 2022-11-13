using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmUrunListesi fr;
        private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr==null || fr.IsDisposed)
            {
                fr= new Formlar.FrmUrunListesi();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        Formlar.frmYeniUrun fr1;
        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1== null || fr.IsDisposed)
            {
                fr1 = new Formlar.frmYeniUrun();
                fr1.Show();
            }
        }
        Formlar.frmKategori fr2;
        private void btnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2== null || fr2.IsDisposed)
            {
                fr2 = new Formlar.frmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }
        Formlar.frmYeniKategori fr3;
        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.frmYeniKategori();
                fr3.Show();
            }

        }
        
        private void btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        Formlar.frmCariListesi fr4;
        private void btnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.frmCariListesi();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        Formlar.frmCariEkle fr5;
        private void btnCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.frmCariEkle();
                fr5.Show();
            }
        }
        Formlar.frmDepartmanListesi fr6;
        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.frmDepartmanListesi();
                fr6.MdiParent = this;
                fr6.Show();
            }

        }
        Formlar.frmYeniDepartman fr7;
        private void btnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.frmYeniDepartman();
                fr7.Show();
            }
        }
        Formlar.frmPersonelListesi fr8;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.frmPersonelListesi();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        private void btnHesapmakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.frmDovizKurları fr9;
        private void btnDoviz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.frmDovizKurları();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
        }
        Formlar.btnHaberler fr10;
        private void btnHaberler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.btnHaberler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        private void btnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("EN KISA ZAMANDA GELİŞTİRİCİLER TARAFINDAN SİZE ULAŞILACAKTIR.", "BİLGİLENDİRME ", MessageBoxButtons.OK);
        }

        Formlar.frmYeniPersonel fr11;
        private void btnYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11= new Formlar.frmYeniPersonel();
                fr11.Show();
            }
        }
        Formlar.frmArizaListesi fr12;
        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.frmArizaListesi();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
        Formlar.frmUrunSatis fr13;
        private void btnYeniUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new Formlar.frmUrunSatis();
                fr13.Show();
            }

        }
        Formlar.frmSatisListesi fr14;
        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.frmSatisListesi();
                fr14.MdiParent = this;
                fr14.Show();
            }

        }
        Formlar.frmYeniArizaliUrunKaydi fr15;
        private void btnYeniArizalıUrunKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.frmYeniArizaliUrunKaydi();
                fr15.Show();
            }

        }
        Formlar.frmYeniFaturaGirisi fr16;
        private void btnYeniFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.frmYeniFaturaGirisi();
                fr16.Show();
            }
        }
        Formlar.frmFaturaKalem fr17;
        private void btnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {
                fr17 = new Formlar.frmFaturaKalem();
                fr17.MdiParent = this;
                fr17.Show();
            }


        }
        Formlar.frmFaturaSorgulama fr18;
        private void btnFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.frmFaturaSorgulama();
                fr18.MdiParent = this;
                fr18.Show();
            }

        }
        Formlar.frmMail fr19;
        private void btnYeniMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {
                fr19 = new Formlar.frmMail();
                fr19.Show();
            }

        }
        Formlar.frmAnasayfa fr20;
        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)
            {
                fr20 = new Formlar.frmAnasayfa();
                fr20.MdiParent = this;
                fr20.Show();
            }

        }
        Formlar.frmAnasayfa fr21;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr21== null || fr21.IsDisposed)
            {
                fr21 = new Formlar.frmAnasayfa();
                fr21.MdiParent = this;
                fr21.Show();
            }
        }
    }
}
