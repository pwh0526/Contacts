using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Contacts
{
    class DBHelper
    {
        private string Connstring = @"Data Source=.;Initial Catalog=ContactSys;Integrated Security=True";
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(Connstring);
                }
                return connection;
            }

        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (connection.State == ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open || connection.State == ConnectionState.Broken)
            {
                connection.Close();
            }
        }


    }
}