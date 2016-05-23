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
    public partial class XRep05 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep05TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep05TableAdapter();
        public XRep05()
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
            //
            
        }
        private void LoadDataSource()
        {
            new Datasource.dsReportTableAdapters.CDCompanyTableAdapter().Fill(dsReport.CDCompany);
        }

        private void XRep05_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            adpRep.Fill(dsReport.XRep05, (DateTime)e.ParametersInformation[0].Parameter.Value, (DateTime)e.ParametersInformation[1].Parameter.Value);
        }
    }
}
