using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions; 


namespace cafe
{
    public partial class form_kayit : Form
    {
        public form_kayit()
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

        private void btn_kayit_Click_1(object sender, EventArgs e)
        {
            string telefon = txt_telefon.Text;
            string mail = txt_mail.Text;
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            string sifre = txt_sifre.Text;
            string sifreTekrar = txt_sifreTekrar.Text;

            if (string.IsNullOrWhiteSpace(telefon) ||
                string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(soyad) ||
                string.IsNullOrWhiteSpace(sifre) ||
                string.IsNullOrWhiteSpace(sifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun. Mail adresi isteğe bağlıdır.");
                return;
            }

            // Telefon kontrolü
            if (!Regex.IsMatch(telefon, @"^\d{10}$"))
            {
                MessageBox.Show("Telefon numarası 10 haneli olmalı ve sadece rakamlardan oluşmalıdır (örn: 5551234567).");
                return;
            }

            // E-posta kontrolü (boş değilse)
            if (!string.IsNullOrWhiteSpace(mail))
            {
                if (!Regex.IsMatch(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin (örn: example@gmail.com).");
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


            string hashliSifre = SifreyiHashle(sifre);

            try
            {
                baglanti.Open();

                string telefonKontrolSorgu = "SELECT COUNT(*) FROM Kullanicilar WHERE telefon = @telefon";
                MySqlCommand telefonKomut = new MySqlCommand(telefonKontrolSorgu, baglanti);
                telefonKomut.Parameters.AddWithValue("@telefon", telefon);
                int telefonVarMi = Convert.ToInt32(telefonKomut.ExecuteScalar());

                int mailVarMi = 0;

                if (!string.IsNullOrWhiteSpace(mail))
                {
                    string mailKontrolSorgu = "SELECT COUNT(*) FROM Kullanicilar WHERE mail = @mail";
                    MySqlCommand mailKomut = new MySqlCommand(mailKontrolSorgu, baglanti);
                    mailKomut.Parameters.AddWithValue("@mail", mail);
                    mailVarMi = Convert.ToInt32(mailKomut.ExecuteScalar());
                }

                if (telefonVarMi > 0)
                {
                    MessageBox.Show("Bu telefon numarası zaten kayıtlı!");
                }
                else if (mailVarMi > 0)
                {
                    MessageBox.Show("Bu mail adresi zaten kayıtlı!");
                }
                else
                {
                    string ekleSorgu = @"INSERT INTO Kullanicilar (telefon, mail, ad, soyad, sifre)
                                 VALUES (@telefon, @mail, @ad, @soyad, @sifre)";
                    MySqlCommand ekleKomut = new MySqlCommand(ekleSorgu, baglanti);
                    ekleKomut.Parameters.AddWithValue("@telefon", telefon);
                    ekleKomut.Parameters.AddWithValue("@mail", mail);
                    ekleKomut.Parameters.AddWithValue("@ad", ad);
                    ekleKomut.Parameters.AddWithValue("@soyad", soyad);
                    ekleKomut.Parameters.AddWithValue("@sifre", hashliSifre);

                    ekleKomut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla oluşturuldu!");

                    form_giris gtr = new form_giris();
                    gtr.Show();
                    this.Hide();
                }
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

        private void lbl_giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_giris gtr = new form_giris();
            gtr.Show();
            this.Hide();
        }

        private void form_kayit_Load(object sender, EventArgs e)
        {

        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve kontrol tuşlarına izin verir
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Harfi engelle
            }
        }

    
}
}
