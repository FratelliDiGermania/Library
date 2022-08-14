using DBConnectionManager;
using JT.UniStuttgart.LibraryManager.CrossCutting.Interf.Interfaces;
using System;


namespace JT.UniStuttgart.LibraryManager.Models.ModelsRepository
{
    public class CateroyModel : ICategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        DBHelper
    }
}
