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
    public partial class ServiceTypeForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;

        public ServiceTypeForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

            public void BindControls()
        {
            lblSTypeID.DataBindings.Add("Text", DM.DSGreen, "ServiceType.ServiceTypeID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "ServiceType.Description");
            txtRate.DataBindings.Add("Text", DM.DSGreen, "ServiceType.HourlyRate");
            lstServiceType.DataSource = DM.DSGreen;

            lstServiceType.DisplayMember = "ServiceType.Description";
            lstServiceType.ValueMember = "ServiceType.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceType"];
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

            private void btnAddSType_Click(object sender, EventArgs e)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Invalid Data inserted for rate number");
                    return;
                }
                lblSTypeID.Text = null;
                DataRow newSTypeRow = DM.dtServiceType.NewRow();

                if (txtDescription.Text == "")
                {
                    MessageBox.Show("You must type in a Service Description ", "Error");
                }
                else
                {
                    newSTypeRow["Description"] = txtDescription.Text;
                    newSTypeRow["HourlyRate"] = txtRate.Text;
                    DM.dtServiceType.Rows.Add(newSTypeRow);
                    DM.UpdatedServiceType();
                    MessageBox.Show("Service Type added successfully", "Success");
                }

                return;
            }

            private void btnUpdateSType_Click(object sender, EventArgs e)
            {
                DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Invalid Data inserted for rate number");
                    return;
                }
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("You must type in a Service description", "Error");
                }
                else
                {
                    updateServiceTypeRow["Description"] = txtDescription.Text;
                    updateServiceTypeRow["HourlyRate"] = txtRate.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdatedServiceType();
                    MessageBox.Show("Service Type updated successfully", "Success");
                }
                return;
            }

            private void btnDeleteSType_Click(object sender, EventArgs e)
            {
                try
                {
                    DataRow deleteServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
                    DataRow[] ServiceRow = DM.dtService.Select("ServiceTypeID = " + lblSTypeID.Text);
                    if (ServiceRow.Length == 0)
                    {
                        if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                            MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            deleteServiceTypeRow.Delete();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You may only delete Service Types that are not allocated to Services", "Error");
                        return;
                    }
                    //Update
                    DM.UpdatedServiceType();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void ServiceTypeForm_Load(object sender, EventArgs e)
            {
                txtDescription.Enabled = false;
                txtRate.Enabled = false;

                btnAddSType.Hide();
                btnCancel.Hide();
                btnUpdateSType.Hide();
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                txtDescription.Text = "";
                txtRate.Text = "";


                btnAddSType.Enabled = true;
                btnUpdateSType.Enabled = false;
                btnDeleteSType.Enabled = false;
                txtDescription.Enabled = true;
                txtRate.Enabled = true;

                label1.Hide();
                label3.Hide();
                lblSTypeID.Hide();
                btnAdd.Hide();
                btnReturn.Hide();
                btnUpdate.Hide();
                lstServiceType.Hide();
                btnPrevious.Hide();
                btnNext.Hide();

                btnUpdateSType.Show();
                btnAddSType.Show();
                btnCancel.Show();


            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                txtDescription.Text = "";
                txtRate.Text = "";
                btnAddSType.Enabled = false;
                txtDescription.Enabled = false;
                txtRate.Enabled = false;
                btnUpdateSType.Enabled = true;
                btnDeleteSType.Enabled = true;

                label1.Show();
                label3.Show();
                lblSTypeID.Show();
                btnAdd.Show();
                btnReturn.Show();
                btnUpdate.Show();
                lstServiceType.Show();
                btnPrevious.Show();
                btnNext.Show();

                btnUpdateSType.Hide();
                btnAddSType.Hide();
                btnCancel.Hide();
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                txtRate.Enabled = true;
                txtDescription.Enabled = true;


                btnAddSType.Enabled = false;
                btnAddSType.Show();
                btnDeleteSType.Enabled = false;
                btnUpdateSType.Show();
                btnCancel.Show();
                btnAdd.Hide();
                btnReturn.Hide();
                btnUpdate.Hide();
            }

    }
}
