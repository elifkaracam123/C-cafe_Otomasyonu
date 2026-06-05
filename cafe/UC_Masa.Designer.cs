namespace cafe
{
    partial class UC_Masa
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
            this.dataGridViewMasa = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDolu = new System.Windows.Forms.Button();
            this.btnBos = new System.Windows.Forms.Button();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMasa
            // 
            this.dataGridViewMasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasa.Location = new System.Drawing.Point(112, 68);
            this.dataGridViewMasa.Name = "dataGridViewMasa";
            this.dataGridViewMasa.ReadOnly = true;
            this.dataGridViewMasa.RowHeadersWidth = 51;
            this.dataGridViewMasa.RowTemplate.Height = 24;
            this.dataGridViewMasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMasa.Size = new System.Drawing.Size(429, 476);
            this.dataGridViewMasa.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(633, 160);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 59);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Masa Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(633, 309);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 64);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Masa Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDolu
            // 
            this.btnDolu.Location = new System.Drawing.Point(198, 16);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(116, 35);
            this.btnDolu.TabIndex = 3;
            this.btnDolu.Text = "Dolu";
            this.btnDolu.UseVisualStyleBackColor = true;
            this.btnDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // btnBos
            // 
            this.btnBos.Location = new System.Drawing.Point(332, 16);
            this.btnBos.Name = "btnBos";
            this.btnBos.Size = new System.Drawing.Size(116, 35);
            this.btnBos.TabIndex = 4;
            this.btnBos.Text = "Boş";
            this.btnBos.UseVisualStyleBackColor = true;
            this.btnBos.Click += new System.EventHandler(this.btnBos_Click);
            // 
            // comboDurum
            // 
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Items.AddRange(new object[] {
            "Dolu",
            "Boş"});
            this.comboDurum.Location = new System.Drawing.Point(975, 169);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(121, 24);
            this.comboDurum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(943, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Durum Güncelle";
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(975, 238);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(121, 45);
            this.btnDurumGuncelle.TabIndex = 7;
            this.btnDurumGuncelle.Text = "Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // UC_Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.btnBos);
            this.Controls.Add(this.btnDolu);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewMasa);
            this.Name = "UC_Masa";
            this.Size = new System.Drawing.Size(1304, 602);
            this.Load += new System.EventHandler(this.UC_Masa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMasa;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button btnBos;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDurumGuncelle;
    }
}
