using System;
using System.Windows.Forms;


namespace WindowsFormsApp7
{
    public partial class FormHosgeldiniz : Form
    {
        public FormHosgeldiniz()
        {
            InitializeComponent();

            lblUsername.Text = Form1.tb1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();

            Form3 gecis = new Form3();
            gecis.ShowDialog();
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
