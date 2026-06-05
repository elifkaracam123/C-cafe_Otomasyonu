namespace cafe
{
    partial class form_admin
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
            this.panelAna = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kapat = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKullanici = new Guna.UI2.WinForms.Guna2Button();
            this.btnMasa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUrun = new Guna.UI2.WinForms.Guna2Button();
            this.btnSiparis = new Guna.UI2.WinForms.Guna2Button();
            this.btnCikis = new Guna.UI2.WinForms.Guna2Button();
            this.panel_icerik = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAna
            // 
            this.panelAna.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelAna.Location = new System.Drawing.Point(225, 50);
            this.panelAna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(675, 576);
            this.panelAna.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_kapat);
            this.panel1.Controls.Add(this.panelAna);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 1;
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
            this.btn_kapat.Location = new System.Drawing.Point(861, 0);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 40);
            this.btn_kapat.TabIndex = 8;
            this.btn_kapat.Text = "X";
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.flowLayoutPanel1.Controls.Add(this.btnKullanici);
            this.flowLayoutPanel1.Controls.Add(this.btnMasa);
            this.flowLayoutPanel1.Controls.Add(this.btnUrun);
            this.flowLayoutPanel1.Controls.Add(this.btnSiparis);
            this.flowLayoutPanel1.Controls.Add(this.btnCikis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 585);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnKullanici
            // 
            this.btnKullanici.BorderRadius = 15;
            this.btnKullanici.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKullanici.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKullanici.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKullanici.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKullanici.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnKullanici.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnKullanici.ForeColor = System.Drawing.Color.Black;
            this.btnKullanici.Location = new System.Drawing.Point(3, 4);
            this.btnKullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(242, 69);
            this.btnKullanici.TabIndex = 12;
            this.btnKullanici.Text = "Kullanıcılar";
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // btnMasa
            // 
            this.btnMasa.BorderRadius = 15;
            this.btnMasa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMasa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMasa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMasa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMasa.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMasa.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnMasa.ForeColor = System.Drawing.Color.Black;
            this.btnMasa.Location = new System.Drawing.Point(3, 81);
            this.btnMasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(242, 69);
            this.btnMasa.TabIndex = 12;
            this.btnMasa.Text = "Masalar";
            this.btnMasa.Click += new System.EventHandler(this.btnMasa_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.BorderRadius = 15;
            this.btnUrun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrun.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUrun.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnUrun.ForeColor = System.Drawing.Color.Black;
            this.btnUrun.Location = new System.Drawing.Point(3, 156);
            this.btnUrun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(242, 69);
            this.btnUrun.TabIndex = 10;
            this.btnUrun.Text = "Ürünler";
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.BorderRadius = 15;
            this.btnSiparis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSiparis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSiparis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSiparis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSiparis.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSiparis.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSiparis.ForeColor = System.Drawing.Color.Black;
            this.btnSiparis.Location = new System.Drawing.Point(3, 231);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(242, 69);
            this.btnSiparis.TabIndex = 11;
            this.btnSiparis.Text = "Siparişler";
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
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
            this.btnCikis.Location = new System.Drawing.Point(3, 308);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(242, 69);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel_icerik
            // 
            this.panel_icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_icerik.Location = new System.Drawing.Point(260, 40);
            this.panel_icerik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_icerik.Name = "panel_icerik";
            this.panel_icerik.Size = new System.Drawing.Size(640, 585);
            this.panel_icerik.TabIndex = 12;
            // 
            // form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 625);
            this.Controls.Add(this.panel_icerik);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAna;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_kapat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_icerik;
        private Guna.UI2.WinForms.Guna2Button btnUrun;
        private Guna.UI2.WinForms.Guna2Button btnSiparis;
        private Guna.UI2.WinForms.Guna2Button btnKullanici;
        private Guna.UI2.WinForms.Guna2Button btnCikis;
        private Guna.UI2.WinForms.Guna2Button btnMasa;
    }
}