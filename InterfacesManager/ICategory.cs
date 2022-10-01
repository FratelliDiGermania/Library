using System;
using System.Collections.Generic;
using System.Text;

namespace JT.UniStuttgart.LibraryManager.CrossCutting.Interf.InterfacesManager
{
    public interface ICategory
    {
        int ID { get; set; }
        string CategoryName { get; set; }
    }
}

