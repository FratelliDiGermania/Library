using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionAdministrator
{
    public static class DBManager
    {
        public static SqlCommand command { get; set; }

        // get connection string
        static SqlConnection getConnection()
        {
            return new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = Properties.Settings.Default.Server,
                    InitialCatalog = Properties.Settings.Default.DataBase,
                    IntegratedSecurity = true,

                }.ConnectionString);
        }
        // execute stored procedures
        public static bool ExecuteProcedureByName(string storedProcedure, Action assignParameters2SqlCommand)
        {
            using (SqlConnection connection = getConnection())// set db connection
            {
                try
                {
                    command = new SqlCommand(storedProcedure, connection);//instantiate command
                    command.CommandType = CommandType.StoredProcedure;// set command type
                    assignParameters2SqlCommand?.Invoke();//invoke the definded method to command: assign pamaters to command
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
