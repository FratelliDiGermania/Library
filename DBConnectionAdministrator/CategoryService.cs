using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionAdministrator
{
    public static class CategoryService
    {
        //insert
        public static bool CategoryInsert(int id, string name)
        {
            return DBManager.ExecuteProcedureByName("categorieInsert", () => AssignCategoryCommandParameterInsert(id, name, DBManager.command));
        }
        static void AssignCategoryCommandParameterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        //Delete
        public static bool CategoryDelete(int id)
        {
            return DBManager.ExecuteProcedureByName("categorieDelete", () => AssignCategoryCommandParameterDelete(id, DBManager.command));
        }
        static void AssignCategoryCommandParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //Delete All
        public static bool CategoryDeleteAll()
        {
            return DBManager.ExecuteProcedureByName("categorieDeleteAll", null);
        }

        //Update Category
        public static bool CategoryUpdate(int id, string name)
        {
            return DBManager.ExecuteProcedureByName("categorieUpdate", () => AssignCategoryCommandParameterUpdate(id, name, DBManager.command));
        }
        static void AssignCategoryCommandParameterUpdate(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
    }
}
