using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaxiTel
{
    class Drive : main
    {
        public Boolean addDriver(string commandstring)
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

        public Boolean editDriver(string commandstring)
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


        public Boolean delDriver(int id)
        {

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE Driver_tbl WHERE ID='" + id + "'";
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

        public Boolean attendenceDriver(int id,bool status)
        {
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Driver_tbl SET Status='"+status+"' WHERE ID='" + id + "'";
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

        public DataTable showDrivers()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Driver_tbl ";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public DataTable getDrivers()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Driver_tbl WHERE Driver_tbl.Status='true' AND Driver_tbl.Enable='true'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable ListDrivers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,Name,Family,Status FROM Driver_tbl WHERE Driver_tbl.Enable='true'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable ListDrivers(bool _enable)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,Name,Family,Status FROM Driver_tbl WHERE Status='"+_enable+"' AND Enable='True'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable search(string code, string name, string family,string citifID)
        {
            DataTable dts = new DataTable();
            dts.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Driver_tbl WHERE ID LIKE '%" + code + "%' AND Name LIKE '%" + name + "%' AND Family LIKE '%" + family + "%' AND CirtificatedID LIKE '%" + citifID + "%'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dts);

            }
            finally
            {
                connection.Close();
            }
            return dts;
        }

        public DataTable ReportService(int id)
        {
            DataTable dts = new DataTable();
            dts.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Service_tbl.ID, Service_tbl.Date, Service_tbl.TimeBegin, Customer_tbl.Name +' '+ Customer_tbl.Family AS 'customer', Destination_tbl.Price,(Destination_tbl.Price*0.75) as 'sahm' FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID WHERE Service_tbl.ID_Driver='" + id + "'";
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
