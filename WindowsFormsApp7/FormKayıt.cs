using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormKayıt : Form
    {
        public FormKayıt()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();
                //SqlCommand cmd = new SqlCommand(kayit,con);  //          yukarıda olsaydı:      string kayit = "insert into Bilgi (kullanici_adi, ad_soyad, telefon) values (@kul_ad, @ad, @telefon)";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@adsyd", txtKul.Text);
                cmd.Parameters.AddWithValue("@eposta", txtMail.Text);
                cmd.Parameters.AddWithValue("@sif", txtSif.Text);

                cmd.CommandText = "insert into Admin (ad_soyad, email, sifre) values (@adsyd, @eposta, @sif)";

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Kayıt oluşturuldu.");
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void btnKayit_MouseEnter(object sender, EventArgs e)
        {
            btnKayit.ForeColor = Color.White;
            btnKayit.FlatAppearance.BorderColor = Color.White;
        }

        private void btnKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKayit.ForeColor = Color.FromArgb(119, 54, 142);
            btnKayit.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKayıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
