namespace cafe
{
    partial class form_anasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kapat = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sepet = new Guna.UI2.WinForms.Guna2Button();
            this.btn_masalar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ayarlar = new Guna.UI2.WinForms.Guna2Button();
            this.panel_icerik = new System.Windows.Forms.Panel();
            this.btnCikis = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 0;
            // 
            // btn_kapat
            // 
            this.btn_kapat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kapat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kapat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kapat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_kapat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(765, 0);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(35, 32);
            this.btn_kapat.TabIndex = 8;
            this.btn_kapat.Text = "X";
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.flowLayoutPanel1.Controls.Add(this.btn_menu);
            this.flowLayoutPanel1.Controls.Add(this.btn_sepet);
            this.flowLayoutPanel1.Controls.Add(this.btn_masalar);
            this.flowLayoutPanel1.Controls.Add(this.btn_ayarlar);
            this.flowLayoutPanel1.Controls.Add(this.btnCikis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 468);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.BorderRadius = 15;
            this.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_menu.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_menu.ForeColor = System.Drawing.Color.Black;
            this.btn_menu.Location = new System.Drawing.Point(3, 2);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(215, 55);
            this.btn_menu.TabIndex = 7;
            this.btn_menu.Text = "Menü";
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_sepet
            // 
            this.btn_sepet.BorderRadius = 15;
            this.btn_sepet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sepet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sepet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sepet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sepet.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sepet.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_sepet.ForeColor = System.Drawing.Color.Black;
            this.btn_sepet.Location = new System.Drawing.Point(3, 61);
            this.btn_sepet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sepet.Name = "btn_sepet";
            this.btn_sepet.Size = new System.Drawing.Size(215, 55);
            this.btn_sepet.TabIndex = 6;
            this.btn_sepet.Text = "Sepet";
            this.btn_sepet.Click += new System.EventHandler(this.btn_sepet_Click);
            // 
            // btn_masalar
            // 
            this.btn_masalar.BorderRadius = 15;
            this.btn_masalar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_masalar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_masalar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_masalar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_masalar.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_masalar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_masalar.ForeColor = System.Drawing.Color.Black;
            this.btn_masalar.Location = new System.Drawing.Point(3, 120);
            this.btn_masalar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_masalar.Name = "btn_masalar";
            this.btn_masalar.Size = new System.Drawing.Size(215, 55);
            this.btn_masalar.TabIndex = 5;
            this.btn_masalar.Text = "Masalar";
            this.btn_masalar.Click += new System.EventHandler(this.btn_masalar_Click);
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.BorderRadius = 15;
            this.btn_ayarlar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ayarlar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ayarlar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ayarlar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ayarlar.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ayarlar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btn_ayarlar.ForeColor = System.Drawing.Color.Black;
            this.btn_ayarlar.Location = new System.Drawing.Point(3, 179);
            this.btn_ayarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(215, 55);
            this.btn_ayarlar.TabIndex = 4;
            this.btn_ayarlar.Text = "Ayarlar";
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // panel_icerik
            // 
            this.panel_icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_icerik.Location = new System.Drawing.Point(220, 32);
            this.panel_icerik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_icerik.Name = "panel_icerik";
            this.panel_icerik.Size = new System.Drawing.Size(580, 468);
            this.panel_icerik.TabIndex = 0;
            this.panel_icerik.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_icerik_Paint);
            // 
            // btnCikis
            // 
            this.btnCikis.BorderRadius = 15;
            this.btnCikis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCikis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCikis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCikis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCikis.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(3, 238);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(215, 55);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // form_anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel_icerik);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_icerik;
        private Guna.UI2.WinForms.Guna2Button btn_menu;
        private Guna.UI2.WinForms.Guna2Button btn_sepet;
        private Guna.UI2.WinForms.Guna2Button btn_masalar;
        private Guna.UI2.WinForms.Guna2Button btn_ayarlar;
        private Guna.UI2.WinForms.Guna2Button btn_kapat;
        private Guna.UI2.WinForms.Guna2Button btnCikis;
    }
}