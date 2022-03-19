namespace UI
{
    partial class ShowParkingLotOverviewScreen
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
            this.VehicleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VehicleTableLayoutPanel
            // 
            this.VehicleTableLayoutPanel.ColumnCount = 2;
            this.VehicleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VehicleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VehicleTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.VehicleTableLayoutPanel.Name = "VehicleTableLayoutPanel";
            this.VehicleTableLayoutPanel.RowCount = 2;
            this.VehicleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VehicleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VehicleTableLayoutPanel.Size = new System.Drawing.Size(1586, 863);
            this.VehicleTableLayoutPanel.TabIndex = 8;
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.IndianRed;
            this.InfoButton.Location = new System.Drawing.Point(1609, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(35, 29);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ShowParkingLotOverviewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 875);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.VehicleTableLayoutPanel);
            this.Name = "ShowParkingLotOverviewScreen";
            this.Text = "TestShowButtonsVehicleScreen";
            this.Load += new System.EventHandler(this.TestShowButtonsVehicleScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel VehicleTableLayoutPanel;
        private Button InfoButton;
    }
}