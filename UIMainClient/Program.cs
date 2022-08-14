using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JT.UniStuttgart.LibraryManager.Views.Forms.UIMainClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new Views.Forms.UIMainClient.frm_Main());
        }
    }
}
