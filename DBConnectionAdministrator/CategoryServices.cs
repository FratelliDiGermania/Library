using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionAdministrator
{
    // methods provider to presenter
    public static class CategoryServices
    {
        //insert a new category to DB
        public static bool CategoryInsert(int id, string name)
        {
            return DBManager.ExecuteProcedureByName("categorieInsert", () => AssignCategoryInsertPatameters2Command(id, name, DBManager.command));
        }
        static void AssignCategoryInsertPatameters2Command(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        //Update a specific category in DB
        public static bool CategoryUpdate(int id, string name)
        {
            return DBManager.ExecuteProcedureByName("categorieUpdate", () => AssignCategoryUpdatePatameters2Command(id, name, DBManager.command));
        }
        static void AssignCategoryUpdatePatameters2Command(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }

        //Delete a specific category from DB
        public static bool CategoryDelete(int id)
        {
            return DBManager.ExecuteProcedureByName("categorieDelete", () => AssignCategoryDeletePatameters2Command(id, DBManager.command));
        }
        static void AssignCategoryDeletePatameters2Command(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //Delete all categories from DB
        public static bool CategoryDeleteAll()
        {
            return DBManager.ExecuteProcedureByName("categorieDeleteAll", null);
        }
    }
}
