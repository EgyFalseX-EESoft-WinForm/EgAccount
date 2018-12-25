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
    public partial class XRep02a : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep02TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep02TableAdapter();
        public XRep02a(EgAccount.Datasource.Linq.vtbleznsar row)
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
            adpRep.Fill(dsReport.XRep02, row.TRANSID);
            xrleznsarfno.Text = row.eznsarfno.ToString();
            if (dsReport.XRep02.Count > 0)
                lblFromAcc.Text = dsReport.XRep02[0].AccountDes;
            double Dain = 0;
            foreach (Datasource.dsReport.XRep02Row item in dsReport.XRep02)
            {
                Dain += item.Daien;
                if (item.Madeen != 0)
                {
                    item.AccountDes = "من ح/ " + item.AccountDes;
                }
                else
                {
                    item.AccountDes = "الي ح/ " + item.AccountDes;
                }
            }
            xrlTotalDaien.Text = MCls.DecimalToWords(Convert.ToDecimal(Dain));
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
