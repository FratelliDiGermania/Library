using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionAdministrator
{
    public static class DBManager
    {
        public static SqlCommand command { get; set; }
        //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        private static SqlConnection getConnection()
        {
            return new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = Properties.Resources.ServerName,
                    InitialCatalog = Properties.Resources.DBName,
                    IntegratedSecurity = true,

                }.ConnectionString)
                ;

        }

        public static bool ExecuteProcedureByName(string procedureName, Action assignParameters2SqlCommand)
        {
            using (SqlConnection connection = getConnection())// set db connection
            {
                try
                {
                    command = new SqlCommand(procedureName, connection);//instantiate command
                    command.CommandType = CommandType.StoredProcedure;// set command type
                    assignParameters2SqlCommand?.Invoke();//invoke the definded method
                    connection.Open();//get conneted
                    command.ExecuteNonQuery();// execute command/procedure
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
