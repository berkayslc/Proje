namespace WindowsFormsApp7
{
    partial class FormRandData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandData));
            this.lblgun = new System.Windows.Forms.Label();
            this.lblAy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRndEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblYil = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgun
            // 
            this.lblgun.Font = new System.Drawing.Font("Century Gothic", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgun.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblgun.Location = new System.Drawing.Point(26, 62);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(120, 85);
            this.lblgun.TabIndex = 26;
            this.lblgun.Text = "16";
            this.lblgun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAy
            // 
            this.lblAy.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.lblAy.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAy.Location = new System.Drawing.Point(152, 72);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(166, 44);
            this.lblAy.TabIndex = 27;
            this.lblAy.Text = "Kasım";
            this.lblAy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRndEkle);
            this.panel1.Location = new System.Drawing.Point(28, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 60);
            this.panel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Randevu Ekle\r\n";
            // 
            // btnRndEkle
            // 
            this.btnRndEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btnRndEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRndEkle.FlatAppearance.BorderSize = 0;
            this.btnRndEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRndEkle.ForeColor = System.Drawing.Color.Black;
            this.btnRndEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnRndEkle.Image")));
            this.btnRndEkle.Location = new System.Drawing.Point(360, 4);
            this.btnRndEkle.Name = "btnRndEkle";
            this.btnRndEkle.Size = new System.Drawing.Size(60, 53);
            this.btnRndEkle.TabIndex = 33;
            this.btnRndEkle.UseVisualStyleBackColor = false;
            this.btnRndEkle.Click += new System.EventHandler(this.btnRndEkle_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 257);
            this.dataGridView1.TabIndex = 34;
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArama.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtArama.Location = new System.Drawing.Point(83, 314);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(170, 21);
            this.txtArama.TabIndex = 38;
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.ForeColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(83, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 1);
            this.panel4.TabIndex = 39;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(39, 314);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(388, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 53);
            this.btnSil.TabIndex = 36;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.ForeColor = System.Drawing.Color.Black;
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(322, 301);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(60, 53);
            this.btnYenile.TabIndex = 35;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(429, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblYil
            // 
            this.lblYil.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblYil.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblYil.Location = new System.Drawing.Point(154, 115);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(99, 32);
            this.lblYil.TabIndex = 28;
            this.lblYil.Text = "2022";
            this.lblYil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormRandData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(476, 644);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.lblgun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblYil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRandData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRandData_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRndEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MaskedTextBox txtArama;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblYil;
    }
}