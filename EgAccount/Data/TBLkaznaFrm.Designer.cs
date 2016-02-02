namespace EgAccount.Data
{
    partial class TBLkaznaFrm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coleznnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactiondate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colactionmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditc2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colmostafeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbean = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkaznatype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
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
            this.repositoryItemTextEditc2});
            this.gridControlData.Size = new System.Drawing.Size(928, 411);
            this.gridControlData.TabIndex = 5;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(EgAccount.Datasource.Linq.vTBLkazna);
            this.LSMSData.KeyExpression = "[actionid]";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coleznnumber,
            this.colactiondate,
            this.colactionmony,
            this.colmostafeed,
            this.colbean,
            this.coldatein,
            this.colclosed,
            this.colkaznatype,
            this.colAccountDes,
            this.colUserName,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            // 
            // coleznnumber
            // 
            this.coleznnumber.AppearanceCell.Options.UseTextOptions = true;
            this.coleznnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleznnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.coleznnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleznnumber.Caption = "رقم الاذن";
            this.coleznnumber.FieldName = "eznnumber";
            this.coleznnumber.Name = "coleznnumber";
            this.coleznnumber.Visible = true;
            this.coleznnumber.VisibleIndex = 0;
            // 
            // colactiondate
            // 
            this.colactiondate.AppearanceCell.Options.UseTextOptions = true;
            this.colactiondate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colactiondate.AppearanceHeader.Options.UseTextOptions = true;
            this.colactiondate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colactiondate.Caption = "التاريخ";
            this.colactiondate.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colactiondate.FieldName = "actiondate";
            this.colactiondate.Name = "colactiondate";
            this.colactiondate.Visible = true;
            this.colactiondate.VisibleIndex = 1;
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
            // colactionmony
            // 
            this.colactionmony.AppearanceCell.Options.UseTextOptions = true;
            this.colactionmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colactionmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colactionmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colactionmony.Caption = "المبلغ";
            this.colactionmony.ColumnEdit = this.repositoryItemTextEditc2;
            this.colactionmony.FieldName = "actionmony";
            this.colactionmony.Name = "colactionmony";
            this.colactionmony.Visible = true;
            this.colactionmony.VisibleIndex = 4;
            // 
            // repositoryItemTextEditc2
            // 
            this.repositoryItemTextEditc2.AutoHeight = false;
            this.repositoryItemTextEditc2.DisplayFormat.FormatString = "c2";
            this.repositoryItemTextEditc2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditc2.EditFormat.FormatString = "c2";
            this.repositoryItemTextEditc2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditc2.Mask.EditMask = "c2";
            this.repositoryItemTextEditc2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditc2.Name = "repositoryItemTextEditc2";
            // 
            // colmostafeed
            // 
            this.colmostafeed.AppearanceCell.Options.UseTextOptions = true;
            this.colmostafeed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostafeed.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostafeed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostafeed.Caption = "مورد او مستفيد";
            this.colmostafeed.FieldName = "mostafeed";
            this.colmostafeed.Name = "colmostafeed";
            this.colmostafeed.Visible = true;
            this.colmostafeed.VisibleIndex = 5;
            this.colmostafeed.Width = 92;
            // 
            // colbean
            // 
            this.colbean.AppearanceCell.Options.UseTextOptions = true;
            this.colbean.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbean.AppearanceHeader.Options.UseTextOptions = true;
            this.colbean.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbean.Caption = "البيان";
            this.colbean.FieldName = "bean";
            this.colbean.Name = "colbean";
            this.colbean.Visible = true;
            this.colbean.VisibleIndex = 6;
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
            this.coldatein.VisibleIndex = 9;
            this.coldatein.Width = 76;
            // 
            // colclosed
            // 
            this.colclosed.AppearanceCell.Options.UseTextOptions = true;
            this.colclosed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colclosed.AppearanceHeader.Options.UseTextOptions = true;
            this.colclosed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colclosed.Caption = "اغلاق";
            this.colclosed.FieldName = "closed";
            this.colclosed.Name = "colclosed";
            this.colclosed.Visible = true;
            this.colclosed.VisibleIndex = 7;
            // 
            // colkaznatype
            // 
            this.colkaznatype.AppearanceCell.Options.UseTextOptions = true;
            this.colkaznatype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkaznatype.AppearanceHeader.Options.UseTextOptions = true;
            this.colkaznatype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkaznatype.Caption = "نوع الحركة";
            this.colkaznatype.FieldName = "kaznatype";
            this.colkaznatype.Name = "colkaznatype";
            this.colkaznatype.Visible = true;
            this.colkaznatype.VisibleIndex = 2;
            // 
            // colAccountDes
            // 
            this.colAccountDes.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountDes.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountDes.Caption = "الحساب";
            this.colAccountDes.FieldName = "AccountDes";
            this.colAccountDes.Name = "colAccountDes";
            this.colAccountDes.Visible = true;
            this.colAccountDes.VisibleIndex = 3;
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
            this.colUserName.VisibleIndex = 8;
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
            this.gridColumn1.VisibleIndex = 10;
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
            this.gridColumn2.VisibleIndex = 11;
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
            // TBLkaznaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 461);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TBLkaznaFrm";
            this.Text = "حركة الخزينة";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private DevExpress.XtraGrid.Columns.GridColumn coleznnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colactiondate;
        private DevExpress.XtraGrid.Columns.GridColumn colactionmony;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditc2;
        private DevExpress.XtraGrid.Columns.GridColumn colmostafeed;
        private DevExpress.XtraGrid.Columns.GridColumn colbean;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colclosed;
        private DevExpress.XtraGrid.Columns.GridColumn colkaznatype;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountDes;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}