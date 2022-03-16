namespace UI
{
    partial class PresentTheParkingGarageScreen
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
            this.VehicleSplitContainers = new System.Windows.Forms.SplitContainer();
            this.SecondVehicleListBox = new System.Windows.Forms.ListBox();
            this.CarListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MotorcycleListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleSplitContainers)).BeginInit();
            this.VehicleSplitContainers.Panel1.SuspendLayout();
            this.VehicleSplitContainers.Panel2.SuspendLayout();
            this.VehicleSplitContainers.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleSplitContainers
            // 
            this.VehicleSplitContainers.AccessibleName = "";
            this.VehicleSplitContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleSplitContainers.Location = new System.Drawing.Point(0, 0);
            this.VehicleSplitContainers.Name = "VehicleSplitContainers";
            // 
            // VehicleSplitContainers.Panel1
            // 
            this.VehicleSplitContainers.Panel1.Controls.Add(this.SecondVehicleListBox);
            this.VehicleSplitContainers.Panel1.Controls.Add(this.CarListBox);
            // 
            // VehicleSplitContainers.Panel2
            // 
            this.VehicleSplitContainers.Panel2.Controls.Add(this.label2);
            this.VehicleSplitContainers.Panel2.Controls.Add(this.label1);
            this.VehicleSplitContainers.Panel2.Controls.Add(this.MotorcycleListBox);
            this.VehicleSplitContainers.Size = new System.Drawing.Size(1448, 513);
            this.VehicleSplitContainers.SplitterDistance = 735;
            this.VehicleSplitContainers.TabIndex = 0;
            // 
            // SecondVehicleListBox
            // 
            this.SecondVehicleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondVehicleListBox.FormattingEnabled = true;
            this.SecondVehicleListBox.ItemHeight = 38;
            this.SecondVehicleListBox.Location = new System.Drawing.Point(318, 426);
            this.SecondVehicleListBox.Name = "SecondVehicleListBox";
            this.SecondVehicleListBox.Size = new System.Drawing.Size(345, 42);
            this.SecondVehicleListBox.TabIndex = 3;
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.ItemHeight = 20;
            this.CarListBox.Location = new System.Drawing.Point(84, 42);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(444, 344);
            this.CarListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(481, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parking Spot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "MC";
            // 
            // MotorcycleListBox
            // 
            this.MotorcycleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MotorcycleListBox.FormattingEnabled = true;
            this.MotorcycleListBox.ItemHeight = 69;
            this.MotorcycleListBox.Location = new System.Drawing.Point(3, 91);
            this.MotorcycleListBox.Name = "MotorcycleListBox";
            this.MotorcycleListBox.Size = new System.Drawing.Size(638, 211);
            this.MotorcycleListBox.TabIndex = 0;
            // 
            // PresentTheParkingGarageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 513);
            this.Controls.Add(this.VehicleSplitContainers);
            this.Name = "PresentTheParkingGarageScreen";
            this.Text = "PresentTheParkingGarageScreen";
            this.Load += new System.EventHandler(this.PresentTheParkingGarageScreen_Load);
            this.VehicleSplitContainers.Panel1.ResumeLayout(false);
            this.VehicleSplitContainers.Panel2.ResumeLayout(false);
            this.VehicleSplitContainers.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleSplitContainers)).EndInit();
            this.VehicleSplitContainers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer VehicleSplitContainers;
        private ListBox MotorcycleListBox;
        private ListBox CarListBox;
        private Label label2;
        private Label label1;
        private ListBox SecondVehicleListBox;
    }
}