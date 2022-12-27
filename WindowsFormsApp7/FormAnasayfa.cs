using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormAnasayfa : Form
    {
        int hgun, ay, g;
        public FormAnasayfa()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            ay = now.Month;
            hgun = now.Day;
            lblAy.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);
            lblHaftaGunu.Text = CultureInfo.CurrentCulture.DateTimeFormat.DayNames[hgun];
            g = DateTime.Today.Day;
            lblgun.Text = g.ToString();
            kayitgetir();
            designDataGridView();
            petSay();
        }
        private void kayitgetir()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Randevu where tarih=@trh order by saat asc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@trh", g + "." + ay + "." + DateTime.Now.Year);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void petSay()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
                string che = @"(select count(*) from Petler)";
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                SqlCommand cmda = new SqlCommand(che, con);
                int sayac = (int)cmda.ExecuteScalar();
                lblSayi.Text = sayac.ToString();
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
    }


}
