using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Functions
    {
        public static SqlConnection conn;
        
        public static void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"";
            conn.Open();

            if (conn.State == ConnectionState.Open)
                MessageBox.Show("successful connection");
            else MessageBox.Show("Cannot connection with database");

        }
        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close(); // close connect
                conn.Dispose(); // giai phong tai nguyen
                conn = null;
            }
        }
    }
}
