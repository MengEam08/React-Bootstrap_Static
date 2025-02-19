using System.Data.SqlClient;

namespace Store
{
    internal class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\C# Project\My Store\My Store\mystoresystem.mdf"";Integrated Security=True;Connect Timeout=30");

        public SqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseCon()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
