using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EgAccount
{
    static class Program
    {
        public static MCls MC = new MCls();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MessageBox.Show(MCls.DecimalToWords(Convert.ToDecimal(3970)));
            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (MCls.LoadSqlDBPath())
            {
                Properties.Settings.Default["EGAccountConnectionString"] = MCls.SQLConStrStoreAccount;
                DevExpress.Xpo.XpoDefault.Session.ConnectionString = MCls.SQLConStrStoreAccount;
                DevExpress.Xpo.XpoDefault.Session.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
                DatabaseScripts.FireScript();
                //MCls.LoadSQLReports();
                MainFrm FrmMain = new MainFrm();
                MCls.PrepareBaseRole(FrmMain.menuStrip);
                Application.Run(FrmMain);
            }
        }
        

    }
}
