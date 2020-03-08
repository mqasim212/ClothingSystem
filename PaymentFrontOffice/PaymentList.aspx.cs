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

    //event handler for the Add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["PaymentID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnPayment.aspx");
    }
    //event handler for the Delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 PaymentID;
        //if a record has been selected from the list
        if (lstPayment.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            PaymentID = Convert.ToInt32(lstPayment.SelectedValue);
            //store the data in the session object
            Session["PaymentID"] = PaymentID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 PaymentID;
        //if a record has been selected from the list
        if (lstPayment.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            PaymentID = Convert.ToInt32(lstPayment.SelectedValue);
            //store the data in the session object
            Session["PaymentID"] = PaymentID;
            //redirect to the edit page
            Response.Redirect("AnPayment.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

}
