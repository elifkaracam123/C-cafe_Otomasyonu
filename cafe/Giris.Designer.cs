namespace cafe
{
    partial class form_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_giris));
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kayit = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_uyeolmaa = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_telefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_giris = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefon.Location = new System.Drawing.Point(62, 165);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(117, 28);
            this.lbl_telefon.TabIndex = 0;
            this.lbl_telefon.Text = "Telefon No";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.Location = new System.Drawing.Point(62, 236);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(63, 28);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hesabın yoksa";
            // 
            // lbl_kayit
            // 
            this.lbl_kayit.AutoSize = true;
            this.lbl_kayit.BackColor = System.Drawing.Color.White;
            this.lbl_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kayit.LinkColor = System.Drawing.Color.OrangeRed;
            this.lbl_kayit.Location = new System.Drawing.Point(231, 23);
            this.lbl_kayit.Name = "lbl_kayit";
            this.lbl_kayit.Size = new System.Drawing.Size(73, 24);
            this.lbl_kayit.TabIndex = 8;
            this.lbl_kayit.TabStop = true;
            this.lbl_kayit.Text = "Kayıt Ol";
            this.lbl_kayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_kayit_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lbl_uyeolmaa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_kayit);
            this.panel1.Location = new System.Drawing.Point(-18, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 128);
            this.panel1.TabIndex = 10;
            // 
            // lbl_uyeolmaa
            // 
            this.lbl_uyeolmaa.AutoSize = true;
            this.lbl_uyeolmaa.BackColor = System.Drawing.Color.White;
            this.lbl_uyeolmaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uyeolmaa.LinkColor = System.Drawing.Color.OrangeRed;
            this.lbl_uyeolmaa.Location = new System.Drawing.Point(93, 94);
            this.lbl_uyeolmaa.Name = "lbl_uyeolmaa";
            this.lbl_uyeolmaa.Size = new System.Drawing.Size(211, 24);
            this.lbl_uyeolmaa.TabIndex = 11;
            this.lbl_uyeolmaa.TabStop = true;
            this.lbl_uyeolmaa.Text = "Üye Olmadan Devam Et";
            this.lbl_uyeolmaa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_uyeolmaa_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Veya";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telefon.DefaultText = "";
            this.txt_telefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telefon.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_telefon.ForeColor = System.Drawing.Color.Black;
            this.txt_telefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telefon.Location = new System.Drawing.Point(67, 198);
            this.txt_telefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.PlaceholderText = "0555-555-55-55";
            this.txt_telefon.SelectedText = "";
            this.txt_telefon.Size = new System.Drawing.Size(244, 32);
            this.txt_telefon.TabIndex = 12;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.DefaultText = "";
            this.txt_sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sifre.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_sifre.ForeColor = System.Drawing.Color.Black;
            this.txt_sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sifre.Location = new System.Drawing.Point(67, 269);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.PlaceholderText = "Şifrenizi Giriniz";
            this.txt_sifre.SelectedText = "";
            this.txt_sifre.Size = new System.Drawing.Size(244, 32);
            this.txt_sifre.TabIndex = 13;
            // 
            // btn_giris
            // 
            this.btn_giris.BorderRadius = 20;
            this.btn_giris.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_giris.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_giris.CheckedState.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_giris.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_giris.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_giris.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_giris.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_giris.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giris.ForeColor = System.Drawing.Color.Black;
            this.btn_giris.Location = new System.Drawing.Point(97, 309);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(174, 45);
            this.btn_giris.TabIndex = 14;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 503);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_telefon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbl_kayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_uyeolmaa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_telefon;
        private Guna.UI2.WinForms.Guna2TextBox txt_sifre;
        private Guna.UI2.WinForms.Guna2Button btn_giris;
    }
}