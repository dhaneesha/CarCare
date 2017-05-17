namespace GreenCarCare
{
    partial class ServiceForm
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
            this.components = new System.ComponentModel.Container();
            this.rdoPaid = new System.Windows.Forms.RadioButton();
            this.dtpService = new System.Windows.Forms.DateTimePicker();
            this.rdoNotPaid = new System.Windows.Forms.RadioButton();
            this.cmboServiceType = new System.Windows.Forms.ComboBox();
            this.cmboHours = new System.Windows.Forms.ComboBox();
            this.cmboVehicleID = new System.Windows.Forms.ComboBox();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.greenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.greenDataSet = new GreenCarCare.GreenDataSet();
            this.sERVICETableAdapter = new GreenCarCare.GreenDataSetTableAdapters.SERVICETableAdapter();
            this.lbPlate = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lbNme = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblServDes = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblHourRate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoPaid
            // 
            this.rdoPaid.AutoSize = true;
            this.rdoPaid.Location = new System.Drawing.Point(6, 19);
            this.rdoPaid.Name = "rdoPaid";
            this.rdoPaid.Size = new System.Drawing.Size(46, 17);
            this.rdoPaid.TabIndex = 1;
            this.rdoPaid.Text = "Paid";
            this.rdoPaid.UseVisualStyleBackColor = true;
            // 
            // dtpService
            // 
            this.dtpService.Enabled = false;
            this.dtpService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpService.Location = new System.Drawing.Point(445, 213);
            this.dtpService.Name = "dtpService";
            this.dtpService.Size = new System.Drawing.Size(186, 22);
            this.dtpService.TabIndex = 2;
            // 
            // rdoNotPaid
            // 
            this.rdoNotPaid.AutoSize = true;
            this.rdoNotPaid.Location = new System.Drawing.Point(6, 42);
            this.rdoNotPaid.Name = "rdoNotPaid";
            this.rdoNotPaid.Size = new System.Drawing.Size(67, 17);
            this.rdoNotPaid.TabIndex = 3;
            this.rdoNotPaid.Text = "Pending ";
            this.rdoNotPaid.UseVisualStyleBackColor = true;
            // 
            // cmboServiceType
            // 
            this.cmboServiceType.Enabled = false;
            this.cmboServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboServiceType.FormattingEnabled = true;
            this.cmboServiceType.Location = new System.Drawing.Point(533, 72);
            this.cmboServiceType.Name = "cmboServiceType";
            this.cmboServiceType.Size = new System.Drawing.Size(54, 24);
            this.cmboServiceType.TabIndex = 4;
            // 
            // cmboHours
            // 
            this.cmboHours.Enabled = false;
            this.cmboHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboHours.FormattingEnabled = true;
            this.cmboHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmboHours.Location = new System.Drawing.Point(548, 106);
            this.cmboHours.Name = "cmboHours";
            this.cmboHours.Size = new System.Drawing.Size(39, 24);
            this.cmboHours.TabIndex = 5;
            // 
            // cmboVehicleID
            // 
            this.cmboVehicleID.Enabled = false;
            this.cmboVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboVehicleID.FormattingEnabled = true;
            this.cmboVehicleID.Location = new System.Drawing.Point(518, 12);
            this.cmboVehicleID.Name = "cmboVehicleID";
            this.cmboVehicleID.Size = new System.Drawing.Size(69, 24);
            this.cmboVehicleID.TabIndex = 6;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.rdoPaid);
            this.groupBoxPayment.Controls.Add(this.rdoNotPaid);
            this.groupBoxPayment.Enabled = false;
            this.groupBoxPayment.Location = new System.Drawing.Point(471, 133);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(116, 67);
            this.groupBoxPayment.TabIndex = 7;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment Status";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(581, 347);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 37);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOwner.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteOwner.Location = new System.Drawing.Point(491, 299);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteOwner.TabIndex = 22;
            this.btnDeleteOwner.Text = "Delete";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.Location = new System.Drawing.Point(686, 299);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateService.TabIndex = 23;
            this.btnUpdateService.Text = "Update";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(686, 251);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 37);
            this.btnAddService.TabIndex = 21;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(123, 312);
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
            this.btnPrevious.Location = new System.Drawing.Point(12, 312);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(90, 30);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "<";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vehicle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Service Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hours";
            // 
            // dataGridService
            // 
            this.dataGridService.AutoGenerateColumns = false;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.serviceTypeIDDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.serviceDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridService.DataSource = this.sERVICEBindingSource;
            this.dataGridService.Location = new System.Drawing.Point(12, 18);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.Size = new System.Drawing.Size(416, 251);
            this.dataGridService.TabIndex = 29;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // serviceTypeIDDataGridViewTextBoxColumn
            // 
            this.serviceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.HeaderText = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.Name = "serviceTypeIDDataGridViewTextBoxColumn";
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            // 
            // serviceDateDataGridViewTextBoxColumn
            // 
            this.serviceDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDate";
            this.serviceDateDataGridViewTextBoxColumn.HeaderText = "ServiceDate";
            this.serviceDateDataGridViewTextBoxColumn.Name = "serviceDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // sERVICEBindingSource
            // 
            this.sERVICEBindingSource.DataMember = "SERVICE";
            this.sERVICEBindingSource.DataSource = this.greenDataSetBindingSource;
            // 
            // greenDataSetBindingSource
            // 
            this.greenDataSetBindingSource.DataSource = this.greenDataSet;
            this.greenDataSetBindingSource.Position = 0;
            // 
            // greenDataSet
            // 
            this.greenDataSet.DataSetName = "GreenDataSet";
            this.greenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICETableAdapter
            // 
            this.sERVICETableAdapter.ClearBeforeFill = true;
            // 
            // lbPlate
            // 
            this.lbPlate.AutoSize = true;
            this.lbPlate.Enabled = false;
            this.lbPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlate.Location = new System.Drawing.Point(600, 15);
            this.lbPlate.Name = "lbPlate";
            this.lbPlate.Size = new System.Drawing.Size(63, 16);
            this.lbPlate.TabIndex = 30;
            this.lbPlate.Text = "Plate No:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Enabled = false;
            this.lblPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.Location = new System.Drawing.Point(671, 15);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(45, 16);
            this.lblPlateNumber.TabIndex = 31;
            this.lblPlateNumber.Text = "label5";
            // 
            // lbNme
            // 
            this.lbNme.AutoSize = true;
            this.lbNme.Enabled = false;
            this.lbNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNme.Location = new System.Drawing.Point(434, 47);
            this.lbNme.Name = "lbNme";
            this.lbNme.Size = new System.Drawing.Size(89, 16);
            this.lbNme.TabIndex = 33;
            this.lbNme.Text = "Owner Name:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Enabled = false;
            this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.Location = new System.Drawing.Point(523, 47);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(45, 16);
            this.lblOwnerName.TabIndex = 32;
            this.lblOwnerName.Text = "Name";
            // 
            // lblServDes
            // 
            this.lblServDes.Enabled = false;
            this.lblServDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServDes.Location = new System.Drawing.Point(602, 39);
            this.lblServDes.Name = "lblServDes";
            this.lblServDes.Size = new System.Drawing.Size(63, 39);
            this.lblServDes.TabIndex = 35;
            this.lblServDes.Text = "Service Description";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.BackColor = System.Drawing.Color.White;
            this.lblServiceType.Enabled = false;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(671, 48);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(99, 16);
            this.lblServiceType.TabIndex = 36;
            this.lblServiceType.Text = "Service Details";
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Enabled = false;
            this.lblHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHR.Location = new System.Drawing.Point(600, 114);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(79, 16);
            this.lblHR.TabIndex = 37;
            this.lblHR.Text = "Hourly Rate";
            // 
            // lblHourRate
            // 
            this.lblHourRate.AutoSize = true;
            this.lblHourRate.BackColor = System.Drawing.Color.White;
            this.lblHourRate.Enabled = false;
            this.lblHourRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourRate.Location = new System.Drawing.Point(686, 115);
            this.lblHourRate.Name = "lblHourRate";
            this.lblHourRate.Size = new System.Drawing.Size(37, 16);
            this.lblHourRate.TabIndex = 38;
            this.lblHourRate.Text = "Rate";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(686, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(581, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(581, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHourRate);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblServDes);
            this.Controls.Add(this.lbNme);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lbPlate);
            this.Controls.Add(this.dataGridService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.cmboVehicleID);
            this.Controls.Add(this.cmboHours);
            this.Controls.Add(this.cmboServiceType);
            this.Controls.Add(this.dtpService);
            this.Name = "ServiceForm";
            this.Text = "Service Maintenance Form";
            this.Load += new System.EventHandler(this.ServiceForm_Load_1);
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoPaid;
        private System.Windows.Forms.DateTimePicker dtpService;
        private System.Windows.Forms.RadioButton rdoNotPaid;
        private System.Windows.Forms.ComboBox cmboServiceType;
        private System.Windows.Forms.ComboBox cmboHours;
        private System.Windows.Forms.ComboBox cmboVehicleID;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.BindingSource greenDataSetBindingSource;
        private GreenDataSet greenDataSet;
        private System.Windows.Forms.BindingSource sERVICEBindingSource;
        private GreenDataSetTableAdapters.SERVICETableAdapter sERVICETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbPlate;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lbNme;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblServDes;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblHourRate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}