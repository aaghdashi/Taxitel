using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TaxiTel
{
    class ReportService:main
    {
        public DataTable getServices()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Service_tbl.ID, Service_tbl.Date, Service_tbl.TimeBegin, Driver_tbl.Name +' '+ Driver_tbl.Family as 'driver', Customer_tbl.Name +' '+ Customer_tbl.Family AS 'customer', Destination_tbl.Price,(Destination_tbl.Price*0.75) as 'sahm' FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID";
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
