using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
     public class sqlDBConnection
    {
        private SqlConnection con;
        public SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public sqlDBConnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-U2CIFPM;Initial Catalog=Products;Integrated Security=True");
            con.Open();
        }

        public void SqlQuery(string qText)
        {
            cmd = new SqlCommand(qText,con);
        }

        public DataTable QueryEx()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void NonQueryEx()
        {
            cmd.ExecuteNonQuery();
        }
    }
}

