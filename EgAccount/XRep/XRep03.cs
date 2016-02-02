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
    public partial class XRep03 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep03TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep03TableAdapter();
        Datasource.dsReportTableAdapters.XRep03_ATableAdapter adpRepA = new Datasource.dsReportTableAdapters.XRep03_ATableAdapter();
        public XRep03()
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
        }
        private void LoadDataSource()
        {
            new Datasource.dsReportTableAdapters.CDCompanyTableAdapter().Fill(dsReport.CDCompany);
            adpRepA.Fill(dsReport.XRep03_A);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramYear"].Value == DBNull.Value)
                return;
            int Year = Convert.ToInt32(Parameters["pramYear"].Value);
            adpRep.Fill(dsReport.XRep03, Year);
            //xrlAccountName.Text = dsReport.XRep01_A.FindByAccountId(Year).AccountDes;
        }

    }
}
