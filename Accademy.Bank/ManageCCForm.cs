using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Bank
{
    public partial class ManageCCForm : Form
    {
        public ManageCCForm(string numconto)
        {
            InitializeComponent();
            this.lbl_CC.Text = numconto;
        }

        private void lbl_CC_Click(object sender, EventArgs e)
        {

        }

        private void btn_Preleva_Click(object sender, EventArgs e)
        {

        }

        private void btn_versa_Click(object sender, EventArgs e)
        {

        }

        private void btn_esegui_bonifico_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }
    }
}
