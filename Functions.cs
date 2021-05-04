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
            conn.ConnectionString = @"";//them PATH ket noi database

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
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.conn; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
    }
}
