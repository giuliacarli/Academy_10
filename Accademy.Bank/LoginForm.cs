using Accademy.DataManager;
using Accademy.Entities;
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
    public partial class LoginForm : Form
    {
        private IDataManager datamanager;
        public LoginForm()
        {
            datamanager = new FIleSystemDataManager();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = this.txt_username.Text;
            string password = this.txt_password.Text;

            if (datamanager.LoginIsOK(username, password))
            {
                if (datamanager.UserIsAnOwner(username))
                {
                    ContoCorrente cc = datamanager.GetContocorrenteByUsername(username);
                    ManageCCForm manageform = new ManageCCForm(cc.GetNumeroConto());
                    manageform.Tag = this;
                    manageform.Show();
                    this.Hide();
                }
                else
                {
                    //OpenCCForm openform = new OpenCCForm();
                    //openform.CurrentUser = username;

                    OpenCCForm openform = new OpenCCForm(username);

                    openform.Tag = this;
                    openform.Show();
                    this.Hide();
                }              
            }
            else
            {
                this.lbl_loginerror.Text = "Invalid Credentials!";
            }
        }
    }
}
