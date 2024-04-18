using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exem
{
    public partial class Form1 : Form
    {
        DaateBase database = new DaateBase();

        public Form1()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Regist_Click(object sender, EventArgs e)
        {
            Registrat reg = new Registrat();
            reg.Show();
            this.Hide();
            
        }

        private void Avtor_Click(object sender, EventArgs e)
        {

           
            string connectionString = ("Data Source=appk-main;Initial Catalog=BeautyShopFD;Integrated Security=True");
            SqlConnection conn = new SqlConnection(connectionString);

            var loginUser = TbUserAvt.Text;
            var passUser = TbPasAvt.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

                string querystring = $"select [Name],[password] from Клиент where Name='{loginUser}' and Password= '{passUser}' ";

            SqlCommand command = new SqlCommand(querystring,conn);
            conn.Open();
            

            adapter.SelectCommand = command;
                adapter.Fill(table);

                if (TbUserAvt.TextLength <= 0)
                {
                    MessageBox.Show("Не заполнено поле Логин");

                }

                if (TbPasAvt.TextLength <= 0)
                {
                    MessageBox.Show("Не заполнено поле Пароль");

                }

                if (table.Rows.Count == 1)
                {
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();




                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();

                    main.Show();

                    this.Hide();
                conn.Close();

                }
                else
                {

                    MessageBox.Show("Такого аккаунта не существует!!!", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            
        }
    }
}
