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
    public partial class form_admin : Form
    {
        public form_admin()
        {
            InitializeComponent();
        }
        private void EkranaGetir(UserControl user)
        {
            panel_icerik.Controls.Clear();
            user.Dock = DockStyle.Fill;
            panel_icerik.Controls.Add(user);
        }


       
       


        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            EkranaGetir(new UC_Urun());
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            EkranaGetir(new UC_Siparis());

        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            EkranaGetir(new UC_Kullanici());

        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_giris().Show();
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            EkranaGetir(new UC_Masa());
        }

    }
}

