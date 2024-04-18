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

namespace Exem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyShopFDDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.beautyShopFDDataSet.Расписание);
            try
            {
                string connectString = "Data Source=appk-main;Initial Catalog=BeautyShopFD;Integrated Security=True";
                SqlConnection Connection = new SqlConnection(connectString);


                Connection.Open();

                string query = @"SELECT nameserv,dolg,price  FROM  Услуги  ";
                SqlCommand cmd = new SqlCommand(query, Connection);
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                dAdapter.Fill(ds);

                dataGridView1.ReadOnly = true;

                dataGridView1.DataSource = ds.Tables[0];



                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ohas main = new Ohas();

            main.Show();

            this.Hide();
        }
    }
    
}
