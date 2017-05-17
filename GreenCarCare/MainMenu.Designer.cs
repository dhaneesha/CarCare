namespace GreenCarCare
{
    partial class MainMenu
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
            this.btnMainEquipment = new System.Windows.Forms.Button();
            this.btnMainOwner = new System.Windows.Forms.Button();
            this.btnMainService = new System.Windows.Forms.Button();
            this.btnMainServiceTypes = new System.Windows.Forms.Button();
            this.btnMainVehicles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainServiceEquip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainEquipment
            // 
            this.btnMainEquipment.Location = new System.Drawing.Point(20, 157);
            this.btnMainEquipment.Name = "btnMainEquipment";
            this.btnMainEquipment.Size = new System.Drawing.Size(98, 40);
            this.btnMainEquipment.TabIndex = 0;
            this.btnMainEquipment.Text = "Equipment";
            this.btnMainEquipment.UseVisualStyleBackColor = true;
            this.btnMainEquipment.Click += new System.EventHandler(this.btnMainEquipment_Click);
            // 
            // btnMainOwner
            // 
            this.btnMainOwner.Location = new System.Drawing.Point(20, 75);
            this.btnMainOwner.Name = "btnMainOwner";
            this.btnMainOwner.Size = new System.Drawing.Size(98, 40);
            this.btnMainOwner.TabIndex = 1;
            this.btnMainOwner.Text = "Owners";
            this.btnMainOwner.UseVisualStyleBackColor = true;
            this.btnMainOwner.Click += new System.EventHandler(this.btnMainOwner_Click);
            // 
            // btnMainService
            // 
            this.btnMainService.Location = new System.Drawing.Point(20, 239);
            this.btnMainService.Name = "btnMainService";
            this.btnMainService.Size = new System.Drawing.Size(98, 40);
            this.btnMainService.TabIndex = 2;
            this.btnMainService.Text = "Service";
            this.btnMainService.UseVisualStyleBackColor = true;
            this.btnMainService.Click += new System.EventHandler(this.btnMainService_Click);
            // 
            // btnMainServiceTypes
            // 
            this.btnMainServiceTypes.Location = new System.Drawing.Point(20, 116);
            this.btnMainServiceTypes.Name = "btnMainServiceTypes";
            this.btnMainServiceTypes.Size = new System.Drawing.Size(98, 40);
            this.btnMainServiceTypes.TabIndex = 3;
            this.btnMainServiceTypes.Text = "ServiceTypes";
            this.btnMainServiceTypes.UseVisualStyleBackColor = true;
            this.btnMainServiceTypes.Click += new System.EventHandler(this.btnMainServiceTypes_Click);
            // 
            // btnMainVehicles
            // 
            this.btnMainVehicles.Location = new System.Drawing.Point(20, 198);
            this.btnMainVehicles.Name = "btnMainVehicles";
            this.btnMainVehicles.Size = new System.Drawing.Size(98, 40);
            this.btnMainVehicles.TabIndex = 4;
            this.btnMainVehicles.Text = "Vehicles";
            this.btnMainVehicles.UseVisualStyleBackColor = true;
            this.btnMainVehicles.Click += new System.EventHandler(this.btnMainVehicles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnMainServiceEquip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMainServiceTypes);
            this.panel1.Controls.Add(this.btnMainVehicles);
            this.panel1.Controls.Add(this.btnMainEquipment);
            this.panel1.Controls.Add(this.btnMainOwner);
            this.panel1.Controls.Add(this.btnMainService);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 329);
            this.panel1.TabIndex = 5;
            // 
            // btnMainServiceEquip
            // 
            this.btnMainServiceEquip.Location = new System.Drawing.Point(20, 280);
            this.btnMainServiceEquip.Name = "btnMainServiceEquip";
            this.btnMainServiceEquip.Size = new System.Drawing.Size(98, 40);
            this.btnMainServiceEquip.TabIndex = 6;
            this.btnMainServiceEquip.Text = "Equipment Allocation";
            this.btnMainServiceEquip.UseVisualStyleBackColor = true;
            this.btnMainServiceEquip.Click += new System.EventHandler(this.btnMainServiceEquip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maintain";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnInvoices);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(275, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 329);
            this.panel2.TabIndex = 6;
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(63, 183);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(75, 49);
            this.btnInvoices.TabIndex = 8;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(63, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(487, 347);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainEquipment;
        private System.Windows.Forms.Button btnMainOwner;
        private System.Windows.Forms.Button btnMainService;
        private System.Windows.Forms.Button btnMainServiceTypes;
        private System.Windows.Forms.Button btnMainVehicles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainServiceEquip;
        private System.Windows.Forms.Button btnInvoices;
    }
}

