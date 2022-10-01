
using JT.UniStuttgart.LibraryManager.CrossCutting.Interf.InterfacesManager;
using JT.UniStuttgart.LibraryManager.Logic.Services.DBConnectionAdministrator;
using JT.UniStuttgart.LibraryManager.Models.ModelsAdministrator;

namespace JT.UniStuttgart.LibraryManager.Logic.Presenter.PresenterAdministrator
{
    public class CategoryPresenter
    {
        // fields
        CateroyModel categoryModel = new CateroyModel();//model
        // Properties
        ICategory CategoryView { get; set; } // view
        // methods

        // ctor
        public CategoryPresenter(ICategory view)
        {
            CategoryView = view;
        }

        // assign view values to the category model
        void ConnectView2Model()
        {
            categoryModel.ID = int.Parse(CategoryView.ID.ToString());
            categoryModel.Name = CategoryView.CategoryName;
        }

        // invorke CategoryInsert
        public bool Insert()
        {
            ConnectView2Model();
            return CategoryServices.CategoryInsert(categoryModel.ID, categoryModel.Name);
        }

        // invorke CategoryUpdate
        public bool Update()
        {
            ConnectView2Model();
            return CategoryServices.CategoryUpdate(categoryModel.ID, categoryModel.Name);
        }

        // invorke CategoryDelete
        public bool Delete()
        {
            ConnectView2Model();
            return CategoryServices.CategoryDelete(categoryModel.ID);
        }

        //invoke DeleteAll
        public bool DeleteAll()
        {
            ConnectView2Model();
            return CategoryServices.CategoryDeleteAll();
        }

        // Clear all Fields
        public void ClearFields()
        {
            CategoryView.ID = -1;
            CategoryView.CategoryName = string.Empty;
        }
    }
}
