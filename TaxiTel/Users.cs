using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaxiTel
{
    class Users:main
    {
       public Boolean addUser(string username, string password, string confirmpass)
        {
            if (username != null && password.Equals(confirmpass))
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO [User](UserName,PassWord) VALUES('"+username+"','"+password+"')";
                    command.ExecuteNonQuery();

                }
                finally
                {
                    connection.Close();
                }
                return true;
            }
            
            return false;
        }

       public Boolean editUser(string username, string password, string confirmpass,int id)
       {
           if (username != null && password.Equals(confirmpass))
           {
               try
               {
                   connection.Open();
                   command.Connection = connection;
                   command.CommandText = "UPDATE  [User] SET UserName='" + username + "',PassWord='" + password + "' WHERE Id='"+id+"'";
                   command.ExecuteNonQuery();

               }
               finally
               {
                   connection.Close();
               }
               return true;
           }

           return false;
       }


       public Boolean delUser(int id)
       {
          
               try
               {
                   connection.Open();
                   command.Connection = connection;
                   command.CommandText = "DELETE [User] WHERE Id='"+id+"'";
                   command.ExecuteNonQuery();
               }
               finally
               {
                   connection.Close();
               }
               return true;
         
    }
        public DataTable getUsers()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Id,UserName FROM [User]";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt; 
        }
    }
}
