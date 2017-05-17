namespace GreenCarCare
{
    partial class ReportInvoices
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
            this.btnShowReport = new System.Windows.Forms.Button();
            this.txtInvoices = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(438, 463);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(75, 23);
            this.btnShowReport.TabIndex = 0;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // txtInvoices
            // 
            this.txtInvoices.Location = new System.Drawing.Point(3, 12);
            this.txtInvoices.Multiline = true;
            this.txtInvoices.Name = "txtInvoices";
            this.txtInvoices.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInvoices.Size = new System.Drawing.Size(669, 445);
            this.txtInvoices.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(589, 463);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // ReportInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 520);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtInvoices);
            this.Controls.Add(this.btnShowReport);
            this.Name = "ReportInvoices";
            this.Text = "ReportInvoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.TextBox txtInvoices;
        private System.Windows.Forms.Button btnReturn;
    }
}