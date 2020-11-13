using Accademy.DataManager;
using Accademy.Entities;
using DataManager;
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
    public partial class OpenCCForm : Form
    {
        private IDataManager datamanager;
        private string CurrentUser;
        public OpenCCForm(string username)
        {
            InitializeComponent();
            datamanager = new FIleSystemDataManager();
            this.CurrentUser = username;
            this.label3.Text = CurrentUser;
            string numConto = Accademy.Helper.Helper.GetNumConto(20);
            this.label5.Text = numConto;
        }
        public OpenCCForm()
        {
            datamanager = new FIleSystemDataManager();
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            string username = this.label3.Text;
            string numconto = this.label5.Text;
            string nome = this.txt_Nome.Text;
            string cognome = this.txt_Cognome.Text;
            string cf = this.txt_CF.Text;

            ContoCorrente newCC = new ContoCorrente(numconto);

            Cliente newCliente = new Cliente()
            {
                Username = username,
                FirstName = nome,
                LastName = cognome,
                CF = cf,
                mioConto = newCC
            };

            DataOperationResult result = datamanager.CreateNewCliente(newCliente);
            if (result.IsOK)
            {
                
                ManageCCForm manageform = new ManageCCForm(numconto);
                manageform.Tag = this;
                manageform.Show();
                this.Hide();
            }
            else
            {
                this.label9.Text = result.Message;
            }

        }
    }
}
