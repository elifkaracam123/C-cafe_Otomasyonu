namespace cafe
{
    partial class SiparisTipiSec
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
            this.btn_masaSec = new Guna.UI2.WinForms.Guna2Button();
            this.btn_alGotur = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_secim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btn_masaSec
            // 
            this.btn_masaSec.BorderRadius = 20;
            this.btn_masaSec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_masaSec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_masaSec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_masaSec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_masaSec.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_masaSec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_masaSec.ForeColor = System.Drawing.Color.Black;
            this.btn_masaSec.Location = new System.Drawing.Point(66, 115);
            this.btn_masaSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_masaSec.Name = "btn_masaSec";
            this.btn_masaSec.Size = new System.Drawing.Size(202, 56);
            this.btn_masaSec.TabIndex = 0;
            this.btn_masaSec.Text = "Masa Seç";
            this.btn_masaSec.Click += new System.EventHandler(this.btn_masaSec_Click);
            // 
            // btn_alGotur
            // 
            this.btn_alGotur.BorderRadius = 20;
            this.btn_alGotur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_alGotur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_alGotur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_alGotur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_alGotur.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_alGotur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_alGotur.ForeColor = System.Drawing.Color.Black;
            this.btn_alGotur.Location = new System.Drawing.Point(378, 115);
            this.btn_alGotur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_alGotur.Name = "btn_alGotur";
            this.btn_alGotur.Size = new System.Drawing.Size(202, 56);
            this.btn_alGotur.TabIndex = 1;
            this.btn_alGotur.Text = "Al Götür";
            this.btn_alGotur.Click += new System.EventHandler(this.btn_alGotur_Click);
            // 
            // lbl_secim
            // 
            this.lbl_secim.BackColor = System.Drawing.Color.Transparent;
            this.lbl_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secim.Location = new System.Drawing.Point(210, 32);
            this.lbl_secim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_secim.Name = "lbl_secim";
            this.lbl_secim.Size = new System.Drawing.Size(227, 31);
            this.lbl_secim.TabIndex = 2;
            this.lbl_secim.Text = "Lütfen Seçim Yapınız";
            // 
            // SiparisTipiSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 254);
            this.Controls.Add(this.lbl_secim);
            this.Controls.Add(this.btn_alGotur);
            this.Controls.Add(this.btn_masaSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SiparisTipiSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisTipiSec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_masaSec;
        private Guna.UI2.WinForms.Guna2Button btn_alGotur;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_secim;
    }
}