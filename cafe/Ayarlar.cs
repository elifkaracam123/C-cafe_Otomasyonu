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
    public partial class form_ayarlar : Form
    {
        public form_ayarlar()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=projeCafe;Uid=root;Pwd=;Charset=utf8;");

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

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            string telefon = KullaniciBilgisi.Telefon;
            if (string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Kullanıcı tanımlı değil. Buraya erişim için kayıt ol.");
                
                this.Close();
                return;
            }

            try
            {
                baglanti.Open();
                string sorgu = "SELECT ad, soyad, mail FROM Kullanicilar WHERE telefon = @telefon";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@telefon", telefon);

                MySqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    txt_telefon.Text = telefon;
                    txt_ad.Text = dr["ad"].ToString();
                    txt_soyad.Text = dr["soyad"].ToString();
                    txt_mail.Text = dr["mail"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            string telefon = KullaniciBilgisi.Telefon;
            string ad = txt_ad.Text.Trim();
            string soyad = txt_soyad.Text.Trim();
            string mail = txt_mail.Text.Trim();
            string sifre = txt_sifre.Text;
            string sifreTekrar = txt_sifreTekrar.Text;

            // Ad ve soyad kontrolü
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Ad ve soyad boş bırakılamaz.");
                return;
            }

            // Mail kontrolü isteğe bağlı
            if (!string.IsNullOrWhiteSpace(mail))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Geçerli bir e-posta adresi giriniz (örnek: isim@example.com).");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(sifre))
            {
                if (sifre != sifreTekrar)
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                    return;
                }

                // Şifre güvenlik kontrolü
                if (sifre.Length < 8 ||
                    !sifre.Any(char.IsUpper) ||       // büyük harf kontrolü
                    !sifre.Any(char.IsLower) ||       // küçük harf kontrolü
                    !sifre.Any(char.IsDigit))         // rakam kontrolü
                {
                    MessageBox.Show("Şifre en az 8 karakter olmalı, en az bir büyük harf, bir küçük harf ve bir rakam içermelidir.");
                    return;
                }
            }


            // Güncelleme işlemi
            try
            {
                baglanti.Open();
                string sorgu = @"UPDATE Kullanicilar 
                        SET ad = @ad, soyad = @soyad, mail = @mail" +
                               (!string.IsNullOrWhiteSpace(sifre) ? ", sifre = @sifre" : "") +
                               " WHERE telefon = @telefon";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@telefon", telefon);

                if (!string.IsNullOrWhiteSpace(sifre))
                {
                    komut.Parameters.AddWithValue("@sifre", SifreyiHashle(sifre));
                }

                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgiler güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

    }
}
