using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormHatir : Form
    {
        public FormHatir()
        {
            InitializeComponent();
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
           this.Hide();
        }

        private void btnMail_MouseEnter(object sender, EventArgs e)
        {
            btnMail.ForeColor = Color.White;
            btnMail.FlatAppearance.BorderColor = Color.White;
        }

        private void btnMail_MouseLeave(object sender, EventArgs e)
        {
            btnMail.ForeColor = Color.FromArgb(119, 54, 142);
            btnMail.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select *From Admin where ad_soyad='" + txtKul.Text + "'And email='" + txtEmail.Text.ToString() + "'");
                con.Open();
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    SmtpClient smtpserver = new SmtpClient();       //SMTP: e-posta göndermek için sunucu ile istemci arasındaki iletişim şeklini belirleyen protokol
                    MailMessage mail = new MailMessage();

                    string gonderen = "ilaydaglba@gmail.com";
                    string gndrensif = "mutfak13";

                    smtpserver.Port = 587;          //gmail için port
                    smtpserver.Host = "smtp.gmail.com";
                    smtpserver.EnableSsl = true;        //Ssl: kullanılan server ve internet tarayıcısı arasında yapılan tüm işlemleri şifreleyerek koruma altına alır ve bilgilerin üçüncü kişilerin eline geçmesini engeller
                    smtpserver.Credentials = new NetworkCredential(gonderen, gndrensif);

                    mail.From = new MailAddress(gonderen);
                    mail.To.Add(dr["email"].ToString());
                    mail.Subject = "Şifre Hatırlatma Maili";
                    mail.Body = "Sayın " + dr["ad_soyad"] + ",\nBizden " + DateTime.Now.ToLongDateString() + " tarihinde şifre hatırlatma talebinde bulundunuz. Şifreniz: " + dr["sifre"] + "\nİyi günler dileriz.\nPetEvim";

                    smtpserver.Send(mail);
                    con.Close();
                    MessageBox.Show("Mailiniz gönderildi.");
                }
                else
                    MessageBox.Show("Hatalı ad soyad veya e-mail adresi girdiniz.");

            }
            catch (Exception er) { MessageBox.Show("" + er.Message); }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
