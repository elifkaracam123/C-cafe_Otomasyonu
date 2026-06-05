using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cafe
{
    public partial class UC_Urun : UserControl
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=projeCafe;Uid=root;Pwd=;");

        public UC_Urun()
        {
            InitializeComponent();
            UrunleriGetir();
            btnGuncelle.Enabled = false; 
            btnSil.Enabled = false;      
        }




        private void UrunleriGetir(string arama = "")
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT urunId, ad AS 'Ürün Adı', kategori AS 'Kategori', fiyat AS 'Fiyat'," +
                " stokAdeti AS 'Stok Adeti', resimYolu AS 'Resim Yolu', stoktaMi AS 'Stokta Mı' FROM urunler";

                if (!string.IsNullOrEmpty(arama))
                {
                    sorgu += " WHERE ad LIKE @arama OR kategori LIKE @arama";
                }

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                if (!string.IsNullOrEmpty(arama))
                {
                    komut.Parameters.AddWithValue("@arama", "%" + arama + "%");
                }

                using (MySqlDataReader reader = komut.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader); 
                    dgvUrunler.DataSource = dt;

                    
                    if (dgvUrunler.Columns.Contains("urunId"))
                        dgvUrunler.Columns["urunId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler getirilirken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }






        private void Temizle()
        {
            txtUrunAdi.Clear();
            cmbKategori.SelectedIndex = -1;
            numFiyat.Value = 0;
            numStokAdeti.Value = 0;
            txtResimYolu.Clear();
            chkStoktaMi.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

       

       


        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {

            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçin.");
                return;
            }

            try
            {
                int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["urunId"].Value);

                baglanti.Open();
                string sorgu = "UPDATE urunler SET ad=@ad, kategori=@kategori, fiyat=@fiyat," +
                " stokAdeti=@stokAdeti, resimYolu=@resimYolu, stoktaMi=@stoktaMi WHERE urunId=@urunId";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@fiyat", numFiyat.Value);
                komut.Parameters.AddWithValue("@stokAdeti", (int)numStokAdeti.Value);
                komut.Parameters.AddWithValue("@resimYolu", txtResimYolu.Text);
                komut.Parameters.AddWithValue("@stoktaMi", chkStoktaMi.Checked ? 1 : 0);
                komut.Parameters.AddWithValue("@urunId", urunId);

                komut.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla güncellendi.");
                Temizle();

                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
                    UrunleriGetir();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin.");
                return;
            }

            int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["urunId"].Value);

            DialogResult dr = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Ürün Sil",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();

                    
                    string detaySilSorgu = "DELETE FROM siparis_detay WHERE urunId=@urunId";
                    MySqlCommand detayKomut = new MySqlCommand(detaySilSorgu, baglanti);
                    detayKomut.Parameters.AddWithValue("@urunId", urunId);
                    detayKomut.ExecuteNonQuery();

                    
                    string urunSilSorgu = "DELETE FROM urunler WHERE urunId=@urunId";
                    MySqlCommand urunKomut = new MySqlCommand(urunSilSorgu, baglanti);
                    urunKomut.Parameters.AddWithValue("@urunId", urunId);
                    urunKomut.ExecuteNonQuery();

                    MessageBox.Show("Ürün ve ilgili sipariş detayları başarıyla silindi.");
                    Temizle();
                    if (baglanti.State == System.Data.ConnectionState.Open)
                        baglanti.Close();
                        UrunleriGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == System.Data.ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();
            UrunleriGetir(aramaMetni);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) ||
                string.IsNullOrWhiteSpace(cmbKategori.Text) ||
                numFiyat.Value <= 0 ||
                numStokAdeti.Value < 0 ||
                string.IsNullOrWhiteSpace(txtResimYolu.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz ve geçerli şekilde doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                string sorgu = "INSERT INTO urunler (ad, kategori, fiyat, stokAdeti, resimYolu, stoktaMi)" +
                    " VALUES (@ad, @kategori, @fiyat, @stokAdeti, @resimYolu, @stoktaMi)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@fiyat", numFiyat.Value);
                komut.Parameters.AddWithValue("@stokAdeti", (int)numStokAdeti.Value);
                komut.Parameters.AddWithValue("@resimYolu", txtResimYolu.Text);
                komut.Parameters.AddWithValue("@stoktaMi", chkStoktaMi.Checked ? 1 : 0);

                komut.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla eklendi.");
                Temizle();
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
                UrunleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];
                txtUrunAdi.Text = row.Cells["Ürün Adı"].Value.ToString();
                cmbKategori.Text = row.Cells["Kategori"].Value.ToString();
                numFiyat.Value = Convert.ToDecimal(row.Cells["Fiyat"].Value);
                numStokAdeti.Value = Convert.ToInt32(row.Cells["Stok Adeti"].Value);
                txtResimYolu.Text = row.Cells["Resim Yolu"].Value.ToString();
                chkStoktaMi.Checked = Convert.ToBoolean(row.Cells["Stokta Mı"].Value);

                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
        }

        
    }
}


