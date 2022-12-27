using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormBorclar : Form
    {
        public FormBorclar()
        {
            InitializeComponent();
            designDataGridView();
            kayitgetir();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
        private void kayitgetir()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Borclar", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@id", txtid.Text);

                fiyatogren(comboBoxislem.Text, cmd);

                string che = @"select count(*) from Borclar where borc_sahibi_id= @id";

                SqlCommand cmda = new SqlCommand(che, con);
                cmda.Parameters.AddWithValue("@id", txtid.Text);

                int sayac = (int)cmda.ExecuteScalar();

                if (sayac > 0)
                    cmd.CommandText = "Update Borclar Set miktar+=@mik";

                else
                    cmd.CommandText = "insert into Borclar (borc_sahibi_id, miktar) values (@id, @mik)";

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Borç eklendi.");
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void fiyatogren(string s, SqlCommand cmd)
        {
            if (s == "İç Parazit aşısı" || s == "Dış Parazit aşısı")
            {
                cmd.Parameters.AddWithValue("@mik", 100);
            }

            else if (s == "Kedi kısırlaştırma" || s == "Kısırlaştırma diğer")
            {
                cmd.Parameters.AddWithValue("@mik", 900);
            }

            else if (s == "Köpek kısırlaştırma")
            {
                cmd.Parameters.AddWithValue("@mik", 1000);
            }

            else if (s == "Karma aşı" || s == "Kuduz aşısı" || s == "Aşı diğer")
            {
                cmd.Parameters.AddWithValue("@mik", 150);
            }
            else
                cmd.Parameters.AddWithValue("@mik", 200);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int i = Convert.ToInt32(r.Cells[1].Value);
                verisil(i);
                kayitgetir();
            }
        }


        private void verisil(int i)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Borclar where borc_sahibi_id=@id", con);
                cmd.Parameters.AddWithValue("@id", i);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }

        }

        private void btnBorcAzalt_Click(object sender, EventArgs e)
        {
            label1.Text = "Ödenen işlem";
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@id", txtid.Text);

                fiyatogren(comboBoxislem.Text, cmd);

                string che = @"select count(*) from Borclar where borc_sahibi_id= @id";

                SqlCommand cmda = new SqlCommand(che, con);
                cmda.Parameters.AddWithValue("@id", txtid.Text);

                int sayac = (int)cmda.ExecuteScalar();

                if (sayac > 0)
                    cmd.CommandText = "Update Borclar Set miktar-=@mik";

                else
                {
                    MessageBox.Show("Bu kişinin borcu yok.");
                    label1.Text = "Yapılan işlem";
                    con.Close();
                    return;
                }

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Borç silindi.");
                label1.Text = "Yapılan işlem";
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select *from Borclar where borc_sahibi_id=@id", con);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        int i = 0;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            txtid.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBoxislem.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void designDataGridView()
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void btnBorcEkle_MouseEnter(object sender, EventArgs e)
        {
            btnBorcEkle.ForeColor = Color.White;
            btnBorcEkle.FlatAppearance.BorderColor = Color.White;
        }

        private void btnBorcEkle_MouseLeave(object sender, EventArgs e)
        {
            btnBorcEkle.ForeColor = Color.FromArgb(119, 54, 142);
            btnBorcEkle.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnSil_MouseEnter(object sender, EventArgs e)
        {
            btnSil.ForeColor = Color.White;
            btnSil.FlatAppearance.BorderColor = Color.White;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.ForeColor = Color.FromArgb(119, 54, 142);
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnYenile_MouseEnter(object sender, EventArgs e)
        {
            btnYenile.ForeColor = Color.White;
            btnYenile.FlatAppearance.BorderColor = Color.White;
        }

        private void btnYenile_MouseLeave(object sender, EventArgs e)
        {
            btnYenile.ForeColor = Color.FromArgb(119, 54, 142);
            btnYenile.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnAra_MouseEnter(object sender, EventArgs e)
        {
            btnAra.ForeColor = Color.White;
            btnAra.FlatAppearance.BorderColor = Color.White;
        }

        private void btnAra_MouseLeave(object sender, EventArgs e)
        {
            btnAra.ForeColor = Color.FromArgb(119, 54, 142);
            btnAra.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnBorcAzalt_MouseEnter(object sender, EventArgs e)
        {
            btnBorcAzalt.ForeColor = Color.White;
            btnBorcAzalt.FlatAppearance.BorderColor = Color.White;
        }

        private void btnBorcAzalt_MouseLeave(object sender, EventArgs e)
        {
            btnBorcAzalt.ForeColor = Color.FromArgb(119, 54, 142);
            btnBorcAzalt.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }
    }
}
