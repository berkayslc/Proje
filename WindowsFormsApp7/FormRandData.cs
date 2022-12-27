using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormRandData : Form
    {
        public FormRandData()
        {
            InitializeComponent();
            lblgun.Text = UserControlDays.static_day;
            lblAy.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(FormRandevu.a);
            lblYil.Text = FormRandevu.y.ToString();
            designDataGridView();
            kayitgetir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRndEkle_Click(object sender, EventArgs e)
        {
            FormRandKayit gecis = new FormRandKayit();
            gecis.Show();
        }


        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
        private void kayitgetir()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Randevu where tarih=@trh order by saat asc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@trh", UserControlDays.static_day + "." + FormRandevu.a + "." + FormRandevu.y);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int i = Convert.ToInt32(r.Cells[2].Value); //petid ye göre silme
                verisil(i);
                kayitgetir();
            }
        }
        private void verisil(int i)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Randevu where rnd_pet_id=@id", con);
                cmd.Parameters.AddWithValue("@id", i);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }

        }

        private void txtArama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select *from Randevu where rnd_sahibi_id=@shpid OR rnd_pet_id=@petid", con);

                    cmd.Parameters.AddWithValue("@shpid", txtArama.Text);
                    cmd.Parameters.AddWithValue("@petid", txtArama.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
            }
        }

        private void FormRandData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
