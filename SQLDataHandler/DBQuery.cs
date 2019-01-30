using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDataHandler
{
    public abstract class DBQuery
    {
        protected MySqlConnection connection = null;
        protected MySqlCommand command = null;
        string connectionString;


        public DBQuery(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private void Open()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command = new MySqlCommand();
            command.Connection = connection;
        }

        public void Execute()
        {
            Open();

            ExecuteCommand();

            Close();
        }

        private void Close()
        {
            connection.Dispose();
        }

        public abstract void ExecuteCommand();
    }
}
