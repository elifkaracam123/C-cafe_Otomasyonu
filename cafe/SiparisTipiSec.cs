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
    public partial class SiparisTipiSec : Form
    {
        public enum Tip { Masa, AlGötür }
        public Tip SecilenTip { get; private set; }
        public SiparisTipiSec()
        {
            InitializeComponent();
        }

        private void btn_masaSec_Click(object sender, EventArgs e)
        {
            SecilenTip = Tip.Masa;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_alGotur_Click(object sender, EventArgs e)
        {
            SecilenTip = Tip.AlGötür;
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
