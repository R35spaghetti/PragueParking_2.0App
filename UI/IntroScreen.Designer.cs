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
            this.rentalPricesLabel = new System.Windows.Forms.Label();
            this.LimitationValuesWindow = new System.Windows.Forms.RichTextBox();
            this.ParkingGarageLimitationValuesButton = new System.Windows.Forms.Button();
            this.GarageOperationsButton = new System.Windows.Forms.Button();
            this.ParkedvehiclesButton = new System.Windows.Forms.Button();
            this.TestDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rentalPricesLabel
            // 
            this.rentalPricesLabel.AutoSize = true;
            this.rentalPricesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentalPricesLabel.Location = new System.Drawing.Point(12, 15);
            this.rentalPricesLabel.Name = "rentalPricesLabel";
            this.rentalPricesLabel.Size = new System.Drawing.Size(225, 28);
            this.rentalPricesLabel.TabIndex = 2;
            this.rentalPricesLabel.Text = "Current limitation values";
            // 
            // LimitationValuesWindow
            // 
            this.LimitationValuesWindow.BackColor = System.Drawing.Color.MistyRose;
            this.LimitationValuesWindow.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LimitationValuesWindow.Location = new System.Drawing.Point(12, 46);
            this.LimitationValuesWindow.Name = "LimitationValuesWindow";
            this.LimitationValuesWindow.ReadOnly = true;
            this.LimitationValuesWindow.Size = new System.Drawing.Size(834, 439);
            this.LimitationValuesWindow.TabIndex = 5;
            this.LimitationValuesWindow.Text = "";
            this.LimitationValuesWindow.Click += new System.EventHandler(this.LimitationValuesWindow_Load);
            // 
            // ParkingGarageLimitationValuesButton
            // 
            this.ParkingGarageLimitationValuesButton.Location = new System.Drawing.Point(12, 511);
            this.ParkingGarageLimitationValuesButton.Name = "ParkingGarageLimitationValuesButton";
            this.ParkingGarageLimitationValuesButton.Size = new System.Drawing.Size(241, 29);
            this.ParkingGarageLimitationValuesButton.TabIndex = 1;
            this.ParkingGarageLimitationValuesButton.Text = "Update limitation values";
            this.ParkingGarageLimitationValuesButton.UseVisualStyleBackColor = true;
            this.ParkingGarageLimitationValuesButton.Click += new System.EventHandler(this.ParkingGarageLimitationValuesButton_Click);
            // 
            // GarageOperationsButton
            // 
            this.GarageOperationsButton.Location = new System.Drawing.Point(12, 565);
            this.GarageOperationsButton.Name = "GarageOperationsButton";
            this.GarageOperationsButton.Size = new System.Drawing.Size(243, 29);
            this.GarageOperationsButton.TabIndex = 3;
            this.GarageOperationsButton.Text = "Update the parking garage";
            this.GarageOperationsButton.UseVisualStyleBackColor = true;
            this.GarageOperationsButton.Click += new System.EventHandler(this.GarageOperationsButton_Click);
            // 
            // ParkedvehiclesButton
            // 
            this.ParkedvehiclesButton.Location = new System.Drawing.Point(667, 511);
            this.ParkedvehiclesButton.Name = "ParkedvehiclesButton";
            this.ParkedvehiclesButton.Size = new System.Drawing.Size(179, 29);
            this.ParkedvehiclesButton.TabIndex = 2;
            this.ParkedvehiclesButton.Text = "Show parked vehicles";
            this.ParkedvehiclesButton.UseVisualStyleBackColor = true;
            this.ParkedvehiclesButton.Click += new System.EventHandler(this.ParkedVehiclesButton_Click);
            // 
            // TestDataButton
            // 
            this.TestDataButton.Location = new System.Drawing.Point(667, 565);
            this.TestDataButton.Name = "TestDataButton";
            this.TestDataButton.Size = new System.Drawing.Size(179, 29);
            this.TestDataButton.TabIndex = 4;
            this.TestDataButton.Text = "Get test data";
            this.TestDataButton.UseVisualStyleBackColor = true;
            this.TestDataButton.Click += new System.EventHandler(this.TestDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edition: Bleeding Edge";
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.IndianRed;
            this.InfoButton.Location = new System.Drawing.Point(852, 565);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(35, 29);
            this.InfoButton.TabIndex = 6;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 727);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestDataButton);
            this.Controls.Add(this.ParkedvehiclesButton);
            this.Controls.Add(this.GarageOperationsButton);
            this.Controls.Add(this.ParkingGarageLimitationValuesButton);
            this.Controls.Add(this.LimitationValuesWindow);
            this.Controls.Add(this.rentalPricesLabel);
            this.Name = "IntroScreen";
            this.Text = "Parking garage app";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IntroScreen_FormClosing);
            this.Load += new System.EventHandler(this.LimitationValuesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label rentalPricesLabel;
        private RichTextBox LimitationValuesWindow;
        private Button ParkingGarageLimitationValuesButton;
        private Button GarageOperationsButton;
        private Button ParkedvehiclesButton;
        private Button TestDataButton;
        private Label label1;
        private Button InfoButton;
    }
}