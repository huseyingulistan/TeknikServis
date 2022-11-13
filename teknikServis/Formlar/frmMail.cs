using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;         // Mail ekleme KÜTÜPHANESİ // 
using System.Net.Mail;   // Mail ekleme KÜTÜPHANESİ // 

namespace teknikServis.Formlar
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        teknikServisEntities db = new teknikServisEntities();
        MailMessage eposta = new MailMessage();
        void MailGonder()
        {
            try
            {
                eposta.From = new MailAddress("huseyinglstn@hotmail.com");
                eposta.To.Add(txtMailAdres.Text.ToString());
                eposta.Subject = txtKonu.Text.ToString();
                eposta.Body = txtİcerik.Text.ToString();

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("huseyinglstn@hotmail.com", "Gmailokul2019.");
                smtp.Host = "smtp.live.com";
                //gmail host ="smtp.gmail.com"
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(eposta);
                MessageBox.Show("Mail Gönderildi", "Bilgilendirme", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Bağlantı Sorunu Veya Sistem Hatası Olabilir. Lütfen Tekrar Deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {

        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
