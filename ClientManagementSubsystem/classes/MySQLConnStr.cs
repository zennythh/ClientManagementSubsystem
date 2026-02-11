using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 
using MySql.Data.MySqlClient; 

namespace ClientManagementSubsystem.classes
{
    public static class MySQLConnStr
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Car Rental DB"].ConnectionString;
            }
        }
        public static MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open(); 
            return connection;
        }
    }
}

