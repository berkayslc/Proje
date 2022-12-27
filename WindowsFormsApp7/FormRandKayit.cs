
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormRandKayit : Form
    {
        public FormRandKayit()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
                string che = @"(select count(*) from Randevu where saat='" + comboBoxSaat.Text + "AND tarih=@trh')";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                SqlCommand cmda = new SqlCommand(che, con);
                int sayac = (int)cmda.ExecuteScalar();
                cmd.Parameters.AddWithValue("@trh", UserControlDays.static_day + "." + FormRandevu.a + "." + FormRandevu.y);
                if (sayac > 0)
                    MessageBox.Show("Bu saat dolu. Lütfen yeni bir saat seçin.");
                
                else
                {
                    cmd.Parameters.AddWithValue("@saat", comboBoxSaat.Text);
                    cmd.Parameters.AddWithValue("@petid", txtpet.Text);
                    cmd.Parameters.AddWithValue("@sahipid", txtshp.Text);
                    cmd.Parameters.AddWithValue("@vetad", comboBoxVet.Text);
                    cmd.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
                    cmd.Parameters.AddWithValue("@tarih", UserControlDays.static_day + "." + FormRandevu.a + "." + FormRandevu.y);

                    cmd.CommandText = "insert into Randevu (saat, rnd_pet_id, rnd_sahibi_id, veteriner_adsoyad, aciklama, tarih) values (@saat, @petid, @sahipid, @vetad, @aciklama,@tarih)";

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Randevu kaydı oluşturuldu.");
                }
            }

            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKaydet_MouseEnter(object sender, EventArgs e)
        {
            btnKaydet.ForeColor = Color.White;
            btnKaydet.FlatAppearance.BorderColor = Color.White;
        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            btnKaydet.ForeColor = Color.FromArgb(119, 54, 142);
            btnKaydet.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void FormRandKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
