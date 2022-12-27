using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class UserControlDays : UserControl
    {
     public static string static_day;
    public static Label lblD;
        public UserControlDays()
        {
            InitializeComponent();

            timer1.Start();
        }

        public void days(int numday)
        {
            lblDays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
            static_day = lblDays.Text;
            lblD = lblDays;
            FormRandData gecis = new FormRandData();
            gecis.Show();
        }

        private void DisplayEvent()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Bilgiler;Integrated Security=True");
               SqlCommand cmd = new SqlCommand("Select *From Randevu where tarih=@trh");
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@trh",lblDays.Text+"."+FormRandevu.a+"."+FormRandevu.y);
              SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblEvent.Text = dr["aciklama"].ToString();
                    
                }
                dr.Dispose();
                cmd.Dispose();




                con.Close();
            }
            catch (Exception er) { MessageBox.Show("Bir hata meydana geldi. " + er.Message); }
        }

        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(190, 174, 220);
            lblDays.ForeColor = Color.White;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            lblDays.ForeColor = Color.FromArgb(119, 54, 142);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayEvent();
        }
    }
}
