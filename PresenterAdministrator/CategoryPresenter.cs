
using JT.UniStuttgart.LibraryManager.CrossCutting.Interf.InterfacesManager;
using JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionAdministrator;
using JT.UniStuttgart.LibraryManager.Models.ModelsAdministrator;

namespace JT.UniStuttgart.LibraryManager.Logic.Presenter.PresenterAdministrator
{
    public class CategoryPresenter
    {
        ICategory categoryView; // view
        CateroyModel categoryModel; //model

        public CategoryPresenter(ICategory view)
        {
            categoryView = view;
        }

        void ConnectViewToModel()
        {
            categoryModel = new CateroyModel();
            categoryModel.id = int.Parse(categoryView.idText.ToString());
            categoryModel.name = categoryView.nameText;
        }

        public bool CatInsert()
        {
            ConnectViewToModel();
            return CategoryService.CategoryInsert(categoryModel.id, categoryModel.name);
        }
        public bool CatDelete()
        {
            ConnectViewToModel();
            return CategoryService.CategoryDelete(categoryModel.id);
        }

        public bool CatDeleteAll()
        {
            ConnectViewToModel();
            return CategoryService.CategoryDeleteAll();
        }

        public bool CatUpdate()
        {
            ConnectViewToModel();
            return CategoryService.CategoryUpdate(categoryModel.id, categoryModel.name);
        }

        public void ClearFields()
        {
            categoryView.idText = 0;
            categoryView.nameText = string.Empty;
        }
    }
}
