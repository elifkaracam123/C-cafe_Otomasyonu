using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace cafe
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async Task UrunleriYukleAsync(string kategori = "")
        {
            flow_urunler.Controls.Clear();

            string connStr = "Server=localhost;Database=projeCafe;Uid=root;Pwd=;Charset=utf8;";

            using (MySqlConnection baglanti = new MySqlConnection(connStr))
            {
                await baglanti.OpenAsync();

                string sorgu = "SELECT * FROM Urunler";
                if (!string.IsNullOrEmpty(kategori))
                    sorgu += " WHERE kategori = @kategori";

                using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                {
                    if (!string.IsNullOrEmpty(kategori))
                        komut.Parameters.AddWithValue("@kategori", kategori);

                    using (MySqlDataReader dr = (MySqlDataReader)await komut.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            Panel kart = new Panel
                            {
                                Width = 160,
                                Height = 220,
                                Margin = new Padding(10),
                                BorderStyle = BorderStyle.FixedSingle,
                                BackColor = Color.White
                            };

                            PictureBox resim = new PictureBox
                            {
                                Width = 140,
                                Height = 100,
                                SizeMode = PictureBoxSizeMode.StretchImage
                            };

                            try
                            {
                                resim.Image = Image.FromFile(dr["resimYolu"].ToString());
                            }
                            catch
                            {
                                resim.Image = Properties.Resources.varsayilan;
                            }

                            Label lblAd = new Label
                            {
                                Text = dr["ad"].ToString(),
                                AutoSize = false,
                                Width = kart.Width,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            Label lblFiyat = new Label
                            {
                                Text = $"{dr["fiyat"]} TL",
                                AutoSize = false,
                                Width = kart.Width,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            Button btnSepet = new Button
                            {
                                Text = "Sepete Ekle",
                                Width = 100,
                                Height = 30,
                                BackColor = Color.FromArgb(128, 64, 64),
                                ForeColor = Color.White,
                                Tag = dr["urunId"]
                            };
                            btnSepet.Click += BtnSepet_Click;

                            kart.Controls.Add(resim);
                            kart.Controls.Add(lblAd);
                            kart.Controls.Add(lblFiyat);
                            kart.Controls.Add(btnSepet);

                            resim.Top = 10;
                            resim.Left = 10;

                            lblAd.Top = resim.Bottom + 5;
                            lblAd.Left = 0;

                            lblFiyat.Top = lblAd.Bottom + 5;
                            lblFiyat.Left = 0;

                            btnSepet.Top = lblFiyat.Bottom + 5;
                            btnSepet.Left = 30;

                            flow_urunler.Controls.Add(kart);
                        }
                    }
                }
            }
        }

        private async void BtnSepet_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int urunId = Convert.ToInt32(btn.Tag);

            string connStr = "Server=localhost;Database=projeCafe;Uid=root;Pwd=;Charset=utf8;";

            using (MySqlConnection baglanti = new MySqlConnection(connStr))
            {
                await baglanti.OpenAsync();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM Urunler WHERE urunId = @id", baglanti);
                komut.Parameters.AddWithValue("@id", urunId);

                using (MySqlDataReader dr = (MySqlDataReader)await komut.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        var mevcut = Program.Sepet.FirstOrDefault(x => x.UrunId == urunId);
                        if (mevcut != null)
                        {
                            mevcut.Adet++;
                        }
                        else
                        {
                            Program.Sepet.Add(new SepetUrun
                            {
                                UrunId = urunId,
                                UrunAdi = dr["ad"].ToString(),
                                Fiyat = Convert.ToDecimal(dr["fiyat"]),
                                Adet = 1
                            });
                        }

                        MessageBox.Show($"{dr["ad"]} sepete eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void FormMenu_Load(object sender, EventArgs e)
        {
            await UrunleriYukleAsync();
        }

        private async void btn_sicak_Click(object sender, EventArgs e)
        {
            await UrunleriYukleAsync("Sıcak İçecekler");
        }

        private async void btn_soguk_Click(object sender, EventArgs e)
        {
            await UrunleriYukleAsync("Soğuk İçecekler");
        }

        private async void btn_tatli_Click(object sender, EventArgs e)
        {
            await UrunleriYukleAsync("Tatlı");
        }

        private async void btn_yemek_Click(object sender, EventArgs e)
        {
            await UrunleriYukleAsync("Yemek");
        }

        private void flow_urunler_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

