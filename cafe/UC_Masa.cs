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
    public partial class UC_Masa : UserControl
    {
        public UC_Masa()
        {
            InitializeComponent();
        }

        private void MasalariYukle(bool? sadeceDolu)
        {
            dataGridViewMasa.Rows.Clear();
            dataGridViewMasa.Columns.Clear();
            dataGridViewMasa.Columns.Add("masaId", "ID");
            dataGridViewMasa.Columns.Add("masaNo", "Masa No");
            dataGridViewMasa.Columns.Add("doluMu", "Durum");

            string query = "SELECT * FROM masalar";
            if (sadeceDolu.HasValue)
                query += " WHERE doluMu = @doluMu";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=projeCafe;uid=root;pwd=;"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (sadeceDolu.HasValue)
                    cmd.Parameters.AddWithValue("@doluMu", sadeceDolu.Value ? 1 : 0);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridViewMasa.Rows.Add(
                        reader["masaId"],
                        reader["masaNo"],
                        Convert.ToBoolean(reader["doluMu"]) ? "Dolu" : "Boş"
                    );
                }
                reader.Close();
            }
        }


        private int YeniMasaNoGetir()
        {
            int yeniNo = 1;
            foreach (DataGridViewRow row in dataGridViewMasa.Rows)
            {
                if (row.Cells["masaNo"].Value != null)
                {
                    int mevcutNo = Convert.ToInt32(row.Cells["masaNo"].Value);
                    if (mevcutNo >= yeniNo)
                        yeniNo = mevcutNo + 1;
                }
            }
            return yeniNo;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=projeCafe;uid=root;pwd=;"))
                {
                    conn.Open();
                    string query = "INSERT INTO masalar (masaNo, doluMu) VALUES (@masaNo, 0)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@masaNo", YeniMasaNoGetir());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Masa başarıyla eklendi.");
                    TumMasalariYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasa.SelectedRows.Count > 0)
            {
                int masaId = Convert.ToInt32(dataGridViewMasa.SelectedRows[0].Cells["masaId"].Value);

                DialogResult result = MessageBox.Show("Bu masayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection("server=localhost;database=projeCafe;uid=root;pwd=;"))
                        {
                            conn.Open();
                            string query = "DELETE FROM masalar WHERE masaId = @id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", masaId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Masa silindi.");
                            TumMasalariYukle();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir masa seçin.");
            }
        }

        private void UC_Masa_Load(object sender, EventArgs e)
        {
            TumMasalariYukle();

            comboDurum.Items.Clear();
            comboDurum.Items.Add("Boş");
            comboDurum.Items.Add("Dolu");
            comboDurum.SelectedIndex = 0;

        }

        private void TumMasalariYukle()
        {
            MasalariYukle(null);
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MasalariYukle(true);
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MasalariYukle(false);

        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasa.SelectedRows.Count > 0)
            {
                int masaId = Convert.ToInt32(dataGridViewMasa.SelectedRows[0].Cells["masaId"].Value);
                bool yeniDurum = comboDurum.SelectedItem.ToString() == "Dolu" ? true : false;

                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=projeCafe;uid=root;pwd=;"))
                {
                    conn.Open();
                    string query = "UPDATE masalar SET doluMu = @doluMu WHERE masaId = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@doluMu", yeniDurum ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", masaId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Masa durumu başarıyla güncellendi.");
                    TumMasalariYukle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir masa seçin.");
            }
        }
        

    }
}
