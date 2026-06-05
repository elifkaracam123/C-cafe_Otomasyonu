namespace cafe
{
    partial class UC_Urun
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
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblResimYolu = new System.Windows.Forms.Label();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.lblStoktaMi = new System.Windows.Forms.Label();
            this.chkStoktaMi = new System.Windows.Forms.CheckBox();
            this.lblStokAdeti = new System.Windows.Forms.Label();
            this.numStokAdeti = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numStokAdeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(228, 37);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(58, 30);
            this.btnAra.TabIndex = 35;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(32, 37);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(190, 30);
            this.txtArama.TabIndex = 34;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Location = new System.Drawing.Point(1179, 444);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 51);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(1070, 444);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 51);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(950, 444);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 51);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblResimYolu
            // 
            this.lblResimYolu.AutoSize = true;
            this.lblResimYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResimYolu.Location = new System.Drawing.Point(967, 333);
            this.lblResimYolu.Name = "lblResimYolu";
            this.lblResimYolu.Size = new System.Drawing.Size(110, 25);
            this.lblResimYolu.TabIndex = 30;
            this.lblResimYolu.Text = "Resim Yolu";
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResimYolu.Location = new System.Drawing.Point(1105, 331);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.Size = new System.Drawing.Size(139, 30);
            this.txtResimYolu.TabIndex = 29;
            // 
            // lblStoktaMi
            // 
            this.lblStoktaMi.AutoSize = true;
            this.lblStoktaMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStoktaMi.Location = new System.Drawing.Point(974, 289);
            this.lblStoktaMi.Name = "lblStoktaMi";
            this.lblStoktaMi.Size = new System.Drawing.Size(105, 25);
            this.lblStoktaMi.TabIndex = 28;
            this.lblStoktaMi.Text = "Stokta Mı?";
            // 
            // chkStoktaMi
            // 
            this.chkStoktaMi.AutoSize = true;
            this.chkStoktaMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkStoktaMi.Location = new System.Drawing.Point(1105, 286);
            this.chkStoktaMi.Name = "chkStoktaMi";
            this.chkStoktaMi.Size = new System.Drawing.Size(18, 17);
            this.chkStoktaMi.TabIndex = 27;
            this.chkStoktaMi.UseVisualStyleBackColor = true;
            // 
            // lblStokAdeti
            // 
            this.lblStokAdeti.AutoSize = true;
            this.lblStokAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokAdeti.Location = new System.Drawing.Point(964, 238);
            this.lblStokAdeti.Name = "lblStokAdeti";
            this.lblStokAdeti.Size = new System.Drawing.Size(102, 25);
            this.lblStokAdeti.TabIndex = 26;
            this.lblStokAdeti.Text = "Stok Adeti";
            // 
            // numStokAdeti
            // 
            this.numStokAdeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numStokAdeti.Location = new System.Drawing.Point(1105, 233);
            this.numStokAdeti.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numStokAdeti.Name = "numStokAdeti";
            this.numStokAdeti.Size = new System.Drawing.Size(140, 30);
            this.numStokAdeti.TabIndex = 25;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(987, 193);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(54, 25);
            this.lblFiyat.TabIndex = 24;
            this.lblFiyat.Text = "Fiyat";
            // 
            // numFiyat
            // 
            this.numFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numFiyat.Location = new System.Drawing.Point(1104, 188);
            this.numFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(140, 30);
            this.numFiyat.TabIndex = 23;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(974, 146);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(85, 25);
            this.lblKategori.TabIndex = 22;
            this.lblKategori.Text = "Kategori";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(974, 97);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(88, 25);
            this.lblUrunAdi.TabIndex = 21;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Yemek",
            "Tatlı",
            "Soğuk İçecekler",
            "Sıcak İçecekler"});
            this.cmbKategori.Location = new System.Drawing.Point(1104, 139);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(141, 33);
            this.cmbKategori.TabIndex = 20;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(1104, 98);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(141, 30);
            this.txtUrunAdi.TabIndex = 19;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(32, 85);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(900, 622);
            this.dgvUrunler.TabIndex = 18;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            // 
            // UC_Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblResimYolu);
            this.Controls.Add(this.txtResimYolu);
            this.Controls.Add(this.lblStoktaMi);
            this.Controls.Add(this.chkStoktaMi);
            this.Controls.Add(this.lblStokAdeti);
            this.Controls.Add(this.numStokAdeti);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "UC_Urun";
            this.Size = new System.Drawing.Size(1305, 745);
            ((System.ComponentModel.ISupportInitialize)(this.numStokAdeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblResimYolu;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.Label lblStoktaMi;
        private System.Windows.Forms.CheckBox chkStoktaMi;
        private System.Windows.Forms.Label lblStokAdeti;
        private System.Windows.Forms.NumericUpDown numStokAdeti;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.DataGridView dgvUrunler;
    }
}
