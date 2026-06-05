using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class form_logo : Form
    {
        public form_logo()
        {
            InitializeComponent();
        }
        bool islem = false; 

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.009;
            }
            if(this.Opacity==1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.009;
                if(this.Opacity==0)
                {
                    form_giris gtr = new form_giris();
                    gtr.Show();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
