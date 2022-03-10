namespace UI
{
    partial class ChangeParkingSpacesScreen
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
            this.SubmitParkingSpotLimitationValuesButton = new System.Windows.Forms.Button();
            this.MCParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.CarsParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.ParkingSpotTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitParkingSpotLimitationValuesButton
            // 
            this.SubmitParkingSpotLimitationValuesButton.Location = new System.Drawing.Point(21, 166);
            this.SubmitParkingSpotLimitationValuesButton.Name = "SubmitParkingSpotLimitationValuesButton";
            this.SubmitParkingSpotLimitationValuesButton.Size = new System.Drawing.Size(452, 29);
            this.SubmitParkingSpotLimitationValuesButton.TabIndex = 3;
            this.SubmitParkingSpotLimitationValuesButton.Text = "Submit";
            this.SubmitParkingSpotLimitationValuesButton.UseVisualStyleBackColor = true;
            this.SubmitParkingSpotLimitationValuesButton.Click += new System.EventHandler(this.SubmitParkingSpotLimitationValuesButton_Click);
            // 
            // MCParkingSpotTextBox
            // 
            this.MCParkingSpotTextBox.Location = new System.Drawing.Point(348, 108);
            this.MCParkingSpotTextBox.Name = "MCParkingSpotTextBox";
            this.MCParkingSpotTextBox.Size = new System.Drawing.Size(125, 27);
            this.MCParkingSpotTextBox.TabIndex = 2;
            // 
            // CarsParkingSpotTextBox
            // 
            this.CarsParkingSpotTextBox.Location = new System.Drawing.Point(191, 108);
            this.CarsParkingSpotTextBox.Name = "CarsParkingSpotTextBox";
            this.CarsParkingSpotTextBox.Size = new System.Drawing.Size(125, 27);
            this.CarsParkingSpotTextBox.TabIndex = 1;
            // 
            // ParkingSpotTextBox
            // 
            this.ParkingSpotTextBox.Location = new System.Drawing.Point(21, 108);
            this.ParkingSpotTextBox.Name = "ParkingSpotTextBox";
            this.ParkingSpotTextBox.Size = new System.Drawing.Size(125, 27);
            this.ParkingSpotTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parking spots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "MCs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Here you can do the following:\r\n-Limit the amount of vehicles in the parking gara" +
    "ge\r\n-Limit the amount of parking spots in the parking garage\r\n";
            // 
            // ChangeParkingSpacesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 222);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParkingSpotTextBox);
            this.Controls.Add(this.CarsParkingSpotTextBox);
            this.Controls.Add(this.MCParkingSpotTextBox);
            this.Controls.Add(this.SubmitParkingSpotLimitationValuesButton);
            this.Name = "ChangeParkingSpacesScreen";
            this.Text = "ChangeParkingSpacesScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SubmitParkingSpotLimitationValuesButton;
        private TextBox MCParkingSpotTextBox;
        private TextBox CarsParkingSpotTextBox;
        private TextBox ParkingSpotTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}