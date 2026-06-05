using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cafe
{
    public partial class Masa : Form
    {
        private readonly string connectionString = "Server=localhost;Database=projeCafe;Uid=root;Pwd=;Charset=utf8;";
        private List<MasaModel> masalar;
        private Image masaResmi;

        public Masa()
        {
            InitializeComponent();
            masaResmi = Properties.Resources.masa; // Resources - masa.png
        }

        private void Masa_Load(object sender, EventArgs e)
        {
            masalar = GetMasalar();
            MasalariOlustur();
        }

        private void MasalariOlustur()
        {
            int kolonSayisi = 8; // Her satırda kaç masa olacak
            int aralik = 20;     // Masalar arası boşluk
            int genislik = 150;
            int yukseklik = 150;

            for (int i = 0; i < masalar.Count; i++)
            {
                MasaModel masa = masalar[i];

               
                Panel panel = new Panel
                {
                    Width = genislik,
                    Height = yukseklik + 20,
                };

                int x = (i % kolonSayisi) * (genislik + aralik) + aralik;
                int y = (i / kolonSayisi) * (yukseklik + 40) + aralik;
                panel.Location = new Point(x, y);

                
                PictureBox pb = new PictureBox
                {
                    Width = genislik,
                    Height = yukseklik,
                    Tag = masa.MasaNo,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand,
                };

                pb.Click += Masa_Click;
                MasaDurumunuGuncelle(pb, masa);

                
                Label lbl = new Label
                {
                    Text = $"Masa {masa.MasaNo}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom,
                    Height = 20,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                };

                
                panel.Controls.Add(pb);
                panel.Controls.Add(lbl);

                
                this.Controls.Add(panel);
            }
        }



        private MasaModel seciliMasa = null; // class düzeyinde tanımlı olacak
        public int SecilenMasaId { get; private set; } // dışarı aktarılacak masa ID



        private void Masa_Click(object sender, EventArgs e)
        {
            PictureBox tiklananMasa = sender as PictureBox;
            int masaNo = (int)tiklananMasa.Tag;

            MasaModel masa = masalar.FirstOrDefault(m => m.MasaNo == masaNo);
            if (masa == null) return;

            
            if (seciliMasa != null)
            {
                if (seciliMasa.MasaNo == masa.MasaNo)
                {
                    MessageBox.Show($"Zaten bu masayı seçtiniz: Masa {masa.MasaNo}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Zaten bir masa seçtiniz: Masa {seciliMasa.MasaNo}. Lütfen önce onu boşaltın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            
            if (masa.DoluMu)
            {
                MessageBox.Show($"Masa {masa.MasaNo} zaten dolu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            seciliMasa = masa;

            
            using (Odeme odemeForm = new Odeme())
            {
                var result = odemeForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    masa.DoluMu = true;
                    SecilenMasaId = masa.MasaId;

                    GuncelleMasaDurumu(masa.MasaId, true);
                    MasaDurumunuGuncelle(tiklananMasa, masa);

                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    
                    seciliMasa = null;
                    MessageBox.Show("Ödeme iptal edildi. Masa seçimi yapılmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        




        private void MasaDurumunuGuncelle(PictureBox pb, MasaModel masa)
        {
            if (pb == null || masa == null)
                return;

            Bitmap bmp = new Bitmap(masaResmi.Width, masaResmi.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                
                g.DrawImage(masaResmi, 0, 0, bmp.Width, bmp.Height);

                
                Color renk = masa.DoluMu ? Color.FromArgb(120, Color.Red) : Color.FromArgb(120, Color.Green);
                using (Brush b = new SolidBrush(renk))
                {
                    g.FillRectangle(b, 0, 0, bmp.Width, bmp.Height);
                }

                
                string yazi = $"Masa {masa.MasaNo}";
                using (Font font = new Font("Arial", 14, FontStyle.Bold))
                using (Brush yaziRenk = new SolidBrush(Color.White))
                {
                    SizeF yaziBoyut = g.MeasureString(yazi, font);
                    PointF konum = new PointF((bmp.Width - yaziBoyut.Width) / 2, (bmp.Height - yaziBoyut.Height) / 2);
                    g.DrawString(yazi, font, yaziRenk, konum);
                }
            }

            pb.Image = bmp;
        }


       
        private List<MasaModel> GetMasalar()
        {
            var liste = new List<MasaModel>();
            string query = "SELECT masaId, masaNo, doluMu FROM Masalar ORDER BY masaNo";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        liste.Add(new MasaModel
                        {
                            MasaId = reader.GetInt32("masaId"),
                            MasaNo = reader.GetInt32("masaNo"),
                            DoluMu = reader.GetBoolean("doluMu")
                        });
                    }
                }
            }

            return liste;
        }

        private void GuncelleMasaDurumu(int masaId, bool doluMu)
        {
            string query = "UPDATE Masalar SET doluMu = @doluMu WHERE masaId = @masaId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@doluMu", doluMu);
                cmd.Parameters.AddWithValue("@masaId", masaId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }



    
    public class MasaModel
    {
        public int MasaId { get; set; }
        public int MasaNo { get; set; }
        public bool DoluMu { get; set; }
    }
}
