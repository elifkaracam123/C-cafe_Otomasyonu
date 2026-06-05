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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

       

       


        private void btnOnayla_Click_Click_1(object sender, EventArgs e)
        {

            if (radioKrediKarti.Checked || radioNakit.Checked)
            {
                string odemeYontemi = radioKrediKarti.Checked ? "Kredi Kartı" : "Nakit";
                MessageBox.Show($"Ödemeniz ({odemeYontemi}) onaylandı.", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
