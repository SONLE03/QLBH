using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = @"Data Source=DESKTOP-MV4COEO\SQLEXPRESS; Initial Catalog = BAKERY; Integrated Security = True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
