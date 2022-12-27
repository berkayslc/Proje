using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormRandevu : Form
    {
        int ay, yil;

        public static int a, y;


        public FormRandevu()
        {
            InitializeComponent();
            displayDays();
        }


        private void displayDays()
        {

            DateTime now = DateTime.Now;
            ay = now.Month;
            yil = now.Year;

            a = ay;
            y = yil;

            String ayAdi = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);

            lbltrih.Text = ayAdi + " " + yil;

            DateTime aybasi = new DateTime(yil, ay, 1);
            int days = DateTime.DaysInMonth(yil, ay); //aydaki gün sayısı
            int dayoftheweek = Convert.ToInt32(aybasi.DayOfWeek.ToString("d")) - 1;     //pazar ise 0-1 çıkıyor
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBosluk uc = new UserControlBosluk();
                daycontainer.Controls.Add(uc);
            }
            if (dayoftheweek == -1)
            {
                for (int i = 0; i < 6; i++) //başta dayofthe week i 1 azalttığımız için zaten 1 boşluk eklemişti
                {
                    UserControlBosluk uc = new UserControlBosluk();
                    daycontainer.Controls.Add(uc);
                }
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays uc2 = new UserControlDays();
                uc2.days(i);
                daycontainer.Controls.Add(uc2);
            }

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (ay == 1)
            {
                ay = 12;
                yil--;
            }
            ay--;
            a = ay;
            y = yil;

            daycontainer.Controls.Clear();
            String ayAdi = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);

            lbltrih.Text = ayAdi + " " + yil;

            DateTime aybasi = new DateTime(yil, ay, 1);
            int days = DateTime.DaysInMonth(yil, ay); //aydaki gün sayısı
            int dayoftheweek = Convert.ToInt32(aybasi.DayOfWeek.ToString("d")) - 1;
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBosluk uc = new UserControlBosluk();
                daycontainer.Controls.Add(uc);
            }

            if (dayoftheweek == -1)
            {
                for (int i = 0; i < 6; i++) //başta dayofthe week i 1 azalttığımız için zaten 1 eklemişti
                {
                    UserControlBosluk uc = new UserControlBosluk();
                    daycontainer.Controls.Add(uc);
                }
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays uc2 = new UserControlDays();
                uc2.days(i);
                daycontainer.Controls.Add(uc2);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ay == 12)
            {
                ay = 0;
                yil++;
            }
            ay++;
            a = ay;
            y = yil;

            daycontainer.Controls.Clear();
            String ayAdi = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);

            lbltrih.Text = ayAdi + " " + yil;
            DateTime aybasi = new DateTime(yil, ay, 1);
            int days = DateTime.DaysInMonth(yil, ay); //aydaki gün sayısı
            int dayoftheweek = Convert.ToInt32(aybasi.DayOfWeek.ToString("d")) - 1;
            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBosluk uc = new UserControlBosluk();
                daycontainer.Controls.Add(uc);
            }

            if (dayoftheweek == -1)
            {
                for (int i = 0; i < 6; i++) //başta dayofthe week i 1 azalttığımız için zaten 1 eklemişti
                {
                    UserControlBosluk uc = new UserControlBosluk();
                    daycontainer.Controls.Add(uc);
                }
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays uc2 = new UserControlDays();
                uc2.days(i);
                daycontainer.Controls.Add(uc2);
            }
        }
    }



}
