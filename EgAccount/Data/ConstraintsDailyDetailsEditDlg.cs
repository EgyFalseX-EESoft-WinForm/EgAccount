using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EgAccount.Data
{
    public partial class ConstraintsDailyDetailsEditDlg : DevExpress.XtraEditors.XtraForm
    {
        int _id = 0;
        public ConstraintsDailyDetailsEditDlg(int id, bool canEdit)
        {
            InitializeComponent();
            _id = id;
            // TODO: This line of code loads data into the 'dsData.TBLTRAANSDETAILS' table. You can move, or remove it, as needed.
            this.tBLTRAANSDETAILSTableAdapter.FillByTRANSID(this.dsData.TBLTRAANSDETAILS, id);
            if (canEdit)
            {
                lciSave.Enabled = false; btnSave.Visible = false;
                repositoryItemButtonEditDel.Buttons[0].Enabled = false;
                gridViewData.OptionsBehavior.ReadOnly = true;
            }
        }
        private void ConstraintsDailyDetailsEditDlg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsData.TBL_Accountes' table. You can move, or remove it, as needed.
            this.tBL_AccountesTableAdapter.Fill(this.dsData.TBL_Accountes);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewData.FocusedRowHandle == -1)
                return;
            gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
        }
        private void gridViewData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Datasource.dsData.TBLTRAANSDETAILSRow row = (Datasource.dsData.TBLTRAANSDETAILSRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            row.TRANSID = _id;
            row.userin = Convert.ToInt32(MCls.UserInfo.UserID);
            row.datein = (DateTime)MCls.adpQ.ServerDatetime();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            double Daien = 0, Madeen = 0;
            foreach (Datasource.dsData.TBLTRAANSDETAILSRow row in dsData.TBLTRAANSDETAILS)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;
                Daien += row.Daien;
                Madeen += row.Madeen;
                row.userin = Convert.ToInt32(MCls.UserInfo.UserID);
                row.datein = (DateTime)MCls.adpQ.ServerDatetime();
                row.EndEdit();
            }

            if (Daien != Madeen)
            {
                MessageBox.Show("القيد غير متوازن", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tBLTRAANSDETAILSTableAdapter.Update(dsData.TBLTRAANSDETAILS);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

      
    }
}