using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormSahiplendirme : Form
    {
        public static FlowLayoutPanel flp;
        public static string s, k, p;
        public FormSahiplendirme()
        {
            InitializeComponent();
            flp = petcontainer;
            doldur();
            kayitgetir();
            dataGridView1.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormShplndrmeEkle gecis = new FormShplndrmeEkle();
            gecis.Show();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
        private void btnPetEkle_Click(object sender, EventArgs e)
        {
            FormShplndrmeEkle gecis = new FormShplndrmeEkle();
            gecis.Show();
        }
        private void btnPetEkle_MouseEnter(object sender, EventArgs e)
        {
            btnPetEkle.ForeColor = Color.White;
            btnPetEkle.FlatAppearance.BorderColor = Color.White;
        }

        private void btnPetEkle_MouseLeave(object sender, EventArgs e)
        {
            btnPetEkle.ForeColor = Color.FromArgb(119, 54, 142);
            btnPetEkle.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }
        private void kayitgetir()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {

                s = Convert.ToString(r.Cells[0].Value);
                k = Convert.ToString(r.Cells[2].Value);
                p = Convert.ToString(r.Cells[3].Value);
                UserControlSahiplendirme uc = new UserControlSahiplendirme();
                petcontainer.Controls.Add(uc);
            }
        }
        private void doldur()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Sahiplendirme", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

