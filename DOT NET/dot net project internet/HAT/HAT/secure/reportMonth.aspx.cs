using System;
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

public partial class reportMonth : System.Web.UI.Page
{
    int recTotal = 0, payTotal = 0, depTotal = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            txtYear.Text = DateTime.Today.Year.ToString();
    }

    /// <summary>
    /// Fires when submit button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void MonthlyReport(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        string strSql = string.Empty;
        string thisYear = txtYear.Text.ToString();
        OleDbConnection conn = new OleDbConnection(connStr);
        conn.Open();
        try
        {
            // receipts total
            strSql = "select month(rdate) as ThisMonth, sum(ramount) as MonthTotal from receipts where year(rdate) = " + thisYear + " group by month(rdate)";
            OleDbDataAdapter dAd = new OleDbDataAdapter(strSql, conn);
            DataSet dSet = new DataSet();
            dAd.Fill(dSet, "monthDataSet");
            GridView1.DataSource = dSet.Tables[0].DefaultView;
            GridView1.DataBind();
            dSet.Dispose();
            dAd.Dispose();

            // payment total
            strSql = "select month(pdate) as ThisMonth, sum(pamount) as MonthTotal from payments where year(pdate) = " + thisYear + " group by month(pdate)";
            dAd = new OleDbDataAdapter(strSql, conn);
            dSet = new DataSet();
            dAd.Fill(dSet, "monthDataSet");
            GridView2.DataSource = dSet.Tables[0].DefaultView;
            GridView2.DataBind();
            dSet.Dispose();
            dAd.Dispose();

        }
        catch (Exception ee)
        {
            lblError.Text = ee.ToString();
        }
        finally
        {
            conn.Close();
            conn.Dispose();
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
        switch (pay)
        {
            case 0:
                recTotal += amt;
                break;
            case 1:
                payTotal += amt;
                break;
            case 3:
                depTotal += amt;
                break;

        }
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
        switch (pay)
        {
            case 0:
                retAmt = recTotal;
                break;
            case 1:
                retAmt = payTotal;
                break;
            case 3:
                retAmt = depTotal;
                break;
        }
        return retAmt.ToString();
    }
}
