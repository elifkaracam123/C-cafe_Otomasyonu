namespace cafe
{
    partial class Menu
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
            this.panel_kategori = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_soguk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sicak = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tatli = new Guna.UI2.WinForms.Guna2Button();
            this.btn_yemek = new Guna.UI2.WinForms.Guna2Button();
            this.flow_urunler = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_kategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_kategori
            // 
            this.panel_kategori.Controls.Add(this.btn_soguk);
            this.panel_kategori.Controls.Add(this.btn_sicak);
            this.panel_kategori.Controls.Add(this.btn_tatli);
            this.panel_kategori.Controls.Add(this.btn_yemek);
            this.panel_kategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_kategori.Location = new System.Drawing.Point(0, 0);
            this.panel_kategori.Name = "panel_kategori";
            this.panel_kategori.Size = new System.Drawing.Size(900, 57);
            this.panel_kategori.TabIndex = 0;
            // 
            // btn_soguk
            // 
            this.btn_soguk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_soguk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_soguk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_soguk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_soguk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_soguk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_soguk.ForeColor = System.Drawing.Color.White;
            this.btn_soguk.Location = new System.Drawing.Point(662, 6);
            this.btn_soguk.Name = "btn_soguk";
            this.btn_soguk.Size = new System.Drawing.Size(135, 45);
            this.btn_soguk.TabIndex = 3;
            this.btn_soguk.Text = "Soğuk İçecekler";
            this.btn_soguk.Click += new System.EventHandler(this.btn_soguk_Click);
            // 
            // btn_sicak
            // 
            this.btn_sicak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sicak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sicak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sicak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sicak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sicak.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sicak.ForeColor = System.Drawing.Color.White;
            this.btn_sicak.Location = new System.Drawing.Point(473, 6);
            this.btn_sicak.Name = "btn_sicak";
            this.btn_sicak.Size = new System.Drawing.Size(135, 45);
            this.btn_sicak.TabIndex = 2;
            this.btn_sicak.Text = "Sıcak İçecekler";
            this.btn_sicak.Click += new System.EventHandler(this.btn_sicak_Click);
            // 
            // btn_tatli
            // 
            this.btn_tatli.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tatli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tatli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tatli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tatli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_tatli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_tatli.ForeColor = System.Drawing.Color.White;
            this.btn_tatli.Location = new System.Drawing.Point(285, 6);
            this.btn_tatli.Name = "btn_tatli";
            this.btn_tatli.Size = new System.Drawing.Size(135, 45);
            this.btn_tatli.TabIndex = 1;
            this.btn_tatli.Text = "Tatlı";
            this.btn_tatli.Click += new System.EventHandler(this.btn_tatli_Click);
            // 
            // btn_yemek
            // 
            this.btn_yemek.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_yemek.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_yemek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_yemek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_yemek.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_yemek.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_yemek.ForeColor = System.Drawing.Color.White;
            this.btn_yemek.Location = new System.Drawing.Point(89, 6);
            this.btn_yemek.Name = "btn_yemek";
            this.btn_yemek.Size = new System.Drawing.Size(135, 45);
            this.btn_yemek.TabIndex = 0;
            this.btn_yemek.Text = "Yemek";
            this.btn_yemek.Click += new System.EventHandler(this.btn_yemek_Click);
            // 
            // flow_urunler
            // 
            this.flow_urunler.AutoScroll = true;
            this.flow_urunler.BackColor = System.Drawing.Color.Gainsboro;
            this.flow_urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_urunler.Location = new System.Drawing.Point(0, 57);
            this.flow_urunler.Name = "flow_urunler";
            this.flow_urunler.Size = new System.Drawing.Size(900, 443);
            this.flow_urunler.TabIndex = 0;
            this.flow_urunler.Paint += new System.Windows.Forms.PaintEventHandler(this.flow_urunler_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.flow_urunler);
            this.Controls.Add(this.panel_kategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel_kategori.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_kategori;
        private Guna.UI2.WinForms.Guna2Button btn_soguk;
        private Guna.UI2.WinForms.Guna2Button btn_sicak;
        private Guna.UI2.WinForms.Guna2Button btn_tatli;
        private Guna.UI2.WinForms.Guna2Button btn_yemek;
        private System.Windows.Forms.FlowLayoutPanel flow_urunler;
    }
}