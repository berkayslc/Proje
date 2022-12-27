namespace WindowsFormsApp7
{
    partial class FormSahiplendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSahiplendirme));
            this.btnPetEkle = new System.Windows.Forms.Button();
            this.petcontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPetEkle
            // 
            this.btnPetEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPetEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPetEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnPetEkle.FlatAppearance.BorderSize = 2;
            this.btnPetEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnPetEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetEkle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPetEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.btnPetEkle.Location = new System.Drawing.Point(293, 558);
            this.btnPetEkle.Name = "btnPetEkle";
            this.btnPetEkle.Size = new System.Drawing.Size(186, 44);
            this.btnPetEkle.TabIndex = 29;
            this.btnPetEkle.Text = "Pet ekle";
            this.btnPetEkle.UseVisualStyleBackColor = true;
            this.btnPetEkle.Click += new System.EventHandler(this.btnPetEkle_Click);
            this.btnPetEkle.MouseEnter += new System.EventHandler(this.btnPetEkle_MouseEnter);
            this.btnPetEkle.MouseLeave += new System.EventHandler(this.btnPetEkle_MouseLeave);
            // 
            // petcontainer
            // 
            this.petcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petcontainer.AutoScroll = true;
            this.petcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.petcontainer.Location = new System.Drawing.Point(45, 52);
            this.petcontainer.MinimumSize = new System.Drawing.Size(185, 431);
            this.petcontainer.Name = "petcontainer";
            this.petcontainer.Size = new System.Drawing.Size(706, 431);
            this.petcontainer.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 649);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 0);
            this.dataGridView1.TabIndex = 38;
            // 
            // FormSahiplendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(817, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPetEkle);
            this.Controls.Add(this.petcontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSahiplendirme";
            this.Text = "FormSahiplendirme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPetEkle;
        private System.Windows.Forms.FlowLayoutPanel petcontainer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}