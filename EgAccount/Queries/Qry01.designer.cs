namespace EgAccount
{
    partial class Qry01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qry01));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cardViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEditG = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cardViewSells = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colTRANSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIEDDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIEDDESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMadeen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkieddes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccNatueName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMostandNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKIEDDAFTRYNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrhel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            this.CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditG.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewSells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.ContextMenuStrip = this.CMS;
            this.gridControlMain.DataSource = this.LSMSData;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditYMD,
            this.repositoryItemDateEditG});
            this.gridControlMain.Size = new System.Drawing.Size(1038, 462);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain,
            this.cardViewSells});
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cardViewToolStripMenuItem,
            this.gridViewToolStripMenuItem});
            this.CMS.Name = "CMSPartnerStaff";
            this.CMS.Size = new System.Drawing.Size(172, 98);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refreshToolStripMenuItem.Text = "اعادة تحميل البيانات";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::EgAccount.Properties.Resources.Print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printToolStripMenuItem.Text = "طباعه";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // cardViewToolStripMenuItem
            // 
            this.cardViewToolStripMenuItem.Name = "cardViewToolStripMenuItem";
            this.cardViewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cardViewToolStripMenuItem.Text = "عرض كروت";
            this.cardViewToolStripMenuItem.Click += new System.EventHandler(this.cardViewToolStripMenuItem_Click);
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gridViewToolStripMenuItem.Text = "عرض جدولي";
            this.gridViewToolStripMenuItem.Click += new System.EventHandler(this.gridViewToolStripMenuItem_Click);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewMain.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewMain.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gridViewMain.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(86)))), ((int)(((byte)(156)))));
            this.gridViewMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gridViewMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gridViewMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewMain.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gridViewMain.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.gridViewMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRANSID,
            this.colYearName,
            this.colKIEDDATE,
            this.colKIEDDESC,
            this.colAccountId,
            this.colMadeen,
            this.colDaien,
            this.colkieddes,
            this.colAccountDes,
            this.colAccNatueName,
            this.colMostandNo,
            this.colKIEDDAFTRYNO,
            this.coltrhel,
            this.coldatein,
            this.colUserName});
            this.gridViewMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", null, "")});
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsCustomization.AllowRowSizing = true;
            this.gridViewMain.OptionsPrint.AutoWidth = false;
            this.gridViewMain.OptionsPrint.ExpandAllDetails = true;
            this.gridViewMain.OptionsPrint.PrintDetails = true;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemDateEditYMD
            // 
            this.repositoryItemDateEditYMD.AutoHeight = false;
            this.repositoryItemDateEditYMD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEditYMD.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEditYMD.Name = "repositoryItemDateEditYMD";
            // 
            // repositoryItemDateEditG
            // 
            this.repositoryItemDateEditG.AutoHeight = false;
            this.repositoryItemDateEditG.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditG.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEditG.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEditG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditG.EditFormat.FormatString = "g";
            this.repositoryItemDateEditG.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditG.Mask.EditMask = "g";
            this.repositoryItemDateEditG.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEditG.Name = "repositoryItemDateEditG";
            // 
            // cardViewSells
            // 
            this.cardViewSells.Appearance.CardCaption.BackColor = System.Drawing.Color.DarkGray;
            this.cardViewSells.Appearance.CardCaption.BorderColor = System.Drawing.Color.DarkGray;
            this.cardViewSells.Appearance.CardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.CardCaption.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.EmptySpace.BackColor = System.Drawing.Color.DimGray;
            this.cardViewSells.Appearance.EmptySpace.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.cardViewSells.Appearance.EmptySpace.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FieldCaption.BackColor = System.Drawing.Color.White;
            this.cardViewSells.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.cardViewSells.Appearance.FieldValue.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.cardViewSells.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.cardViewSells.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.cardViewSells.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.cardViewSells.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardViewSells.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.Black;
            this.cardViewSells.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.Black;
            this.cardViewSells.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardViewSells.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.cardViewSells.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.LightSlateGray;
            this.cardViewSells.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.LightSlateGray;
            this.cardViewSells.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.DimGray;
            this.cardViewSells.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.SeparatorLine.BackColor = System.Drawing.Color.LightGray;
            this.cardViewSells.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardViewSells.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.cardViewSells.FocusedCardTopFieldIndex = 0;
            this.cardViewSells.GridControl = this.gridControlMain;
            this.cardViewSells.Name = "cardViewSells";
            this.cardViewSells.OptionsBehavior.ReadOnly = true;
            this.cardViewSells.OptionsPrint.PrintFilterInfo = true;
            this.cardViewSells.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم الصنف";
            this.gridColumn1.FieldName = "SanfName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الكميه";
            this.gridColumn2.FieldName = "Quantity";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "السعر";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "التاريخ";
            this.gridColumn4.ColumnEdit = this.repositoryItemDateEditG;
            this.gridColumn4.FieldName = "StoreTrDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(EgAccount.Datasource.Linq.vTBLTRAANSDETAIL);
            this.LSMSData.KeyExpression = "[TRANSID], [AccountId]";
            // 
            // colTRANSID
            // 
            this.colTRANSID.AppearanceCell.Options.UseTextOptions = true;
            this.colTRANSID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSID.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRANSID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRANSID.Caption = "كود القيد";
            this.colTRANSID.FieldName = "TRANSID";
            this.colTRANSID.Name = "colTRANSID";
            this.colTRANSID.Visible = true;
            this.colTRANSID.VisibleIndex = 0;
            // 
            // colYearName
            // 
            this.colYearName.AppearanceCell.Options.UseTextOptions = true;
            this.colYearName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.Caption = "السنة";
            this.colYearName.FieldName = "YearName";
            this.colYearName.Name = "colYearName";
            this.colYearName.Visible = true;
            this.colYearName.VisibleIndex = 1;
            // 
            // colKIEDDATE
            // 
            this.colKIEDDATE.AppearanceCell.Options.UseTextOptions = true;
            this.colKIEDDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colKIEDDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDATE.Caption = "التاريخ";
            this.colKIEDDATE.ColumnEdit = this.repositoryItemDateEditYMD;
            this.colKIEDDATE.FieldName = "KIEDDATE";
            this.colKIEDDATE.Name = "colKIEDDATE";
            this.colKIEDDATE.Visible = true;
            this.colKIEDDATE.VisibleIndex = 2;
            // 
            // colKIEDDESC
            // 
            this.colKIEDDESC.AppearanceCell.Options.UseTextOptions = true;
            this.colKIEDDESC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDESC.AppearanceHeader.Options.UseTextOptions = true;
            this.colKIEDDESC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDESC.Caption = "البيان";
            this.colKIEDDESC.FieldName = "KIEDDESC";
            this.colKIEDDESC.Name = "colKIEDDESC";
            this.colKIEDDESC.Visible = true;
            this.colKIEDDESC.VisibleIndex = 3;
            // 
            // colAccountId
            // 
            this.colAccountId.AppearanceCell.Options.UseTextOptions = true;
            this.colAccountId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccountId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccountId.Caption = "كود الحساب";
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.Visible = true;
            this.colAccountId.VisibleIndex = 4;
            this.colAccountId.Width = 84;
            // 
            // colMadeen
            // 
            this.colMadeen.AppearanceCell.Options.UseTextOptions = true;
            this.colMadeen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMadeen.AppearanceHeader.Options.UseTextOptions = true;
            this.colMadeen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMadeen.Caption = "مدين";
            this.colMadeen.FieldName = "Madeen";
            this.colMadeen.Name = "colMadeen";
            this.colMadeen.Visible = true;
            this.colMadeen.VisibleIndex = 6;
            // 
            // colDaien
            // 
            this.colDaien.AppearanceCell.Options.UseTextOptions = true;
            this.colDaien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDaien.AppearanceHeader.Options.UseTextOptions = true;
            this.colDaien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDaien.Caption = "دائن";
            this.colDaien.FieldName = "Daien";
            this.colDaien.Name = "colDaien";
            this.colDaien.Visible = true;
            this.colDaien.VisibleIndex = 7;
            // 
            // colkieddes
            // 
            this.colkieddes.AppearanceCell.Options.UseTextOptions = true;
            this.colkieddes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkieddes.AppearanceHeader.Options.UseTextOptions = true;
            this.colkieddes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkieddes.Caption = "بيان القيد";
            this.colkieddes.FieldName = "kieddes";
            this.colkieddes.Name = "colkieddes";
            this.colkieddes.Visible = true;
            this.colkieddes.VisibleIndex = 8;
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
            this.colAccountDes.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAccountDes.Visible = true;
            this.colAccountDes.VisibleIndex = 5;
            // 
            // colAccNatueName
            // 
            this.colAccNatueName.AppearanceCell.Options.UseTextOptions = true;
            this.colAccNatueName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccNatueName.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccNatueName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccNatueName.Caption = "طبيعة الحساب";
            this.colAccNatueName.FieldName = "AccNatueName";
            this.colAccNatueName.Name = "colAccNatueName";
            this.colAccNatueName.Visible = true;
            this.colAccNatueName.VisibleIndex = 9;
            this.colAccNatueName.Width = 96;
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
            this.colMostandNo.VisibleIndex = 10;
            this.colMostandNo.Width = 84;
            // 
            // colKIEDDAFTRYNO
            // 
            this.colKIEDDAFTRYNO.AppearanceCell.Options.UseTextOptions = true;
            this.colKIEDDAFTRYNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDAFTRYNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colKIEDDAFTRYNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKIEDDAFTRYNO.Caption = "رقم القيد الدفتري";
            this.colKIEDDAFTRYNO.FieldName = "KIEDDAFTRYNO";
            this.colKIEDDAFTRYNO.Name = "colKIEDDAFTRYNO";
            this.colKIEDDAFTRYNO.Visible = true;
            this.colKIEDDAFTRYNO.VisibleIndex = 11;
            this.colKIEDDAFTRYNO.Width = 110;
            // 
            // coltrhel
            // 
            this.coltrhel.AppearanceCell.Options.UseTextOptions = true;
            this.coltrhel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrhel.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrhel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrhel.Caption = "مرحل";
            this.coltrhel.FieldName = "trhel";
            this.coltrhel.Name = "coltrhel";
            this.coltrhel.Visible = true;
            this.coltrhel.VisibleIndex = 12;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditG;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 13;
            this.coldatein.Width = 87;
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Options.UseTextOptions = true;
            this.colUserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "مسئول الادخال";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 14;
            this.colUserName.Width = 99;
            // 
            // Qry01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 462);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Qry01";
            this.Text = "القيود";
            this.Load += new System.EventHandler(this.QryPartnerStaffFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            this.CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditG.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewSells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewSells;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cardViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditG;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANSID;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colKIEDDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colKIEDDESC;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colMadeen;
        private DevExpress.XtraGrid.Columns.GridColumn colDaien;
        private DevExpress.XtraGrid.Columns.GridColumn colkieddes;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountDes;
        private DevExpress.XtraGrid.Columns.GridColumn colAccNatueName;
        private DevExpress.XtraGrid.Columns.GridColumn colMostandNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKIEDDAFTRYNO;
        private DevExpress.XtraGrid.Columns.GridColumn coltrhel;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
    }
}