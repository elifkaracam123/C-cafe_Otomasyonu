using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
using System.Security.Cryptography;

namespace cafe
{
    public partial class form_giris : Form
    {
        public form_giris()
        {
            InitializeComponent();
        }

        // mysql baglantısı
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=projeCafe;Uid=root;Pwd=;");

        private string SifreyiHashle(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(sifre);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string telefon = txt_telefon.Text;
            string sifre = txt_sifre.Text;

            // Admin kontrolü
            if (telefon == "admin" && sifre == "777")
            {
                MessageBox.Show("Admin girişi başarılı!");
                form_admin adminForm = new form_admin();
                adminForm.Show();
                this.Hide();
                return;
            }

            string hashliSifre = SifreyiHashle(sifre);

            try
            {
                baglanti.Open();

                string sorgu = "SELECT COUNT(*) FROM Kullanicilar WHERE telefon = @telefon AND sifre = @sifre";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@sifre", hashliSifre);

                int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                if (sonuc > 0)
                {
                    KullaniciBilgisi.Telefon = txt_telefon.Text;

                    MessageBox.Show("Giriş başarılı!");
                    form_anasayfa gtr = new form_anasayfa();
                    gtr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Telefon numarası veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void lbl_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_kayit gtr = new form_kayit();
            gtr.Show();
            this.Hide();
        }

        private void lbl_uyeolmaa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_anasayfa gtr = new form_anasayfa();
            gtr.Show();
            this.Hide();
        }
    }
}
