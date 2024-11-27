namespace PDP_Deliveries
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dateTimeRentalsMade = new System.Windows.Forms.DateTimePicker();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.txtBookings = new System.Windows.Forms.RichTextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1504, 634);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(13, 630);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(127, 40);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show Bookings";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dateTimeRentalsMade
            // 
            this.dateTimeRentalsMade.Location = new System.Drawing.Point(1514, 97);
            this.dateTimeRentalsMade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeRentalsMade.Name = "dateTimeRentalsMade";
            this.dateTimeRentalsMade.Size = new System.Drawing.Size(138, 20);
            this.dateTimeRentalsMade.TabIndex = 9;
            this.dateTimeRentalsMade.ValueChanged += new System.EventHandler(this.dateTimeRentalsMade_ValueChanged);
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDate.Location = new System.Drawing.Point(1563, 129);
            this.lblChooseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(89, 15);
            this.lblChooseDate.TabIndex = 8;
            this.lblChooseDate.Text = "Choose Date";
            this.lblChooseDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBookings
            // 
            this.txtBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookings.Location = new System.Drawing.Point(23, 54);
            this.txtBookings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookings.Name = "txtBookings";
            this.txtBookings.Size = new System.Drawing.Size(1442, 570);
            this.txtBookings.TabIndex = 7;
            this.txtBookings.Text = "";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(20, 20);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(218, 15);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Text = "Display Booking On A Given Date";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::PDP_Deliveries.Properties.Resources.PDP_Logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(1515, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(138, 75);
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 686);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dateTimeRentalsMade);
            this.Controls.Add(this.lblChooseDate);
            this.Controls.Add(this.txtBookings);
            this.Controls.Add(this.lblDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dateTimeRentalsMade;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.RichTextBox txtBookings;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.PictureBox picLogo;
    }
}