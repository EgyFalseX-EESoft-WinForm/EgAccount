﻿using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            if (MCls.LoadSqlDBPath())
            {
                Properties.Settings.Default["EGAccountConnectionString"] = MCls.SQLConStrStoreAccount;
                //MCls.LoadSQLReports();
                MainFrm FrmMain = new MainFrm();
                MCls.PrepareBaseRole(FrmMain.menuStrip);
                Application.Run(FrmMain);
            }
        }
        

    }
}
