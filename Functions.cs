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
            conn.ConnectionString = @"Data Source=ADMIN;Initial Catalog=homework;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//them PATH ket noi database

            conn.Open();

            if (conn.State == ConnectionState.Open)
                MessageBox.Show("successful connection");
            else MessageBox.Show("Cannot connection with database");

        }
        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); 
            
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.conn;
            dap.SelectCommand.CommandText = sql;
            
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
