using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Linq;

namespace EgAccount
{
    public partial class ConstraintsDailyFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable YearsTbl = new DataTable("YearsTable");
        DataTable ConsDetials = new DataTable("FalseX");
        DataTable ConsDelDetials = new DataTable("FalseX");
        DataTable ConsTbl = new DataTable("ConsTable");
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQ = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        public ConstraintsDailyFrm()
        {
            InitializeComponent();
            XPSCSData.Session.ConnectionString = Properties.Settings.Default.EGAccountConnectionString;
            LSMSCDYeras.QueryableSource = dsLinq.CDYeras;
            ConsDetials.Columns.Add("Madeen", typeof(int));
            ConsDetials.Columns.Add("Daien", typeof(int));
            ConsDetials.Columns.Add("AccountName");
            ConsDetials.Columns.Add("Accountid");
            ConsDetials.Columns.Add("MostandNo");
            ConsDetials.Columns.Add("kieddes");
            ClearForm();
        }
        private void ClearForm()
        {
            LUEYear.EditValue = null;
            TxtGeneralConstraintNo.EditValue = adpQ.NewKIEDNO();
            TxtGeneralBillNumber.EditValue = TxtGeneralConstraintNo.EditValue;
            DEDate.EditValue = adpQ.ServerDatetime();
            MemoTxtGeneralDes.EditValue = string.Empty;
            CBRelay.Checked = false;

            TxtConsValue.EditValue = 0;
            TxtBillNumber.EditValue = string.Empty;
            MemoTxtDes.EditValue = string.Empty;

            ConsDetials.Rows.Clear();
            GCDetials.DataSource = ConsDetials;
            GroupControlDetials.Enabled = false;
            GroupControlAdding.Enabled = false;
            GCGeneralCons.Enabled = true;

        }
        private void ReloadEditGrid()
        {
            XPSCSData.Session.DropChanges();
            XPSCSData.Session.DropIdentityMap();
            XPSCSData.Reload();
            gridViewEdit.RefreshData();
        }
        private void ConstraintsDailyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsData.TBL_Accountes' table. You can move, or remove it, as needed.
            this.tBL_AccountesTableAdapter.Fill(this.dsData.TBL_Accountes);
            
