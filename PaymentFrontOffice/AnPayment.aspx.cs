using PaymentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AnPayment : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 PaymentID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the payment to be processed
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        if (IsPostBack == false)
        {
            //populate the list of dates
            DisplayCounties();
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect to the main page
        Response.Redirect("PaymentList.aspx");
        ////create a new instance of clsPayment
        //clsPayment AnPayment = new clsPayment();
        ////capture the Active
        //AnPayment.Active = Convert.ToBoolean(chkActive.Text);
        ////capture the Order ID
        //AnPayment.OrderID = Convert.ToInt32(txtOrderID.Text);
        ////capture the date
        //AnPayment.Date = Convert.ToDateTime(txtDate.Text);
        ////capture the total cost
        //AnPayment.TotalCost = Convert.ToInt32(txtTotalCost.Text);
        ////capture the status ID
        //AnPayment.StatusID = Convert.ToBoolean(chkStatusID.Checked);
        ////store the date in the session object
        //Session["AnPayment"] = AnPayment;
        ////redirect to the viewer page
        //Response.Redirect("AnPaymentViewer.aspx");
    }
    //function for adding new record
    void Add()
    {
        //create an instance of the payment Book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //validate the data on the web form
        String Error = PaymentBook.ThisPayment.Valid(txtOrderID.Text, txtTotalCost.Text);
        //if the data is ok then add it to the object
        if (Error =="")
        {
            //get the data entered by the user
            PaymentBook.ThisPayment.Active = Convert.ToBoolean(chkActive.Checked);
            PaymentBook.ThisPayment.OrderID = txtOrderID.Text;
            PaymentBook.ThisPayment.Date = Convert.ToDateTime(txtDate.Text);
            PaymentBook.ThisPayment.TotalCost = txtTotalCost.Text;
            PaymentBook.ThisPayment.StatusID = Convert.ToBoolean(chkStatusID.Checked);
            //add the record
            PaymentBook.Add();
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
}