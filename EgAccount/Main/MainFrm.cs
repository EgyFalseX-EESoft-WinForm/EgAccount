﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;
using EgAccount.Data;
using DevExpress.XtraSplashScreen;

namespace EgAccount
{
    public partial class MainFrm : Form
    {
        #region -   Variables   -

        //Codes
        AccTreeOptionsFrm FrmAccTreeOptions;
        EditorYearFrm FrmEditorYear;
        EditorAccountNatureFrm FrmEditorAccountNature;
        EditorSalesUnitFrm FrmEditorSalesUnit;
        EditorStoreFrm FrmEditorStore;
        EditorBankFrm FrmEditorBank;
        EditorCustomerFrm FrmEditorCustomer;
        EditorCDCategoriesFrm FrmEditorCDCategories;
        EditorSuppliersFrm FrmEditorSuppliers;
        EditorCompaniesFrm FrmEditorCompanies;
        EditorBillPayTypesFrm FrmEditorBillPayTypes;
        EditorJobFrm FrmEditorJob;
        EditorCDASNAFFrm FrmEditorCDASNAF;
        //Data
        AccTypesDlgFrm FrmAccTypesDlg;
        AccTypesFrm FrmAccTypes;
        ConstraintsDailyFrm FrmConstraintsDaily;
        DataEmpFrm FrmDataEmp;
        DataBillFrm FrmDataBill;
        DataSellBillFrm FrmDataSellBill;
        DataSellBillBarCodeFrm FrmDataSellBillBarCode;
        DataTblPricelistsFrm FrmDataTblPricelists;
        TBLCheekNumbersFrm FrmTBLCheekNumbers;
        tbleznsarsFrm Frmtbleznsars;
        tbleznsars2Frm Frmtbleznsars2;
        tblraseedFrm Frmtblraseed;
        TBLkaznaFrm FrmTBLkazna;
        //Queries
        QrysellsFrm FrmQrysells;
        QryBuysFrm FrmQryBuys;
        ItemAvailabilityFrm FrmItemAvailability;
        QryBarcodeFrm FrmQryBarcode;
        //Roles
        EditorRoleFrm FrmEditorRole;
        EditorRoleMenuFrm FrmEditorRoleMenu;
        EditorUserFrm FrmEditorUser;
        EditorUserInRoleFrm FrmEditorUserInRole;
        //Tools
        SkinsFrm FrmSkins = new SkinsFrm();


