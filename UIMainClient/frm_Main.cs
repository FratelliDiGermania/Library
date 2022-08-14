using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JT.UniStuttgart.LibraryManager.Views.Forms.UIMainClient
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btnCategorie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_BuchCategorie frmBuchCategorie = new frm_BuchCategorie();
            frmBuchCategorie.ShowDialog();
        }

        private void btnBereiche_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_BuchPlatz frm_BuchPlatz = new frm_BuchPlatz();
            frm_BuchPlatz.ShowDialog();
        }
    }
}
