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
    public partial class XRep06 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep06TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep06TableAdapter();
        public XRep06()
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
        }
        private void LoadDataSource()
        {
            new Datasource.dsReportTableAdapters.CDCompanyTableAdapter().Fill(dsReport.CDCompany);
        }

        private void XRep05_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            adpRep.Fill(dsReport.XRep06, (DateTime)e.ParametersInformation[0].Parameter.Value, (DateTime)e.ParametersInformation[1].Parameter.Value);
        }

    }
}
