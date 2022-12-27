using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormShplndrmeEkle : Form
    {
        public FormShplndrmeEkle()
        {
            InitializeComponent();

        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                
                  pictureBox1.Load(openFileDialog1.FileName);
            

        }

        public static ComboBox cmbYas;
        public static ComboBox cmbCins;
        public static string fpath;

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);

                cmd.Parameters.AddWithValue("@tur", comboBoxTur.Text);
                cmd.Parameters.AddWithValue("@yas", comboBoxYas.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", comboBoxCinsiyet.Text);
                cmd.Parameters.AddWithValue("@image", path);
                fpath = path;
                cmbYas = comboBoxYas;
                cmbCins = comboBoxCinsiyet;

                cmd.CommandText = "insert into Sahiplendirme (tur, yas, cinsiyet, imgpath) values (@tur, @yas, @cinsiyet,@image)";

                cmd.ExecuteNonQuery();

                con.Close();

                UserControlSahiplendirme uc = new UserControlSahiplendirme();
                FormSahiplendirme.flp.Controls.Add(uc);

                MessageBox.Show("Kayıt oluşturuldu.");
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void FormShplndrmeGncl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnFotoSec_MouseEnter(object sender, EventArgs e)
        {
            btnFotoSec.ForeColor = Color.White;
            btnFotoSec.FlatAppearance.BorderColor = Color.White;
        }
        private void btnFotoSec_MouseLeave(object sender, EventArgs e)
        {
            btnFotoSec.ForeColor = Color.FromArgb(119, 54, 142);
            btnFotoSec.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
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
    }
}
