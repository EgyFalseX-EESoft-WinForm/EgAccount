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
    public partial class XRep04 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.XRep04TableAdapter adpRep = new Datasource.dsReportTableAdapters.XRep04TableAdapter();
        Datasource.dsReportTableAdapters.XRep04_ATableAdapter adpRepA = new Datasource.dsReportTableAdapters.XRep04_ATableAdapter();
        public XRep04()
        {
            InitializeComponent();
            LoadDataSource();
            MCls.SetAllCommandTimeouts(adpRep, 0);
        }
        private void LoadDataSource()
        {
            new Datasource.dsReportTableAdapters.CDCompanyTableAdapter().Fill(dsReport.CDCompany);
            adpRepA.Fill(dsReport.XRep04_A);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramTRANSID"].Value == DBNull.Value)
                return;
            int pramTRANSID = Convert.ToInt32(Parameters["pramTRANSID"].Value);
            adpRep.Fill(dsReport.XRep04, pramTRANSID);

            if (dsReport.XRep04.Count > 0)
            {
                lblTRANSID.Text = dsReport.XRep04[0].TRANSID.ToString();
                lblYearName.Text = dsReport.XRep04[0].YearName;
                lblKIEDDATE.Text = dsReport.XRep04[0].KIEDDATE.ToShortDateString();
                lblDesc.Text = dsReport.XRep04[0].Desc;
            }
            
        }

    }
}
