using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaxiTel
{
    class serviceClass:main
    {
        static int idCustomer;
        static int idDriver;
        static int idDestination;
        static int idService;

        public void Clear()
        {
            idCustomer = 0;
            idDriver = 0;
            idDestination = 0;
            IdService = 0;
        }

        public int IdService
        {
            set { idService = value; }
            get { return idService; }
        }

        public int IdCustomer
        {
            set { idCustomer = value; }
            get { return idCustomer; }
        }

        public int IdDriver
        {
            set { idDriver = value; }
            get { return idDriver; }
        }

        public int IdDestination
        {
            set { idDestination = value; }
            get { return idDestination; }
        }

        public bool addService(string commandstring)
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

        public bool editService(string commandstring)
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

        public Boolean deleteService(int id)
        {

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE Service_tbl WHERE ID='" + id + "'";
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return true;

        }
        public DataTable getCustomer()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,Name,Family,Mobile,Tel,Address  FROM Customer_tbl WHERE ID='"+idCustomer+"'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public DataTable getDriver()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,Name,Family,Mobile,type FROM Driver_tbl   WHERE ID='" + idDriver + "'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public DataTable getDetination()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,Address,Price  FROM Destination_tbl  WHERE ID='" + idDestination + "'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable getServices()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Service_tbl.ID,Service_tbl.ID_Customer,Service_tbl.ID_Driver,Service_tbl.ID_Destination, Service_tbl.Date, Service_tbl.TimeBegin, Service_tbl.TimeEnd, Customer_tbl.Name, Customer_tbl.Family, Service_tbl.Address FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable getServices(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Service_tbl.ID, Service_tbl.Date, Service_tbl.TimeBegin, Driver_tbl.Name +' '+ Driver_tbl.Family as 'driver', Destination_tbl.Price,(Destination_tbl.Price*0.75) as 'sahm'  FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID WHERE Service_tbl.ID_Customer='" + id + "'";
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable getPrice(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT SUM(Destination_tbl.Price*0.25) AS 'Driver',SUM(Destination_tbl.Price*0.75) AS 'Agency' FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID WHERE Service_tbl.ID_Customer='" + id + "'";

                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable getService(string idService,string idCustomer,string idDriver,string idDestination)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Service_tbl.ID,Service_tbl.ID_Customer,Service_tbl.ID_Driver,Service_tbl.ID_Destination, Service_tbl.Date, Service_tbl.TimeBegin, Service_tbl.TimeEnd, Customer_tbl.Name, Customer_tbl.Family, Service_tbl.Address FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID WHERE Service_tbl.ID LIKE '%" + idService + "%' AND Service_tbl.ID_Customer LIKE'%" + idCustomer + "%' AND  Service_tbl.ID_Destination LIKE '%" + idDestination + "%' AND Service_tbl.ID_Driver LIKE '%" + idDriver + "%' ";
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
