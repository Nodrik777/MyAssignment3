using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Installed MySql.Data for Assignment3 project
using MySql.Data.MySqlClient;

namespace Assignment3.Models
{
    
        public class TeacherDBContext
    {
            // properties to access assignment database 
            private static string User { get { return "root"; } }
            private static string Password { get { return "root"; } }
            private static string Database { get { return "assignment"; } }
            private static string Server { get { return "localhost"; } }
            private static string Port { get { return "3306"; } }

            protected static string ConnectionString

        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                     + "; password = " + Password;
            }
        }

                //Method to access database
                /// <summary>
                /// Return connection to assignment database
                /// </summary>
                /// <example>
                /// TeacherDBContext MyModule = new TeacherDBContext();
                /// MySqlConnection Conn = MyModule.AccessDatabase();
                /// </example>
                /// <returns>A MySqlConnection Object </returns>

                


        public MySqlConnection AccessDatabase()
        {
            
        // Instantiating the MySqlConnection class to create an object
            return new MySqlConnection(ConnectionString);
        }
    }
}