using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaxiTel
{
    class Customers : main
    {
        public Boolean addCustomer(string commandstring)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = commandstring;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }


        public Boolean editCustomer(string commandstring)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = commandstring;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }


        public Boolean delCustomer(int id)
        {

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE Customer_tbl WHERE ID='" + id + "'";
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return true;
        }


        public DataTable getCustomers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer_tbl";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable search(string code,string name,string family)
        {
            DataTable dts = new DataTable();
            dts.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer_tbl WHERE ID LIKE '%"+code+"%' AND Name LIKE '%"+name+"%' AND Family LIKE '%"+family+"%' ";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dts);

            }
            finally
            {
                connection.Close();
            }
            return dts;
        }
    }
}
