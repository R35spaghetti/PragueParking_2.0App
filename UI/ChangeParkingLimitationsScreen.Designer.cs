namespace UI
{
    partial class ChangeParkingLimitationsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeParkingLimitationsScreen));
            this.SubmitParkingSpotLimitationValuesButton = new System.Windows.Forms.Button();
            this.MCSizeTextBox = new System.Windows.Forms.TextBox();
            this.CarSizeTextBox = new System.Windows.Forms.TextBox();
            this.ParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ParkingSpotSizeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MCRentalPriceTextbox = new System.Windows.Forms.TextBox();
            this.CarRentalPriceTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitParkingSpotLimitationValuesButton
            // 
            this.SubmitParkingSpotLimitationValuesButton.BackColor = System.Drawing.Color.MistyRose;
            this.SubmitParkingSpotLimitationValuesButton.Location = new System.Drawing.Point(12, 319);
            this.SubmitParkingSpotLimitationValuesButton.Name = "SubmitParkingSpotLimitationValuesButton";
            this.SubmitParkingSpotLimitationValuesButton.Size = new System.Drawing.Size(527, 29);
            this.SubmitParkingSpotLimitationValuesButton.TabIndex = 7;
            this.SubmitParkingSpotLimitationValuesButton.Text = "Submit";
            this.SubmitParkingSpotLimitationValuesButton.UseVisualStyleBackColor = false;
            this.SubmitParkingSpotLimitationValuesButton.Click += new System.EventHandler(this.SubmitParkingSpotLimitationValuesButton_Click);
            // 
            // MCSizeTextBox
            // 
            this.MCSizeTextBox.Location = new System.Drawing.Point(399, 195);
            this.MCSizeTextBox.Name = "MCSizeTextBox";
            this.MCSizeTextBox.Size = new System.Drawing.Size(140, 27);
            this.MCSizeTextBox.TabIndex = 3;
            // 
            // CarSizeTextBox
            // 
            this.CarSizeTextBox.Location = new System.Drawing.Point(225, 263);
            this.CarSizeTextBox.Name = "CarSizeTextBox";
            this.CarSizeTextBox.Size = new System.Drawing.Size(141, 27);
            this.CarSizeTextBox.TabIndex = 5;
            // 
            // ParkingSpotTextBox
            // 
            this.ParkingSpotTextBox.Location = new System.Drawing.Point(226, 195);
            this.ParkingSpotTextBox.Name = "ParkingSpotTextBox";
            this.ParkingSpotTextBox.Size = new System.Drawing.Size(141, 27);
            this.ParkingSpotTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parking spot limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cars\' size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motorcycles\' size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 120);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parking spot size";
            // 
            // ParkingSpotSizeTextBox
            // 
            this.ParkingSpotSizeTextBox.Location = new System.Drawing.Point(394, 263);
            this.ParkingSpotSizeTextBox.Name = "ParkingSpotSizeTextBox";
            this.ParkingSpotSizeTextBox.Size = new System.Drawing.Size(145, 27);
            this.ParkingSpotSizeTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter a new mc rental price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter a new car rental price";
            // 
            // MCRentalPriceTextbox
            // 
            this.MCRentalPriceTextbox.Location = new System.Drawing.Point(12, 263);
            this.MCRentalPriceTextbox.Name = "MCRentalPriceTextbox";
            this.MCRentalPriceTextbox.Size = new System.Drawing.Size(141, 27);
            this.MCRentalPriceTextbox.TabIndex = 4;
            // 
            // CarRentalPriceTextbox
            // 
            this.CarRentalPriceTextbox.Location = new System.Drawing.Point(12, 195);
            this.CarRentalPriceTextbox.Name = "CarRentalPriceTextbox";
            this.CarRentalPriceTextbox.Size = new System.Drawing.Size(141, 27);
            this.CarRentalPriceTextbox.TabIndex = 1;
            // 
            // ChangeParkingLimitationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MCRentalPriceTextbox);
            this.Controls.Add(this.CarRentalPriceTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ParkingSpotSizeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParkingSpotTextBox);
            this.Controls.Add(this.CarSizeTextBox);
            this.Controls.Add(this.MCSizeTextBox);
            this.Controls.Add(this.SubmitParkingSpotLimitationValuesButton);
            this.Name = "ChangeParkingLimitationsScreen";
            this.Text = "ChangeParkingSpacesScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeParkingSpacesScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SubmitParkingSpotLimitationValuesButton;
        private TextBox MCSizeTextBox;
        private TextBox CarSizeTextBox;
        private TextBox ParkingSpotTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ParkingSpotSizeTextBox;
        private Label label6;
        private Label label7;
        private TextBox MCRentalPriceTextbox;
        private TextBox CarRentalPriceTextbox;
    }
}