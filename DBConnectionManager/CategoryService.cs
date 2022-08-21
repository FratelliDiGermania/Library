using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionManager
{
    public static class CategoryService
    {
        public static bool CategoryInsert(int id, string name)
        {
            return DBHelper.ExecuteProcedureByName("categorieInsert", () => CategoryParameterInsert(id, name, DBHelper.command));
        }

        static void CategoryParameterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        public static bool CategoryDelete(int id)
        {
            return DBHelper.ExecuteProcedureByName("categorieDelete", () => CategoryParameterDelete(id, DBHelper.command));
        }

        static void CategoryParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        public static bool CategoryUpdate(int id, string name)
        {
            return DBHelper.ExecuteProcedureByName("categorieUpdate", () => CategoryParameterUpdate(id, name, DBHelper.command));
        }

        static void CategoryParameterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

    }

}
