using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class headRecord : System.Web.UI.Page
{
    string what = string.Empty;
    string head = string.Empty;
    int thisMonth = 0, thisYear = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        StoreQueryValues();

        if (!IsPostBack)
        {
            BindRecords(what);
        }
    }

    private void StoreQueryValues()
    {
        what = Request["what"].ToString();
        head = Request["head"].ToString();
        thisMonth = Int32.Parse(Request["month"].ToString());
        thisYear = Int32.Parse(Request["year"].ToString());
    }

    private void BindRecords(string wh)
    {
        switch (wh)
        {
            case "rec" :
                AccessDataSource1.SelectCommand = "SELECT heads.head as Head, rdate as [Date], ramount as Amount, rmode as Mode, rdesc as Descriptions FROM receipts, heads WHERE receipts.headid = heads.id AND heads.head = '" + head + "' AND month(rdate) = " + thisMonth + " AND year(rdate) = " + thisYear + " order by rdate DESC";
                this.Title = "Receipts details";
                break;
            case "pay" :
                AccessDataSource1.SelectCommand = "SELECT heads.head as Head, pdate as [Date], pamount as Amount, pmode as Mode, pdesc as Descriptions FROM payments, heads WHERE payments.headid = heads.id AND heads.head = '" + head + "' AND month(pdate) = " + thisMonth + " AND year(pdate) = " + thisYear + " order by pdate DESC";
                this.Title = "Payments details";
                break;
            case "dep" :
                AccessDataSource1.SelectCommand = "SELECT heads.head as Head, rdate as [Date], ramount as Amount, rmode as Mode, rdesc as Descriptions FROM deposits, heads WHERE deposits.headid = heads.id AND heads.head = '" + head + "' AND month(rdate) = " + thisMonth + " AND year(rdate) = " + thisYear + " order by rdate DESC";
                this.Title = "Deposits details";
                break;
            default :
                AccessDataSource1.SelectCommand = "SELECT heads.head as Head, rdate as [Date], ramount as Amount, rmode as Mode, rdesc as Descriptions FROM receipts, heads WHERE receipts.headid = heads.id AND heads.head = '" + head + "' AND month(rdate) = " + thisMonth + " AND year(rdate) = " + thisYear + " order by rdate DESC";
                break;
        }

        lblTitle.Text = "Details of [" + head.ToUpper() +"] for " + System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(thisMonth).ToUpper() + ", " + thisYear.ToString();

        // AccessDataSource2.SelectCommand = 
        // AccessDataSource3.SelectCommand = "SELECT heads.head ,  sum(deposits.ramount) as ramount FROM deposits, heads  where deposits.headid = heads.id AND heads.type = 'Deposits' AND month(rdate) = " + thisMonth + " AND year(rdate) = " + thisYear + " group by heads.head";
    }
}
