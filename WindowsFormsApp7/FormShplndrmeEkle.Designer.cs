namespace WindowsFormsApp7
{
    partial class FormShplndrmeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShplndrmeEkle));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFotoSec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxYas = new System.Windows.Forms.ComboBox();
            this.comboBoxTur = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFotoSec
            // 
            this.btnFotoSec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFotoSec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnFotoSec.FlatAppearance.BorderSize = 2;
            this.btnFotoSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnFotoSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoSec.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnFotoSec.Location = new System.Drawing.Point(242, 117);
            this.btnFotoSec.Name = "btnFotoSec";
            this.btnFotoSec.Size = new System.Drawing.Size(186, 44);
            this.btnFotoSec.TabIndex = 30;
            this.btnFotoSec.Text = "Fotoğraf seç";
            this.btnFotoSec.UseVisualStyleBackColor = true;
            this.btnFotoSec.Click += new System.EventHandler(this.btnFotoSec_Click);
            this.btnFotoSec.MouseEnter += new System.EventHandler(this.btnFotoSec_MouseEnter);
            this.btnFotoSec.MouseLeave += new System.EventHandler(this.btnFotoSec_MouseLeave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(42, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 33);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tür";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(42, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Yaş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(42, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cinsiyet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxCinsiyet.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCinsiyet.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Dişi",
            "Kısırlaştırılmış erkek",
            "Kısırlaştırılmış dişi",
            "Bilinmiyor"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(196, 421);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(164, 29);
            this.comboBoxCinsiyet.TabIndex = 34;
            // 
            // comboBoxYas
            // 
            this.comboBoxYas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxYas.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxYas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYas.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxYas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBoxYas.FormattingEnabled = true;
            this.comboBoxYas.Items.AddRange(new object[] {
            "Yavru (0-3 ay)",
            "Yavru (3-6 ay)",
            "Genç (6-12 ay)",
            "Yetişkin"});
            this.comboBoxYas.Location = new System.Drawing.Point(196, 350);
            this.comboBoxYas.Name = "comboBoxYas";
            this.comboBoxYas.Size = new System.Drawing.Size(164, 29);
            this.comboBoxYas.TabIndex = 35;
            // 
            // comboBoxTur
            // 
            this.comboBoxTur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTur.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTur.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBoxTur.FormattingEnabled = true;
            this.comboBoxTur.Items.AddRange(new object[] {
            "Kedi",
            "Köpek",
            "Kuş",
            "Kemirgen",
            "Kümes hayvanı",
            "Küçükbaş/Büyükbaş",
            "Binek hayvan",
            "Sürüngen",
            "Diğer"});
            this.comboBoxTur.Location = new System.Drawing.Point(196, 272);
            this.comboBoxTur.Name = "comboBoxTur";
            this.comboBoxTur.Size = new System.Drawing.Size(164, 29);
            this.comboBoxTur.TabIndex = 36;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnKaydet.FlatAppearance.BorderSize = 2;
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnKaydet.Location = new System.Drawing.Point(159, 505);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 47);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseEnter += new System.EventHandler(this.btnKaydet_MouseEnter);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(412, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(31, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormShplndrmeGncl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(458, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxTur);
            this.Controls.Add(this.comboBoxYas);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFotoSec);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShplndrmeGncl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShplndrmeGncl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShplndrmeGncl_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFotoSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxYas;
        private System.Windows.Forms.ComboBox comboBoxTur;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button1;
    }
}