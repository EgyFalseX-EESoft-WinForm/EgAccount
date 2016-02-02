
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace EgAccount
{
    public static class DatabaseScripts
    {
        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EGAccountConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                //vTBLMashat
                if (CheckViewExists("vtbleznsars"))
                {
                    cmd.CommandText = DropObject("vtbleznsars");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vtbleznsars;
                cmd.ExecuteNonQuery();
                //vQry001
                if (CheckViewExists("vQry001"))
                {
                    cmd.CommandText = DropObject("vQry001");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry001;
                cmd.ExecuteNonQuery();
                //vTBLCheekNumbers
                if (CheckViewExists("vTBLCheekNumbers"))
                {
                    cmd.CommandText = DropObject("vTBLCheekNumbers");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLCheekNumbers;
                cmd.ExecuteNonQuery();
                //vQry002
                if (CheckViewExists("vQry002"))
                {
                    cmd.CommandText = DropObject("vQry002");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry002;
                cmd.ExecuteNonQuery();
                //vtblraseed
                if (CheckViewExists("vtblraseed"))
                {
                    cmd.CommandText = DropObject("vtblraseed");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vtblraseed;
                cmd.ExecuteNonQuery();
                //vTBL_Accountes
                if (CheckViewExists("vTBL_Accountes"))
                {
                    cmd.CommandText = DropObject("vTBL_Accountes");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBL_Accountes;
                cmd.ExecuteNonQuery();
                //vTBLkazna
                if (CheckViewExists("vTBLkazna"))
                {
                    cmd.CommandText = DropObject("vTBLkazna");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLkazna;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error - " + ex.Number, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EGAccountConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error - " + ex.Number, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }
        public static string vtbleznsars
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vtbleznsars]
                AS
                SELECT        dbo.tbleznsars.eznsarfno, dbo.tbleznsars.TRANSID, dbo.tbleznsars.CheekAuto, dbo.tbleznsars.cheekstateid, dbo.tbleznsars.mostafeed, dbo.tbleznsars.userin, dbo.tbleznsars.datein, dbo.tbleznsars.ezndes, 
                         dbo.TBLCheekNumbers.CheekNumber, dbo.CDBANK.BankName, dbo.CDBANK.BankAcountName, dbo.Users.UserName, dbo.CDYeras.YearName, dbo.TBLTRANSACTION.KIEDDATE, 
                         dbo.TBLTRANSACTION.KIEDDESC, dbo.TBLTRANSACTION.trhel, dbo.tbleznsars.morfacat, dbo.tbleznsars.ezndate, dbo.tbleznsars.show, dbo.tbleznsars.tsleem, dbo.tbleznsars.mostlem, 
                         dbo.tbleznsars.tsleemdate, dbo.tbleznsars.usertasleem, dbo.tbleznsars.dateintasleem, Users_1.UserName AS UserNameTasleem
FROM            dbo.tbleznsars INNER JOIN
                         dbo.TBLTRANSACTION ON dbo.tbleznsars.TRANSID = dbo.TBLTRANSACTION.TRANSID INNER JOIN
                         dbo.TBLCheekNumbers ON dbo.tbleznsars.CheekAuto = dbo.TBLCheekNumbers.CheekAuto INNER JOIN
                         dbo.CDBANK ON dbo.TBLCheekNumbers.BankAcountID = dbo.CDBANK.BankAcountID INNER JOIN
                         dbo.Users ON dbo.tbleznsars.userin = dbo.Users.UserID INNER JOIN
                         dbo.CDYeras ON dbo.TBLTRANSACTION.YearID = dbo.CDYeras.YearID LEFT OUTER JOIN
                         dbo.Users AS Users_1 ON dbo.tbleznsars.usertasleem = Users_1.UserID";
            }
        }
        public static string vQry001
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry001]
                AS
                SELECT        dbo.CDYeras.YearName, dbo.TBLTRANSACTION.KIEDDATE, dbo.TBLTRANSACTION.KIEDDESC, dbo.TBLTRANSACTION.trhel, dbo.TBLTRANSACTION.TRANSID, dbo.TBLTRANSACTION.YearID, 
                         dbo.TBLTRANSACTION.KIEDNO, dbo.TBLTRANSACTION.KIEDDAFTRYNO
FROM            dbo.TBLTRANSACTION INNER JOIN
                         dbo.CDYeras ON dbo.TBLTRANSACTION.YearID = dbo.CDYeras.YearID INNER JOIN
                         dbo.TBLTRAANSDETAILS ON dbo.TBLTRANSACTION.TRANSID = dbo.TBLTRAANSDETAILS.TRANSID INNER JOIN
                         dbo.TBL_Accountes ON dbo.TBLTRAANSDETAILS.AccountId = dbo.TBL_Accountes.AccountId
WHERE        (dbo.TBLTRAANSDETAILS.Daien > 0) AND (dbo.TBL_Accountes.aznsarf = 1)";
            }
        }
        public static string vTBLCheekNumbers
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLCheekNumbers]
                AS
                SELECT        dbo.TBLCheekNumbers.CheekAuto, dbo.TBLCheekNumbers.BankAcountID, dbo.TBLCheekNumbers.CheekNumber, dbo.TBLCheekNumbers.userin, dbo.TBLCheekNumbers.datein, dbo.Users.UserName, 
                         dbo.CDBANK.BankName, dbo.CDBANK.BankAcountName, dbo.CDBANK.BankAcountNO
FROM            dbo.TBLCheekNumbers INNER JOIN
                         dbo.CDBANK ON dbo.TBLCheekNumbers.BankAcountID = dbo.CDBANK.BankAcountID INNER JOIN
                         dbo.Users ON dbo.TBLCheekNumbers.userin = dbo.Users.UserID";
            }
        }
        public static string vQry002
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry002]
                AS
                SELECT        dbo.TBLCheekNumbers.CheekAuto, dbo.TBLCheekNumbers.BankAcountID, dbo.TBLCheekNumbers.CheekNumber, dbo.TBLCheekNumbers.userin, dbo.TBLCheekNumbers.datein, dbo.Users.UserName, 
