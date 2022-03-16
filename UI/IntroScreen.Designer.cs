namespace UI
{
    partial class IntroScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdatePrice = new System.Windows.Forms.Button();
            this.rentalPricesLabel = new System.Windows.Forms.Label();
            this.PriceWindow = new System.Windows.Forms.RichTextBox();
            this.ParkingGarageLimitationValuesButton = new System.Windows.Forms.Button();
            this.GarageOperationsButton = new System.Windows.Forms.Button();
            this.ShowParkingLotButton = new System.Windows.Forms.Button();
            this.ver2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdatePrice
            // 
            this.UpdatePrice.Location = new System.Drawing.Point(277, 46);
            this.UpdatePrice.Name = "UpdatePrice";
            this.UpdatePrice.Size = new System.Drawing.Size(133, 29);
            this.UpdatePrice.TabIndex = 1;
            this.UpdatePrice.Text = "Update prices";
            this.UpdatePrice.UseVisualStyleBackColor = true;
            this.UpdatePrice.Click += new System.EventHandler(this.UpdatePrice_Click);
            // 
            // rentalPricesLabel
            // 
            this.rentalPricesLabel.AutoSize = true;
            this.rentalPricesLabel.Location = new System.Drawing.Point(12, 24);
            this.rentalPricesLabel.Name = "rentalPricesLabel";
            this.rentalPricesLabel.Size = new System.Drawing.Size(142, 20);
            this.rentalPricesLabel.TabIndex = 2;
            this.rentalPricesLabel.Text = "Current rental prices";
            // 
            // PriceWindow
            // 
            this.PriceWindow.Location = new System.Drawing.Point(12, 47);
            this.PriceWindow.Name = "PriceWindow";
            this.PriceWindow.ReadOnly = true;
            this.PriceWindow.Size = new System.Drawing.Size(241, 120);
            this.PriceWindow.TabIndex = 3;
            this.PriceWindow.Text = "";
            this.PriceWindow.Click += new System.EventHandler(this.PriceWindow_Load);
            // 
            // ParkingGarageLimitationValuesButton
            // 
            this.ParkingGarageLimitationValuesButton.Location = new System.Drawing.Point(12, 182);
            this.ParkingGarageLimitationValuesButton.Name = "ParkingGarageLimitationValuesButton";
            this.ParkingGarageLimitationValuesButton.Size = new System.Drawing.Size(241, 29);
            this.ParkingGarageLimitationValuesButton.TabIndex = 4;
            this.ParkingGarageLimitationValuesButton.Text = "Update limitation values";
            this.ParkingGarageLimitationValuesButton.UseVisualStyleBackColor = true;
            this.ParkingGarageLimitationValuesButton.Click += new System.EventHandler(this.ParkingGarageLimitationValuesButton_Click);
            // 
            // GarageOperationsButton
            // 
            this.GarageOperationsButton.Location = new System.Drawing.Point(259, 182);
            this.GarageOperationsButton.Name = "GarageOperationsButton";
            this.GarageOperationsButton.Size = new System.Drawing.Size(243, 29);
            this.GarageOperationsButton.TabIndex = 5;
            this.GarageOperationsButton.Text = "Update the parking garage";
            this.GarageOperationsButton.UseVisualStyleBackColor = true;
            this.GarageOperationsButton.Click += new System.EventHandler(this.GarageOperationsButton_Click);
            // 
            // ShowParkingLotButton
            // 
            this.ShowParkingLotButton.Location = new System.Drawing.Point(307, 113);
            this.ShowParkingLotButton.Name = "ShowParkingLotButton";
            this.ShowParkingLotButton.Size = new System.Drawing.Size(176, 29);
            this.ShowParkingLotButton.TabIndex = 6;
            this.ShowParkingLotButton.Text = "Show parking lot";
            this.ShowParkingLotButton.UseVisualStyleBackColor = true;
            this.ShowParkingLotButton.Click += new System.EventHandler(this.ShowParkingLotButton_Click);
            // 
            // ver2Button
            // 
            this.ver2Button.Location = new System.Drawing.Point(489, 113);
            this.ver2Button.Name = "ver2Button";
            this.ver2Button.Size = new System.Drawing.Size(176, 29);
            this.ver2Button.TabIndex = 7;
            this.ver2Button.Text = "Show parking lot ver2";
            this.ver2Button.UseVisualStyleBackColor = true;
            this.ver2Button.Click += new System.EventHandler(this.ver2Button_Click);
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 253);
            this.Controls.Add(this.ver2Button);
            this.Controls.Add(this.ShowParkingLotButton);
            this.Controls.Add(this.GarageOperationsButton);
            this.Controls.Add(this.ParkingGarageLimitationValuesButton);
            this.Controls.Add(this.PriceWindow);
            this.Controls.Add(this.rentalPricesLabel);
            this.Controls.Add(this.UpdatePrice);
            this.Name = "IntroScreen";
            this.Text = "Parking garage app";
            this.Load += new System.EventHandler(this.PriceWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button UpdatePrice;
        private Label rentalPricesLabel;
        private RichTextBox PriceWindow;
        private Button ParkingGarageLimitationValuesButton;
        private Button GarageOperationsButton;
        private Button ShowParkingLotButton;
        private Button ver2Button;
    }
}