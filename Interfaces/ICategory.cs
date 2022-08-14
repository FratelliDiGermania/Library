using System;
using System.Collections.Generic;
using System.Text;

namespace JT.UniStuttgart.LibraryManager.CrossCutting.Interf.Interfaces
{
    public interface ICategory
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}

