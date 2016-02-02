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
    public partial class tblraseedFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        public tblraseedFrm()
        {
            InitializeComponent();
            
            LSMSData.QueryableSource = dsLinq.vtblraseeds;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblraseedEditDlg dlg = new tblraseedEditDlg();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EgAccount.Datasource.Linq.vtblraseed row = (EgAccount.Datasource.Linq.vtblraseed)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            tblraseedEditDlg dlg = new tblraseedEditDlg(row);
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            EgAccount.Datasource.Linq.vtblraseed row = (EgAccount.Datasource.Linq.vtblraseed)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            int effected = adp.Delete(Convert.ToByte(row.AccountId), Convert.ToByte(row.YearID));
            if (effected > 0)
            {
                MessageBox.Show("تم الحذف", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LSMSData.Reload();
            }
            else
                MessageBox.Show("لم يتم الحذف", "خظاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}