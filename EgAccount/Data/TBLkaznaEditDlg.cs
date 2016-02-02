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
    public partial class TBLkaznaEditDlg : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLkaznaTableAdapter adp = new Datasource.dsDataTableAdapters.TBLkaznaTableAdapter();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQ = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.Linq.vTBLkazna _row = null;
        
        public TBLkaznaEditDlg(Datasource.Linq.vTBLkazna row = null)
        {
            InitializeComponent();
            LSMSkaznatypeid.QueryableSource = dsLinq.CDkaznatypes;
            LSMSAccountId.QueryableSource = dsLinq.vTBL_Accountes;
            if (row != null)
            {
                _row = row;
                
                //Datasource.dsData.tblraseedRow data = adp.GetDataByID(_row.AccountId, _row.YearID)[0];
                
                lueAccountId.EditValue = _row.AccountDes;
                lueAccountId.Tag = _row.acountid;
                luekaznatypeid.EditValue = _row.kaznatypeid;
                tbeznnumber.EditValue = _row.eznnumber;
                deactiondate.EditValue = _row.actiondate;
                tbactionmony.EditValue = _row.actionmony;
                tbmostafeed.EditValue = _row.mostafeed;
                tbbean.EditValue = _row.bean;
                ceclosed.EditValue = _row.closed;
            }
            else
            {
                deactiondate.EditValue = (DateTime)MCls.adpQ.ServerDatetime();
            }
        }
        private void luekaznatypeid_EditValueChanged(object sender, EventArgs e)
        {
            tbeznnumber.EditValue = adp.eznnumberNewId(Convert.ToByte(luekaznatypeid.EditValue));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate() || lueAccountId.Tag == null)
                return;
            if (luekaznatypeid.EditValue.ToString() == "2")
            {
                object obj = adpQ.GetRaseedKhazna();
                if (obj != null && (double)adpQ.GetRaseedKhazna() < Convert.ToDouble(tbactionmony.Value))
                {
                    MessageBox.Show("الرصيد غير كافي", "تحزير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                if (_row == null)
                {
                    int effected = adp.Insert(Convert.ToByte(luekaznatypeid.EditValue), Convert.ToInt32(tbeznnumber.EditValue), deactiondate.DateTime, Convert.ToDouble(tbactionmony.EditValue)
                        , Convert.ToInt32(lueAccountId.Tag), tbmostafeed.EditValue.ToString(), tbbean.EditValue.ToString()
                        , Convert.ToInt32(MCls.UserInfo.UserID), (DateTime)MCls.adpQ.ServerDatetime(), ceclosed.Checked);
                    if (effected > 0)
                    {
                        MessageBox.Show("تم الاضافة", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK; Close();
                    }
                }
                else
                {
                    int effected = adp.Update(Convert.ToByte(luekaznatypeid.EditValue), Convert.ToInt32(tbeznnumber.EditValue), deactiondate.DateTime, Convert.ToDouble(tbactionmony.EditValue)
                        , Convert.ToInt32(lueAccountId.Tag), tbmostafeed.EditValue.ToString(), tbbean.EditValue.ToString()
                        , Convert.ToInt32(MCls.UserInfo.UserID), (DateTime)MCls.adpQ.ServerDatetime(), ceclosed.Checked
                        , _row.kaznatypeid, _row.eznnumber);
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
        private void lueAccountId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AccTypesDlgFrm dlg = new AccTypesDlgFrm();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            lueAccountId.Text = dlg.AccountName;
            lueAccountId.Tag = dlg.AccountID;
        }
        
    }
}