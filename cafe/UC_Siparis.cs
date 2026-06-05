using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace cafe
{
    public partial class UC_Siparis : UserControl
    {
        public UC_Siparis()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server=localhost;user=root;database=projeCafe;password=;");
        DataTable dt;


        void SiparisDetayGoster(int siparisId)
        {
            try
            {
                string sorgu = @"
                SELECT u.ad, sd.adet, sd.birimFiyat, (sd.adet * sd.birimFiyat) AS toplam
                FROM siparis_detay sd
                JOIN urunler u ON sd.urunId = u.urunId
                WHERE sd.siparisId = @siparisId";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@siparisId", siparisId);

                listView1.Items.Clear();

                if (listView1.Columns.Count == 0)
                {
                    listView1.Columns.Add("Ürün Adı", 150);
                    listView1.Columns.Add("Adet", 70);
                    listView1.Columns.Add("Birim Fiyat", 100);
                    listView1.Columns.Add("Toplam", 100);
                }

                baglanti.Open();
                MySqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ad"].ToString());
                    item.SubItems.Add(reader["adet"].ToString());
                    item.SubItems.Add(reader["birimFiyat"].ToString());
                    item.SubItems.Add(reader["toplam"].ToString());

                    listView1.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }


        void SiparisleriYukle()
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("siparisId");

                string sorgu = "SELECT siparisId FROM siparisler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                baglanti.Open();
                MySqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    dt.Rows.Add(reader["siparisId"]);
                }

                reader.Close();
                dataGridView1.DataSource = dt;

                if (!dataGridView1.Columns.Contains("Detay"))
                {
                    DataGridViewButtonColumn detayButton = new DataGridViewButtonColumn();
                    detayButton.HeaderText = "Detay";
                    detayButton.Name = "Detay";
                    detayButton.Text = "Göster";
                    detayButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(detayButton);
                }

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }


        private void UC_Siparis_Load(object sender, EventArgs e)
        {
            SiparisleriYukle();

        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detay")
            {
                int siparisId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["siparisId"].Value);
                SiparisDetayGoster(siparisId);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "SatirSil")
            {
                
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                
                listView1.Items.Clear();
            }
        }

        private void btnKaldir_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];

                dataGridView1.Rows.Remove(secilenSatir);

                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
