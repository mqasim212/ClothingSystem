using PaymentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 PaymentID;
    //event hadler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Payment to be deleted from the session object]
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
    }

    void DeletePayment()
    {
        //function to delete the selected record

        //create a new instance of the Payment book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //find the record to delete
        PaymentBook.ThisPayment.Find(PaymentID);
        //delete the record
        PaymentBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeletePayment();
        //redirect back to the main page
        Response.Redirect("PaymentList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentList.aspx");
    }
}