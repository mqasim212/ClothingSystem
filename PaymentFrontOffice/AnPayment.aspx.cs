using PaymentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AnPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment AnPayment = new clsPayment();
        //capture the Order ID
        AnPayment.OrderID = Convert.ToInt32(txtOrderID.Text);
        //capture the date
        AnPayment.Date = Convert.ToDateTime(txtDate.Text);
        //capture the total cost
        AnPayment.TotalCost = Convert.ToInt32(txtTotalCost.Text);
        //capture the status ID
        AnPayment.StatusID = Convert.ToBoolean(chkStatusID.Checked);
        //store the date in the session object
        Session["AnPayment"] = AnPayment;
        //redirect to the viewer page
        Response.Redirect("AnPaymentViewer.aspx");
    }
}