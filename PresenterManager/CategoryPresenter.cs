using JT.UniStuttgart.LibraryManager.CrossCutting.Interf.Interfaces;
using JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionManager;
using JT.UniStuttgart.LibraryManager.Models.ModelsRepository;
using System;

namespace JT.UniStuttgart.LibraryManager.Logic.Presenter.PresenterManager
{
    // to excecuet tasks // scrape together
    public class CategoryPresenter
    {

        ICategory categoryView; // view
        CateroyModel categoryModel = new CateroyModel(); //model

        public CategoryPresenter(ICategory view, CateroyModel model)
        {
            categoryView = view;
        }

        void ConnectViewToModel()
        {
            categoryModel.id = int.Parse(categoryView.idText);
            categoryModel.name = categoryView.nameText;
        }

        public bool CatInsert()
        {
            ConnectViewToModel();
            return CategoryService.CategoryInsert(categoryModel.id, categoryModel.name);
        }
    }
}
