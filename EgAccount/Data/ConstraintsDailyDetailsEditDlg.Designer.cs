namespace EgAccount.Data
{
    partial class ConstraintsDailyDetailsEditDlg
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLTRAANSDETAILSBindingSource = new System.Windows.Forms.BindingSource();
            this.dsData = new EgAccount.Datasource.dsData();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTreeListLookUpEditAccountId = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.tBLAccountesBindingSource = new System.Windows.Forms.BindingSource();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colAccountDes = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colaznsarf = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMadeen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditn2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDaien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostandNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkieddes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tBLTRAANSDETAILSTableAdapter = new EgAccount.Datasource.dsDataTableAdapters.TBLTRAANSDETAILSTableAdapter();
            this.tBL_AccountesTableAdapter = new EgAccount.Datasource.dsDataTableAdapters.TBL_AccountesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTRAANSDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEditAccountId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLAccountesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.gridControlData);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(606, 375, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(684, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::EgAccount.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(478, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::EgAccount.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(462, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.tBLTRAANSDETAILSBindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(12, 12);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDel,
            this.repositoryItemTextEditn2,
            this.repositoryItemTreeListLookUpEditAccountId});
            this.gridControlData.Size = new System.Drawing.Size(660, 311);
            this.gridControlData.TabIndex = 4;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLTRAANSDETAILSBindingSource
            // 
            this.tBLTRAANSDETAILSBindingSource.DataMember = "TBLTRAANSDETAILS";
            this.tBLTRAANSDETAILSBindingSource.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountId,
            this.colTNO,
            this.colMadeen,
            this.colDaien,
            this.colMostandNo,
            this.colkieddes,
            this.gridColumn1});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewData_InitNewRow);
            // 
            // colAccountId
            // 
            this.colAccountId.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountId.Caption = "الحساب";
            this.colAccountId.ColumnEdit = this.repositoryItemTreeListLookUpEditAccountId;
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.Visible = true;
            this.colAccountId.VisibleIndex = 0;
            this.colAccountId.Width = 91;
            // 
            // repositoryItemTreeListLookUpEditAccountId
            // 
            this.repositoryItemTreeListLookUpEditAccountId.AutoHeight = false;
            this.repositoryItemTreeListLookUpEditAccountId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEditAccountId.DataSource = this.tBLAccountesBindingSource;
            this.repositoryItemTreeListLookUpEditAccountId.DisplayMember = "AccountDes";
            this.repositoryItemTreeListLookUpEditAccountId.Name = "repositoryItemTreeListLookUpEditAccountId";
            this.repositoryItemTreeListLookUpEditAccountId.NullText = "";
            this.repositoryItemTreeListLookUpEditAccountId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemTreeListLookUpEditAccountId.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            this.repositoryItemTreeListLookUpEditAccountId.ValueMember = "AccountId";
            // 
            // tBLAccountesBindingSource
            // 
            this.tBLAccountesBindingSource.DataMember = "TBL_Accountes";
            this.tBLAccountesBindingSource.DataSource = this.dsData;
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colAccountDes,
            this.colaznsarf});
            this.repositoryItemTreeListLookUpEdit1TreeList.DataSource = this.tBLAccountesBindingSource;
            this.repositoryItemTreeListLookUpEdit1TreeList.KeyFieldName = "AccountId";
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.ParentFieldName = "PairantAccount";
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colAccountDes
            // 
            this.colAccountDes.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountDes.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountDes.Caption = "الاسم";
            this.colAccountDes.FieldName = "AccountDes";
            this.colAccountDes.Name = "colAccountDes";
            this.colAccountDes.Visible = true;
            this.colAccountDes.VisibleIndex = 0;
            this.colAccountDes.Width = 64;
            // 
            // colaznsarf
            // 
            this.colaznsarf.AppearanceCell.Options.UseTextOptions = true;
            this.colaznsarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaznsarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colaznsarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaznsarf.Caption = "اذن صرف";
            this.colaznsarf.FieldName = "aznsarf";
            this.colaznsarf.Name = "colaznsarf";
            this.colaznsarf.Visible = true;
            this.colaznsarf.VisibleIndex = 1;
            this.colaznsarf.Width = 64;
            // 
            // colTNO
            // 
            this.colTNO.AppearanceCell.Options.UseTextOptions = true;
            this.colTNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colTNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTNO.Caption = "رقم";
            this.colTNO.FieldName = "TNO";
            this.colTNO.Name = "colTNO";
            this.colTNO.Visible = true;
            this.colTNO.VisibleIndex = 1;
            this.colTNO.Width = 91;
            // 
            // colMadeen
            // 
            this.colMadeen.AppearanceCell.Options.UseTextOptions = true;
            this.colMadeen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMadeen.AppearanceHeader.Options.UseTextOptions = true;
            this.colMadeen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMadeen.Caption = "داين";
            this.colMadeen.ColumnEdit = this.repositoryItemTextEditn2;
            this.colMadeen.FieldName = "Madeen";
            this.colMadeen.Name = "colMadeen";
            this.colMadeen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Madeen", "{0:0.##}")});
            this.colMadeen.Visible = true;
            this.colMadeen.VisibleIndex = 2;
            this.colMadeen.Width = 91;
            // 
            // repositoryItemTextEditn2
            // 
            this.repositoryItemTextEditn2.AutoHeight = false;
            this.repositoryItemTextEditn2.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.EditFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.Mask.EditMask = "n2";
            this.repositoryItemTextEditn2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditn2.Name = "repositoryItemTextEditn2";
            // 
            // colDaien
            // 
            this.colDaien.AppearanceCell.Options.UseTextOptions = true;
            this.colDaien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDaien.AppearanceHeader.Options.UseTextOptions = true;
            this.colDaien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDaien.Caption = "مدين";
            this.colDaien.ColumnEdit = this.repositoryItemTextEditn2;
            this.colDaien.FieldName = "Daien";
            this.colDaien.Name = "colDaien";
            this.colDaien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Daien", "{0:0.##}")});
            this.colDaien.Visible = true;
            this.colDaien.VisibleIndex = 3;
            this.colDaien.Width = 91;
            // 
            // colMostandNo
            // 
            this.colMostandNo.AppearanceCell.Options.UseTextOptions = true;
            this.colMostandNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMostandNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMostandNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMostandNo.Caption = "رقم المستند";
            this.colMostandNo.FieldName = "MostandNo";
            this.colMostandNo.Name = "colMostandNo";
            this.colMostandNo.Visible = true;
            this.colMostandNo.VisibleIndex = 4;
            this.colMostandNo.Width = 91;
            // 
            // colkieddes
            // 
            this.colkieddes.AppearanceCell.Options.UseTextOptions = true;
            this.colkieddes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkieddes.AppearanceHeader.Options.UseTextOptions = true;
            this.colkieddes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkieddes.Caption = "ملاحظات";
            this.colkieddes.FieldName = "kieddes";
            this.colkieddes.Name = "colkieddes";
            this.colkieddes.Visible = true;
            this.colkieddes.VisibleIndex = 5;
            this.colkieddes.Width = 153;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "حذف";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 34;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::EgAccount.Properties.Resources.cancel_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciSave,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(684, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlData;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(664, 315);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.btnSave;
            this.lciSave.Location = new System.Drawing.Point(0, 315);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(466, 26);
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(466, 315);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // tBLTRAANSDETAILSTableAdapter
            // 
            this.tBLTRAANSDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_AccountesTableAdapter
            // 
            this.tBL_AccountesTableAdapter.ClearBeforeFill = true;
            // 
            // ConstraintsDailyDetailsEditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ConstraintsDailyDetailsEditDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل القيد";
            this.Load += new System.EventHandler(this.ConstraintsDailyDetailsEditDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTRAANSDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEditAccountId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLAccountesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Datasource.dsData dsData;
        private System.Windows.Forms.BindingSource tBLTRAANSDETAILSBindingSource;
        private Datasource.dsDataTableAdapters.TBLTRAANSDETAILSTableAdapter tBLTRAANSDETAILSTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colMadeen;
        private DevExpress.XtraGrid.Columns.GridColumn colDaien;
        private DevExpress.XtraGrid.Columns.GridColumn colMostandNo;
        private DevExpress.XtraGrid.Columns.GridColumn colkieddes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEditAccountId;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn2;
        private System.Windows.Forms.BindingSource tBLAccountesBindingSource;
        private Datasource.dsDataTableAdapters.TBL_AccountesTableAdapter tBL_AccountesTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAccountDes;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colaznsarf;
    }
}