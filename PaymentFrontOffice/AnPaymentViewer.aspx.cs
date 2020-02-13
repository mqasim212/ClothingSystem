using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaymentClasses;

public partial class AnPaymentViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of the clsPayment
        clsPayment AnPayment = new clsPayment();
        //get the data from the session object
        AnPayment = (clsPayment)Session["AnPayment"];
        //display the date for the Order ID entry
        Response.Write(AnPayment.OrderID);
        //display the date for the Date entry
        Response.Write(AnPayment.Date);
        //display the date for the Total Cost entry
        Response.Write(AnPayment.TotalCost);
        //display the date for the Order Status ID entry
        Response.Write(AnPayment.StatusID);

    }
}