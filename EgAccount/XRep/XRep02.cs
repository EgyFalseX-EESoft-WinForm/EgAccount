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
    public partial class XRep02 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep02TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep02TableAdapter();
        public XRep02(EgAccount.Datasource.Linq.vtbleznsar row)
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
            adpRep.Fill(dsReport.XRep02, row.TRANSID);
            xrleznsarfno.Text = row.eznsarfno.ToString();
            double Dain = 0;
            foreach (Datasource.dsReport.XRep02Row item in dsReport.XRep02)
                Dain += item.Daien;
            xrlTotalDaien.Text = Dain.ToString();
            xrlezndes.Text = row.ezndes;
            xrlmostafeed.Text = row.mostafeed;
            xrlTRANSID.Text = row.TRANSID.ToString();
            xrlmorfacat.Text = row.morfacat;
            xrlCheekNumber.Text = row.CheekNumber.ToString();
            if (row.ezndate != null)
                xrlezndate.Text = row.ezndate.Value.ToShortDateString();
        }
        private void LoadDataSource()
        {
            new Datasource.dsReportTableAdapters.CDCompanyTableAdapter().Fill(dsReport.CDCompany);
        }
    }
}
