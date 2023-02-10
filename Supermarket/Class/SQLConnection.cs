using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class SQLConnection
    {
        public string strcon;
        public SqlConnection con;
        public SQLConnection()
        {

            try
            {
                strcon = @"Data Source=DESKTOP-MV4COEO\SQLEXPRESS; Initial Catalog = BAKERY; Integrated Security = True";
            }
            catch
            {
                return;
            }
            con = new SqlConnection(strcon);
        }
        public void OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CloseConnection()
        {
            con.Close();
        }
    }
}
