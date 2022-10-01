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
        CategoryPresenter categoryPresenter;

        public frm_BuchCategorie()
        {
            InitializeComponent();
            categoryPresenter = new CategoryPresenter(this);
        }

        public int ID
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

        public string CategoryName
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
            if (categoryPresenter.Insert())
            {
                MessageBox.Show("insert successful.");
            }
            else
            {
                MessageBox.Show("insert not successful.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (categoryPresenter.DeleteAll())
            {
                categoryPresenter.ClearFields();
                MessageBox.Show("all entries have been deleted!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (categoryPresenter.Update())
            {
                MessageBox.Show("save successful.");
            }
            else
            {
                MessageBox.Show("save not successful.");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (categoryPresenter.Delete())
            {
                categoryPresenter.ClearFields();
                MessageBox.Show("delete successful.");
            }
            else
            {
                MessageBox.Show("delete not successful.");

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            categoryPresenter.ClearFields();
        }
    }
}