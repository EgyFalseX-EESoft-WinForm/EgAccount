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
    public partial class TBLkaznaFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        Datasource.dsDataTableAdapters.TBLkaznaTableAdapter adp = new Datasource.dsDataTableAdapters.TBLkaznaTableAdapter();
        public TBLkaznaFrm()
        {
            InitializeComponent();
            
            LSMSData.QueryableSource = dsLinq.vTBLkaznas;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLkaznaEditDlg dlg = new TBLkaznaEditDlg();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EgAccount.Datasource.Linq.vTBLkazna row = (EgAccount.Datasource.Linq.vTBLkazna)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLkaznaEditDlg dlg = new TBLkaznaEditDlg(row);
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            EgAccount.Datasource.Linq.vTBLkazna row = (EgAccount.Datasource.Linq.vTBLkazna)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            int effected = adp.Delete(row.kaznatypeid, row.eznnumber);
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