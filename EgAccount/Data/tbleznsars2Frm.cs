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
    public partial class tbleznsars2Frm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext() { ObjectTrackingEnabled = false };
        public tbleznsars2Frm()
        {
            InitializeComponent();
            
            LSMSData.QueryableSource = from q in dsLinq.vtbleznsars where q.show == true select q;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EgAccount.Datasource.Linq.vtbleznsar row = (EgAccount.Datasource.Linq.vtbleznsar)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            tbleznsars2EditDlg dlg = new tbleznsars2EditDlg(row);
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EgAccount.Datasource.Linq.vtbleznsar row = (EgAccount.Datasource.Linq.vtbleznsar)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            XRep.XRep02 FrmRep = new XRep.XRep02(row);
            MCls.ShowPrintPreview(FrmRep);
        }
    }
}