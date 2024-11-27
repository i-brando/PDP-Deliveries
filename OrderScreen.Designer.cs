namespace PDP_Deliveries
{
    partial class OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCustDetails = new System.Windows.Forms.GroupBox();
            this.txtRetrunAdd = new System.Windows.Forms.TextBox();
            this.lblReturnAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbPackageDetails = new System.Windows.Forms.GroupBox();
            this.cmbTracking = new System.Windows.Forms.ComboBox();
            this.lblTracking = new System.Windows.Forms.Label();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.cmbParcelVol = new System.Windows.Forms.ComboBox();
            this.cmbShipTime = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblParcelVol = new System.Windows.Forms.Label();
            this.lblShippingTime = new System.Windows.Forms.Label();
            this.lblNumPkg = new System.Windows.Forms.Label();
            this.txtNumOfPackages = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gbDeliveryFees = new System.Windows.Forms.GroupBox();
            this.btnClac = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblInsuranceQ = new System.Windows.Forms.Label();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.gbCustDetails.SuspendLayout();
            this.gbPackageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.gbDeliveryFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(727, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbCustDetails
            // 
            this.gbCustDetails.Controls.Add(this.txtRetrunAdd);
            this.gbCustDetails.Controls.Add(this.lblReturnAddress);
            this.gbCustDetails.Controls.Add(this.txtAddress);
            this.gbCustDetails.Controls.Add(this.lblAddress);
            this.gbCustDetails.Controls.Add(this.txtLastName);
            this.gbCustDetails.Controls.Add(this.lblLastName);
            this.gbCustDetails.Controls.Add(this.lblFirstName);
            this.gbCustDetails.Controls.Add(this.txtFirstName);
            this.gbCustDetails.Location = new System.Drawing.Point(12, 12);
            this.gbCustDetails.Name = "gbCustDetails";
            this.gbCustDetails.Size = new System.Drawing.Size(246, 140);
            this.gbCustDetails.TabIndex = 5;
            this.gbCustDetails.TabStop = false;
            this.gbCustDetails.Text = "Your Details";
            this.gbCustDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRetrunAdd
            // 
            this.txtRetrunAdd.Location = new System.Drawing.Point(98, 105);
            this.txtRetrunAdd.Name = "txtRetrunAdd";
            this.txtRetrunAdd.Size = new System.Drawing.Size(142, 20);
            this.txtRetrunAdd.TabIndex = 7;
            // 
            // lblReturnAddress
            // 
            this.lblReturnAddress.AutoSize = true;
            this.lblReturnAddress.Location = new System.Drawing.Point(6, 108);
            this.lblReturnAddress.Name = "lblReturnAddress";
            this.lblReturnAddress.Size = new System.Drawing.Size(80, 13);
            this.lblReturnAddress.TabIndex = 6;
            this.lblReturnAddress.Text = "Retrun Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(98, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(142, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 82);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // gbPackageDetails
            // 
            this.gbPackageDetails.Controls.Add(this.cmbTracking);
            this.gbPackageDetails.Controls.Add(this.lblTracking);
            this.gbPackageDetails.Controls.Add(this.cmbWeight);
            this.gbPackageDetails.Controls.Add(this.cmbParcelVol);
            this.gbPackageDetails.Controls.Add(this.cmbShipTime);
            this.gbPackageDetails.Controls.Add(this.lblWeight);
            this.gbPackageDetails.Controls.Add(this.lblParcelVol);
            this.gbPackageDetails.Controls.Add(this.lblShippingTime);
            this.gbPackageDetails.Controls.Add(this.lblNumPkg);
            this.gbPackageDetails.Controls.Add(this.txtNumOfPackages);
            this.gbPackageDetails.Location = new System.Drawing.Point(12, 158);
            this.gbPackageDetails.Name = "gbPackageDetails";
            this.gbPackageDetails.Size = new System.Drawing.Size(246, 165);
            this.gbPackageDetails.TabIndex = 8;
            this.gbPackageDetails.TabStop = false;
            this.gbPackageDetails.Text = "Package Details";
            // 
            // cmbTracking
            // 
            this.cmbTracking.FormattingEnabled = true;
            this.cmbTracking.Items.AddRange(new object[] {
            "Regular Tracking",
            "Recorded Tracking",
            "Tracked Tracking"});
            this.cmbTracking.Location = new System.Drawing.Point(98, 132);
            this.cmbTracking.Name = "cmbTracking";
            this.cmbTracking.Size = new System.Drawing.Size(142, 21);
            this.cmbTracking.TabIndex = 12;
            this.cmbTracking.SelectedIndexChanged += new System.EventHandler(this.cmbTracking_SelectedIndexChanged);
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Location = new System.Drawing.Point(6, 135);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(49, 13);
            this.lblTracking.TabIndex = 11;
            this.lblTracking.Text = "Tracking";
            // 
            // cmbWeight
            // 
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Items.AddRange(new object[] {
            "0-99",
            "100-199",
            "200-299",
            "300-399",
            "400-699",
            "700+"});
            this.cmbWeight.Location = new System.Drawing.Point(98, 55);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(142, 21);
            this.cmbWeight.TabIndex = 10;
            this.cmbWeight.SelectedIndexChanged += new System.EventHandler(this.cmbWeight_SelectedIndexChanged);
            // 
            // cmbParcelVol
            // 
            this.cmbParcelVol.FormattingEnabled = true;
            this.cmbParcelVol.Items.AddRange(new object[] {
            "Less than 30cm³",
            "Greater than 30cm³"});
            this.cmbParcelVol.Location = new System.Drawing.Point(98, 79);
            this.cmbParcelVol.Name = "cmbParcelVol";
            this.cmbParcelVol.Size = new System.Drawing.Size(142, 21);
            this.cmbParcelVol.TabIndex = 9;
            // 
            // cmbShipTime
            // 
            this.cmbShipTime.FormattingEnabled = true;
            this.cmbShipTime.Items.AddRange(new object[] {
            "24 Hours Shipping",
            "48 Hours Shipping"});
            this.cmbShipTime.Location = new System.Drawing.Point(98, 106);
            this.cmbShipTime.Name = "cmbShipTime";
            this.cmbShipTime.Size = new System.Drawing.Size(142, 21);
            this.cmbShipTime.TabIndex = 8;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 58);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Weight";
            // 
            // lblParcelVol
            // 
            this.lblParcelVol.AutoSize = true;
            this.lblParcelVol.Location = new System.Drawing.Point(6, 82);
            this.lblParcelVol.Name = "lblParcelVol";
            this.lblParcelVol.Size = new System.Drawing.Size(75, 13);
            this.lblParcelVol.TabIndex = 4;
            this.lblParcelVol.Text = "Parcel Volume";
            // 
            // lblShippingTime
            // 
            this.lblShippingTime.AutoSize = true;
            this.lblShippingTime.Location = new System.Drawing.Point(6, 109);
            this.lblShippingTime.Name = "lblShippingTime";
            this.lblShippingTime.Size = new System.Drawing.Size(74, 13);
            this.lblShippingTime.TabIndex = 2;
            this.lblShippingTime.Text = "Shipping Time";
            // 
            // lblNumPkg
            // 
            this.lblNumPkg.AutoSize = true;
            this.lblNumPkg.Location = new System.Drawing.Point(6, 32);
            this.lblNumPkg.Name = "lblNumPkg";
            this.lblNumPkg.Size = new System.Drawing.Size(89, 13);
            this.lblNumPkg.TabIndex = 1;
            this.lblNumPkg.Text = "No. Of Packages";
            // 
            // txtNumOfPackages
            // 
            this.txtNumOfPackages.Location = new System.Drawing.Point(98, 29);
            this.txtNumOfPackages.Name = "txtNumOfPackages";
            this.txtNumOfPackages.Size = new System.Drawing.Size(142, 20);
            this.txtNumOfPackages.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::PDP_Deliveries.Properties.Resources.PDP_Logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(650, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(138, 75);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // gbDeliveryFees
            // 
            this.gbDeliveryFees.Controls.Add(this.chkInsurance);
            this.gbDeliveryFees.Controls.Add(this.lblInsuranceQ);
            this.gbDeliveryFees.Controls.Add(this.btnClac);
            this.gbDeliveryFees.Controls.Add(this.txtTotal);
            this.gbDeliveryFees.Controls.Add(this.txtTax);
            this.gbDeliveryFees.Controls.Add(this.btnDiscount);
            this.gbDeliveryFees.Controls.Add(this.lblTotal);
            this.gbDeliveryFees.Controls.Add(this.lblTax);
            this.gbDeliveryFees.Controls.Add(this.lblDiscountCode);
            this.gbDeliveryFees.Controls.Add(this.txtDiscountCode);
            this.gbDeliveryFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeliveryFees.Location = new System.Drawing.Point(12, 329);
            this.gbDeliveryFees.Name = "gbDeliveryFees";
            this.gbDeliveryFees.Size = new System.Drawing.Size(246, 169);
            this.gbDeliveryFees.TabIndex = 11;
            this.gbDeliveryFees.TabStop = false;
            this.gbDeliveryFees.Text = "Delivery Fees";
            // 
            // btnClac
            // 
            this.btnClac.Location = new System.Drawing.Point(6, 48);
            this.btnClac.Name = "btnClac";
            this.btnClac.Size = new System.Drawing.Size(234, 23);
            this.btnClac.TabIndex = 14;
            this.btnClac.Text = "Calculate Your Price";
            this.btnClac.UseVisualStyleBackColor = true;
            this.btnClac.Click += new System.EventHandler(this.btnClac_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(96, 133);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(144, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "£0.00";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(96, 107);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(144, 20);
            this.txtTax.TabIndex = 12;
            this.txtTax.Text = "£0.00";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(190, 78);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(50, 23);
            this.btnDiscount.TabIndex = 11;
            this.btnDiscount.Text = "Apply";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(4, 110);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax";
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Location = new System.Drawing.Point(6, 83);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(77, 13);
            this.lblDiscountCode.TabIndex = 1;
            this.lblDiscountCode.Text = "Discount Code";
            this.lblDiscountCode.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.Location = new System.Drawing.Point(96, 78);
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.Size = new System.Drawing.Size(88, 20);
            this.txtDiscountCode.TabIndex = 0;
            this.txtDiscountCode.TextChanged += new System.EventHandler(this.txtDiscountCode_TextChanged);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Snow;
            this.btnAdmin.Location = new System.Drawing.Point(628, 460);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(93, 38);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Snow;
            this.btnOrder.Location = new System.Drawing.Point(542, 460);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(80, 38);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(264, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(325, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "First Enter Your Order Details\r\n";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(264, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "Calculate Your Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(264, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(254, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Then Place Your Order";
            // 
            // lblInsuranceQ
            // 
            this.lblInsuranceQ.AutoSize = true;
            this.lblInsuranceQ.Location = new System.Drawing.Point(6, 26);
            this.lblInsuranceQ.Name = "lblInsuranceQ";
            this.lblInsuranceQ.Size = new System.Drawing.Size(82, 13);
            this.lblInsuranceQ.TabIndex = 15;
            this.lblInsuranceQ.Text = "Add Insurance?";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(137, 25);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(103, 17);
            this.chkInsurance.TabIndex = 17;
            this.chkInsurance.Text = "£2 Per Package";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.gbDeliveryFees);
            this.Controls.Add(this.gbPackageDetails);
            this.Controls.Add(this.gbCustDetails);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderScreen";
            this.Text = "Order Screen";
            this.Load += new System.EventHandler(this.OrderScreen_Load);
            this.gbCustDetails.ResumeLayout(false);
            this.gbCustDetails.PerformLayout();
            this.gbPackageDetails.ResumeLayout(false);
            this.gbPackageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gbDeliveryFees.ResumeLayout(false);
            this.gbDeliveryFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox gbCustDetails;
        private System.Windows.Forms.TextBox txtRetrunAdd;
        private System.Windows.Forms.Label lblReturnAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbPackageDetails;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblParcelVol;
        private System.Windows.Forms.Label lblShippingTime;
        private System.Windows.Forms.Label lblNumPkg;
        private System.Windows.Forms.TextBox txtNumOfPackages;
        private System.Windows.Forms.ComboBox cmbShipTime;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.ComboBox cmbParcelVol;
        private System.Windows.Forms.GroupBox gbDeliveryFees;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbTracking;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.Button btnClac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.Label lblInsuranceQ;
    }
}