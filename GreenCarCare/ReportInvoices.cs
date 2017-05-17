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
    public partial class ReportInvoices : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        //private CurrencyManager currencyManager;

        public ReportInvoices(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
           
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmVehicle;
            CurrencyManager cmOwner;
            CurrencyManager cmService;
            CurrencyManager cmServiceType;
            CurrencyManager cmEquipment;
            string serviceText = "";
            double serviceTotal = 0;

            
            cmOwner = (CurrencyManager)this.BindingContext[DM.DSGreen, "OWNER"];
            cmService = (CurrencyManager)this.BindingContext[DM.DSGreen, "SERVICE"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.DSGreen, "Servicetype"];
            cmVehicle = (CurrencyManager)this.BindingContext[DM.DSGreen, "Vehicle"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.DSGreen, "Equipment"];
            txtInvoices.Text = "";            
            foreach (DataRow drService in DM.dtService.Rows)
            {
                string visitStatus = drService["Status"].ToString();
                if (visitStatus.Equals("Pending") == true)
                {
                    int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
                    cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
                    DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

                    int anOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
                    cmOwner.Position = DM.ownerView.Find(anOwnerID);
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                    int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
                    cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
                    DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

                    serviceText += "Owner ID: " + drOwner["OwnerID"] + "\r\n"; //serviceText
                    serviceText += drOwner["LastName"].ToString() + ", " + drOwner["FirstName"].ToString() + "\r\n";//serviceText
                    serviceText += drOwner["StreetAddress"] + "\r\n";//serviceText
                    serviceText += drOwner["Suburb"] + "\r\n\r\n";//serviceText
                    serviceText += "Vehicle Number Plate: " + drVehicle["PlateNumber"] + "   Make : " + drVehicle["MAKE"] + "   Model : " + drVehicle["MODEL"] +"\r\n" +//serviceText
                    "Service Type" + drServiceType["Description"] + "Hourly rate :" + drServiceType["HourlyRate"] + " \r\nTotal Hours" + drService["Hours"] +
                    "Service Date: " + drService["ServiceDate"] + "\r\n\r\n\r\n";
                    serviceTotal = (Convert.ToInt32(drServiceType["HourlyRate"].ToString())) * (Convert.ToInt32(drService["Hours"].ToString()));

                    DataRow[] drServiceEquipment = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["SERVICETYPESERVICETYPEEQUIPMENT"]);  /// InvestigatorAssignment
                    txtInvoices.Text += serviceText;
                    if (drServiceEquipment.Length > 0)
                    {                        
                        foreach (DataRow drAllEquipment in drServiceEquipment)
                        {
                            string serviceTypeText = "";
                            int anEquipmentID = Convert.ToInt32(drAllEquipment["EquipmentID"].ToString());

                            cmEquipment.Position = DM.equipmentView.Find(anEquipmentID);
                            DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];

                            serviceTypeText = "\t* Equipment Description:-  " + drEquipment["Description"] + "\r\n";
                            txtInvoices.Text += serviceTypeText;
                        }

                        txtInvoices.Text += "\r\n";                       
                        txtInvoices.Text += "\r\n\r\n";
                    }
                    txtInvoices.Text += "Gross Due: " + Convert.ToString(serviceTotal);
                    txtInvoices.Text += "\r\n========================================================================================================== "; 
                    serviceText = "";
                    serviceTotal = 0;
                }
            }

        }

       
    }
}
