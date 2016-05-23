using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace EgAccount
{
    public partial class Qry01 : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        Datasource.Linq.dsLinqDataDataContext dsLinq = new Datasource.Linq.dsLinqDataDataContext();
        #endregion
        #region -   Functions   -
        public Qry01()
        {
            InitializeComponent();
            LSMSData.QueryableSource = from q in dsLinq.vTBLTRAANSDETAILs select q;
        }
        private void LoadGridTbl()
        {
            LSMSData.Reload();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryPartnerStaffFrm_Load(object sender, EventArgs e)
        {
            LoadGridTbl();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridTbl();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.ShowPrintPreview();
        }
        private void cardViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = cardViewSells;
        }
        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewMain;
        }
        #endregion
    }
}