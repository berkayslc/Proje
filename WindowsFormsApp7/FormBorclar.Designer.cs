namespace WindowsFormsApp7
{
    partial class FormBorclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorclar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxislem = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBorcEkle = new System.Windows.Forms.Button();
            this.txtadsyd = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBorcAzalt = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.comboBoxislem);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBorcEkle);
            this.panel1.Controls.Add(this.txtadsyd);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 173);
            this.panel1.TabIndex = 21;
            // 
            // comboBoxislem
            // 
            this.comboBoxislem.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxislem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxislem.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxislem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBoxislem.FormattingEnabled = true;
            this.comboBoxislem.Items.AddRange(new object[] {
            "İç parazit aşısı",
            "Dış parazit aşısı",
            "Karma aşı",
            "Kuduz aşısı",
            "Aşı diğer",
            "Kedi kısırlaştırma",
            "Köpek kısırlaştırma",
            "Kısırlaştırma diğer",
            "Kan tahlili",
            ""});
            this.comboBoxislem.Location = new System.Drawing.Point(202, 117);
            this.comboBoxislem.Name = "comboBoxislem";
            this.comboBoxislem.Size = new System.Drawing.Size(170, 29);
            this.comboBoxislem.TabIndex = 35;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(202, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(170, 21);
            this.txtid.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Yapılan işlem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtmail.Location = new System.Drawing.Point(162, 90);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(170, 21);
            this.txtmail.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(202, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(30, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Borç sahibi id";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBorcEkle
            // 
            this.btnBorcEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorcEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBorcEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnBorcEkle.FlatAppearance.BorderSize = 2;
            this.btnBorcEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnBorcEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorcEkle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorcEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnBorcEkle.Location = new System.Drawing.Point(535, 64);
            this.btnBorcEkle.Name = "btnBorcEkle";
            this.btnBorcEkle.Size = new System.Drawing.Size(128, 47);
            this.btnBorcEkle.TabIndex = 20;
            this.btnBorcEkle.Text = "Borç Ekle";
            this.btnBorcEkle.UseVisualStyleBackColor = true;
            this.btnBorcEkle.Click += new System.EventHandler(this.btnBorcEkle_Click);
            this.btnBorcEkle.MouseEnter += new System.EventHandler(this.btnBorcEkle_MouseEnter);
            this.btnBorcEkle.MouseLeave += new System.EventHandler(this.btnBorcEkle_MouseLeave);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 261);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnYenile
            // 
            this.btnYenile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnYenile.FlatAppearance.BorderSize = 2;
            this.btnYenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnYenile.Location = new System.Drawing.Point(153, 249);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(116, 44);
            this.btnYenile.TabIndex = 28;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            this.btnYenile.MouseEnter += new System.EventHandler(this.btnYenile_MouseEnter);
            this.btnYenile.MouseLeave += new System.EventHandler(this.btnYenile_MouseLeave);
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
            this.btnSil.Location = new System.Drawing.Point(19, 249);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 44);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseEnter += new System.EventHandler(this.btnSil_MouseEnter);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(511, 224);
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
            this.btnAra.Location = new System.Drawing.Point(563, 269);
            this.btnAra.MaximumSize = new System.Drawing.Size(192, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(112, 36);
            this.btnAra.TabIndex = 35;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            this.btnAra.MouseEnter += new System.EventHandler(this.btnAra_MouseEnter);
            this.btnAra.MouseLeave += new System.EventHandler(this.btnAra_MouseLeave);
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtArama.Location = new System.Drawing.Point(563, 224);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(170, 21);
            this.txtArama.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.ForeColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(563, 251);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 40;
            // 
            // btnBorcAzalt
            // 
            this.btnBorcAzalt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBorcAzalt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnBorcAzalt.FlatAppearance.BorderSize = 2;
            this.btnBorcAzalt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnBorcAzalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorcAzalt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorcAzalt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnBorcAzalt.Location = new System.Drawing.Point(316, 249);
            this.btnBorcAzalt.Name = "btnBorcAzalt";
            this.btnBorcAzalt.Size = new System.Drawing.Size(167, 44);
            this.btnBorcAzalt.TabIndex = 41;
            this.btnBorcAzalt.Text = "Borç Azalt";
            this.btnBorcAzalt.UseVisualStyleBackColor = true;
            this.btnBorcAzalt.Click += new System.EventHandler(this.btnBorcAzalt_Click);
            this.btnBorcAzalt.MouseEnter += new System.EventHandler(this.btnBorcAzalt_MouseEnter);
            this.btnBorcAzalt.MouseLeave += new System.EventHandler(this.btnBorcAzalt_MouseLeave);
            // 
            // FormBorclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(778, 617);
            this.Controls.Add(this.btnBorcAzalt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorclar";
            this.Text = "FormBorclar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorcEkle;
        private System.Windows.Forms.MaskedTextBox txtadsyd;
        private System.Windows.Forms.MaskedTextBox txtid;
        private System.Windows.Forms.ComboBox comboBoxislem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.MaskedTextBox txtArama;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBorcAzalt;
    }
}