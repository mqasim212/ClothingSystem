using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PaymentClasses;

public partial class PaymentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time first time page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayPaymentDates();
        }
    }

    void DisplayPaymentDates()
    {
        //create an instance of the payment collection class
        clsPaymentCollection Payments = new clsPaymentCollection();
        //set the data source to the list of payment dates in the collection
        lstPayment.DataSource = Payments.PaymentList;
        //set the name of the primary key
        lstPayment.DataValueField = "PaymentID";
        //set the data field to display
        lstPayment.DataTextField = "Date";
        //bind the data to the list
        lstPayment.DataBind();
    }
    
}