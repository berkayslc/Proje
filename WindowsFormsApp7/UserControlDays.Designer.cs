namespace WindowsFormsApp7
{
    partial class UserControlDays
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
            this.components = new System.ComponentModel.Container();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(54)))), ((int)(((byte)(142)))));
            this.lblDays.Location = new System.Drawing.Point(3, 14);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(30, 21);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "00";
            // 
            // lblEvent
            // 
            this.lblEvent.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEvent.Location = new System.Drawing.Point(0, 45);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(100, 38);
            this.lblEvent.TabIndex = 1;
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblDays);
            this.Name = "UserControlGunler";
            this.Size = new System.Drawing.Size(103, 100);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlDays_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlDays_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Timer timer1;
    }
}
