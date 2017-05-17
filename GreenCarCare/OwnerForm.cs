using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GreenCarCare
{
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }


    public void BindControls()
    {
        lblOwnerID.DataBindings.Add("Text", DM.DSGreen, "Owner.OwnerID");
        txtLastName.DataBindings.Add("Text", DM.DSGreen, "Owner.LastName");
        txtFirstName.DataBindings.Add("Text", DM.DSGreen, "Owner.FirstName");
        txtAddress.DataBindings.Add("Text", DM.DSGreen, "Owner.StreetAddress");
        txtPhoneNo.DataBindings.Add("Text", DM.DSGreen, "Owner.PhoneNumber");
        txtSuburb.DataBindings.Add("Text", DM.DSGreen, "Owner.Suburb");
        lstOwner.DataSource = DM.DSGreen;
        lstOwner.DisplayMember = "Owner.LastName";
        lstOwner.ValueMember = "Owner.LastName";
        currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
    }

    private void btnPrevious_Click(object sender, EventArgs e)
    {
        if (currencyManager.Position > 0)
        {
            --currencyManager.Position;
        }
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        if (currencyManager.Position < currencyManager.Count - 1)
        {
            ++currencyManager.Position;
        }
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnUpdateOwner_Click(object sender, EventArgs e)
    {
        DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$"))
        {
            MessageBox.Show("Invalid Data inserted for first name");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
        {
            MessageBox.Show("Invalid Data inserted for last name");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtSuburb.Text, @"^[a-zA-Z]+$"))
        {
            MessageBox.Show("Invalid Data inserted for suburb");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text, @"^[0-9]+$"))
        {
            MessageBox.Show("Invalid Data inserted for phone number");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(txtAddress.Text, @"^[a-zA-Z0-9]+$"))
        {
            MessageBox.Show("Invalid Data inserted for address");
            return;
        }
        if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
           (txtPhoneNo.Text == "") || (txtAddress.Text == "") || (txtSuburb.Text == ""))
        {
            MessageBox.Show("You must enter a value for each of the text fields", "Error");

        }
        else
        {
            updateOwnerRow["FirstName"] = txtFirstName.Text;
            updateOwnerRow["LastName"] = txtLastName.Text;
            updateOwnerRow["StreetAddress"] = txtAddress.Text;
            updateOwnerRow["Suburb"] = txtSuburb.Text;
            updateOwnerRow["PhoneNumber"] = txtPhoneNo.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateOwner();
            MessageBox.Show("Owner updated successfully", "Success");
        }
        return;
    }

    private void btnAddOwner_Click(object sender, EventArgs e)
    {

        try
        {

            DataRow newOwnerRow = DM.dtOwner.NewRow();
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid Data inserted for first name");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid Data inserted for last name");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSuburb.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid Data inserted for suburb");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNo.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Invalid Data inserted for phone number");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAddress.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalid Data inserted for address");
                return;
            }
            //If any of the text areas are empty then do not write data and return
            if ((txtLastName.Text == "") || (txtFirstName.Text == "") ||
               (txtPhoneNo.Text == "") || (txtAddress.Text == "") || (txtSuburb.Text == ""))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else
            {
                newOwnerRow["LastName"] = txtLastName.Text;
                newOwnerRow["FirstName"] = txtFirstName.Text;
                newOwnerRow["StreetAddress"] = txtAddress.Text;
                newOwnerRow["Suburb"] = txtSuburb.Text;
                newOwnerRow["PhoneNumber"] = txtPhoneNo.Text;
                //Add the new row to the Table
                DM.dtOwner.Rows.Add(newOwnerRow);
                currencyManager.EndCurrentEdit();
                DM.UpdateOwner();
                //Give the user a success message
                MessageBox.Show("Owner added successfully", "Success");
            }
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);        
        }
    }

    private void btnDeleteOwner_Click(object sender, EventArgs e)
    {

        try
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] dtVehicleRow = DM.dtVehicle.Select("OwnerID = " + lblOwnerID.Text);
            if (dtVehicleRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    MessageBox.Show("Owner Deleted Successfuly", "Error");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Owners that dont have vehicles registered", "Error");
                return;
            }
            //Update
            DM.UpdateOwner();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void OwnerForm_Load(object sender, EventArgs e)
    {
        txtFirstName.Enabled = false;
        txtLastName.Enabled = false;
        txtAddress.Enabled = false;
        txtPhoneNo.Enabled = false;
        txtSuburb.Enabled = false;
        btnAddOwner.Hide();
        btnUpdateOwner.Hide();
        btnCancel.Hide();
    }

    private void clearFields() 
    {
        lblOwnerID.Text = "";
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtAddress.Text = "";
        txtPhoneNo.Text = "";
        txtSuburb.Text = "";
        lblOwnerID.Text = "";    
    }

    private void btnAddNewRecord_Click(object sender, EventArgs e)
    {
        clearFields();
        btnAddOwner.Show();
        btnAddOwner.Enabled=true;
        label1.Hide();
        lblOwnerID.Hide();
        txtFirstName.Enabled = true;
        txtLastName.Enabled = true;
        txtAddress.Enabled = true;
        txtPhoneNo.Enabled = true;
        txtSuburb.Enabled = true;

        btnUpdateOwner.Show();
        btnCancel.Show();
        btnAdd.Hide();
        btnReturn.Hide();
        btnDeleteOwner.Enabled=false;
        btnUpdateOwner.Enabled = false;
        btnUpdate.Hide();
        lstOwner.Hide();
        btnPrevious.Hide();
        btnNext.Hide();
        txtAddress.Text = "MA";
    }

    private void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {        
        txtFirstName.Enabled = false;
        txtLastName.Enabled = false;
        txtAddress.Enabled = false;
        txtPhoneNo.Enabled = false;
        txtSuburb.Enabled = false;

        btnAddOwner.Hide();
        btnAddOwner.Hide();
        btnCancel.Hide();
        btnUpdateOwner.Hide();

        btnDeleteOwner.Enabled = true;
        btnUpdateOwner.Enabled = true;

        label1.Show();
        lblOwnerID.Show();
        btnAdd.Show();
        btnReturn.Show();

        btnUpdate.Show();
        lstOwner.Show();
        btnPrevious.Show();
        btnNext.Show();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        txtFirstName.Enabled = true;
        txtLastName.Enabled = true;
        txtAddress.Enabled = true;
        txtPhoneNo.Enabled = true;
        txtSuburb.Enabled = true;


        btnAddOwner.Enabled=false;
        btnAddOwner.Show();
        btnDeleteOwner.Enabled = false;
        btnUpdateOwner.Show();
        btnCancel.Show();
        btnAdd.Hide();
        btnReturn.Hide();
        btnUpdate.Hide();
    }

    }
}
