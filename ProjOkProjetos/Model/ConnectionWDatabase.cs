using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOkProjetos.Model
{
    internal class ConnectionWDatabase
    {
        public static string GetRDSConnectionString()
        {

            string hostname = "xxxxxx.rds.amazonaws.com";
            string dbname = "xxxxxx";
            string username = "xxxxxx";
            string password = "xxxxxx";

            return "Data Source=" + hostname + 
                ";Initial Catalog=" + dbname + 
                ";User ID=" + username + 
                ";Password=" + password +
                ";";
        }
    }
}
