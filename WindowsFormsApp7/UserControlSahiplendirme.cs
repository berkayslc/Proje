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
    public partial class UserControlSahiplendirme : UserControl
    {
       

        public UserControlSahiplendirme()
        {
            InitializeComponent();


            if (FormShplndrmeEkle.fpath != null)
            {
                lblYas.Text = FormShplndrmeEkle.cmbYas.Text;
                lblCins.Text = FormShplndrmeEkle.cmbCins.Text;
                pictureBox3.Load(FormShplndrmeEkle.fpath);
            }

            else
            {
                lblYas.Text = FormSahiplendirme.s;
                lblCins.Text = FormSahiplendirme.k;
                pictureBox3.ImageLocation = FormSahiplendirme.p;
            }


        }
       
    }
}
