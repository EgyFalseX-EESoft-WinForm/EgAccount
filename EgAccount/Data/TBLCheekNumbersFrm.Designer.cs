namespace EgAccount.Data
{
    partial class TBLCheekNumbersFrm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.XPSCSData = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.UOWData = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankAcountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheekNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbCount = new DevExpress.XtraEditors.TextEdit();
            this.tbStart = new DevExpress.XtraEditors.TextEdit();
            this.LUEBankAcountID = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.repositoryItemLookUpEditBankAcountID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOWData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEBankAcountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBankAcountID)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlData);
            this.layoutControl1.Controls.Add(this.tbCount);
            this.layoutControl1.Controls.Add(this.tbStart);
            this.layoutControl1.Controls.Add(this.LUEBankAcountID);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1128, 320, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(663, 421);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.XPSCSData;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(12, 38);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditBankAcountID});
            this.gridControlData.Size = new System.Drawing.Size(639, 371);
            this.gridControlData.TabIndex = 8;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // XPSCSData
            // 
            this.XPSCSData.AllowEdit = true;
            this.XPSCSData.AllowRemove = true;
            this.XPSCSData.ObjectType = typeof(EgAccount.Datasource.dsData.TBLCheekNumbersDataTable);
            this.XPSCSData.Session = this.UOWData;
            // 
            // UOWData
            // 
            this.UOWData.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOWData.TrackPropertiesModifications = false;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankAcountID,
            this.colCheekNumber});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsSelection.MultiSelect = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewData_RowDeleted);
            // 
            // colBankAcountID
            // 
            this.colBankAcountID.Caption = "البنك";
            this.colBankAcountID.ColumnEdit = this.repositoryItemLookUpEditBankAcountID;
            this.colBankAcountID.FieldName = "BankAcountID";
            this.colBankAcountID.Name = "colBankAcountID";
            this.colBankAcountID.Visible = true;
            this.colBankAcountID.VisibleIndex = 0;
            // 
            // colCheekNumber
            // 
            this.colCheekNumber.Caption = "رقم الشيك";
            this.colCheekNumber.FieldName = "CheekNumber";
            this.colCheekNumber.Name = "colCheekNumber";
            this.colCheekNumber.Visible = true;
            this.colCheekNumber.VisibleIndex = 1;
            // 
            // tbCount
            // 
            this.tbCount.EditValue = "0";
            this.tbCount.Location = new System.Drawing.Point(12, 12);
            this.tbCount.Name = "tbCount";
            this.tbCount.Properties.DisplayFormat.FormatString = "n0";
            this.tbCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCount.Properties.EditFormat.FormatString = "n0";
            this.tbCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCount.Properties.Mask.EditMask = "n0";
            this.tbCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbCount.Size = new System.Drawing.Size(111, 20);
            this.tbCount.StyleController = this.layoutControl1;
            this.tbCount.TabIndex = 7;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxvp.SetValidationRule(this.tbCount, conditionValidationRule1);
            // 
            // tbStart
            // 
            this.tbStart.EditValue = "0";
            this.tbStart.Location = new System.Drawing.Point(163, 12);
            this.tbStart.Name = "tbStart";
            this.tbStart.Properties.DisplayFormat.FormatString = "n0";
            this.tbStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbStart.Properties.EditFormat.FormatString = "n0";
            this.tbStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbStart.Properties.Mask.EditMask = "n0";
            this.tbStart.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbStart.Size = new System.Drawing.Size(111, 20);
            this.tbStart.StyleController = this.layoutControl1;
            this.tbStart.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxvp.SetValidationRule(this.tbStart, conditionValidationRule2);
            // 
            // LUEBankAcountID
            // 
            this.LUEBankAcountID.Location = new System.Drawing.Point(314, 12);
            this.LUEBankAcountID.Name = "LUEBankAcountID";
            this.LUEBankAcountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEBankAcountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "الاسم", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LUEBankAcountID.Properties.DataSource = this.LSMSData;
            this.LUEBankAcountID.Properties.DisplayMember = "BankName";
            this.LUEBankAcountID.Properties.NullText = "";
            this.LUEBankAcountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUEBankAcountID.Properties.ValueMember = "BankAcountID";
            this.LUEBankAcountID.Size = new System.Drawing.Size(193, 20);
            this.LUEBankAcountID.StyleController = this.layoutControl1;
            this.LUEBankAcountID.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxvp.SetValidationRule(this.LUEBankAcountID, conditionValidationRule3);
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(EgAccount.Datasource.Linq.CDBANK);
            this.LSMSData.KeyExpression = "[BankAcountID]";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EgAccount.Properties.Resources.apply_16x16;
            this.btnAdd.Location = new System.Drawing.Point(547, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(663, 421);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.LUEBankAcountID;
            this.layoutControlItem2.Location = new System.Drawing.Point(302, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(233, 26);
            this.layoutControlItem2.Text = "البنك";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(33, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tbStart;
            this.layoutControlItem3.Location = new System.Drawing.Point(151, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(151, 26);
            this.layoutControlItem3.Text = "يبدا من";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(33, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tbCount;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(151, 26);
            this.layoutControlItem4.Text = "العدد";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(33, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControlData;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(643, 375);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(535, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // repositoryItemLookUpEditBankAcountID
            // 
            this.repositoryItemLookUpEditBankAcountID.AutoHeight = false;
            this.repositoryItemLookUpEditBankAcountID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditBankAcountID.DataSource = this.LSMSData;
            this.repositoryItemLookUpEditBankAcountID.DisplayMember = "BankName";
            this.repositoryItemLookUpEditBankAcountID.Name = "repositoryItemLookUpEditBankAcountID";
            this.repositoryItemLookUpEditBankAcountID.NullText = "";
            this.repositoryItemLookUpEditBankAcountID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditBankAcountID.ValueMember = "BankAcountID";
            // 
            // TBLCheekNumbersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 421);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TBLCheekNumbersFrm";
            this.Text = "ترقيم الشيكات";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOWData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEBankAcountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBankAcountID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit LUEBankAcountID;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.TextEdit tbCount;
        private DevExpress.XtraEditors.TextEdit tbStart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSData;
        private DevExpress.Xpo.UnitOfWork UOWData;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAcountID;
        private DevExpress.XtraGrid.Columns.GridColumn colCheekNumber;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBankAcountID;
    }
}