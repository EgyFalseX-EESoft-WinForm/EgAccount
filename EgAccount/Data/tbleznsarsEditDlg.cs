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
    public partial class tbleznsarsEditDlg : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.tbleznsarsTableAdapter adp = new Datasource.dsDataTableAdapters.tbleznsarsTableAdapter();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQ = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        int? _id = null;
        public tbleznsarsEditDlg(int? id = null)
        {
            InitializeComponent();
            LSMSTRANSID.QueryableSource = from q in dsLinq.vQry001s where q.trhel == true select q;
            LSMSTBLCheekNumbers.QueryableSource = dsLinq.vQry002s;
            if (id == null)
            {
                tbeznsarfno.EditValue = adp.NewId();
                deezndate.EditValue = adpQ.ServerDatetime();
            }
            else
            {
                _id = id;
                Datasource.dsData.tbleznsarsRow row = adp.GetDataByeznsarfno((int)id)[0];
                tbeznsarfno.Enabled = false;

                tbeznsarfno.EditValue = row.eznsarfno;
                lueTRANSID.EditValue = row.TRANSID;
                lueCheekAuto.EditValue = row.CheekAuto;
                tbmostafeed.EditValue = row.mostafeed;
                tbmorfacat.EditValue = row.morfacat;
                deezndate.EditValue = row.ezndate;
                ceshow.EditValue = row.show;
                tbezndes.EditValue = row.ezndes;
            }

            lueTRANSID.EditValueChanged += lueTRANSID_EditValueChanged;
        }
        void lueTRANSID_EditValueChanged(object sender, EventArgs e)
        {
           tbezndes.EditValue = adpQ.Get_KIEDDESC_By_TRANSID(Convert.ToInt32(lueTRANSID.EditValue));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            try
            {
                if (_id == null)
                {
                    int effected = adp.Insert(Convert.ToInt64(tbeznsarfno.EditValue), Convert.ToInt32(lueTRANSID.EditValue), Convert.ToInt32(lueCheekAuto.EditValue), 1, tbmostafeed.EditValue.ToString()
                        , Convert.ToInt32(MCls.UserInfo.UserID), (DateTime)MCls.adpQ.ServerDatetime(), tbezndes.EditValue.ToString(), tbmorfacat.EditValue.ToString(), deezndate.DateTime, ceshow.Checked);
                    if (effected > 0)
                    {
                        MessageBox.Show("تم الاضافة", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK; Close();
                    }
                }
                else
                {
                    int effected = adp.Update(Convert.ToInt64(tbeznsarfno.EditValue), 1, tbmostafeed.EditValue.ToString(), Convert.ToInt32(MCls.UserInfo.UserID), (DateTime)MCls.adpQ.ServerDatetime()
                    , tbezndes.EditValue.ToString(), tbmorfacat.EditValue.ToString(), deezndate.DateTime, ceshow.Checked, Convert.ToInt32(lueTRANSID.EditValue), Convert.ToInt64(lueCheekAuto.EditValue));
                    if (effected > 0)
                    {
                        MessageBox.Show("تم التعديل", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK; Close();
                    }
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