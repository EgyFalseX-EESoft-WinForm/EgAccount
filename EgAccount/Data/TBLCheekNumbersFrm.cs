using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace EgAccount.Data
{
    public partial class TBLCheekNumbersFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        public TBLCheekNumbersFrm()
        {
            InitializeComponent();
            XPSCSData.Session.ConnectionString = Properties.Settings.Default.EGAccountConnectionString;
            LSMSData.QueryableSource = dsLinq.CDBANKs;
        }
        private void ReloadEditGrid()
        {
            XPSCSData.Session.DropChanges();
            XPSCSData.Session.DropIdentityMap();
            XPSCSData.Reload();
            gridViewData.RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EGAccountConnectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLCheekNumbers (BankAcountID, CheekNumber, userin, datein) VALUES (@BankAcountID, @CheekNumber, @userin, GETDATE())", con);
            SqlParameter paramBankAcountID = new SqlParameter("@BankAcountID", SqlDbType.Int) { Value = Convert.ToInt32(LUEBankAcountID.EditValue) };
            SqlParameter paramCheekNumber = new SqlParameter("@CheekNumber", SqlDbType.BigInt);
            SqlParameter paramuserin = new SqlParameter("@userin", SqlDbType.Int) { Value = MCls.UserInfo.UserID };
            cmd.Parameters.AddRange(new SqlParameter[] { paramBankAcountID, paramCheekNumber, paramuserin });
            try
            {
                con.Open();
                for (int i = 0; i < Convert.ToInt32(tbCount.EditValue); i++)
                {
                    paramCheekNumber.Value = Convert.ToInt32(tbStart.EditValue) + i;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("تم الاضافة", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            cmd.Dispose(); con.Dispose();
            ReloadEditGrid();
        }
        private void gridViewData_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)e.Row;
            UOWData.Delete(row);
            //gridViewData.DeleteRow(e.RowHandle);
            UOWData.CommitChanges();
            //MessageBox.Show("Deleted ....");
            ReloadEditGrid();
        }
    }
}