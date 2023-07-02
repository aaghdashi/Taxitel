using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaxiTel
{
    class Dest:main
    {
        public Boolean add(string address, string price, bool status)
        {

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Destination_tbl(Address,Price,Status) VALUES('" + address + "','" + price + "','" + status + "')";
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

        public Boolean edit(string address, string price, bool status, int id)
        {
          
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "UPDATE  Destination_tbl SET Address='" + address + "',Price='" + price + "' ,Status='"+status+"' WHERE ID='" + id + "'";
                    command.ExecuteNonQuery();

                } catch
            {
                return false;
            }

                finally
                {
                    connection.Close();
                }
                return true;        
           
        }


        public Boolean del(int id)
        {

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE Destination_tbl WHERE ID='" + id + "'";
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return true;

        }
        
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Destination_tbl";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable search(string id,bool ? terrafic)
        {
            DataTable dts = new DataTable();
            dts.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Destination_tbl WHERE ID LIKE '%"+id+"%' AND Status='"+terrafic+"' ";
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
