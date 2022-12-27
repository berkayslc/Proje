namespace WindowsFormsApp7
{
    partial class UserControlSahiplendirme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblCins);
            this.panel3.Controls.Add(this.lblYas);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 228);
            this.panel3.TabIndex = 3;
            // 
            // lblCins
            // 
            this.lblCins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCins.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCins.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCins.Location = new System.Drawing.Point(10, 191);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(193, 24);
            this.lblCins.TabIndex = 27;
            this.lblCins.Text = "Cinsiyet";
            this.lblCins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblYas
            // 
            this.lblYas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblYas.Location = new System.Drawing.Point(6, 152);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(197, 24);
            this.lblYas.TabIndex = 26;
            this.lblYas.Text = "Yaş";
            this.lblYas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(37, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserControlSahiplendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "UserControlSahiplendirme";
            this.Size = new System.Drawing.Size(215, 228);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
