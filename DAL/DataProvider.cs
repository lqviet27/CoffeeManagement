using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DataProvider
    {
        private static string ConStr = @"Data Source=desktop-0pub91e\toan1;Initial Catalog=PBL3;Integrated Security=True";
        public SqlConnection con { get; set; }
        private static DataProvider _instance;
        private DataProvider()
        {
            con = new SqlConnection(ConStr);
        }
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DataProvider();
                return _instance;
            }
            private set => _instance = value;

        }
        public DataTable ExecuteTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Check Information Again !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Check Information Again !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        public string ExecuteScalar(SqlCommand cmd)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                return cmd.ExecuteScalar().ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Check Information Again !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
