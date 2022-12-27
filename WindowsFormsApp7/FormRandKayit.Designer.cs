namespace WindowsFormsApp7
{
    partial class FormRandKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.comboBoxVet = new System.Windows.Forms.ComboBox();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpet = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtshp = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaciklama = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(28, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pet sahip id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(28, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veteriner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(28, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama";
            // 
            // btnKaydet
            // 
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnKaydet.FlatAppearance.BorderSize = 2;
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnKaydet.Location = new System.Drawing.Point(148, 494);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(157, 49);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseEnter += new System.EventHandler(this.btnKaydet_MouseEnter);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            // 
            // comboBoxVet
            // 
            this.comboBoxVet.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxVet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBoxVet.FormattingEnabled = true;
            this.comboBoxVet.Items.AddRange(new object[] {
            "Enes Doğan",
            "Engin Ertaş",
            "Zeynep Kesici",
            "Murat Öztürk"});
            this.comboBoxVet.Location = new System.Drawing.Point(233, 313);
            this.comboBoxVet.Name = "comboBoxVet";
            this.comboBoxVet.Size = new System.Drawing.Size(166, 29);
            this.comboBoxVet.TabIndex = 28;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboBoxSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00"});
            this.comboBoxSaat.Location = new System.Drawing.Point(233, 78);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(166, 29);
            this.comboBoxSaat.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(28, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pet id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(430, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpet
            // 
            this.txtpet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtpet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpet.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtpet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtpet.Location = new System.Drawing.Point(233, 164);
            this.txtpet.Name = "txtpet";
            this.txtpet.Size = new System.Drawing.Size(170, 21);
            this.txtpet.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(233, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 35;
            // 
            // txtshp
            // 
            this.txtshp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtshp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtshp.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtshp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtshp.Location = new System.Drawing.Point(233, 234);
            this.txtshp.Name = "txtshp";
            this.txtshp.Size = new System.Drawing.Size(170, 21);
            this.txtshp.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(233, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 1);
            this.panel1.TabIndex = 37;
            // 
            // txtaciklama
            // 
            this.txtaciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.txtaciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaciklama.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtaciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.txtaciklama.Location = new System.Drawing.Point(233, 395);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(170, 21);
            this.txtaciklama.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(233, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 39;
            // 
            // FormRandKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(476, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtshp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtpet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSaat);
            this.Controls.Add(this.comboBoxVet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRandKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRandKayit_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox comboBoxVet;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtpet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtshp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtaciklama;
        private System.Windows.Forms.Panel panel3;
    }
}