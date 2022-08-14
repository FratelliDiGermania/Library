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
            frm_BuchPlatz frmBuchPlatz = new frm_BuchPlatz();
            frmBuchPlatz.ShowDialog();
        }

        private void btnVerlag_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Verlag frmVerlag = new frm_Verlag();
            frmVerlag.ShowDialog();

        }

        private void btnLaender_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Laender frmLaender = new frm_Laender();
            frmLaender.ShowDialog();
        }

        private void btnAutoren_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Authoren frmAuthoren = new frm_Authoren();
            frmAuthoren.ShowDialog();
            
        }
    }
}
