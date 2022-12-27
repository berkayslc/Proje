using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormVet : Form
    {
        public FormVet()
        {
            InitializeComponent();
            designDataGridView();
            kayitgetir();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
        private void kayitgetir()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Veterinerler", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@isim", txtadsyd.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);

                cmd.CommandText = "insert into Veterinerler (ad_soyad, telefon, unvan) values (@isim, @tel, @unvan)";

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Kayıt oluşturuldu.");
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select *from Veterinerler where ad_soyad=@isim OR telefon=@tel OR unvan=@unvan", con);
                cmd.Parameters.AddWithValue("@isim", txtadsyd.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int i = Convert.ToInt32(r.Cells[0].Value);
                verisil(i);
                kayitgetir();
            }

        }

        private void verisil(int i)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Veterinerler where ad_soyad=@isim", con);
                cmd.Parameters.AddWithValue("@isim", i);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }

        }
        int i = 0;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string kayitguncel = ("Update Veterinerler Set ad_soyad=@isim, telefon=@tel,unvan=@unvan");
                SqlCommand cmd = new SqlCommand(kayitguncel, con);
                cmd.Parameters.AddWithValue("@isim", txtadsyd.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                kayitgetir();
                MessageBox.Show("Kayıt güncellendi.");
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            txtadsyd.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTel.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtUnvan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
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

        private void btnSil_MouseEnter(object sender, EventArgs e)
        {
            btnSil.ForeColor = Color.White;
            btnSil.FlatAppearance.BorderColor = Color.White;
        }

        private void btnSil_Leave(object sender, EventArgs e)
        {
            btnSil.ForeColor = Color.FromArgb(119, 54, 142);
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnGuncelle_MouseEnter(object sender, EventArgs e)
        {
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.FlatAppearance.BorderColor = Color.White;
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGuncelle.ForeColor = Color.FromArgb(119, 54, 142);
            btnGuncelle.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
        }

        private void btnListele_MouseEnter(object sender, EventArgs e)
        {
            btnListele.ForeColor = Color.White;
            btnListele.FlatAppearance.BorderColor = Color.White;
        }

        private void btnListele_MouseLeave(object sender, EventArgs e)
        {
            btnListele.ForeColor = Color.FromArgb(119, 54, 142);
            btnListele.FlatAppearance.BorderColor = Color.FromArgb(119, 54, 142);
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
    }


}
