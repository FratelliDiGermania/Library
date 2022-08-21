using DevExpress.XtraEditors;
using JT.UniStuttgart.LibraryManager.CrossCutting.Interf.InterfacesManager;
using JT.UniStuttgart.LibraryManager.Logic.Presenter.PresenterAdministrator;
using JT.UniStuttgart.LibraryManager.Models.ModelsAdministrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JT.UniStuttgart.LibraryManager.Views.Forms.UIMainClient
{
    public partial class frm_BuchCategorie : DevExpress.XtraEditors.XtraForm, ICategory
    {
        CategoryPresenter presenter;
        public frm_BuchCategorie()
        {
            InitializeComponent();
            presenter = new CategoryPresenter(this);
        }

        public int idText
        {
            get
            {
                if (string.IsNullOrEmpty(tbID.Text))
                {
                    return -1;
                }
                return int.Parse(tbID.Text);
            }

            set
            {
                tbID.Text = Convert.ToInt32(value).ToString();
            }
        }
        public string nameText
        {
            get
            {
                return tbName.Text;
            }

            set
            {
                tbName.Text = value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            presenter?.CatInsert();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter?.CatDelete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter?.CatUpdate();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            presenter?.CatDeleteAll();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            presenter?.ClearFields();
        }
    }
}