using System;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class report : System.Web.UI.Page
{

    int Total = 0;
    string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
    OleDbConnection conn = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        conn = new OleDbConnection(connStr);
        conn.Open();

        if (!IsPostBack)
        {
            txtFrom.Text = DateTime.Today.ToShortDateString();
            txtTo.Text = DateTime.Today.ToShortDateString();
            PopulateDefaultValues();
            
            
        }
    }

    private void PopulateDefaultValues()
    {
        string strSql = "Select head + ' >> ' + type as HeadsAndType, id as HeadId from heads order by type, head";

        OleDbCommand dCmd = new OleDbCommand(strSql, conn);
        OleDbDataReader dReader = dCmd.ExecuteReader();
        
        dropHeads.DataSource = dReader;
        dropHeads.DataBind();
        dropHeads.Items.Insert(0, new ListItem("ALL Heads", ""));
        dCmd.Dispose();
        
    }

    /// <summary>
    /// Fires when Submit button is clicked for Head reports
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ReportsForHead(object sender, EventArgs e)
    {
        
        string strSql = string.Empty;
        string strSqlDep, strSqlRec, strSqlExp = string.Empty;

        string headid = dropHeads.SelectedValue.ToString();

        strSqlDep = "select heads.head as Head, deposits.rdate as [Date], deposits.ramount as [Amount], deposits.rmode as [Mode], deposits.rdesc as [Description]  from deposits, heads WHERE deposits.headid = heads.id AND deposits.rdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by deposits.rdate desc";
        strSqlRec = "select heads.head as Head, receipts.rdate as [Date], receipts.ramount as [Amount], receipts.rmode as [Mode], receipts.rdesc as [Description]  from receipts, heads WHERE receipts.headid = heads.id AND receipts.rdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by receipts.rdate desc";
        strSqlExp = "select heads.head as Head, payments.pdate as [Date], payments.pamount as [Amount], payments.pmode as [Mode], payments.pdesc as [Description]  from payments, heads WHERE payments.headid = heads.id AND payments.pdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by payments.pdate desc";

        if (!dropHeads.SelectedValue.ToString().Equals("")) // if any a/c has been selected
        {
            Regex r = new Regex(">>");
            string[] st = r.Split(dropHeads.SelectedItem.Text);
            string what = st[1].ToString().Trim(); ;
            switch (what)
            {
                case "Deposits":
                    strSql = "select heads.head as Head, deposits.rdate as [Date], deposits.ramount as [Amount], deposits.rmode as [Mode], deposits.rdesc as [Description]  from deposits, heads WHERE deposits.headid = heads.id AND deposits.headid = " + headid + " AND deposits.rdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by deposits.rdate desc";
                    break;
                case "Receipts":
                    strSql = "select heads.head as Head, receipts.rdate as [Date], receipts.ramount as [Amount], receipts.rmode as [Mode], receipts.rdesc as [Description]  from receipts, heads WHERE receipts.headid = heads.id AND receipts.headid = " + headid + " AND receipts.rdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by receipts.rdate desc";
                    break;
                case "Expenditure":
                    strSql = "select heads.head as Head, payments.pdate as [Date], payments.pamount as [Amount], payments.pmode as [Mode], payments.pdesc as [Description]  from payments, heads WHERE payments.headid = heads.id AND payments.headid = " + headid + " AND payments.pdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by payments.pdate desc";
                    break;
                default:
                    strSql = "selectfdasfa heads.head, deposits.* from deposits, heads WHERE deposits.headid = heads.id AND deposits.headid = " + headid + " AND deposits.rdate between #" + txtFrom.Text + "# and #" + txtTo.Text + "# order by deposits.rdate desc";
                    break;
            }

            OleDbDataAdapter dAd = new OleDbDataAdapter(strSql, conn);
            DataSet dSet = new DataSet();
            try
            {
                dAd.Fill(dSet);
                GridView1.DataSource = dSet.Tables[0].DefaultView;
                GridView1.DataBind();
                // Just rebind, so the current records will be displayed (actually just remove all rows if any)

                GridView2.DataBind();

                GridView3.DataBind();
            }
            catch (Exception ee)
            {
                lblError.Text = ee.ToString();
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
            }
        }
        else
        {
            OleDbDataAdapter dAd = new OleDbDataAdapter(strSqlDep, conn);
            DataSet dSet = new DataSet();
            try
            {
                
                // Bind Deposits
                Label1.Text = "Deposits reports";
                dAd.Fill(dSet);
                GridView1.DataSource = dSet.Tables[0].DefaultView;
                GridView1.DataBind();
                dAd.Dispose();
                
                // Bind Receipts
                Total = 0;
                Label2.Text = "Receipts reports";
                dAd = new OleDbDataAdapter(strSqlRec, conn);
                dSet.Clear();
                dAd.Fill(dSet);
                GridView2.DataSource = dSet.Tables[0].DefaultView;
                GridView2.DataBind();
                dAd.Dispose();
                
                // Bind Expenditure
                Total = 0;
                Label3.Text = "Expenditure reports";
                dAd = new OleDbDataAdapter(strSqlExp, conn);
                dSet.Clear();
                dAd.Fill(dSet);
                GridView3.DataSource = dSet.Tables[0].DefaultView;
                GridView3.DataBind();
                dAd.Dispose();
            }
            catch (Exception ee)
            {
                lblError.Text = ee.ToString();
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
            }
        }
        
    }


    /// <summary>
    /// Used to write the amount
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="pay"></param>
    /// <returns></returns>
    protected string WriteAmount(string amount, int pay)
    {
        int amt = Int32.Parse(amount);
        Total += amt;
        return amount.ToString();
    }

    /// <summary>
    /// Used to write the total of the Receipts/Payments
    /// </summary>
    /// <param name="pay"></param>
    /// <returns></returns>
    protected string WriteTotal(int pay)
    {
        int retAmt = 0;
        retAmt = Total;
        return retAmt.ToString();
    }



    protected void Page_UnLoad(object sender, EventArgs e)
    {
        conn.Close();
        conn.Dispose();
    }
}
