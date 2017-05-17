namespace GreenCarCare
{
    partial class VehiclesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxVehicle = new System.Windows.Forms.ListBox();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmboMake = new System.Windows.Forms.ComboBox();
            this.cmboOwnerID = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblfirst = new System.Windows.Forms.Label();
            this.lbllast = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxVehicle
            // 
            this.lstBoxVehicle.FormattingEnabled = true;
            this.lstBoxVehicle.Location = new System.Drawing.Point(12, 18);
            this.lstBoxVehicle.Name = "lstBoxVehicle";
            this.lstBoxVehicle.Size = new System.Drawing.Size(160, 264);
            this.lstBoxVehicle.TabIndex = 0;
            //this.lstBoxVehicle.SelectedValueChanged += new System.EventHandler(this.lstBoxVehicle_SelectedValueChanged);
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Location = new System.Drawing.Point(189, 9);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(56, 13);
            this.lblVehicleNo.TabIndex = 1;
            this.lblVehicleNo.Text = "Vehicle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(286, 9);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(0, 13);
            this.lblVehicleID.TabIndex = 5;
            //this.lblVehicleID.TextChanged += new System.EventHandler(this.lblVehicleID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "OwnerID";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(280, 85);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(78, 20);
            this.txtPlateNumber.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(280, 148);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(117, 20);
            this.txtModel.TabIndex = 8;
            // 
            // cmboMake
            // 
            this.cmboMake.FormattingEnabled = true;
            this.cmboMake.Items.AddRange(new object[] {
            "Toyota",
            "Nissan",
            "Lexus",
            "Acura",
            "KIA",
            "Renault",
            "Hyhundai",
            "Mitsubishi",
            "Jeep",
            "Ferrari",
            "Land Rower",
            "Range Rower"});
            this.cmboMake.Location = new System.Drawing.Point(280, 116);
            this.cmboMake.Name = "cmboMake";
            this.cmboMake.Size = new System.Drawing.Size(117, 21);
            this.cmboMake.TabIndex = 9;
            // 
            // cmboOwnerID
            // 
            this.cmboOwnerID.FormattingEnabled = true;
            this.cmboOwnerID.Location = new System.Drawing.Point(280, 179);
            this.cmboOwnerID.Name = "cmboOwnerID";
            this.cmboOwnerID.Size = new System.Drawing.Size(45, 21);
            this.cmboOwnerID.TabIndex = 10;
            //this.cmboOwnerID.SelectedIndexChanged += new System.EventHandler(this.cmboOwnerID_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(232, 420);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 37);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicle.Location = new System.Drawing.Point(313, 368);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateVehicle.TabIndex = 23;
            this.btnUpdateVehicle.Text = "Update";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(313, 314);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 37);
            this.btnAddVehicle.TabIndex = 21;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(123, 292);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 30);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(12, 292);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(90, 30);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(151, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(189, 34);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(97, 13);
            this.lblfirst.TabIndex = 25;
            this.lblfirst.Text = "Owner First Name: ";
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Location = new System.Drawing.Point(189, 59);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(97, 13);
            this.lbllast.TabIndex = 26;
            this.lbllast.Text = "Owner First Name: ";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(284, 31);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(23, 13);
            this.lblFname.TabIndex = 27;
            this.lblFname.Text = "last";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(284, 59);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(23, 13);
            this.lblLName.TabIndex = 28;
            this.lblLName.Text = "last";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(313, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(232, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(232, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 469);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lblfirst);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.cmboOwnerID);
            this.Controls.Add(this.cmboMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVehicleNo);
            this.Controls.Add(this.lstBoxVehicle);
            this.Name = "VehiclesForm";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxVehicle;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmboMake;
        private System.Windows.Forms.ComboBox cmboOwnerID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}