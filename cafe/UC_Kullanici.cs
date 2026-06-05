using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class UC_Kullanici : UserControl
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=projeCafe;Uid=root;Pwd=;");

        public UC_Kullanici()
        {
            InitializeComponent();
            KullanicilariGetir();
            btnSil.Enabled = false;
        }
        private void KullanicilariGetir(string arama = "")
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT kullaniciId, ad AS 'Ad', soyad AS 'Soyad', mail AS 'Email', telefon AS" +
                " 'Telefon', kayitTarihi AS 'Kayıt Tarihi' FROM kullanicilar";

                if (!string.IsNullOrEmpty(arama))
                {
                    sorgu += " WHERE ad LIKE @arama OR soyad LIKE @arama OR mail LIKE @arama";
                }

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                if (!string.IsNullOrEmpty(arama))
                {
                    komut.Parameters.AddWithValue("@arama", "%" + arama + "%");
                }

                MySqlDataReader reader = komut.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);  // Reader'dan DataTable'a veri aktarımı

                dgvKullanicilar.DataSource = dt;
                dgvKullanicilar.Columns["kullaniciId"].Visible = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcılar getirilirken hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }




        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir kullanıcı seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["kullaniciId"].Value);

            DialogResult sonuc = MessageBox.Show("Bu kullanıcıyı silmek istiyor musun? ",
            "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    string silSorgu = "DELETE FROM kullanicilar WHERE kullaniciId = @id";
                    MySqlCommand komut = new MySqlCommand(silSorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kullanıcı silindi");
                    KullanicilariGetir();
                    btnSil.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                btnSil.Enabled = true;
            }
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {

            string aranan = txtArama.Text.Trim();
            KullanicilariGetir(aranan);
        }


        private void UC_Kullanici_Load_1(object sender, EventArgs e)
        {

        }
    }
}