dbo.CDBANK.BankName, dbo.CDBANK.BankAcountName, dbo.CDBANK.BankAcountNO
FROM            dbo.TBLCheekNumbers INNER JOIN
dbo.CDBANK ON dbo.TBLCheekNumbers.BankAcountID = dbo.CDBANK.BankAcountID INNER JOIN
dbo.Users ON dbo.TBLCheekNumbers.userin = dbo.Users.UserID
WHERE NOT EXISTS(SELECT CheekAuto FROM [dbo].[tbleznsars] WHERE [CheekAuto] = TBLCheekNumbers.CheekAuto)";
            }
        }
        public static string vtblraseed
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vtblraseed]
                AS
                SELECT        dbo.tblraseed.AccountId, dbo.tblraseed.YearID, dbo.tblraseed.raseedmadeen, dbo.tblraseed.raseeddaen, dbo.tblraseed.userin, dbo.tblraseed.datein, dbo.Users.UserName, dbo.CDYeras.YearName, 
                         dbo.TBL_Accountes.AccountDes
                FROM            dbo.tblraseed INNER JOIN
                         dbo.TBL_Accountes ON dbo.tblraseed.AccountId = dbo.TBL_Accountes.AccountId INNER JOIN
                         dbo.CDYeras ON dbo.tblraseed.YearID = dbo.CDYeras.YearID INNER JOIN
                         dbo.Users ON dbo.tblraseed.userin = dbo.Users.UserID";
            }
        }
        public static string vTBL_Accountes
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBL_Accountes]
                AS
                SELECT        dbo.TBL_Accountes.AccountId, dbo.TBL_Accountes.AccountTreeId, dbo.TBL_Accountes.PairantAccount, dbo.TBL_Accountes.AccountDes, dbo.TBL_Accountes.AccountSort, dbo.TBL_Accountes.KhtamiaccID, 
                         dbo.TBL_Accountes.AccNatueID, dbo.TBL_Accountes.AccountBudget, dbo.TBL_Accountes.CuurentMadeen, dbo.TBL_Accountes.CuurentDaien, dbo.TBL_Accountes.aznsarf, 
                         dbo.CDKHTAMIACOUNT.KhtamiaccName, dbo.CDAccountNature.AccNatueName
FROM            dbo.TBL_Accountes INNER JOIN
                         dbo.CDAccountNature ON dbo.TBL_Accountes.AccNatueID = dbo.CDAccountNature.AccNatueID INNER JOIN
                         dbo.CDKHTAMIACOUNT ON dbo.TBL_Accountes.KhtamiaccID = dbo.CDKHTAMIACOUNT.KhtamiaccID";
            }
        }
        public static string vTBLkazna
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vTBLkazna]
                AS
                SELECT        dbo.TBLkazna.actionid, dbo.TBLkazna.kaznatypeid, dbo.TBLkazna.eznnumber, dbo.TBLkazna.actiondate, dbo.TBLkazna.actionmony, dbo.TBLkazna.acountid, dbo.TBLkazna.mostafeed, dbo.TBLkazna.bean, 
                         dbo.TBLkazna.userin, dbo.TBLkazna.datein, dbo.TBLkazna.closed, dbo.CDkaznatype.kaznatype, dbo.TBL_Accountes.AccountDes, dbo.Users.UserName
FROM            dbo.TBLkazna INNER JOIN
                         dbo.CDkaznatype ON dbo.TBLkazna.kaznatypeid = dbo.CDkaznatype.kaznatypeid INNER JOIN
                         dbo.Users ON dbo.TBLkazna.userin = dbo.Users.UserID INNER JOIN
                         dbo.TBL_Accountes ON dbo.TBLkazna.acountid = dbo.TBL_Accountes.AccountId";
            }
        }

    }
}
