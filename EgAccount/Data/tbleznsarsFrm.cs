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
    public partial class tbleznsarsFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        public tbleznsarsFrm()
        {
            InitializeComponent();
            
            LSMSData.QueryableSource = dsLinq.vtbleznsars;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbleznsarsEditDlg dlg = new tbleznsarsEditDlg();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EgAccount.Datasource.Linq.vtbleznsar row = (EgAccount.Datasource.Linq.vtbleznsar)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            tbleznsarsEditDlg dlg = new tbleznsarsEditDlg(Convert.ToInt32(row.eznsarfno));
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            EgAccount.Datasource.Linq.vtbleznsar row = (EgAccount.Datasource.Linq.vtbleznsar)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            int effected = adp.Delete(Convert.ToInt32(row.TRANSID), Convert.ToInt64(row.CheekAuto));
            if (effected > 0)
            {
                MessageBox.Show("تم الحذف", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LSMSData.Reload();
            }
            else
                MessageBox.Show("لم يتم الحذف", "خظاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EgAccount.Datasource.Linq.vtbleznsar row = (EgAccount.Datasource.Linq.vtbleznsar)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            XRep.XRep02 FrmRep = new XRep.XRep02(row);
            MCls.ShowPrintPreview(FrmRep);
        }
    }
}