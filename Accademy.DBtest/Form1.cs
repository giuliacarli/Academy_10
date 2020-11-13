using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.DBtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clienti_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=WINAP6A66HJRUSC\SQLEXPRESS;Initial Catalog=AccademyDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                string sqlCmdtext = "SELECT [ID],[FirstName],[LastName],[FiscalCode] FROM[AccademyDB].[dbo].[Clients]";
                SqlCommand cmd = new SqlCommand(sqlCmdtext, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string id = dr[0].ToString();
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();

                    string item = id + " " + firstName + " " + lastName;
                    this.lst_Clienti.Items.Add(item);
                }

                conn.Close(); 
            }
        }

        private void lst_Clienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = this.lst_Clienti.SelectedItem.ToString();
            string[] splittedString = item.Split(new char[] { ' ' });
            int ID = Int32.Parse(splittedString[0]);

            string connectionString = @"Data Source=WINAP6A66HJRUSC\SQLEXPRESS;Initial Catalog=AccademyDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string sqlClients_ContiCorrtext = "SELECT co.saldo FROM AccademyDB.dbo.Clients AS c INNER JOIN AccademyDB.dbo.ContiCorrenti AS co ON c.id=co.owner where co.owner =" + ID;
                SqlCommand cmd = new SqlCommand(sqlClients_ContiCorrtext, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                this.lst_ContiCorrenti.Items.Add(dr[0]);

                conn.Close();
            }
        }
    }
}