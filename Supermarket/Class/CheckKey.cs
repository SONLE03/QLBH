using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Class
{
    public class CheckKey
    {
        SQLConnection SQLConnection;
        string sql_check { get; set; }
        public CheckKey()
        {

        }
        public CheckKey(string sql_check)
        {
            this.sql_check = sql_check;
        }
        public bool Check(string sql)
        {
            SQLConnection = new SQLConnection();
            SQLConnection.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, SQLConnection.con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
    
}
