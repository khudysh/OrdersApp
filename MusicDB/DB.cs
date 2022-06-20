using System;
using System.Data;
using System.Windows.Forms;

namespace Shop
{
    public class DB : Database
    {
        public DataTable GetCanceled()
        {
            return GetTable("SELECT * FROM " + GetTableName("orders") + "WHERE status='аннулирован'");
        }

        public DataTable GetCanceledDates()
        {
            return GetTable("SELECT DISTINCT date FROM " + GetTableName("orders") + "WHERE status='аннулирован'");
        }

        public DataTable GetSuccess()
        {
            return GetTable("SELECT * FROM " + GetTableName("orders") + "WHERE status='ожидает оплаты' OR status='успешно'");
        }

        public DataTable GetSuccessDates()
        {
            return GetTable("SELECT DISTINCT date FROM " + GetTableName("orders") + "WHERE status='ожидает оплаты' OR status='успешно'");
        }

        public bool AddOrder(DataGridViewRow row)
        {
            string insertQuery = "INSERT INTO " + GetTableName("orders") +
                $" VALUES ({row.Cells[0].Value}, '{row.Cells[1].Value}', '{row.Cells[2].Value}', {row.Cells[3].Value}," +
                $" '{row.Cells[4].Value}', '{row.Cells[5].Value}', {row.Cells[6].Value})";
            Console.WriteLine(insertQuery);
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateStatusOrder(DataGridViewRow row)
        {
            string updateQuery = $"UPDATE " + GetTableName("orders") + 
                $" SET status = '{row.Cells[5].Value}' WHERE id = {row.Cells[0].Value}";
            Console.WriteLine(updateQuery);
            return ExecuteQuery(updateQuery);
        }

        public DataTable GetAllClients()
        {
            return GetTable("SELECT * FROM " + GetTableName("clients"));
        }

        public DataTable GetAllTable()
        {
            return GetTable("SELECT * FROM " + GetTableName("orders"));
        }

        public DataTable GetAllDates()
        {
            return GetTable("SELECT DISTINCT date FROM " + GetTableName("orders"));
        }

        public DataTable Search(string word)
        {
            string searchQuery = "SELECT * FROM " + GetTableName("orders") +
 $" WHERE product LIKE '%{word}%' ";
            return GetTable(searchQuery);
        }

        public DataTable SearchClients(string word)
        {
            string searchQuery = "SELECT * FROM " + GetTableName("clients") +
 $" WHERE 'Name' LIKE '%{word}%' ";
            return GetTable(searchQuery);
        }

        #region Helper Methods

        private string GetTableName(string tableName)
        {
            return @"public.""" + tableName + @"""";
        }

        #endregion
    }
}
