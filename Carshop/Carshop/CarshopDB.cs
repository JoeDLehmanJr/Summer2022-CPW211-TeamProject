using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    static class CarshopDB
    {
        public static SqlConnection GetDatabaseConnection()
        {
            return new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Carshop;Integrated Security=True; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
        }
    }
}
