namespace EgAccount.Data
{
    partial class tbleznsarsFrm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coleznsarfno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheekstateid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmostafeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colezndes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheekNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAcountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIEDDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIEDDESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrhel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colmorfacat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colezndate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.adp = new EgAccount.Datasource.dsDataTableAdapters.tbleznsarsTableAdapter();
            this.colshow = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlData);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 239, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(952, 461);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.LSMSData;
            this.gridControlData.Location = new System.Drawing.Point(12, 38);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemDateEditYMD,
            this.repositoryItemButtonEditPrint});
            this.gridControlData.Size = new System.Drawing.Size(928, 411);
            this.gridControlData.TabIndex = 5;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(EgAccount.Datasource.Linq.vtbleznsar);
            this.LSMSData.KeyExpression = "[eznsarfno]";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coleznsarfno,
            this.colTRANSID,
            this.colcheekstateid,
            this.colmostafeed,
            this.coldatein,
            this.colezndes,
            this.colCheekNumber,
            this.colBankName,
            this.colBankAcountName,
            this.colUserName,
            this.colYearName,
            this.colKIEDDATE,
            this.colKIEDDESC,
            this.coltrhel,
            this.gridColumn1,
            this.gridColumn2,
            this.colmorfacat,
            this.colezndate,
            this.gcPrint,
            this.colshow});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            // 
            // coleznsarfno
            // 
            this.coleznsarfno.AppearanceCell.Options.UseTextOptions = true;
            this.coleznsarfno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleznsarfno.AppearanceHeader.Options.UseTextOptions = true;
            this.coleznsarfno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleznsarfno.Caption = "رقم الاذن";
            this.coleznsarfno.FieldName = "eznsarfno";
            this.coleznsarfno.Name = "coleznsarfno";
            this.coleznsarfno.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "eznsarfno", "{0}")});
            this.coleznsarfno.Visible = true;
            this.coleznsarfno.VisibleIndex = 0;
            // 
            // colTRANSID
            // 
            this.colTRANSID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANSID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANSID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSID.Caption = "رقم القيد";
            this.colTRANSID.FieldName = "TRANSID";
            this.colTRANSID.Name = "colTRANSID";
            this.colTRANSID.Visible = true;
            this.colTRANSID.VisibleIndex = 1;
            // 
            // colcheekstateid
            // 
            this.colcheekstateid.AppearanceCell.Options.UseTextOptions = true;
            this.colcheekstateid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcheekstateid.AppearanceHeader.Options.UseTextOptions = true;
            this.colcheekstateid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcheekstateid.Caption = "حالة الشيك";
            this.colcheekstateid.FieldName = "cheekstateid";
            this.colcheekstateid.Name = "colcheekstateid";
            this.colcheekstateid.Visible = true;
            this.colcheekstateid.VisibleIndex = 2;
            // 
            // colmostafeed
            // 
            this.colmostafeed.AppearanceCell.Options.UseTextOptions = true;
            this.colmostafeed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostafeed.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostafeed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostafeed.Caption = "مستفيد";
            this.colmostafeed.FieldName = "mostafeed";
            this.colmostafeed.Name = "colmostafeed";
            this.colmostafeed.Visible = true;
            this.colmostafeed.VisibleIndex = 3;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditYMD;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 11;
            this.coldatein.Width = 76;
            // 
            // repositoryItemDateEditYMD
            // 
            this.repositoryItemDateEditYMD.AutoHeight = false;
            this.repositoryItemDateEditYMD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.Name = "repositoryItemDateEditYMD";
            // 
            // colezndes
            // 
            this.colezndes.AppearanceCell.Options.UseTextOptions = true;
            this.colezndes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colezndes.AppearanceHeader.Options.UseTextOptions = true;
            this.colezndes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colezndes.Caption = "البيان";
            this.colezndes.FieldName = "ezndes";
            this.colezndes.Name = "colezndes";
            this.colezndes.Visible = true;
            this.colezndes.VisibleIndex = 5;
            // 
            // colCheekNumber
            // 
            this.colCheekNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colCheekNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCheekNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colCheekNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCheekNumber.Caption = "رقم الشيك";
            this.colCheekNumber.FieldName = "CheekNumber";
            this.colCheekNumber.Name = "colCheekNumber";
            this.colCheekNumber.Visible = true;
            this.colCheekNumber.VisibleIndex = 6;
            // 
            // colBankName
            // 
            this.colBankName.AppearanceCell.Options.UseTextOptions = true;
            this.colBankName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankName.Caption = "اسم البنك";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 7;
            // 
            // colBankAcountName
            // 
            this.colBankAcountName.AppearanceCell.Options.UseTextOptions = true;
            this.colBankAcountName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankAcountName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankAcountName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankAcountName.Caption = "اسم الحساب في البنك";
            this.colBankAcountName.FieldName = "BankAcountName";
            this.colBankAcountName.Name = "colBankAcountName";
            this.colBankAcountName.Visible = true;
            this.colBankAcountName.VisibleIndex = 8;
            this.colBankAcountName.Width = 127;
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Options.UseTextOptions = true;
            this.colUserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "مدخل البيان";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 10;
            // 
            // colYearName
            // 
            this.colYearName.AppearanceCell.Options.UseTextOptions = true;
            this.colYearName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.Caption = "السنة المالية";
            this.colYearName.FieldName = "YearName";
            this.colYearName.Name = "colYearName";
            this.colYearName.Visible = true;
            this.colYearName.VisibleIndex = 12;
            this.colYearName.Width = 80;
            // 
            // colKIEDDATE
            // 
            this.colKIEDDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colKIEDDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colKIEDDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDATE.Caption = "تاريخ القيد";
            this.colKIEDDATE.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colKIEDDATE.FieldName = "KIEDDATE";
            this.colKIEDDATE.Name = "colKIEDDATE";
            this.colKIEDDATE.Visible = true;
            this.colKIEDDATE.VisibleIndex = 13;
            // 
            // colKIEDDESC
            // 
            this.colKIEDDESC.AppearanceCell.Options.UseTextOptions = true;
            this.colKIEDDESC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDESC.AppearanceHeader.Options.UseTextOptions = true;
            this.colKIEDDESC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDESC.Caption = "ملاحظات القيد";
            this.colKIEDDESC.FieldName = "KIEDDESC";
            this.colKIEDDESC.Name = "colKIEDDESC";
            this.colKIEDDESC.Visible = true;
            this.colKIEDDESC.VisibleIndex = 14;
            this.colKIEDDESC.Width = 86;
            // 
            // coltrhel
            // 
            this.coltrhel.AppearanceCell.Options.UseTextOptions = true;
            this.coltrhel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrhel.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrhel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrhel.Caption = "ترحيل";
            this.coltrhel.FieldName = "trhel";
            this.coltrhel.Name = "coltrhel";
            this.coltrhel.Visible = true;
            this.coltrhel.VisibleIndex = 16;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "تعديل";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 17;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::EgAccount.Properties.Resources.editname_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "حذف";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 18;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::EgAccount.Properties.Resources.cancel_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // colmorfacat
            // 
            this.colmorfacat.AppearanceCell.Options.UseTextOptions = true;
            this.colmorfacat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmorfacat.AppearanceHeader.Options.UseTextOptions = true;
            this.colmorfacat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmorfacat.Caption = "مرفقات";
            this.colmorfacat.FieldName = "morfacat";
            this.colmorfacat.Name = "colmorfacat";
            this.colmorfacat.Visible = true;
            this.colmorfacat.VisibleIndex = 9;
            // 
            // colezndate
            // 
            this.colezndate.AppearanceCell.Options.UseTextOptions = true;
            this.colezndate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colezndate.AppearanceHeader.Options.UseTextOptions = true;
            this.colezndate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colezndate.Caption = "تاريخ الاذن";
            this.colezndate.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colezndate.FieldName = "ezndate";
            this.colezndate.Name = "colezndate";
            this.colezndate.Visible = true;
            this.colezndate.VisibleIndex = 4;
            // 
            // gcPrint
            // 
            this.gcPrint.AppearanceCell.Options.UseTextOptions = true;
            this.gcPrint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPrint.AppearanceHeader.Options.UseTextOptions = true;
            this.gcPrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcPrint.Caption = "طباعة";
            this.gcPrint.ColumnEdit = this.repositoryItemButtonEditPrint;
            this.gcPrint.Name = "gcPrint";
            this.gcPrint.Visible = true;
            this.gcPrint.VisibleIndex = 19;
            // 
            // repositoryItemButtonEditPrint
            // 
            this.repositoryItemButtonEditPrint.AutoHeight = false;
            this.repositoryItemButtonEditPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::EgAccount.Properties.Resources.Print1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.repositoryItemButtonEditPrint.Name = "repositoryItemButtonEditPrint";
            this.repositoryItemButtonEditPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditPrint_ButtonClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EgAccount.Properties.Resources.apply_16x16;
            this.btnAdd.Location = new System.Drawing.Point(807, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافة جديد";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(952, 461);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(795, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(137, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlData;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(932, 415);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(795, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // adp
            // 
            this.adp.ClearBeforeFill = true;
            // 
            // colshow
            // 
            this.colshow.AppearanceCell.Options.UseTextOptions = true;
            this.colshow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colshow.AppearanceHeader.Options.UseTextOptions = true;
            this.colshow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colshow.Caption = "يظهر للخزينة ";
            this.colshow.FieldName = "show";
            this.colshow.Name = "colshow";
            this.colshow.Visible = true;
            this.colshow.VisibleIndex = 15;
            // 
            // tbleznsarsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 461);
            this.Controls.Add(this.layoutControl1);
            this.Name = "tbleznsarsFrm";
            this.Text = "اذن الصرف";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraGrid.Columns.GridColumn coleznsarfno;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANSID;
        private DevExpress.XtraGrid.Columns.GridColumn colcheekstateid;
        private DevExpress.XtraGrid.Columns.GridColumn colmostafeed;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colezndes;
        private DevExpress.XtraGrid.Columns.GridColumn colCheekNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAcountName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colKIEDDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colKIEDDESC;
        private DevExpress.XtraGrid.Columns.GridColumn coltrhel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private Datasource.dsDataTableAdapters.tbleznsarsTableAdapter adp;
        private DevExpress.XtraGrid.Columns.GridColumn colmorfacat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private DevExpress.XtraGrid.Columns.GridColumn colezndate;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colshow;
    }
}