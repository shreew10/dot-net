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

public partial class paymentList : System.Web.UI.Page
{
    int recTotal = 0, payTotal = 0, depTotal = 0;
    
    public int thisMonth = DateTime.Today.Month;
    public int thisYear = DateTime.Today.Year;
    DateTime thisDateTime = DateTime.Today;

    protected void Page_Load(object sender, EventArgs e)
    {
        DecideCurrentDateTime();

        if (!IsPostBack)
        {
            txtYear.Text = DateTime.Today.Year.ToString();
        }
        
        ModifyDataSourceToFilterData();

        WriteNavigationLink();
    }

    /* Not being used, give textbox as this is easy and more useful in future, if user wants to see 10 years back records.
    /// <summary>
    /// Used to populate the year drop down
    /// </summary>
    private void PopulateYearDropDown()
    {
        int startYear = DateTime.Today.Year - 5;
        int tYear = 0;
        for (int i = 0; i < 10; i++)
        {
            tYear = startYear + i;
            dropYear.Items.Add(new ListItem(tYear.ToString(), tYear.ToString()));
        }
    }
    */
    /// <summary>
    /// Used to write the navigation menu like next, previous, current
    /// </summary>
    private void WriteNavigationLink()
    {
        hyperPrevious.NavigateUrl = "?month=" + thisDateTime.AddMonths(-1).Month + "&year=" + thisDateTime.AddMonths(-1).Year;
        hyperNext.NavigateUrl = "?month=" + thisDateTime.AddMonths(1).Month + "&year=" + thisDateTime.AddMonths(1).Year;
        hyperThis.NavigateUrl = "?month=" + DateTime.Today.Month + "&year=" + DateTime.Today.Year;
    }

    /// <summary>
    /// Decide the current datetime to show the records
    /// </summary>
    private void DecideCurrentDateTime()
    {
        if (IsPostBack)
        {
            Int32.TryParse(dropMonth.SelectedValue.ToString(), out thisMonth);
            Int32.TryParse(txtYear.Text.ToString(), out thisYear);
            // Just redirect again, as this is post back, previous result will remain on the page despite current results will be null
            Response.Redirect("currentstatus.aspx?month=" + thisMonth + "&year=" + thisYear.ToString(), true);
        }
        else
        {
            if (Request["month"] != null && Request["year"] != null)
            {
                Int32.TryParse(Request["month"].ToString(), out thisMonth);
                Int32.TryParse(Request["year"].ToString(), out thisYear);
                thisDateTime = Convert.ToDateTime(thisMonth + "/06/" + thisYear);
            }
        }
        thisMonth = thisDateTime.Month;
        thisYear = thisDateTime.Year;
        // select the current month
        dropMonth.SelectedValue = thisMonth.ToString();

        lblStatusTiming.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(thisMonth) + ", " + thisYear.ToString();
    }

    /// <summary>
    /// Modifiy the datasource to display the desired records
    /// </summary>
    private void ModifyDataSourceToFilterData()
    {
        AccessDataSource1.SelectCommand = "SELECT heads.head,  sum(receipts.ramount) as ramount FROM receipts, heads WHERE receipts.headid = heads.id AND heads.type = 'Receipts' AND month(rdate) = " + thisMonth + " AND year(rdate) = " + thisYear + " group by heads.head";
        AccessDataSource2.SelectCommand = "SELECT heads.head ,  sum(payments.pamount) as pamount FROM payments, heads  where payments.headid = heads.id AND heads.type = 'Expenditure' AND month(pdate) = " + thisMonth + " AND year(pdate) = " + thisYear + " group by heads.head";
        AccessDataSource3.SelectCommand = "SELECT heads.head ,  sum(deposits.ramount) as ramount FROM deposits, heads  where deposits.headid = heads.id AND heads.type = 'Deposits' AND month(rdate) = " + thisMonth + " AND year(rdate) = " + thisYear + " group by heads.head";
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
            case 0 :
                recTotal += amt;
                break;
            case 1 :
                payTotal += amt;
                break;
            case 3 :
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
            case 0 :
                retAmt = recTotal;
                break;
            case 1 :
                retAmt = payTotal;
                break;
            case 3 :
                retAmt = depTotal;
                break;
        }
        return retAmt.ToString();
    }

} // class
