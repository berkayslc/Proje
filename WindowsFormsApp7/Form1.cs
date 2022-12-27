using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace WindowsFormsApp7
{
    public partial class Form3 : Form
    {

        private Panel leftBorderBtn;
        public Form3()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 50);
            Sidebar.Controls.Add(leftBorderBtn);
            panel1.Visible = false;
            pictureBox1.Location = new Point(12, 235);
            pictureBox3.Location = new Point(12, 284);
            pictureBox4.Location = new Point(12, 333);
            miniFormAc(new FormAnasayfa());
        }

        private void ActivateButton(Button senderBtn)
        {
            leftBorderBtn.BackColor = Color.FromArgb(119, 54, 142);
            leftBorderBtn.Location = new Point(0, senderBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
        }

        private void ActivateButton2(Button senderBtn, int y)
        {
            leftBorderBtn.BackColor = Color.FromArgb(119, 54, 142);
            leftBorderBtn.Location = new Point(0, y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
        }


        private void AltMenuShowHide(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
                pictureBox1.Location = new Point(12, 334);
                pictureBox3.Location = new Point(12, 383);
                pictureBox4.Location = new Point(12, 432);
            }

            else
            {
                subMenu.Visible = false;
                pictureBox1.Location = new Point(12, 235);
                pictureBox3.Location = new Point(12, 284);
                pictureBox4.Location = new Point(12, 333);

            }
        }





        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnSlide_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        bool SidebarGenis;
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarGenis)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    SidebarGenis = false;
                    SidebarTimer.Stop();
                }
                Logo.Size = new Size(35, 34);
                Logo.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox8.Location = new Point(12, pictureBox8.Location.Y);
                pictureBox7.Location = new Point(12, pictureBox7.Location.Y);
                pictureBoxCikis.Location = new Point(12, pictureBoxCikis.Location.Y);
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    SidebarGenis = true;
                    SidebarTimer.Stop();
                }
                Logo.Size = new Size(73, 69);
                Logo.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox8.Location = new Point(30, pictureBox8.Location.Y);
                pictureBox7.Location = new Point(30, pictureBox7.Location.Y);
            }
        }


        private Form activeForm = null;
        private void miniFormAc(Form miniForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = miniForm;
            miniForm.FormBorderStyle = FormBorderStyle.None;
            miniForm.Dock = DockStyle.Fill;

            miniForm.TopLevel = false;

            panelMiniForm.Controls.Add(miniForm);
            panelMiniForm.Tag = miniForm;
            miniForm.BringToFront();
            miniForm.Show();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            
                this.WindowState = FormWindowState.Minimized;
            
            else
            
                this.WindowState = FormWindowState.Normal;
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            
                this.WindowState = FormWindowState.Maximized;
            
            else
            
                this.WindowState = FormWindowState.Normal;
            
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormRandevu());
            ActivateButton(btnRandevular);

        }

        private void btnPetler_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormPetler());
            ActivateButton(btnPetler);
            AltMenuShowHide(panel1);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }
        private void pictureBoxCikis_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();
        }
        private void Logo_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormAnasayfa());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormSahipler());
            ActivateButton2(button8, 225);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormBorclar());
            ActivateButton2(btnVet, 275);
        }

        private void btnSahiplendirme_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormSahiplendirme());
            ActivateButton(btnSahiplendirme);
        }

        private void btnVet_Click(object sender, EventArgs e)
        {
            miniFormAc(new FormVet());
            ActivateButton(btnVet);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnRandevular_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(161, 165, 197);
        }
        private void btnRandevular_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(180, 184, 220);
        }

        private void btnRandevular_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(196, 197, 213);
        }

        private void btnRandevular_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(161, 165, 197);
        }
        private void btnPetler_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(161, 165, 197);
        }

        private void btnPetler_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(180, 184, 220);
        }

        private void btnPetler_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(161, 165, 197);
        }

        private void btnPetler_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(196, 197, 213);
        }

        private void btnSahiplendirme_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(161, 165, 197);
        }

        private void btnSahiplendirme_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(180, 184, 220);
        }

        private void btnSahiplendirme_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(196, 197, 213);
        }

        private void btnSahiplendirme_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(161, 165, 197);
        }

        private void btnVet_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(161, 165, 197);
        }

        private void btnVet_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(180, 184, 220);
        }

        private void btnVet_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(161, 165, 197);
        }

        private void btnVet_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(196, 197, 213);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.FromArgb(206, 206, 224);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Lavender;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(206, 206, 224);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Lavender;
        }


    }
}







