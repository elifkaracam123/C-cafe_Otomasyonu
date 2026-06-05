namespace cafe
{
    partial class Odeme
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnayla_Click = new System.Windows.Forms.Button();
            this.radioKrediKarti = new System.Windows.Forms.RadioButton();
            this.radioNakit = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ödeme Sayfası";
            // 
            // btnOnayla_Click
            // 
            this.btnOnayla_Click.Location = new System.Drawing.Point(10, 219);
            this.btnOnayla_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnayla_Click.Name = "btnOnayla_Click";
            this.btnOnayla_Click.Size = new System.Drawing.Size(194, 72);
            this.btnOnayla_Click.TabIndex = 16;
            this.btnOnayla_Click.Text = "Onayla";
            this.btnOnayla_Click.UseVisualStyleBackColor = true;
            this.btnOnayla_Click.Click += new System.EventHandler(this.btnOnayla_Click_Click_1);
            // 
            // radioKrediKarti
            // 
            this.radioKrediKarti.AutoSize = true;
            this.radioKrediKarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKrediKarti.Location = new System.Drawing.Point(8, 155);
            this.radioKrediKarti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioKrediKarti.Name = "radioKrediKarti";
            this.radioKrediKarti.Size = new System.Drawing.Size(151, 33);
            this.radioKrediKarti.TabIndex = 15;
            this.radioKrediKarti.TabStop = true;
            this.radioKrediKarti.Text = "Kredi Kartı";
            this.radioKrediKarti.UseVisualStyleBackColor = true;
            // 
            // radioNakit
            // 
            this.radioNakit.AutoSize = true;
            this.radioNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioNakit.Location = new System.Drawing.Point(8, 104);
            this.radioNakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioNakit.Name = "radioNakit";
            this.radioNakit.Size = new System.Drawing.Size(93, 33);
            this.radioNakit.TabIndex = 14;
            this.radioNakit.TabStop = true;
            this.radioNakit.Text = "Nakit\r\n";
            this.radioNakit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::cafe.Properties.Resources.WhatsApp_Görsel_2025_06_01_saat_21_38_34_129fa54f;
            this.pictureBox1.Location = new System.Drawing.Point(236, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::cafe.Properties.Resources.paraa;
            this.pictureBox3.Location = new System.Drawing.Point(98, 95);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cafe.Properties.Resources.credit_card;
            this.pictureBox2.Location = new System.Drawing.Point(160, 148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOnayla_Click);
            this.Controls.Add(this.radioKrediKarti);
            this.Controls.Add(this.radioNakit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odeme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOnayla_Click;
        private System.Windows.Forms.RadioButton radioKrediKarti;
        private System.Windows.Forms.RadioButton radioNakit;
    }
}