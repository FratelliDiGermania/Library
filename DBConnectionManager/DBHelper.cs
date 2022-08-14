using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionManager
{
    public static class DBHelper
    {
        static SqlCommand command { get; set; }
        //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        private static SqlConnection getConnection()
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.DataSource = Properties.Resources.ServerName;
            connectionBuilder.InitialCatalog = Properties.Resources.DBName;
            connectionBuilder.IntegratedSecurity = true;
            return new SqlConnection(connectionBuilder.ConnectionString);
        }

        public static bool ExecuteProcedureByName(string procedureName, Action method)
        {
            using (SqlConnection connection = getConnection())
            {
                try
                {
                    command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    method.Invoke();
                    connection.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    connection.Close();
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }

        }



    }
}
