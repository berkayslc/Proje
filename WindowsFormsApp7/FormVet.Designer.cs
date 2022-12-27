namespace WindowsFormsApp7
{
    partial class FormVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUnvan = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtadsyd = new System.Windows.Forms.MaskedTextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.txtUnvan);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtadsyd);
            this.panel1.Location = new System.Drawing.Point(30, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 173);
            this.panel1.TabIndex = 21;
            // 
            // txtUnvan
            // 
            this.txtUnvan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtUnvan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnvan.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtUnvan.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUnvan.Location = new System.Drawing.Point(304, 133);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(170, 21);
            this.txtUnvan.TabIndex = 35;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtTel.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTel.Location = new System.Drawing.Point(300, 77);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(170, 21);
            this.txtTel.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.ForeColor = System.Drawing.SystemColors.Window;
            this.panel5.Location = new System.Drawing.Point(304, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 1);
            this.panel5.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.ForeColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(304, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(158, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Unvan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(304, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(158, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Telefon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(158, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ad Soyad";
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
            this.btnKaydet.Location = new System.Drawing.Point(586, 64);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 47);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.MouseEnter += new System.EventHandler(this.btnKaydet_MouseEnter);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            // 
            // txtadsyd
            // 
            this.txtadsyd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtadsyd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadsyd.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtadsyd.ForeColor = System.Drawing.SystemColors.Window;
            this.txtadsyd.Location = new System.Drawing.Point(304, 16);
            this.txtadsyd.Name = "txtadsyd";
            this.txtadsyd.Size = new System.Drawing.Size(170, 21);
            this.txtadsyd.TabIndex = 2;
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
            this.btnListele.Location = new System.Drawing.Point(316, 276);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(116, 44);
            this.btnListele.TabIndex = 29;
            this.btnListele.Text = "Yenile";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.MouseEnter += new System.EventHandler(this.btnListele_MouseEnter);
            this.btnListele.MouseLeave += new System.EventHandler(this.btnListele_MouseLeave);
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
            this.btnGuncelle.Location = new System.Drawing.Point(156, 276);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(132, 44);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.MouseEnter += new System.EventHandler(this.btnGuncelle_MouseEnter);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
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
            this.btnSil.Location = new System.Drawing.Point(30, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 44);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Leave += new System.EventHandler(this.btnSil_Leave);
            this.btnSil.MouseEnter += new System.EventHandler(this.btnSil_MouseEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 278);
            this.dataGridView1.TabIndex = 30;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(541, 241);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
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
            this.btnAra.Location = new System.Drawing.Point(593, 302);
            this.btnAra.MaximumSize = new System.Drawing.Size(192, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 36);
            this.btnAra.TabIndex = 35;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.MouseEnter += new System.EventHandler(this.btnAra_MouseEnter);
            this.btnAra.MouseLeave += new System.EventHandler(this.btnAra_MouseLeave);
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtArama.Location = new System.Drawing.Point(593, 241);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(170, 21);
            this.txtArama.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(593, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 37;
            // 
            // FormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(796, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVet";
            this.Text = "FormVet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtadsyd;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.MaskedTextBox txtArama;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txtUnvan;
        private System.Windows.Forms.MaskedTextBox txtTel;
    }
}