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
    public partial class VehiclesForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;                   


        public VehiclesForm(DataModule dm, MainMenu mnu)

        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        private void currencyManager_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)currencyManager.Current;
            int ownerID = Convert.ToInt32(row["OwnerID"].ToString());
            DataRow ownerRow = DM.dtOwner.Rows[DM.ownerView.Find(ownerID)];
            lblFname.Text = ownerRow["FirstName"].ToString();
            lblLName.Text = ownerRow["LastName"].ToString();
        }

        public void BindControls()
        {
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
            currencyManager.CurrentChanged += new EventHandler(currencyManager_CurrentChanged);
            
            txtPlateNumber.DataBindings.Add("Text", DM.DSGreen, "Vehicle.PlateNumber");
            cmboMake.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Make");
            txtModel.DataBindings.Add("Text", DM.DSGreen, "Vehicle.Model");
            cmboOwnerID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.OwnerID");
            cmboOwnerID.DataSource = DM.DSGreen;
            lblVehicleID.DataBindings.Add("Text", DM.DSGreen, "Vehicle.VehicleID");
            cmboOwnerID.DisplayMember = "Owner.OwnerID";
            cmboOwnerID.ValueMember = "Owner.OwnerID";

            lstBoxVehicle.DataSource = DM.DSGreen;
            lstBoxVehicle.DisplayMember = "Vehicle.PlateNumber";
            lstBoxVehicle.ValueMember = "Vehicle.PlateNumber";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
        }

        private void VehiclesForm_Load(object sender, EventArgs e)
        {
            txtModel.Enabled = false;
            txtPlateNumber.Enabled = false;
            cmboMake.Enabled = false;
            cmboOwnerID.Enabled = false;
            btnAddVehicle.Hide();
            btnUpdateVehicle.Hide();
            btnCancel.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblVehicleID.Text = null;

            DataRow newVehicleRow = DM.dtVehicle.NewRow();

            if (txtPlateNumber.Text == "" || cmboMake.Text == "" || txtModel.Text == "" ||
                cmboOwnerID.Text == "")
            {
                MessageBox.Show("You must type in all data", "Error");
            }
            else
            {
                newVehicleRow["Platenumber"] = txtPlateNumber.Text;
                newVehicleRow["Make"] = cmboMake.Text;
                newVehicleRow["Model"] = txtModel.Text;
                newVehicleRow["Make"] = cmboMake.Text;
                newVehicleRow["OwnerID"] = cmboOwnerID.Text;
                DM.dtVehicle.Rows.Add(newVehicleRow);
                DM.UpdatedVehicle();
                MessageBox.Show("Vehicle added successfully", "Success");
            }

            return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];

            if (txtPlateNumber.Text == "" || cmboMake.Text == "" || txtModel.Text == "" ||
                cmboOwnerID.Text == "")
            {
                MessageBox.Show("You must type in all data", "Error");
            }
            else
            {
                updateVehicleRow["Platenumber"] = txtPlateNumber.Text;
                updateVehicleRow["Make"] = cmboMake.Text;
                updateVehicleRow["Model"] = txtModel.Text;
                updateVehicleRow["Make"] = cmboMake.Text;
                updateVehicleRow["OwnerID"] = cmboOwnerID.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdatedVehicle();
                MessageBox.Show("Vehicle Updated successfully", "Success");
            }
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            DataRow[] vehicleService = DM.dtService.Select("VehicleID = " + lblVehicleID.Text);
            if (vehicleService.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVehicleRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Vehicles that are not allocated to Services", "Error");
                return;
            }
            //Update
            DM.UpdatedVehicle();
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


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnAddVehicle.Show();
            btnAddVehicle.Enabled = true;
            lblVehicleNo.Hide();
            lblVehicleID.Hide();
            lblFname.Hide();
            lblLName.Hide();
            lbllast.Hide();
            lblfirst.Hide();

            txtModel.Enabled = true;
            txtPlateNumber.Enabled = true;
            cmboMake.Enabled = true;
            cmboOwnerID.Enabled = true;

            btnUpdateVehicle.Show();
            btnCancel.Show();
            btnAdd.Hide();
            btnUpdate.Hide();
            btnReturn.Hide();
            btnDelete.Enabled = false;
            btnUpdateVehicle.Enabled = false;
            lstBoxVehicle.Enabled = false;
            btnPrevious.Hide();
            btnNext.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            txtModel.Enabled = true;
            txtPlateNumber.Enabled = true;
            cmboMake.Enabled = true;
            cmboOwnerID.Enabled = true;


            btnAddVehicle.Enabled = false;
            btnAddVehicle.Show();
            btnDelete.Enabled = false;
            btnUpdateVehicle.Show();
            btnCancel.Show();
            btnAdd.Hide();
            btnReturn.Hide();
            btnUpdate.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtModel.Enabled = false;
            txtPlateNumber.Enabled = false;
            cmboMake.Enabled = false;
            cmboOwnerID.Enabled = false;

            btnAddVehicle.Hide();
            btnCancel.Hide();
            btnUpdateVehicle.Hide();

            btnDelete.Enabled = true;
            btnUpdateVehicle.Enabled = true;

            label1.Show();
            lblfirst.Show();
            lbllast.Show();
            lblLName.Show();
            lblFname.Show();
            lblVehicleNo.Show();
            lblVehicleID.Show();

            btnAdd.Show();
            btnReturn.Show();

            btnUpdate.Show();
            lstBoxVehicle.Enabled = true; ;
            btnPrevious.Show();
            btnNext.Show();
        }

    }
}
