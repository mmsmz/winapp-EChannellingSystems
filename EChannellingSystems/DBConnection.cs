using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Neeroga_System
{
    class DBConnection
    {
        public SqlConnection getConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=DESKTOP-ULUP989\\SQLEXPRESS; Initial Catalog=Neeroga_System; Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Open Connection !"+ ex);
            }
            return conn;
        }
    }
}
