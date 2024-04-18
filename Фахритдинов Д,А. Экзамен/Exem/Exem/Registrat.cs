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
using System.Xml.Linq;

namespace Exem
{
    public partial class Registrat : Form
    {
        
        public Registrat()
        {
            InitializeComponent();

        }

        private void Registrat_Load(object sender, EventArgs e)
        {
            

        }

        private void TBfioReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrDob_Click(object sender, EventArgs e)
        {
            string connectString = "Data Source=appk-main;Initial Catalog=BeautyShopFD;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectString);
            
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter Adapt = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query;
            int res;

            try
            {
                con.Open();
                query = "Insert Into [Клиент] (FIO, PhoneK, EMail, Name,Password) VALUES ('" + TBfioReg.Text + "','" + TBphoneReg.Text + "','" + TBemailReg.Text + "','" + TBuserReg.Text + "','" + TBpasswReg.Text + "')";
                cmd = new SqlCommand();
                
                cmd.Connection = con;
                cmd.CommandText = query;

                res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show("New user has been save in the database.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);

            }

               
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();

            main.Show();

            this.Hide();
        }
    }
}
