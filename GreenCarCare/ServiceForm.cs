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
    public partial class ServiceForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;

        //private CurrencyManager ServiceCurrencyManager;

        public ServiceForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        private void currencyManager_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)currencyManager.Current;
            cmboVehicleID.Text = row["VehicleID"].ToString();
            cmboHours.Text = row["Hours"].ToString();
            cmboServiceType.Text = row["ServiceTypeID"].ToString();
            dtpService.Text = row["ServiceDate"].ToString();
            if (row["Status"].ToString() == "Paid"){rdoPaid.Checked=true;}
            else { rdoNotPaid.Checked = true; }

            int vehicleID = Convert.ToInt32(row["VehicleID"].ToString());
            DataRow vehicleRow = DM.dtVehicle.Rows[DM.vehicleView.Find(vehicleID)];
            lblPlateNumber.Text = vehicleRow["PlateNumber"].ToString();


            int ownerID = Convert.ToInt32(vehicleRow["OwnerID"].ToString());

            DataRow ownerRow = DM.dtOwner.Rows[DM.ownerView.Find(ownerID)];
            lblOwnerName.Text = ownerRow["FirstName"] + " "+ ownerRow["LastName"];

            int serviceTypeID = Convert.ToInt32(row["ServiceTypeID"].ToString());
            DataRow serviceType = DM.dtServiceType.Rows[DM.serviceTypeView.Find(serviceTypeID)];

            lblHourRate.Text = serviceType["HourlyRate"].ToString();
            lblServiceType.Text = serviceType["Description"].ToString();

        }



        public void BindControls()
        {
            try
            {
                dataGridService.DataSource = DM.DSGreen;
                dataGridService.DataMember = "Service";

                currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Service"];
                currencyManager.CurrentChanged += new EventHandler(currencyManager_CurrentChanged);

                cmboServiceType.DataSource = DM.DSGreen;
                cmboServiceType.DisplayMember = "ServiceType.Description";
                cmboServiceType.ValueMember = "ServiceType.ServiceTypeID";

                cmboVehicleID.DataSource = DM.DSGreen;
                cmboVehicleID.DisplayMember = "Vehicle.PlateNumber";
                cmboVehicleID.ValueMember = "Vehicle.VehicleID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newServicerRow = DM.dtService.NewRow();
                dtpService.Value = DateTime.Now;
                //If any of the text areas are empty then do not write data and return
                if (cmboHours.Text == "" || cmboServiceType.SelectedValue == null || cmboVehicleID.SelectedValue == null)
                {
                    MessageBox.Show("You must provide all details", "Error");
                }
                else
                {
                    newServicerRow["VehicleID"] = cmboVehicleID.SelectedValue;
                    newServicerRow["ServiceTypeID"] = cmboServiceType.SelectedValue;
                    newServicerRow["Hours"] = cmboHours.Text;
                    newServicerRow["ServiceDate"] = dtpService.Text;
                    if (rdoNotPaid.Checked)
                    {
                        newServicerRow["Status"] = "Pending";
                    }
                    else
                    {
                        newServicerRow["Status"] = "Paid";
                    }
                    //Add the new row to the Table
                    DM.dtService.Rows.Add(newServicerRow);
                    DM.UpdatedService();
                    //Give the user a success message
                    MessageBox.Show("Service added successfully", "Success");
                }
                return;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            if (rdoPaid.Checked)
            {
                DataRow deleteServiceRow = DM.dtService.Rows[currencyManager.Position];

                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteServiceRow.Delete();
                    MessageBox.Show("Service Deleted Successfuly", "Success");
                }
                else
                {
                    return;
                }

                //Update
                DM.UpdatedService();
            }
            else 
            {
                MessageBox.Show("You may only delete paid services");            
            }
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow updateServiceRow = DM.dtService.Rows[currencyManager.Position];

                if ((!rdoNotPaid.Checked) && (!rdoPaid.Checked))
                {
                    MessageBox.Show("You must select a payment status", "Error");
                }
                else
                {

                    updateServiceRow["Hours"] = cmboHours.Text;
                    updateServiceRow["ServiceDate"] = dtpService.Text;
                    if (rdoNotPaid.Checked)
                    {
                        updateServiceRow["Status"] = "Pending";
                    }
                    else
                    {
                        updateServiceRow["Status"] = "Paid";
                    }
                    //Add the new row to the Table
                    currencyManager.EndCurrentEdit();
                    DM.UpdatedService();
                    //Give the user a success message
                    MessageBox.Show("Service updated successfully", "Success");
                }
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ServiceForm_Load_1(object sender, EventArgs e)
        {
            btnAddService.Hide();
            btnUpdateService.Hide();
            btnCancel.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdateService.Enabled = true;
            lblHourRate.Hide();
            lblOwnerName.Hide();
            lblPlateNumber.Hide();
            lblServDes.Hide();
            lbPlate.Hide();
            lblServDes.Hide();
            lbNme.Hide();
            lblServiceType.Hide();

            cmboVehicleID.Enabled = true;
            cmboServiceType.Enabled = true;
            cmboHours.Enabled = true;
            dtpService.Enabled = true;

            groupBoxPayment.Enabled = true;
            rdoNotPaid.Enabled = true;
            rdoPaid.Enabled = false;

            btnAddService.Show();
            btnUpdateService.Show();
            btnCancel.Show();
            btnAdd.Hide();
            btnUpdate.Hide();
            btnReturn.Hide();
            btnDeleteOwner.Enabled = false;
            btnUpdateService.Enabled = false;
            dataGridService.Enabled = false;
            rdoNotPaid.Checked = true;
            rdoNotPaid.Enabled = true;
            btnPrevious.Hide();
            btnNext.Hide();
            cmboServiceType.Size = new Size(150,24);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rdoNotPaid.Checked)
            {
                cmboHours.Enabled = true;
                cmboServiceType.Enabled = true;
                cmboVehicleID.Enabled = true;
                dtpService.Enabled = true;

                btnAddService.Enabled = false;
                btnAddService.Show();
                btnAddService.Enabled = false;
                dataGridService.Enabled = false;
                btnAddService.Show();
                btnUpdateService.Show();
                btnUpdateService.Enabled = true;
                groupBoxPayment.Enabled = true;
                rdoNotPaid.Enabled = true;
                rdoPaid.Enabled = true;
                btnCancel.Show();
                btnAdd.Hide();
                btnReturn.Hide();
                btnUpdate.Hide();
            }

            else {
                MessageBox.Show("You may only update pending services");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdateService.Enabled = false;
            lblHourRate.Show();
            lblOwnerName.Show();
            lblPlateNumber.Show();
            lblServDes.Show();
            lbPlate.Show();
            lblServDes.Show();
            lbNme.Show();
            lblServiceType.Show();

            cmboVehicleID.Enabled = false;
            cmboServiceType.Enabled = false;
            cmboHours.Enabled = false;
            dtpService.Enabled = false;

            groupBoxPayment.Enabled = false;
            rdoNotPaid.Enabled = false;
            rdoPaid.Enabled = false;

            btnAddService.Hide();
            btnUpdateService.Hide();
            btnCancel.Hide();
            btnAdd.Show();
            btnUpdate.Show();
            btnReturn.Show();
            btnDeleteOwner.Enabled = true;
            btnAddService.Enabled=true;
            btnAdd.Enabled = true;
            btnUpdateService.Enabled = true;
            dataGridService.Enabled = true;
            rdoNotPaid.Checked = false;
            rdoNotPaid.Enabled = false;
            btnPrevious.Hide();
            btnNext.Hide();
            cmboServiceType.Size = new Size(50, 24);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
