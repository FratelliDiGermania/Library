using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionManager
{
    public static class CategoryService
    {
        public static void CategoryParameterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

        }


    }

}
