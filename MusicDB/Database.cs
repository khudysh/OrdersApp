using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Shop
{
    public class Database
    {
        private string ConnectionString = "User ID=postgres;Password=1;Host=localhost;Port=5432;Database=StoreDB;Pooling=true;";

        private NpgsqlConnection Connect()
        {
            NpgsqlConnection con = new NpgsqlConnection(this.ConnectionString);
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                return con;
            }
            catch
            {
                MessageBox.Show("Connection Error");
                return null;
            }
        }
        
        public DataTable GetTable(string query)
        {
            try
            {
                Console.WriteLine(query);
                var con = Connect();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("DataAdapter Table Error");
                return null;
            }
        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                var con = Connect();
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Command Execute Error");
                return false;
            }
        }
    }
}
