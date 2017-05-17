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
    public partial class ServiceEquipmentForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;

        public ServiceEquipmentForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {

            cmboEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            cmboServiceTypeID.DataBindings.Add("Text", DM.DSGreen, "ServiceType.ServiceTypeID");
            cmboEquipmentID.DataSource = DM.DSGreen;
            cmboServiceTypeID.DataSource = DM.DSGreen;


            cmboServiceTypeID.DisplayMember = "ServiceType.ServiceTypeID";
            cmboServiceTypeID.ValueMember = "ServiceType.ServiceTypeID";

            cmboEquipmentID.DisplayMember = "Equipment.EquipmentID";
            cmboEquipmentID.ValueMember = "Equipment.EquipmentID";

            dataGridAllocatedEquipment.DataSource = DM.DSGreen;
            dataGridAllocatedEquipment.DataMember = "SERVICETYPEEQUIPMENT";

            dataGridServiceType.DataSource = DM.DSGreen;
            dataGridServiceType.DataMember = "SERVICETYPE";

            dataGridEquipment.DataSource = DM.DSGreen;
            dataGridEquipment.DataMember = "Equipment";


            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "ServiceTypeEquipment"];
        }

        private void ServiceEquipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newServicEqRow = DM.dtServiceTypeEquipment.NewRow();

                //If any of the text areas are empty then do not write data and return
                if ((cmboEquipmentID.Text == "") && (cmboServiceTypeID.Text == ""))
                {
                    MessageBox.Show("You must enter both values", "Error");
                }
                else
                {

                    newServicEqRow["ServiceTypeID"] = cmboServiceTypeID.Text;
                    newServicEqRow["EquipmentID"] = cmboEquipmentID.Text;
                    DM.dtServiceTypeEquipment.Rows.Add(newServicEqRow);
                    DM.UpdatedServiceTypeEquipment();
                    MessageBox.Show("Service & Equipment mapped successfully", "Success");
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow deleteServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Rows[currencyManager.Position];

                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteServiceTypeEquipmentRow.Delete();

                    DM.UpdatedServiceTypeEquipment();
                    MessageBox.Show("Record Deleted Succesfully");
                }
                else
                {
                    return;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
