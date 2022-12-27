namespace WindowsFormsApp7
{
    partial class FormPetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtisim = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShpid = new System.Windows.Forms.MaskedTextBox();
            this.txtDogum = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kedi",
            "Köpek",
            "Kuş",
            "Kemirgen",
            "Kümes hayvanı",
            "Küçükbaş/Büyükbaş",
            "Binek hayvan",
            "Sürüngen",
            "Diğer"});
            this.comboBox1.Location = new System.Drawing.Point(458, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // txtisim
            // 
            this.txtisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtisim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtisim.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtisim.ForeColor = System.Drawing.SystemColors.Window;
            this.txtisim.Location = new System.Drawing.Point(162, 16);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(170, 21);
            this.txtisim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Erkek",
            "Dişi",
            "Kısırlaştırılmış erkek",
            "Kısırlaştırılmış dişi",
            "Bilinmiyor"});
            this.comboBox2.Location = new System.Drawing.Point(458, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 29);
            this.comboBox2.TabIndex = 7;
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtArama.Location = new System.Drawing.Point(590, 216);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(170, 21);
            this.txtArama.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtShpid);
            this.panel1.Controls.Add(this.txtDogum);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtisim);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 173);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.ForeColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(162, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sahip id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShpid
            // 
            this.txtShpid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtShpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShpid.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtShpid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtShpid.Location = new System.Drawing.Point(162, 133);
            this.txtShpid.Name = "txtShpid";
            this.txtShpid.Size = new System.Drawing.Size(170, 21);
            this.txtShpid.TabIndex = 30;
            // 
            // txtDogum
            // 
            this.txtDogum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtDogum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDogum.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtDogum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDogum.Location = new System.Drawing.Point(188, 81);
            this.txtDogum.Mask = "00/00/0000";
            this.txtDogum.Name = "txtDogum";
            this.txtDogum.Size = new System.Drawing.Size(97, 21);
            this.txtDogum.TabIndex = 29;
            this.txtDogum.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(158, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(364, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cinsiyet";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(364, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tür";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Doğum tarihi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(51, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "İsim";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnKaydet.Location = new System.Drawing.Point(614, 64);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 47);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseEnter += new System.EventHandler(this.btnKaydet_MouseEnter);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            // 
            // btnSil
            // 
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnSil.FlatAppearance.BorderSize = 2;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnSil.Location = new System.Drawing.Point(33, 243);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 44);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseEnter += new System.EventHandler(this.btnSil_MouseEnter);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 2;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnGuncelle.Location = new System.Drawing.Point(152, 243);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(132, 44);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseEnter += new System.EventHandler(this.btnGuncelle_MouseEnter);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            // 
            // btnListele
            // 
            this.btnListele.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnListele.FlatAppearance.BorderSize = 2;
            this.btnListele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnListele.Location = new System.Drawing.Point(300, 243);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(116, 44);
            this.btnListele.TabIndex = 23;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            this.btnListele.MouseEnter += new System.EventHandler(this.btnListele_MouseEnter);
            this.btnListele.MouseLeave += new System.EventHandler(this.btnListele_MouseLeave);
            // 
            // btnAra
            // 
            this.btnAra.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnAra.FlatAppearance.BorderSize = 2;
            this.btnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnAra.Location = new System.Drawing.Point(590, 275);
            this.btnAra.MaximumSize = new System.Drawing.Size(192, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 36);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            this.btnAra.MouseEnter += new System.EventHandler(this.btnAra_MouseEnter);
            this.btnAra.MouseLeave += new System.EventHandler(this.btnAra_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(590, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 29;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(538, 216);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // FormPetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(796, 664);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPetler";
            this.Text = "FormPetler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox txtisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox txtArama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDogum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtShpid;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}