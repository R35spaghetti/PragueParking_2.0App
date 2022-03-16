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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.VehicleSplitContainers.Panel1.Controls.Add(this.label3);
            this.VehicleSplitContainers.Panel1.Controls.Add(this.label4);
            this.VehicleSplitContainers.Panel1.Controls.Add(this.CarListBox);
            // 
            // VehicleSplitContainers.Panel2
            // 
            this.VehicleSplitContainers.Panel2.Controls.Add(this.label2);
            this.VehicleSplitContainers.Panel2.Controls.Add(this.label1);
            this.VehicleSplitContainers.Panel2.Controls.Add(this.MotorcycleListBox);
            this.VehicleSplitContainers.Size = new System.Drawing.Size(1395, 750);
            this.VehicleSplitContainers.SplitterDistance = 671;
            this.VehicleSplitContainers.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(482, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parking Spot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car";
            // 
            // CarListBox
            // 
            this.CarListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.ItemHeight = 69;
            this.CarListBox.Location = new System.Drawing.Point(12, 91);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CarListBox.Size = new System.Drawing.Size(638, 625);
            this.CarListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(480, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parking Spot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 42);
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
            this.MotorcycleListBox.Location = new System.Drawing.Point(15, 91);
            this.MotorcycleListBox.Name = "MotorcycleListBox";
            this.MotorcycleListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.MotorcycleListBox.Size = new System.Drawing.Size(638, 625);
            this.MotorcycleListBox.TabIndex = 0;
            // 
            // PresentTheParkingGarageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 750);
            this.Controls.Add(this.VehicleSplitContainers);
            this.Name = "PresentTheParkingGarageScreen";
            this.Text = "PresentTheParkingGarageScreen";
            this.Load += new System.EventHandler(this.PresentTheParkingGarageScreen_Load);
            this.VehicleSplitContainers.Panel1.ResumeLayout(false);
            this.VehicleSplitContainers.Panel1.PerformLayout();
            this.VehicleSplitContainers.Panel2.ResumeLayout(false);
            this.VehicleSplitContainers.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleSplitContainers)).EndInit();
            this.VehicleSplitContainers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer VehicleSplitContainers;
        private ListBox MotorcycleListBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private ListBox CarListBox;
    }
}