using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;   //allows us to use native libraries of os (in this case user32 library)
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public static TextBox tb1;
        public Form1()
        {
            InitializeComponent();

            tb1 = txtKul;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnShowPw_Click(object sender, EventArgs e)
        {
            if (txtSif.PasswordChar == '*')
            {
                btnHidePw.BringToFront();
                txtSif.PasswordChar = '\0';
            }
        }

        private void btnHidePw_Click(object sender, EventArgs e)
        {
            if (txtSif.PasswordChar == '\0')
            {
                btnShowPw.BringToFront();
                txtSif.PasswordChar = '*';
            }
        }
        private void btnGiris_MouseEnter(object sender, EventArgs e)
        {
            btnGiris.ForeColor = Color.White;
            btnGiris.FlatAppearance.BorderColor = Color.White;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.ForeColor = Color.FromArgb(119, 54, 142);
            btnGiris.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
                cmd = new SqlCommand("Select *From Admin where ad_soyad='" + txtKul.Text + "'And sifre='" + txtSif.Text + "'");
                con.Open();
                cmd.Connection = con;   //yukarıdaki baglantiyi al aldıgın baglantıyı da komut satırının baglantısına ekle
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Girişiniz başarılı.");

                    FormHosgeldiniz gecis = new FormHosgeldiniz();
                    gecis.Show();
                    this.Hide();

                }

                else
                    MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış. Lütfen tekrar deneyin.");

                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void lblUnuttum_Click(object sender, EventArgs e)
        {
            FormHatir gecis = new FormHatir();
            gecis.Show();
            this.Hide();
        }

  
        private void label4_Click(object sender, EventArgs e)
        {
            FormKayıt gecis = new FormKayıt();
            gecis.Show();
            this.Hide();
        }


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(119, 54, 142);

        }
        private void lblUnuttum_MouseEnter(object sender, EventArgs e)
        {
            lblUnuttum.ForeColor = Color.Red;
            panel3.BackColor = Color.Red;
        }

        private void lblUnuttum_MouseLeave(object sender, EventArgs e)
        {
            lblUnuttum.ForeColor = Color.FromArgb(119, 54, 142);
            panel3.BackColor = Color.FromArgb(119, 54, 142);
        }

    }
}
