namespace UI
{
    partial class OperateTheParkingGarageScreen
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
            this.AddVehicleToDbButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.NumberPlateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddVehicleToDbButton
            // 
            this.AddVehicleToDbButton.Location = new System.Drawing.Point(12, 193);
            this.AddVehicleToDbButton.Name = "AddVehicleToDbButton";
            this.AddVehicleToDbButton.Size = new System.Drawing.Size(146, 29);
            this.AddVehicleToDbButton.TabIndex = 2;
            this.AddVehicleToDbButton.Text = "Submit";
            this.AddVehicleToDbButton.UseVisualStyleBackColor = true;
            this.AddVehicleToDbButton.Click += new System.EventHandler(this.AddVehicleToDbButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Park the Vehicle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Remove the Vehicle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Parking spot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number Plate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Move the Vehicle";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ParkingSpotTextBox
            // 
            this.ParkingSpotTextBox.Location = new System.Drawing.Point(33, 111);
            this.ParkingSpotTextBox.Name = "ParkingSpotTextBox";
            this.ParkingSpotTextBox.Size = new System.Drawing.Size(125, 27);
            this.ParkingSpotTextBox.TabIndex = 1;
            // 
            // NumberPlateTextBox
            // 
            this.NumberPlateTextBox.Location = new System.Drawing.Point(32, 56);
            this.NumberPlateTextBox.Name = "NumberPlateTextBox";
            this.NumberPlateTextBox.Size = new System.Drawing.Size(125, 27);
            this.NumberPlateTextBox.TabIndex = 0;
            // 
            // OperateTheParkingGarageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 291);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ParkingSpotTextBox);
            this.Controls.Add(this.NumberPlateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddVehicleToDbButton);
            this.Name = "OperateTheParkingGarageScreen";
            this.Text = "OperateTheParkingGarageScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OperateTheParkingGarageScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddVehicleToDbButton;
        private Label label1;
        private Label label6;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button3;
        private TextBox ParkingSpotTextBox;
        private TextBox NumberPlateTextBox;
    }
}