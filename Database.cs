using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public class Database
    {
        public string connectionString = @"Data Source=LAPTOP-9I73UOJP;Initial Catalog=CityGas;Integrated Security=True;TrustServerCertificate=True";


        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void OpenConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
                Console.WriteLine("Підключення до бази даних встановлено успішно.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open) connection.Close();
                Console.WriteLine("Підключення до бази даних закрито успішно.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
