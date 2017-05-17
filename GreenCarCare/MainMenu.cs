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
    public partial class MainMenu : Form
    {
        private DataModule DM;
        private EquipmentForm frmEquip;            		
        private OwnerForm frmOwner;	 		
        private ServiceEquipmentForm frmServiceEquip;      		
        private ServiceForm frmService;         		
        private ServiceTypeForm frmServiceType;       		
        private VehiclesForm frmVehicle;
        private ReportInvoices frmInvoices;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); 
        }

        private void btnMainEquipment_Click(object sender, EventArgs e)
        {
            if (frmEquip == null)
            {
                frmEquip = new EquipmentForm(DM, this);
            }
            frmEquip.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMainOwner_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmOwner == null)
                {
                    frmOwner = new OwnerForm(DM, this);
                }
                frmOwner.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMainService_Click(object sender, EventArgs e)
        {
            if (frmService == null)
            {
                frmService = new ServiceForm(DM, this);
            }
            frmService.ShowDialog();
        }

        private void btnMainServiceTypes_Click(object sender, EventArgs e)
        {
            if (frmServiceType == null)
            {
                frmServiceType = new ServiceTypeForm(DM, this);
            }
            frmServiceType.ShowDialog();
        }

        private void btnMainVehicles_Click(object sender, EventArgs e)
        {
            if (frmVehicle == null)
            {
                frmVehicle = new VehiclesForm(DM, this);
            }
            frmVehicle.ShowDialog();
        }

        private void btnMainServiceEquip_Click(object sender, EventArgs e)
        {
            if (frmServiceEquip == null)
            {
                frmServiceEquip = new ServiceEquipmentForm(DM, this);
            }
            frmServiceEquip.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoices == null)
            {
                frmInvoices = new ReportInvoices(DM, this);
            }
            frmInvoices.ShowDialog();
        }
    }
}
