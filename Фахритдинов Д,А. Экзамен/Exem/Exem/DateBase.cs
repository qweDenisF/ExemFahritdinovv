using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exem
{
    internal class DaateBase
    {
        SqlConnection Sqlconnection = new SqlConnection(@"Data Source=appk-main;Initial Catalog=BeautyShopFD;Integrated Security=True");
        public void openConnection()
        {
            if (Sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                Sqlconnection.Open();
            }

        }

        public void closeConnection()
        {
            if (Sqlconnection.State == System.Data.ConnectionState.Open)
            {
                Sqlconnection.Close();
            }



        }

        internal object getConnection()
        {
            throw new NotImplementedException();
        }
    }
}
