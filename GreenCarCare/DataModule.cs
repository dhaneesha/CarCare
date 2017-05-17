using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GreenCarCare
{
    public partial class DataModule : Form
    {
        public DataTable dtEquipment;
        public DataTable dtOwner;
        public DataTable dtServiceType;
        public DataTable dtService;
        public DataTable dtServiceTypeEquipment;
        public DataTable dtVehicle;

        public DataView vehicleView;
        public DataView serviceTypeView;
        public DataView ownerView;
        public DataView serviceTypeEquipmentView;
        public DataView serviceView;
        public DataView equipmentView;

        public DataModule()
        {
            InitializeComponent();
            DSGreen.EnforceConstraints = false;

            daEquipment.Fill(DSGreen);
            daServiceTypeEquipment.Fill(DSGreen);
            daOwner.Fill(DSGreen);
            daService.Fill(DSGreen);
            daServiceType.Fill(DSGreen);
            daVehicle.Fill(DSGreen);
            dtEquipment = DSGreen.Tables["Equipment"];
            dtService = DSGreen.Tables["Service"];
            dtOwner = DSGreen.Tables["Owner"];
            dtServiceType = DSGreen.Tables["Servicetype"];
            dtServiceTypeEquipment = DSGreen.Tables["ServicetypeEquipment"];
            dtVehicle = DSGreen.Tables["Vehicle"];
            DSGreen.EnforceConstraints = true;

            vehicleView = new DataView(dtVehicle);
            vehicleView.Sort = "VehicleID";

            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";

            equipmentView = new DataView(dtEquipment);
            equipmentView.Sort = "EquipmentID";

            serviceView = new DataView(dtService);

            serviceTypeView = new DataView(dtServiceType);
            serviceTypeView.Sort = "serviceTypeID";

            serviceTypeEquipmentView = new DataView(dtServiceTypeEquipment);

            DSGreen.EnforceConstraints = true;
        }

        public void UpdateEquipment()
        {
            daEquipment.Update(dtEquipment);
        }
        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        } 
        public void UpdatedService()
        {
            daService.Update(dtService);
        }
        public void UpdatedServiceType()
        {
            daServiceType.Update(dtServiceType);
        }

        public void UpdatedVehicle()
        {
            daVehicle.Update(dtVehicle);
        }

        public void UpdatedServiceTypeEquipment()
        {
            daServiceTypeEquipment.Update(dtServiceTypeEquipment);
        } 

        private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CntGreen);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }

        }

        private void daServiceType_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CntGreen);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ServiceTypeID"] = newID;
            }
        }

        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CntGreen);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["OwnerID"] = newID;
            }

        }

    }
}