            LoadDefaultData();
            LoadAllCons();
        }
        private void LoadAllCons()
        {
            ConsTbl = new DataTable("ConsTable");
            ConsTbl = MCls.LoadDataTable("SELECT TRANSID, (Select YearName From CDYeras Where YearID = TBLTRANSACTION.YearID) As YearName, KIEDNO, KIEDDAFTRYNO, KIEDDATE, KIEDDESC FROM TBLTRANSACTION");
            LUEDelCons.Properties.DataSource = ConsTbl;
            LUEDelCons.Properties.DisplayMember = "KIEDNO";
            LUEDelCons.Properties.ValueMember = "TRANSID";
        }
        private void LoadDelConDetail(string TRANSID)
        {
            ConsDelDetials = new DataTable("FalseX");
            ConsDelDetials = MCls.LoadDataTable("SELECT TRANSID, TNO, AccountId, (Select AccountDes From TBL_Accountes Where AccountId = TBLTRAANSDETAILS.AccountId) As AccountDes , Madeen, Daien, MostandNo, kieddes FROM TBLTRAANSDETAILS Where (TRANSID = " + TRANSID + ")");
            GCDelCons.DataSource = ConsDelDetials;
        }
        private void LoadDefaultData()
        {
            YearsTbl = new DataTable("YearsTable");
            YearsTbl = MCls.LoadDataTable("SELECT YearID, YearName FROM CDYeras");
            LUEYear.Properties.DataSource = YearsTbl;
            LUEYear.Properties.DisplayMember = "YearName";
            LUEYear.Properties.ValueMember = "YearID";
            DataTable dtMax = MCls.LoadDataTable("SELECT MAX(YearID) FROM CDYeras");
            if (dtMax.Rows.Count > 0)
                LUEYear.EditValue = dtMax.Rows[0][0];
        }
        private void CalcCons()
        {
            LblMadeen.Text = Convert.ToString(ConsDetials.Compute("Sum(Madeen)", ""));
            LblDa2n.Text = Convert.ToString(ConsDetials.Compute("Sum(Daien)", ""));
            if (LblMadeen.Text.Trim().Length == 0)
            {
                LblMadeen.Text = "0";
            }
            if (LblDa2n.Text.Trim().Length == 0)
            {
                LblDa2n.Text = "0";
            }
            if (Convert.ToInt64(LblMadeen.Text) == Convert.ToInt64(LblDa2n.Text))
            {
                LlState.Text = "القيد متوازن";
                LlState.ForeColor = Color.Green;
                if (LblMadeen.Text != "0" && LblDa2n.Text != "0")
                    BtnSave.Enabled = true;
                else
                    BtnSave.Enabled = false;
            }
            else
            {
                LlState.Text = "القيد غير متوازن";
                LlState.ForeColor = Color.Red;
                BtnSave.Enabled = false;
            }
            //GCDetials.navi
        }
        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if (TxtGeneralConstraintNo.Text.Trim().Length == 0 || LUEYear.ItemIndex == -1)
            {
                MessageBox.Show("يجب ادخال رقم القيد و كود السنه", "معلومات غير كامله", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TxtBillNumber.Text = TxtGeneralBillNumber.Text.Trim();
            MemoTxtDes.Text = MemoTxtGeneralDes.Text.Trim();
            GCGeneralCons.Enabled = false;
            GroupControlAdding.Enabled = true;
            GroupControlDetials.Enabled = true;
        }
        private void BtnLoadAccNames_Click(object sender, EventArgs e)
        {
            AccTypesDlgFrm AccWin = new AccTypesDlgFrm();
            AccWin.ShowDialog(this);
            if(AccWin.AccountName == string.Empty)
            {
                TxtAccName.Text = string.Empty;
                TxtAccName.Tag = string.Empty;
            }
            else
            {
                TxtAccName.Text = AccWin.AccountName;
                TxtAccName.Tag = AccWin.AccountID;
            }
        }
        private void TxtAccName_EditValueChanged(object sender, EventArgs e)
        {
            TxtAccName.Tag = TxtAccName.EditValue;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = ConsDetials.NewRow();
            if (CBEConsTypes.SelectedIndex == 0)
            {
                row["Madeen"] = Convert.ToDecimal(TxtConsValue.Text.Trim());
                row["Daien"] = "0";
            }
            else
            {
                row["Madeen"] = "0";
                row["Daien"] = Convert.ToDecimal(TxtConsValue.Text.Trim());
            }
            row["AccountName"] = TxtAccName.Text.ToString();
            row["Accountid"] = TxtAccName.Tag.ToString();
            row["MostandNo"] = TxtBillNumber.Text.Trim();
            row["kieddes"] = MemoTxtDes.Text.Trim();
            ConsDetials.Rows.Add(row);
            GCDetials.DataSource = ConsDetials;
            CalcCons();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(MCls.SQLConStrStoreAccount);
            SqlTransaction Trn = null;
            SqlCommand Cmd = new SqlCommand("", Con);
            try 
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                string TRANSID = "NULL", YearID = "NULL", KIEDNO = "NULL", KIEDDAFTRYNO = "NULL", KIEDDATE = "NULL", KIEDDESC = "NULL", trhel = "NULL";
                if (ConsDetials.Rows.Count > 0)
                {
                    TRANSID = MCls.GetNewID("TBLTRANSACTION","TRANSID");
                    if (LUEYear.EditValue != DBNull.Value)//كود السنه
                        YearID = LUEYear.EditValue.ToString();
                    if (TxtGeneralConstraintNo.Text.Trim().Length > 0)//رقم القيد
                        KIEDNO = TxtGeneralConstraintNo.Text.Trim();
                    if (TxtGeneralBillNumber.Text.Trim().Length > 0)//الرقم الدفتري
                        KIEDDAFTRYNO = TxtGeneralBillNumber.Text.Trim();
                    if (DEDate.EditValue != null)//التاريخ
                        KIEDDATE = "'" + MCls.ConvertToDateDMY(DEDate.EditValue.ToString()) + "'";
                    if (MemoTxtGeneralDes.Text.Trim().Length > 0)//وصف القيد
                    KIEDDESC = "N'" + MemoTxtGeneralDes.Text.Trim() + "'";
                    if (CBRelay.Checked)//يتم ترحيله
                        trhel = "1";
                    else
                        trhel = "0";
                    Cmd.CommandText = "Set Dateformat dmy INSERT INTO TBLTRANSACTION  (TRANSID, YearID, KIEDNO, KIEDDAFTRYNO, KIEDDATE, KIEDDESC, trhel, datein, userin) VALUES (" + TRANSID + ", " + YearID + ", " + KIEDNO + ", " + KIEDDAFTRYNO + ", " + KIEDDATE + ", " + KIEDDESC + ", " + trhel + ", GETDATE(), " + MCls.UserInfo.UserID + ")";
                    Cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("يجب ادخال قيود قبل الحفظ","بيانات غير كامله",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                int TNO = 0;
                foreach (DataRow row in ConsDetials.Rows)
                {
                    string AccountId = "NULL", Madeen = "NULL", Daien = "NULL", MostandNo = "NULL", kieddes = "NULL";
                    TNO ++;
                    if (row["Madeen"].ToString() != string.Empty)
                        Madeen = row["Madeen"].ToString();
                    if (row["Daien"].ToString() != string.Empty)
                        Daien = row["Daien"].ToString();
                    if ((string)row["Accountid"] != string.Empty)
                        AccountId = row["Accountid"].ToString();
                    if ((string)row["MostandNo"] != string.Empty)
                        MostandNo = "N'" + row["MostandNo"].ToString() + "'";
                    if ((string)row["kieddes"] != string.Empty)
                        kieddes = "N'" + row["kieddes"].ToString() + "'";
                    Cmd.CommandText = "Set Dateformat dmy INSERT INTO TBLTRAANSDETAILS (TRANSID, TNO, AccountId, Madeen, Daien, MostandNo, kieddes, datein, userin) VALUES (" + TRANSID + ", " + TNO + ", " + AccountId + ", " + Madeen + ", " + Daien + ", " + MostandNo + ", " + kieddes + ", GETDATE(), " + MCls.UserInfo.UserID + ")";
                    Cmd.ExecuteNonQuery();
                }
                Trn.Commit();
                MessageBox.Show("تم حفـــظ القيــد", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ClearForm();
                LUEYear.Focus();
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString());
            }
            Con.Close();
        }
        
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            CalcCons();
        }
        private void LUEDelCons_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEDelCons.EditValue != null || LUEDelCons.EditValue.ToString() != string.Empty)
            {
                BtnDelCon.Enabled = true;
                //Load Contains
                LoadDelConDetail(LUEDelCons.EditValue.ToString());
            }
            else
            {
                BtnDelCon.Enabled = false;
                ConsDelDetials = new DataTable("FalseX");
                GCDelCons.DataSource = ConsDelDetials;

            }
        }
        private void BtnDelCon_Click(object sender, EventArgs e)
        {
            SqlTransaction Trn = null;
            SqlConnection Con = new SqlConnection(MCls.SQLConStrStoreAccount);
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                SqlCommand Cmd = new SqlCommand("DELETE FROM TBLTRAANSDETAILS WHERE (TRANSID = " + LUEDelCons.EditValue.ToString() + ")", Con, Trn);
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "DELETE FROM TBLTRANSACTION WHERE (TRANSID = " + LUEDelCons.EditValue.ToString() + ")";
                Cmd.ExecuteNonQuery();
                Trn.Commit();
                LoadAllCons();
                LUEDelCons_EditValueChanged(LUEDelCons, new EventArgs());
                MessageBox.Show("تم حذف القيــــد","تمت العمليه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString());
            }
            Con.Close();
        }

        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewEdit.GetRow(gridViewEdit.FocusedRowHandle);
            bool tarhel = (bool)MCls.adpQ.GetTarhelByTRANSID(Convert.ToInt32(row.GetMemberValue("TRANSID")));
            if (tarhel == true)
            {
                MessageBox.Show("لا يمكن تعديل قيد تم ترحيلة", "لا يمكن التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            row.SetMemberValue("userin", Convert.ToInt32(MCls.UserInfo.UserID));
            row.SetMemberValue("datein", MCls.adpQ.ServerDatetime());
            row.Save();
            UOWData.Save(row);
            UOWData.CommitChanges();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewEdit.GetRow(gridViewEdit.FocusedRowHandle);
            bool tarhel = (bool)MCls.adpQ.GetTarhelByTRANSID(Convert.ToInt32(row.GetMemberValue("TRANSID")));
            if (tarhel == true)
            {
                MessageBox.Show("لا يمكن تعديل قيد تم ترحيلة", "لا يمكن التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            //DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewEdit.GetRow(gridViewEdit.FocusedRowHandle);
            UOWData.Delete(row);
            gridViewEdit.DeleteRow(gridViewEdit.FocusedRowHandle);
            UOWData.CommitChanges();
        }
        private void repositoryItemButtonEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewEdit.GetRow(gridViewEdit.FocusedRowHandle);
            Data.ConstraintsDailyDetailsEditDlg dlg = new Data.ConstraintsDailyDetailsEditDlg(Convert.ToInt32(row.GetMemberValue("TRANSID")), Convert.ToBoolean(row.GetMemberValue("trhel")));
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("تم تعديل تفاصيل القيد", " تم التعديل", MessageBoxButtons.OK,  MessageBoxIcon.Information);
                return;
            }

        }

        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
            {
                ReloadEditGrid();
            }
        }

        
    }
}