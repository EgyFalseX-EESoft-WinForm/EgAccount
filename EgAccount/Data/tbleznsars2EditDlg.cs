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
    public partial class tbleznsars2EditDlg : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.tbleznsars2TableAdapter adp = new Datasource.dsDataTableAdapters.tbleznsars2TableAdapter();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQ = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.Linq.vtbleznsar _row = null;
        public tbleznsars2EditDlg(Datasource.Linq.vtbleznsar row)
        {
            InitializeComponent();
            //LSMSTRANSID.QueryableSource = from q in dsLinq.vQry001s where q.trhel == true select q;
            //LSMSTBLCheekNumbers.QueryableSource = dsLinq.vQry002s;
            _row = row;

            if (row.tsleem != null)
                cetsleem.EditValue = row.tsleem;
            if (row.mostlem != null)
                tbmostlem.EditValue = row.mostlem;
            if (row.tsleemdate != null)
                detsleemdate.EditValue = row.tsleemdate;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            try
            {
                int effected = adp.Update(cetsleem.Checked, tbmostlem.EditValue.ToString(), detsleemdate.DateTime, Convert.ToInt32(MCls.UserInfo.UserID), (DateTime)MCls.adpQ.ServerDatetime(), _row.TRANSID, _row.CheekAuto);
                if (effected > 0)
                {
                    MessageBox.Show("تم التعديل", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK; Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
    }
}