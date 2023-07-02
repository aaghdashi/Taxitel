using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace TaxiTel
{
    class main
    {

        protected SqlConnection connection;
        protected SqlCommand command;
        protected SqlDataAdapter adapter;
        protected SqlDataReader dataReader;
        public  main()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\TaxiTel\TaxiTel\AppData\Taxi.mdf;Integrated Security=True;Connect Timeout=30");
            command = new SqlCommand();
            adapter = new SqlDataAdapter("",connection);
        }

        public bool login(string username, string password)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [User] WHERE UserName='"+username+"' AND PassWord='"+password+"'";
                
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    return true;
                else
                    return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool backup(string _command)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText =_command;
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                    return true;
                else
                    return false;
            }
            finally
            {
                connection.Close();
            }
        }

        ~ main()
        {

        }
    }
}
