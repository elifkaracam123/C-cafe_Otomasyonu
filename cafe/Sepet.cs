using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cafe
{
    public partial class sepet : Form
    {
        public sepet()
        {
            InitializeComponent();
            dgv_sepet.AutoGenerateColumns = false;
            SütunlariOlustur();
            dgv_sepet.RowTemplate.Height = 80;
            dgv_sepet.CellClick += dgv_sepet_CellContentClick;
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            SepetiGoster();
        }

        private void SütunlariOlustur()
        {
            dgv_sepet.Columns.Clear();

            
            DataGridViewImageColumn resimCol = new DataGridViewImageColumn
            {
                Name = "Resim",
                HeaderText = "Resim",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            };
            dgv_sepet.Columns.Add(resimCol);

            dgv_sepet.Columns.Add("UrunAdi", "Ürün Adı");

            dgv_sepet.Columns.Add("Fiyat", "Fiyat");

            dgv_sepet.Columns.Add("Adet", "Adet");

            dgv_sepet.Columns.Add("Toplam", "Toplam");

            
            DataGridViewButtonColumn silCol = new DataGridViewButtonColumn
            {
                Name = "Sil",
                HeaderText = "İşlem",
                Text = "Sil",
                UseColumnTextForButtonValue = true,
                Width = 60
            };
            dgv_sepet.Columns.Add(silCol);

            DataGridViewTextBoxColumn urunIdCol = new DataGridViewTextBoxColumn
            {
                Name = "UrunId",
                Visible = false
            };
            dgv_sepet.Columns.Add(urunIdCol);
        }


        private void SepetiGoster()
        {
            dgv_sepet.Rows.Clear();

            foreach (var urun in Program.Sepet)
            {
                Image urunResmi;

                try
                {
                    string resimYolu = UrunResimYoluGetir(urun.UrunId);
                    if (!string.IsNullOrEmpty(resimYolu) && System.IO.File.Exists(resimYolu))
                        urunResmi = Image.FromFile(resimYolu);
                    else
                        urunResmi = Properties.Resources.varsayilan;
                }
                catch
                {
                    urunResmi = Properties.Resources.varsayilan;
                }

                dgv_sepet.Rows.Add(
                    urunResmi,
                    urun.UrunAdi,
                    $"{urun.Fiyat:F2} TL",
                    urun.Adet,
                    $"{urun.Fiyat * urun.Adet:F2} TL",
                    "Sil",
                    urun.UrunId
                );
            }

            
            dgv_sepet.ClearSelection();
            dgv_sepet.CurrentCell = null;
            ToplamFiyatiGuncelle();
        }

        private void ToplamFiyatiGuncelle()
        {
            decimal toplamFiyat = 0;

            foreach (var urun in Program.Sepet)
            {
                toplamFiyat += urun.Fiyat * urun.Adet;
            }

            lbl_toplam.Text = $"Toplam: {toplamFiyat:F2} TL";
        }


        private string UrunResimYoluGetir(int urunId)
        {
            string yol = "";
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=projeCafe;Uid=root;Pwd=;Charset=utf8;"))
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT resimYolu FROM Urunler WHERE urunId = @id", baglanti);
                komut.Parameters.AddWithValue("@id", urunId);
                object sonuc = komut.ExecuteScalar();
                yol = sonuc?.ToString();
            }
            return yol;
        }



        private void btn_sepetBoşalt_Click(object sender, EventArgs e)
        {
            if (Program.Sepet.Count == 0)
            {
                MessageBox.Show("Sepet zaten boş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Sepeti tamamen boşaltmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Program.Sepet.Clear();
                SepetiGoster();
            }
            ToplamFiyatiGuncelle();
        }

        private void btn_sepetOnay_Click(object sender, EventArgs e)
        {
            if (Program.Sepet.Count == 0)
            {
                MessageBox.Show("Sepet boş. Öncelikle ürün ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SiparisTipiSec secimForm = new SiparisTipiSec();
            if (secimForm.ShowDialog() == DialogResult.OK)
            {
                if (secimForm.SecilenTip == SiparisTipiSec.Tip.AlGötür)
                {
                    
                    Odeme odemeForm = new Odeme();
                    if (odemeForm.ShowDialog() == DialogResult.OK)
                    {
                        int alGötürMasaId = -1;
                        SiparisiKaydet(alGötürMasaId);

                        MessageBox.Show("Al Götür sipariş başarıyla kaydedildi.");

                        Program.Sepet.Clear();
                        SepetiGoster();
                        ToplamFiyatiGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Ödeme iptal edildi. Sipariş kaydedilmedi.");
                    }
                }
                else if (secimForm.SecilenTip == SiparisTipiSec.Tip.Masa)
                {
                    
                    Masa masaForm = new Masa();
                    if (masaForm.ShowDialog() == DialogResult.OK)
                    {
                        int secilenMasaId = masaForm.SecilenMasaId;

                        
                        SiparisiKaydet(secilenMasaId);

                        MessageBox.Show($"Sipariş başarıyla masa {secilenMasaId}'ye kaydedildi.");

                        Program.Sepet.Clear();
                        SepetiGoster();
                        ToplamFiyatiGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Masa seçilmedi. Sipariş kaydedilmedi.");
                    }
                }
            }
        }

        private void SiparisiKaydet(int masaId)
        {
            try
            {
                using (var conn = new MySqlConnection("Server=localhost;Database=projeCafe;Uid=root;Pwd=;Charset=utf8;"))
                {
                    conn.Open();

                    // Önce siparisler tablosuna 1 kayıt
                    var siparisCmd = new MySqlCommand(@"INSERT INTO siparisler (masaId, toplamFiyat, tarih) 
                                                VALUES (@masaId, @toplamFiyat, NOW());
                                                SELECT LAST_INSERT_ID();", conn);

                    decimal toplamFiyat = Program.Sepet.Sum(x => x.Fiyat * x.Adet);

                    if (masaId == -1)
                        siparisCmd.Parameters.AddWithValue("@masaId", DBNull.Value); // Al Götür
                    else
                        siparisCmd.Parameters.AddWithValue("@masaId", masaId); // Normal masa siparişi

                    siparisCmd.Parameters.AddWithValue("@toplamFiyat", toplamFiyat);

                    int siparisId = Convert.ToInt32(siparisCmd.ExecuteScalar());

                    
                    foreach (var urun in Program.Sepet)
                    {
                        var detayCmd = new MySqlCommand(@"INSERT INTO siparis_detay 
                        (siparisId, urunId, adet, birimFiyat) 
                        VALUES (@siparisId, @urunId, @adet, @birimFiyat)", conn);

                        detayCmd.Parameters.AddWithValue("@siparisId", siparisId);
                        detayCmd.Parameters.AddWithValue("@urunId", urun.UrunId);
                        detayCmd.Parameters.AddWithValue("@adet", urun.Adet);
                        detayCmd.Parameters.AddWithValue("@birimFiyat", urun.Fiyat);

                        detayCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş kaydedilirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dgv_sepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgv_sepet.Columns[e.ColumnIndex].Name == "Sil")
            {
                int urunId = Convert.ToInt32(dgv_sepet.Rows[e.RowIndex].Cells["UrunId"].Value);

                var urun = Program.Sepet.FirstOrDefault(x => x.UrunId == urunId);
                if (urun != null)
                {
                    if (urun.Adet > 1)
                    {
                        urun.Adet--; // sadece adet azalt
                    }
                    else
                    {
                        Program.Sepet.Remove(urun); // son adet ise tamamen sil
                    }

                    SepetiGoster(); // her durumda güncelle
                    ToplamFiyatiGuncelle();
                }
            }
        }

        
    }
}
