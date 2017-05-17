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
    public partial class EquipmentForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;

        public EquipmentForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            btnAddEquipment.Hide();           
            btnUpdateEquipment.Hide();
            btnCancel.Hide();
        }

        public void BindControls()
        {
            lblEquipmentID.DataBindings.Add("Text", DM.DSGreen, "Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGreen, "Equipment.Description");
            lstEquipment.DataSource = DM.DSGreen;
            lstEquipment.DisplayMember = "Equipment.Description";
            lstEquipment.ValueMember = "Equipment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
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

        private void btnUpdaeEquipment_Click(object sender, EventArgs e)
        {
             DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];

            if (txtDescription.Text == "" )
            {
                MessageBox.Show("You must type in a Equipment description", "Error");
            }
            else
            {
                updateEquipmentRow["Description"] = txtDescription.Text;                
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Equipment updated successfully", "Success");
            }
            return;

        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            lstEquipment.SelectedItem = null;           
            txtDescription.Text="";
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();

            if (txtDescription.Text == "")
            {
                MessageBox.Show("You must type in a Equipment description ", "Error");
            }
            else
            {
                newEquipmentRow["Description"] = txtDescription.Text;
                DM.dtEquipment.Rows.Add(newEquipmentRow);        
                DM.UpdateEquipment();
                MessageBox.Show("Equipment added successfully", "Success");
            }

            return;

        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            DataRow[] ServiceTypeEquipmentRow = DM.dtServiceTypeEquipment.Select("EquipmentID = " + lblEquipmentID.Text);
            if (ServiceTypeEquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Equipment that are not allocated to Services", "Error");
                return;
            }
            //Update
            DM.UpdateEquipment();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAddEquipment.Show();
            btnAddEquipment.Enabled = true;
            lblEquipmentNo.Hide();
            lblEquipmentID.Hide();
            txtDescription.Enabled = true;
            btnUpdateEquipment.Show();

            lblEquipmentID.Text = null;
            lstEquipment.Hide();
            btnCancel.Show();
            btnAdd.Hide();
            btnReturn.Hide();
            btnDeleteEquipment.Enabled = false;
            btnUpdateEquipment.Enabled = false;
            btnUpdate.Hide();
            btnPrevious.Hide();
            btnNext.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtDescription.Enabled = true;


            lblEquipmentNo.Hide();
            btnAddEquipment.Enabled = false;
            btnAddEquipment.Show();
            btnDeleteEquipment.Enabled = false;
            btnUpdateEquipment.Show();
            btnCancel.Show();
            btnAdd.Hide();
            btnReturn.Hide();
            btnUpdate.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;

            btnAddEquipment.Hide();
            btnCancel.Hide();
            btnUpdateEquipment.Hide();

            btnDeleteEquipment.Enabled = true;
            btnUpdateEquipment.Enabled = true;

            lblEquipmentNo.Show();
            lblEquipmentID.Show();
            btnAdd.Show();
            btnReturn.Show();

            btnUpdate.Show();
            lstEquipment.Show();
            btnPrevious.Show();
            btnNext.Show();
        }

    }
}