        DataTable ActiveMenu = new DataTable("FalseX2010-11");
        private ToolStripMenuItem[] MenuItemZ = null;

        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
            
        }
        private static UserSettings LoadSettings(string fileName)
        {
            UserSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as UserSettings; }
            finally { fStream.Close(); }
            return us;
        }
        public void RebuildForms()
        {
            return;
            //Codes
            FrmAccTreeOptions = new AccTreeOptionsFrm();
            FrmEditorYear = new EditorYearFrm();
            FrmEditorAccountNature = new EditorAccountNatureFrm();
            FrmEditorSalesUnit = new EditorSalesUnitFrm();
            FrmEditorStore = new EditorStoreFrm();
            FrmEditorBank = new EditorBankFrm();
            FrmEditorCustomer = new EditorCustomerFrm();
            FrmEditorCDCategories = new EditorCDCategoriesFrm();
            FrmEditorSuppliers = new EditorSuppliersFrm();
            FrmEditorCompanies = new EditorCompaniesFrm();
            FrmEditorBillPayTypes = new EditorBillPayTypesFrm();
            FrmEditorJob = new EditorJobFrm();
            FrmEditorCDASNAF = new EditorCDASNAFFrm();
            //Data
            FrmAccTypesDlg = new AccTypesDlgFrm();
            FrmAccTypes = new AccTypesFrm();
            FrmConstraintsDaily = new ConstraintsDailyFrm();
            FrmDataEmp = new DataEmpFrm();
            FrmDataBill = new DataBillFrm();
            FrmDataSellBill = new DataSellBillFrm();
            FrmDataSellBillBarCode = new DataSellBillBarCodeFrm();
            FrmDataTblPricelists = new DataTblPricelistsFrm();
            FrmTBLCheekNumbers = new TBLCheekNumbersFrm();
            Frmtbleznsars = new tbleznsarsFrm();
            Frmtbleznsars2 = new tbleznsars2Frm();
            Frmtblraseed = new tblraseedFrm();
            //Queries
            FrmQrysells = new QrysellsFrm();
            FrmQryBuys = new QryBuysFrm();
            FrmItemAvailability = new ItemAvailabilityFrm();
            FrmQryBarcode = new QryBarcodeFrm();
            //Roles
            FrmEditorRole = new EditorRoleFrm();
            FrmEditorRoleMenu = new EditorRoleMenuFrm();
            FrmEditorUser = new EditorUserFrm();
            FrmEditorUserInRole = new EditorUserInRoleFrm();
            //Tools
            FrmSkins = new SkinsFrm();
          
        
        }
        private void LoadMenuItem()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                GetSubMenuItem(item);
        }
        private void GetSubMenuItem(ToolStripMenuItem MItem)
        {
            foreach (ToolStripMenuItem item in MItem.DropDownItems)
            {
                if (MenuItemZ == null)
                {
                    MenuItemZ = new ToolStripMenuItem[1];
                }
                else
                {
                    ToolStripMenuItem[] tempItemList = new ToolStripMenuItem[MenuItemZ.Length + 1];
                    MenuItemZ.CopyTo(tempItemList, 0);
                    MenuItemZ = tempItemList;
                }
                MenuItemZ[MenuItemZ.Length - 1] = item;

                if (item.DropDownItems != null)
                {
                    GetSubMenuItem(item);
                }
            }
        }
        private void EnableMenuItem()
        {
            LoadMenuItem();
            ActiveMenu = new DataTable("FalseX2010-11");
            ActiveMenu = MCls.LoadDataTable("SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID WHERE (UserRoles.UserId = N'" + MCls.UserInfo.UserID + "')", "");
            foreach (DataRow row in ActiveMenu.Rows)
            {
                foreach (ToolStripMenuItem item in MenuItemZ)
                {
                    if (item.Name == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;// Make Menu Item Visible
                        break;
                    }
                }
            }
        }
        private void LoadSQLReports()
        {
            try
            {
                if (MCls.SQLRep == null)
                    return;
                for (int i = 0; i < MCls.SQLRep.Length; i++)
                {
                    ToolStripMenuItem TSMI = new ToolStripMenuItem();
                    TSMI.Name = MCls.SQLRep[i].RepFileName.Replace(".rdl", "");
                    TSMI.Text = MCls.SQLRep[i].RepCaption;
                    TSMI.ImageIndex = 0;
                    TSMI.Tag = i;
                    TSMI.Image = global::EgAccount.Properties.Resources.Report;
                    TSMI.Visible = false;

                    ((ToolStripMenuItem)printingToolStripMenuItem.DropDownItems[Convert.ToInt16(MCls.SQLRep[i].RepPosition)]).DropDownItems.Add(TSMI);
                    TSMI.Click += TSMI_Click;
                }
            }
            catch (Exception ex)
            {
                MCls.msg(ex.Message, true, "", this);
            }
        }
        private void LoadUserPriv(string RoleID)
        {
            ////Hide All Tools
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlCode.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlData.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlPriv.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlQry.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlReport.Items)
            //    item.Visible = false;

            //RoleDetialsTbl = MCls.LoadDataTable("SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID WHERE UserRoles.UserId = " + MCls.UserInfo.UserID);

            //foreach (DataRow row in RoleDetialsTbl.Rows)
            //{
            //    foreach (NavBarItem item in navBarControlCode.Items)//code
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlData.Items)//data
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlPriv.Items)//priv
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlQry.Items)//qry
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlReport.Items)//report
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //nextOne:
            //    ;
            //    //continue;
            //}
        }
        #endregion
        #region - Event Handlers -
        private void ECMMainFrm_Load(object sender, EventArgs e)
        {
            
            if (System.IO.File.Exists(MCls.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(MCls.StyleSettingsPath).SkinName);

            //Load Reports from file and create its item in the interface
            LoadSQLReports();
            this.IsMdiContainer = true;
            // Show Splash Screen..
            using (SplashFrm SC = new SplashFrm())
                SC.ShowDialog();
            // Show Login Screen..
            using (LoginFrm FrmLogin = new LoginFrm())
                FrmLogin.ShowDialog();
            //Get ready all forms
            RebuildForms();
            // Load And Enable User Priv
            //LoadUserPriv(MCls.UserInfo.UserID);
            EnableMenuItem();
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void restConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيـــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            if (System.IO.File.Exists(MCls.DBPath))
            {
                System.IO.File.Delete(MCls.DBPath);
                Application.Restart();
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-E-Soft Co. \n  Test Version ...");
        }
        private void accountsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmAccTypes == null || FrmAccTypes.IsDisposed)
            {
                FrmAccTypes = new AccTypesFrm();
                FrmAccTypes.MdiParent = this;
                FrmAccTypes.Show();
            }
            else
            {
                if (FrmAccTypes.Visible)
                {
                    FrmAccTypes.WindowState = FormWindowState.Normal;
                    FrmAccTypes.Focus();
                }
                else
                {
                    FrmAccTypes.MdiParent = this;
                    FrmAccTypes.Show();
                }
            }
            FrmAccTypes.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.accountsTypes, 16, false);
        }
        private void constraintsDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmConstraintsDaily == null || FrmConstraintsDaily.IsDisposed)
            {
                FrmConstraintsDaily = new ConstraintsDailyFrm();
                FrmConstraintsDaily.MdiParent = this;
                FrmConstraintsDaily.Show();
            }
            else
            {
                if (FrmConstraintsDaily.Visible)
                {
                    FrmConstraintsDaily.WindowState = FormWindowState.Normal;
                    FrmConstraintsDaily.Focus();
                }
                else
                {
                    FrmConstraintsDaily.MdiParent = this;
                    FrmConstraintsDaily.Show();
                }
            }
            FrmConstraintsDaily.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.constraintsDaily, 16, false);
        }
        private void editorYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorYear == null || FrmEditorYear.IsDisposed)
            {
                FrmEditorYear = new EditorYearFrm();
                FrmEditorYear.MdiParent = this;
                FrmEditorYear.Show();
            }
            else
            {
                if (FrmEditorYear.Visible)
                {
                    FrmEditorYear.WindowState = FormWindowState.Normal;
                    FrmEditorYear.Focus();
                }
                else
                {
                    FrmEditorYear.MdiParent = this;
                    FrmEditorYear.Show();
                }
            }
            FrmEditorYear.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.editorYear, 16, false);
        }
        private void editorAccountNatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorAccountNature == null || FrmEditorAccountNature.IsDisposed)
            {
                FrmEditorAccountNature = new EditorAccountNatureFrm();
                FrmEditorAccountNature.MdiParent = this;
                FrmEditorAccountNature.Show();
            }
            else
            {
                if (FrmEditorAccountNature.Visible)
                {
                    FrmEditorAccountNature.WindowState = FormWindowState.Normal;
                    FrmEditorAccountNature.Focus();
                }
                else
                {
                    FrmEditorAccountNature.MdiParent = this;
                    FrmEditorAccountNature.Show();
                }
            }
            FrmEditorAccountNature.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.editorAccountNature, 16, false);
        }
        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorBank == null || FrmEditorBank.IsDisposed)
            {
                FrmEditorBank = new EditorBankFrm();
                FrmEditorBank.MdiParent = this;
                FrmEditorBank.Show();
            }
            else
            {
                if (FrmEditorBank.Visible)
                {
                    FrmEditorBank.WindowState = FormWindowState.Normal;
                    FrmEditorBank.Focus();
                }
                else
                {
                    FrmEditorBank.MdiParent = this;
                    FrmEditorBank.Show();
                }
            }
            FrmEditorBank.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.banks, 16, false);
        }
        private void editJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorJob == null || FrmEditorJob.IsDisposed)
            {
                FrmEditorJob = new EditorJobFrm();
                FrmEditorJob.MdiParent = this;
                FrmEditorJob.Show();
            }
            else
            {
                if (FrmEditorJob.Visible)
                {
                    FrmEditorJob.WindowState = FormWindowState.Normal;
                    FrmEditorJob.Focus();
                }
                else
                {
                    FrmEditorJob.MdiParent = this;
                    FrmEditorJob.Show();
                }
            }
            FrmEditorJob.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.editJobTool, 16, false);
        }
        private void editEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataEmp == null || FrmDataEmp.IsDisposed)
            {
                FrmDataEmp = new DataEmpFrm();
                FrmDataEmp.MdiParent = this;
                FrmDataEmp.Show();
            }
            else
            {
                if (FrmDataEmp.Visible)
                {
                    FrmDataEmp.WindowState = FormWindowState.Normal;
                    FrmDataEmp.Focus();
                }
                else
                {
                    FrmDataEmp.MdiParent = this;
                    FrmDataEmp.Show();
                }
            }
            FrmDataEmp.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.editEmp, 16, false);
        }
        private void prmEditorRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorRole == null || FrmEditorRole.IsDisposed)
            {
                FrmEditorRole = new EditorRoleFrm();
                FrmEditorRole.MdiParent = this;
                FrmEditorRole.Show();
            }
            else
            {
                if (FrmEditorRole.Visible)
                {
                    FrmEditorRole.WindowState = FormWindowState.Normal;
                    FrmEditorRole.Focus();
                }
                else
                {
                    FrmEditorRole.MdiParent = this;
                    FrmEditorRole.Show();
                }
            }
            FrmEditorRole.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.Roles, 16, false);
        }
        private void prmEditorRoleMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorRoleMenu == null || FrmEditorRoleMenu.IsDisposed)
            {
                FrmEditorRoleMenu = new EditorRoleMenuFrm();
                //FrmEditorRoleMenu.MdiParent = this;
                FrmEditorRoleMenu.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.RoleDetial, 16, false);
                FrmEditorRoleMenu.ShowDialog();
            }
            else
            {
                FrmEditorRoleMenu.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.RoleDetial, 16, false);
                if (FrmEditorRoleMenu.Visible)
                {
                    FrmEditorRoleMenu.WindowState = FormWindowState.Normal;
                    FrmEditorRoleMenu.Focus();
                }
                else
                {
                    //FrmEditorRoleMenu.MdiParent = this;
                    FrmEditorRoleMenu.ShowDialog();
                }
            }
            
        }
        private void PremEditorUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorUser == null || FrmEditorUser.IsDisposed)
            {
                FrmEditorUser = new EditorUserFrm();
                FrmEditorUser.MdiParent = this;
                FrmEditorUser.Show();
            }
            else
            {
                if (FrmEditorUser.Visible)
                {
                    FrmEditorUser.WindowState = FormWindowState.Normal;
                    FrmEditorUser.Focus();
                }
                else
                {
                    FrmEditorUser.MdiParent = this;
                    FrmEditorUser.Show();
                }
            }
            FrmEditorUser.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.Users, 16, false);
        }
        private void premEditorUserInRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorUserInRole == null || FrmEditorUserInRole.IsDisposed)
            {
                FrmEditorUserInRole = new EditorUserInRoleFrm();
                FrmEditorUserInRole.MdiParent = this;
                FrmEditorUserInRole.Show();
            }
            else
            {
                if (FrmEditorUserInRole.Visible)
                {
                    FrmEditorUserInRole.WindowState = FormWindowState.Normal;
                    FrmEditorUserInRole.Focus();
                }
                else
                {
                    FrmEditorUserInRole.MdiParent = this;
                    FrmEditorUserInRole.Show();
                }
            }
            FrmEditorUserInRole.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.UserRoles, 16, false);
        }
        private void accTreeOptionsFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmAccTreeOptions == null || FrmAccTreeOptions.IsDisposed)
            {
                FrmAccTreeOptions = new AccTreeOptionsFrm();
                FrmAccTreeOptions.MdiParent = this;
                FrmAccTreeOptions.Show();
            }
            else
            {
                if (FrmAccTreeOptions.Visible)
                {
                    FrmAccTreeOptions.WindowState = FormWindowState.Normal;
                    FrmAccTreeOptions.Focus();
                }
                else
                {
                    FrmAccTreeOptions.MdiParent = this;
                    FrmAccTreeOptions.Show();
                }
            }
            FrmAccTreeOptions.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.accTreeOptionsFrm, 16, false);
        }
        private void qrysellsFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmQrysells == null || FrmQrysells.IsDisposed)
            {
                FrmQrysells = new QrysellsFrm();
                FrmQrysells.MdiParent = this;
                FrmQrysells.Show();
            }
            else
            {
                if (FrmQrysells.Visible)
                {
                    FrmQrysells.WindowState = FormWindowState.Normal;
                    FrmQrysells.Focus();
                }
                else
                {
                    FrmQrysells.MdiParent = this;
                    FrmQrysells.Show();
                }
            }
            FrmQrysells.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.Qry, 16, false);
        }
        private void qryQryBuysFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmQryBuys == null || FrmQryBuys.IsDisposed)
            {
                FrmQryBuys = new QryBuysFrm();
                FrmQryBuys.MdiParent = this;
                FrmQryBuys.Show();
            }
            else
            {
                if (FrmQryBuys.Visible)
                {
                    FrmQryBuys.WindowState = FormWindowState.Normal;
                    FrmQryBuys.Focus();
                }
                else
                {
                    FrmQryBuys.MdiParent = this;
                    FrmQryBuys.Show();
                }
            }
            FrmQryBuys.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.Qry, 16, false);
        }
        private void skinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSkins == null || FrmSkins.IsDisposed)
            {
                FrmSkins = new SkinsFrm();
                FrmSkins.MdiParent = this;
                FrmSkins.Show();
            }
            else
            {
                if (FrmSkins.Visible)
                {
                    FrmSkins.WindowState = FormWindowState.Normal;
                    FrmSkins.Focus();
                }
                else
                {
                    FrmSkins.MdiParent = this;
                    FrmSkins.Show();
                }
            }
        }
        private void deployRptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings rpt = new Settings();
            string reportserver = MCls.ReportURL.Replace("http://", "");
            reportserver = reportserver.Substring(0, reportserver.IndexOf("/"));
            string[] arr = MCls.ReportURL.Split(Convert.ToChar("/"));
            rpt.GlobalSettings(reportserver, arr[arr.Length - 1]);
            System.Data.SqlClient.SqlConnectionStringBuilder constring = new System.Data.SqlClient.SqlConnectionStringBuilder(MCls.SQLConStrStoreAccount);
            string constringpro = string.Format(@"data source={0};initial catalog={1}", constring.DataSource, constring.InitialCatalog);
            rpt.CreateDataSource("DataSourceStoreAccount", true, true, "Data Sources", constringpro, Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
            Settings.Report[] reports = null;
            foreach (MCls.SQLReportsStr item in MCls.SQLRep)
            {
                if (reports == null)
                    Array.Resize<Settings.Report>(ref reports, 1);
                else
                    Array.Resize<Settings.Report>(ref reports, reports.Length + 1);

                reports[reports.Length - 1].Name = item.RepFileName.Replace(".rdl", "");
                reports[reports.Length - 1].FilePathValue = @"\rdl\" + item.RepFileName;
            }
            rpt.CreateReport("GroupDS", "DataSourceStoreAccount", MCls.ReportPath, 10080, reports);
            MCls.DeploySSRSReports(rpt);
        }
        private void TSMI_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            FrmRepGeneral.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.Report, 20, false);
            FrmRepGeneral.rptSelectedIndex = (int)((ToolStripMenuItem)sender).Tag;
            FrmRepGeneral.Show();
        }
        private void tBLCheekNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmTBLCheekNumbers == null || FrmTBLCheekNumbers.IsDisposed)
            {
                FrmTBLCheekNumbers = new TBLCheekNumbersFrm();
                FrmTBLCheekNumbers.MdiParent = this;
                FrmTBLCheekNumbers.Show();
            }
            else
            {
                if (FrmTBLCheekNumbers.Visible)
                {
                    FrmTBLCheekNumbers.WindowState = FormWindowState.Normal;
                    FrmTBLCheekNumbers.Focus();
                }
                else
                {
                    FrmTBLCheekNumbers.MdiParent = this;
                    FrmTBLCheekNumbers.Show();
                }
            }
            FrmTBLCheekNumbers.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.banks, 16, false);
        }
        private void tbleznsarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frmtbleznsars == null || Frmtbleznsars.IsDisposed)
            {
                Frmtbleznsars = new tbleznsarsFrm();
                Frmtbleznsars.MdiParent = this;
                Frmtbleznsars.Show();
            }
            else
            {
                if (Frmtbleznsars.Visible)
                {
                    Frmtbleznsars.WindowState = FormWindowState.Normal;
                    Frmtbleznsars.Focus();
                }
                else
                {
                    Frmtbleznsars.MdiParent = this;
                    Frmtbleznsars.Show();
                }
            }
            Frmtbleznsars.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.tbleznsars16, 16, false);
        }
        private void tblraseedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frmtblraseed == null || Frmtblraseed.IsDisposed)
            {
                Frmtblraseed = new tblraseedFrm();
                Frmtblraseed.MdiParent = this;
                Frmtblraseed.Show();
            }
            else
            {
                if (Frmtblraseed.Visible)
                {
                    Frmtblraseed.WindowState = FormWindowState.Normal;
                    Frmtblraseed.Focus();
                }
                else
                {
                    Frmtblraseed.MdiParent = this;
                    Frmtblraseed.Show();
                }
            }
            Frmtblraseed.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.tblraseed16, 16, false);
        }
        private void tbleznsars2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frmtbleznsars2 == null || Frmtbleznsars2.IsDisposed)
            {
                Frmtbleznsars2 = new tbleznsars2Frm();
                Frmtbleznsars2.MdiParent = this;
                Frmtbleznsars2.Show();
            }
            else
            {
                if (Frmtbleznsars2.Visible)
                {
                    Frmtbleznsars2.WindowState = FormWindowState.Normal;
                    Frmtbleznsars2.Focus();
                }
                else
                {
                    Frmtbleznsars2.MdiParent = this;
                    Frmtbleznsars2.Show();
                }
            }
            Frmtbleznsars2.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.tbleznsars16, 16, false);
        }
        private void tBLkaznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmTBLkazna == null || FrmTBLkazna.IsDisposed)
            {
                FrmTBLkazna = new TBLkaznaFrm();
                FrmTBLkazna.MdiParent = this;
                FrmTBLkazna.Show();
            }
            else
            {
                if (FrmTBLkazna.Visible)
                {
                    FrmTBLkazna.WindowState = FormWindowState.Normal;
                    FrmTBLkazna.Focus();
                }
                else
                {
                    FrmTBLkazna.MdiParent = this;
                    FrmTBLkazna.Show();
                }
            }
            FrmTBLkazna.Icon = MCls.MakeIcon(global::EgAccount.Properties.Resources.TBLkazna16, 16, false);
        }
        private void xrep01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {

                XRep.XRep01 FrmRep = new XRep.XRep01();
                MCls.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void xrep03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {

                XRep.XRep03 FrmRep = new XRep.XRep03();
                MCls.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void xrep04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {

                XRep.XRep04 FrmRep = new XRep.XRep04();
                MCls.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void xrep05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {

                XRep.XRep05 FrmRep = new XRep.XRep05();
                MCls.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void xrep06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {

                XRep.XRep06 FrmRep = new XRep.XRep06();
                MCls.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void qry01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qry01 frm = new Qry01() { MdiParent = this };
            frm.Show();
        }
        #endregion

        

      
        

    }
}