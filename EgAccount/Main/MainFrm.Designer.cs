namespace EgAccount
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.accountCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorAccountNatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accTreeOptionsFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constraintsDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrysellsFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qryQryBuysFrmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rptCol1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rptCol2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployRptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prmEditorRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prmEditorRoleMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PremEditorUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.premEditorUserInRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.CodeMenu,
            this.dataToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.printingToolStripMenuItem,
            this.permissionToolStripMenuItem,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(796, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "GeneralmenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restConnectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Image = global::EgAccount.Properties.Resources.File;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(64, 20);
            this.fileMenu.Text = "ملـــف";
            // 
            // restConnectionToolStripMenuItem
            // 
            this.restConnectionToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Connection;
            this.restConnectionToolStripMenuItem.Name = "restConnectionToolStripMenuItem";
            this.restConnectionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.restConnectionToolStripMenuItem.Text = "ألغاء اتصال قاعدة البيانات";
            this.restConnectionToolStripMenuItem.Visible = false;
            this.restConnectionToolStripMenuItem.Click += new System.EventHandler(this.restConnectionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // CodeMenu
            // 
            this.CodeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountCodesToolStripMenuItem,
            this.generalCodesToolStripMenuItem});
            this.CodeMenu.Image = global::EgAccount.Properties.Resources.Code;
            this.CodeMenu.Name = "CodeMenu";
            this.CodeMenu.Size = new System.Drawing.Size(59, 20);
            this.CodeMenu.Text = "اكواد";
            // 
            // accountCodesToolStripMenuItem
            // 
            this.accountCodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorYearToolStripMenuItem,
            this.editorAccountNatureToolStripMenuItem,
            this.banksToolStripMenuItem,
            this.accTreeOptionsFrmToolStripMenuItem});
            this.accountCodesToolStripMenuItem.Image = global::EgAccount.Properties.Resources.banks;
            this.accountCodesToolStripMenuItem.Name = "accountCodesToolStripMenuItem";
            this.accountCodesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.accountCodesToolStripMenuItem.Text = "اكواد الحسابات";
            // 
            // editorYearToolStripMenuItem
            // 
            this.editorYearToolStripMenuItem.Image = global::EgAccount.Properties.Resources.editorYear;
            this.editorYearToolStripMenuItem.Name = "editorYearToolStripMenuItem";
            this.editorYearToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editorYearToolStripMenuItem.Text = "السنوات الماليه";
            this.editorYearToolStripMenuItem.Visible = false;
            this.editorYearToolStripMenuItem.Click += new System.EventHandler(this.editorYearToolStripMenuItem_Click);
            // 
            // editorAccountNatureToolStripMenuItem
            // 
            this.editorAccountNatureToolStripMenuItem.Image = global::EgAccount.Properties.Resources.editorAccountNature;
            this.editorAccountNatureToolStripMenuItem.Name = "editorAccountNatureToolStripMenuItem";
            this.editorAccountNatureToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editorAccountNatureToolStripMenuItem.Text = "طبيعة الحسابات";
            this.editorAccountNatureToolStripMenuItem.Visible = false;
            this.editorAccountNatureToolStripMenuItem.Click += new System.EventHandler(this.editorAccountNatureToolStripMenuItem_Click);
            // 
            // banksToolStripMenuItem
            // 
            this.banksToolStripMenuItem.Image = global::EgAccount.Properties.Resources.banks;
            this.banksToolStripMenuItem.Name = "banksToolStripMenuItem";
            this.banksToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.banksToolStripMenuItem.Text = "البنـــوك";
            this.banksToolStripMenuItem.Visible = false;
            this.banksToolStripMenuItem.Click += new System.EventHandler(this.banksToolStripMenuItem_Click);
            // 
            // accTreeOptionsFrmToolStripMenuItem
            // 
            this.accTreeOptionsFrmToolStripMenuItem.Image = global::EgAccount.Properties.Resources.accTreeOptionsFrm;
            this.accTreeOptionsFrmToolStripMenuItem.Name = "accTreeOptionsFrmToolStripMenuItem";
            this.accTreeOptionsFrmToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.accTreeOptionsFrmToolStripMenuItem.Text = "خيارات شجرة الحسابات";
            this.accTreeOptionsFrmToolStripMenuItem.Visible = false;
            this.accTreeOptionsFrmToolStripMenuItem.Click += new System.EventHandler(this.accTreeOptionsFrmToolStripMenuItem_Click);
            // 
            // generalCodesToolStripMenuItem
            // 
            this.generalCodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editJobToolStripMenuItem});
            this.generalCodesToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Code;
            this.generalCodesToolStripMenuItem.Name = "generalCodesToolStripMenuItem";
            this.generalCodesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.generalCodesToolStripMenuItem.Text = "اكواد عامه";
            // 
            // editJobToolStripMenuItem
            // 
            this.editJobToolStripMenuItem.Image = global::EgAccount.Properties.Resources.editJobTool;
            this.editJobToolStripMenuItem.Name = "editJobToolStripMenuItem";
            this.editJobToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editJobToolStripMenuItem.Text = "الوظائف";
            this.editJobToolStripMenuItem.Visible = false;
            this.editJobToolStripMenuItem.Click += new System.EventHandler(this.editJobToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataAccountToolStripMenuItem,
            this.dataGeneralToolStripMenuItem});
            this.dataToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Data;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.dataToolStripMenuItem.Text = "ادخال بيانات";
            // 
            // dataAccountToolStripMenuItem
            // 
            this.dataAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsTypesToolStripMenuItem,
            this.constraintsDailyToolStripMenuItem});
            this.dataAccountToolStripMenuItem.Image = global::EgAccount.Properties.Resources.banks;
            this.dataAccountToolStripMenuItem.Name = "dataAccountToolStripMenuItem";
            this.dataAccountToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dataAccountToolStripMenuItem.Text = "بيانات الحسابات";
            // 
            // accountsTypesToolStripMenuItem
            // 
            this.accountsTypesToolStripMenuItem.Image = global::EgAccount.Properties.Resources.accountsTypes;
            this.accountsTypesToolStripMenuItem.Name = "accountsTypesToolStripMenuItem";
            this.accountsTypesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.accountsTypesToolStripMenuItem.Text = "دليل الحسابات";
            this.accountsTypesToolStripMenuItem.Visible = false;
            this.accountsTypesToolStripMenuItem.Click += new System.EventHandler(this.accountsTypesToolStripMenuItem_Click);
            // 
            // constraintsDailyToolStripMenuItem
            // 
            this.constraintsDailyToolStripMenuItem.Image = global::EgAccount.Properties.Resources.constraintsDaily;
            this.constraintsDailyToolStripMenuItem.Name = "constraintsDailyToolStripMenuItem";
            this.constraintsDailyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.constraintsDailyToolStripMenuItem.Text = "القيود اليوميــه";
            this.constraintsDailyToolStripMenuItem.Visible = false;
            this.constraintsDailyToolStripMenuItem.Click += new System.EventHandler(this.constraintsDailyToolStripMenuItem_Click);
            // 
            // dataGeneralToolStripMenuItem
            // 
            this.dataGeneralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEmpToolStripMenuItem});
            this.dataGeneralToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Code;
            this.dataGeneralToolStripMenuItem.Name = "dataGeneralToolStripMenuItem";
            this.dataGeneralToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dataGeneralToolStripMenuItem.Text = "بيانات عامه";
            // 
            // editEmpToolStripMenuItem
            // 
            this.editEmpToolStripMenuItem.Image = global::EgAccount.Properties.Resources.editEmp;
            this.editEmpToolStripMenuItem.Name = "editEmpToolStripMenuItem";
            this.editEmpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editEmpToolStripMenuItem.Text = "العاملون";
            this.editEmpToolStripMenuItem.Visible = false;
            this.editEmpToolStripMenuItem.Click += new System.EventHandler(this.editEmpToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qrysellsFrmToolStripMenuItem,
            this.qryQryBuysFrmToolStripMenuItem});
            this.queryToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Queries;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.queryToolStripMenuItem.Text = "استعلامــات";
            // 
            // qrysellsFrmToolStripMenuItem
            // 
            this.qrysellsFrmToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Qry;
            this.qrysellsFrmToolStripMenuItem.Name = "qrysellsFrmToolStripMenuItem";
            this.qrysellsFrmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.qrysellsFrmToolStripMenuItem.Text = "استعلام المبيعات";
            this.qrysellsFrmToolStripMenuItem.Visible = false;
            this.qrysellsFrmToolStripMenuItem.Click += new System.EventHandler(this.qrysellsFrmToolStripMenuItem_Click);
            // 
            // qryQryBuysFrmToolStripMenuItem
            // 
            this.qryQryBuysFrmToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Qry;
            this.qryQryBuysFrmToolStripMenuItem.Name = "qryQryBuysFrmToolStripMenuItem";
            this.qryQryBuysFrmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.qryQryBuysFrmToolStripMenuItem.Text = "استعلام المشتريات";
            this.qryQryBuysFrmToolStripMenuItem.Visible = false;
            this.qryQryBuysFrmToolStripMenuItem.Click += new System.EventHandler(this.qryQryBuysFrmToolStripMenuItem_Click);
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rptCol1ToolStripMenuItem,
            this.rptCol2ToolStripMenuItem,
            this.deployRptToolStripMenuItem});
            this.printingToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Print1;
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.printingToolStripMenuItem.Text = "طبــاعة تقاريــر";
            // 
            // rptCol1ToolStripMenuItem
            // 
            this.rptCol1ToolStripMenuItem.Image = global::EgAccount.Properties.Resources.ReportGroup;
            this.rptCol1ToolStripMenuItem.Name = "rptCol1ToolStripMenuItem";
            this.rptCol1ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rptCol1ToolStripMenuItem.Text = "مجموعه 1";
            // 
            // rptCol2ToolStripMenuItem
            // 
            this.rptCol2ToolStripMenuItem.Image = global::EgAccount.Properties.Resources.ReportGroup;
            this.rptCol2ToolStripMenuItem.Name = "rptCol2ToolStripMenuItem";
            this.rptCol2ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.rptCol2ToolStripMenuItem.Text = "مجموعه 2";
            // 
            // deployRptToolStripMenuItem
            // 
            this.deployRptToolStripMenuItem.Image = global::EgAccount.Properties.Resources.DeployRpt;
            this.deployRptToolStripMenuItem.Name = "deployRptToolStripMenuItem";
            this.deployRptToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deployRptToolStripMenuItem.Text = "تنصيب التقارير";
            this.deployRptToolStripMenuItem.Visible = false;
            this.deployRptToolStripMenuItem.Click += new System.EventHandler(this.deployRptToolStripMenuItem_Click);
            // 
            // permissionToolStripMenuItem
            // 
            this.permissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prmEditorRoleToolStripMenuItem,
            this.prmEditorRoleMenuToolStripMenuItem,
            this.PremEditorUserToolStripMenuItem,
            this.premEditorUserInRoleToolStripMenuItem});
            this.permissionToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Permission;
            this.permissionToolStripMenuItem.Name = "permissionToolStripMenuItem";
            this.permissionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.permissionToolStripMenuItem.Text = "صلاحيــــات";
            // 
            // prmEditorRoleToolStripMenuItem
            // 
            this.prmEditorRoleToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Roles;
            this.prmEditorRoleToolStripMenuItem.Name = "prmEditorRoleToolStripMenuItem";
            this.prmEditorRoleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prmEditorRoleToolStripMenuItem.Text = "السماحيات";
            this.prmEditorRoleToolStripMenuItem.Visible = false;
            this.prmEditorRoleToolStripMenuItem.Click += new System.EventHandler(this.prmEditorRoleToolStripMenuItem_Click);
            // 
            // prmEditorRoleMenuToolStripMenuItem
            // 
            this.prmEditorRoleMenuToolStripMenuItem.Image = global::EgAccount.Properties.Resources.RoleDetial;
            this.prmEditorRoleMenuToolStripMenuItem.Name = "prmEditorRoleMenuToolStripMenuItem";
            this.prmEditorRoleMenuToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prmEditorRoleMenuToolStripMenuItem.Text = "محتويات الصلاحيات";
            this.prmEditorRoleMenuToolStripMenuItem.Visible = false;
            this.prmEditorRoleMenuToolStripMenuItem.Click += new System.EventHandler(this.prmEditorRoleMenuToolStripMenuItem_Click);
            // 
            // PremEditorUserToolStripMenuItem
            // 
            this.PremEditorUserToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Users;
            this.PremEditorUserToolStripMenuItem.Name = "PremEditorUserToolStripMenuItem";
            this.PremEditorUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.PremEditorUserToolStripMenuItem.Text = "المستخدمين";
            this.PremEditorUserToolStripMenuItem.Visible = false;
            this.PremEditorUserToolStripMenuItem.Click += new System.EventHandler(this.PremEditorUserToolStripMenuItem_Click);
            // 
            // premEditorUserInRoleToolStripMenuItem
            // 
            this.premEditorUserInRoleToolStripMenuItem.Image = global::EgAccount.Properties.Resources.UserRoles;
            this.premEditorUserInRoleToolStripMenuItem.Name = "premEditorUserInRoleToolStripMenuItem";
            this.premEditorUserInRoleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.premEditorUserInRoleToolStripMenuItem.Text = "سماحيات المستخدمين";
            this.premEditorUserInRoleToolStripMenuItem.Visible = false;
            this.premEditorUserInRoleToolStripMenuItem.Click += new System.EventHandler(this.premEditorUserInRoleToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewMenu.Image = global::EgAccount.Properties.Resources.View;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(62, 20);
            this.viewMenu.Text = "عرض";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.skinsToolStripMenuItem});
            this.toolsMenu.Image = global::EgAccount.Properties.Resources.Tools;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(64, 20);
            this.toolsMenu.Text = "ادوات";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Options;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.optionsToolStripMenuItem.Text = "اختيارات";
            this.optionsToolStripMenuItem.Visible = false;
            // 
            // skinsToolStripMenuItem
            // 
            this.skinsToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Skins;
            this.skinsToolStripMenuItem.Name = "skinsToolStripMenuItem";
            this.skinsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.skinsToolStripMenuItem.Text = "الاشكال";
            this.skinsToolStripMenuItem.Visible = false;
            this.skinsToolStripMenuItem.Click += new System.EventHandler(this.skinsToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Image = global::EgAccount.Properties.Resources.Window;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(60, 20);
            this.windowsMenu.Text = "نوافذ";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Image = global::EgAccount.Properties.Resources.WindowCascade;
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cascadeToolStripMenuItem.Text = "ترتيب النوافذ";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Image = global::EgAccount.Properties.Resources.WindowVertical;
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tileVerticalToolStripMenuItem.Text = "العناوين رأسي";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Image = global::EgAccount.Properties.Resources.WindowHorizontal;
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tileHorizontalToolStripMenuItem.Text = "العناوين افقي";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Close;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.closeAllToolStripMenuItem.Text = "اغلاق الكل";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Window;
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.arrangeIconsToolStripMenuItem.Text = "ترتيب الايكون";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpMenu.Image = global::EgAccount.Properties.Resources.Help;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(74, 20);
            this.helpMenu.Text = "مساعده";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.contentsToolStripMenuItem.Text = "المحتويات";
            this.contentsToolStripMenuItem.Visible = false;
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.indexToolStripMenuItem.Text = "فهرس";
            this.indexToolStripMenuItem.Visible = false;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.searchToolStripMenuItem.Text = "بحث";
            this.searchToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::EgAccount.Properties.Resources.EESoft;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "عن البرنامج";
            this.aboutToolStripMenuItem.Visible = false;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 551);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(796, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // imageListIcon
            // 
            this.imageListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcon.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 573);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات العامة";
            this.Load += new System.EventHandler(this.ECMMainFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CodeMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prmEditorRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prmEditorRoleMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PremEditorUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem premEditorUserInRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorAccountNatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accTreeOptionsFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constraintsDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qrysellsFrmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rptCol1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rptCol2ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.ToolStripMenuItem deployRptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qryQryBuysFrmToolStripMenuItem;
    }
}



