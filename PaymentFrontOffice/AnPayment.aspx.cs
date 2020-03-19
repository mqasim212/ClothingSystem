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
            
            //if this is not a new record
            if (PaymentID!= -1)
            {
                //dispaky the current data for the record
                DisplayPayments();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (PaymentID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    
        
        //all done so redirect to the main page
        Response.Redirect("PaymentList.aspx");
       
    }
    //function for adding new record
    void Add()
    {
        //create an instance of the payment Book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //validate the data on the web form
        String Error = PaymentBook.ThisPayment.Valid(txtOrderID.Text, txtDate.Text, txtTotalCost.Text);
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
    //function for updating records
    void Update()
    {
        //create an instance of the payment Book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //validate the data on the web form
        String Error = PaymentBook.ThisPayment.Valid(txtOrderID.Text, txtDate.Text, txtTotalCost.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            PaymentBook.ThisPayment.Find(PaymentID);
            //get the data entered by the user
            PaymentBook.ThisPayment.Active = Convert.ToBoolean(chkActive.Checked);
            PaymentBook.ThisPayment.OrderID = txtOrderID.Text;
            PaymentBook.ThisPayment.Date = Convert.ToDateTime(txtDate.Text);
            PaymentBook.ThisPayment.TotalCost = txtTotalCost.Text;
            PaymentBook.ThisPayment.StatusID = Convert.ToBoolean(chkStatusID.Checked);
            //update the record
            PaymentBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("PaymentList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    void DisplayPayments()
    {
        //create an instance of the payment Book
        clsPaymentCollection PaymentBook = new clsPaymentCollection();
        //find the record to update
        PaymentBook.ThisPayment.Find(PaymentID);
        //display the data for this record
        chkActive.Checked = PaymentBook.ThisPayment.Active;
        txtOrderID.Text = PaymentBook.ThisPayment.OrderID;
        txtDate.Text = PaymentBook.ThisPayment.Date.ToString();
        txtTotalCost.Text = PaymentBook.ThisPayment.TotalCost;
        chkStatusID.Checked = PaymentBook.ThisPayment.StatusID;

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect to the main page
        Response.Redirect("PaymentList.aspx");
    }
}