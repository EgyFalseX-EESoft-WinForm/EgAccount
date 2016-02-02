using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Controls;

namespace EgAccount.XRep
{
    public partial class XRep01 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep01TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep01TableAdapter();
        public XRep01()
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
        }
        private void LoadDataSource()
        {
            new Datasource.dsReportTableAdapters.CDCompanyTableAdapter().Fill(dsReport.CDCompany);
            xRep01_ATableAdapter.Fill(dsReport.XRep01_A);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramAcc"].Value == DBNull.Value || Parameters["paramStart"].Value == DBNull.Value || Parameters["paramEnd"].Value == DBNull.Value)
                return;
            int accountId = Convert.ToInt32(Parameters["pramAcc"].Value);
            DateTime start = Convert.ToDateTime(Parameters["paramStart"].Value);
            DateTime end = Convert.ToDateTime(Parameters["paramEnd"].Value);
            xlFrom.Text = start.ToShortDateString(); xlTo.Text = end.ToShortDateString();

            object obj = adpRep.GetLastBalance(accountId, start);
            double LastBalance = 0;
            if (obj != null)
                LastBalance = Convert.ToDouble(obj);

            xrlLastBalance.Text = LastBalance.ToString();

            adpRep.Fill(dsReport.XRep01, accountId, start, end);
            foreach (Datasource.dsReport.XRep01Row row in dsReport.XRep01)
            {
                LastBalance += row.Balance;
                row.Balance = LastBalance;
            }
            xrlAccountId.Text = accountId.ToString();
            xrlAccountName.Text = dsReport.XRep01_A.FindByAccountId(accountId).AccountDes;
        }

    }
}
