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
    public partial class tblraseedEditDlg : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.tblraseedTableAdapter adp = new Datasource.dsDataTableAdapters.tblraseedTableAdapter();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQ = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.Linq.vtblraseed _row = null;
        
        public tblraseedEditDlg(Datasource.Linq.vtblraseed row = null)
        {
            InitializeComponent();
            LSMSYearID.QueryableSource = dsLinq.CDYeras;
            LSMSAccountId.QueryableSource = dsLinq.vTBL_Accountes;
            if (row != null)
            {
                _row = row;
                
                Datasource.dsData.tblraseedRow data = adp.GetDataByID(_row.AccountId, _row.YearID)[0];
                
                lueAccountId.EditValue = _row.AccountDes;
                lueAccountId.Tag = data.AccountId;
                lueYearID.EditValue = data.YearID;
                tbraseedmadeen.EditValue = data.raseedmadeen;
                tbraseeddaen.EditValue = data.raseeddaen;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate() || lueAccountId.Tag == null)
                return;
            try
            {
                if (_row == null)
                {
                    int effected = adp.Insert(Convert.ToInt32(lueAccountId.Tag), Convert.ToByte(lueYearID.EditValue), Convert.ToDouble(tbraseedmadeen.EditValue), Convert.ToDouble(tbraseeddaen.EditValue)
                        , Convert.ToInt32(MCls.UserInfo.UserID), (DateTime)MCls.adpQ.ServerDatetime());
                    if (effected > 0)
                    {
                        MessageBox.Show("تم الاضافة", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK; Close();
                    }
                }
                else
                {
                    int effected = adp.Update(Convert.ToInt32(lueAccountId.Tag), Convert.ToByte(lueYearID.EditValue)
                        , Convert.ToDouble(tbraseedmadeen.EditValue), Convert.ToDouble(tbraseeddaen.EditValue), Convert.ToInt32(MCls.UserInfo.UserID)
                        , (DateTime)MCls.adpQ.ServerDatetime()
                        , _row.AccountId, _row.YearID);
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