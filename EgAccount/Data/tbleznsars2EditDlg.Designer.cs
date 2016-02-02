namespace EgAccount.Data
{
    partial class tbleznsars2EditDlg
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cetsleem = new DevExpress.XtraEditors.CheckEdit();
            this.detsleemdate = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LSMSTBLCheekNumbers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSTRANSID = new DevExpress.Data.Linq.LinqServerModeSource();
            this.tbmostlem = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cetsleem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detsleemdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detsleemdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLCheekNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTRANSID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmostlem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cetsleem);
            this.layoutControl1.Controls.Add(this.detsleemdate);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.tbmostlem);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(982, 279, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(506, 121);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cetsleem
            // 
            this.cetsleem.EditValue = true;
            this.cetsleem.Location = new System.Drawing.Point(12, 12);
            this.cetsleem.Name = "cetsleem";
            this.cetsleem.Properties.Caption = "";
            this.cetsleem.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.cetsleem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cetsleem.Size = new System.Drawing.Size(413, 19);
            this.cetsleem.StyleController = this.layoutControl1;
            this.cetsleem.TabIndex = 9;
            // 
            // detsleemdate
            // 
            this.detsleemdate.EditValue = null;
            this.detsleemdate.Location = new System.Drawing.Point(12, 59);
            this.detsleemdate.Name = "detsleemdate";
            this.detsleemdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detsleemdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detsleemdate.Size = new System.Drawing.Size(413, 20);
            this.detsleemdate.StyleController = this.layoutControl1;
            this.detsleemdate.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::EgAccount.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(108, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(386, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::EgAccount.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(12, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LSMSTBLCheekNumbers
            // 
            this.LSMSTBLCheekNumbers.ElementType = typeof(EgAccount.Datasource.Linq.vQry002);
            this.LSMSTBLCheekNumbers.KeyExpression = "[CheekAuto]";
            // 
            // LSMSTRANSID
            // 
            this.LSMSTRANSID.ElementType = typeof(EgAccount.Datasource.Linq.vQry001);
            this.LSMSTRANSID.KeyExpression = "[TRANSID]";
            // 
            // tbmostlem
            // 
            this.tbmostlem.Location = new System.Drawing.Point(12, 35);
            this.tbmostlem.Name = "tbmostlem";
            this.tbmostlem.Size = new System.Drawing.Size(413, 20);
            this.tbmostlem.StyleController = this.layoutControl1;
            this.tbmostlem.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxvp.SetValidationRule(this.tbmostlem, conditionValidationRule1);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem10,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(506, 121);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.tbmostlem;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(486, 24);
            this.layoutControlItem1.Text = "اسم المستلم";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(96, 30);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(96, 71);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(390, 30);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem9.Control = this.detsleemdate;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(486, 24);
            this.layoutControlItem9.Text = "التاريخ";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem10.Control = this.cetsleem;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(486, 23);
            this.layoutControlItem10.Text = "تسليم";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(66, 13);
            // 
            // tbleznsars2EditDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 121);
            this.Controls.Add(this.layoutControl1);
            this.Name = "tbleznsars2EditDlg";
            this.Text = "تحرير";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cetsleem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detsleemdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detsleemdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLCheekNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTRANSID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmostlem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit tbmostlem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTRANSID;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLCheekNumbers;
        private DevExpress.XtraEditors.DateEdit detsleemdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.CheckEdit cetsleem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}