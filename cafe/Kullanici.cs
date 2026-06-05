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
    public partial class form_anasayfa : Form
    {
        public form_anasayfa()
        {
            InitializeComponent();
        }

        private Form aktifForm = null;

        private void FormuPaneldeAc(Form yeniForm)
        {
            if (aktifForm != null)
                aktifForm.Close();

            aktifForm = yeniForm;
            yeniForm.TopLevel = false;
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.Dock = DockStyle.Fill;
            panel_icerik.Controls.Add(yeniForm);
            panel_icerik.Tag = yeniForm;
            yeniForm.BringToFront();
            yeniForm.Show();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FormuPaneldeAc(new Menu());
        }

        private void panel_icerik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            FormuPaneldeAc(new form_ayarlar());
        }

        private void btn_sepet_Click(object sender, EventArgs e)
        {
            FormuPaneldeAc(new sepet());
        }

        private void btn_masalar_Click(object sender, EventArgs e)
        {
            FormuPaneldeAc(new Masa());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form_giris().Show();
        }
    }
}
