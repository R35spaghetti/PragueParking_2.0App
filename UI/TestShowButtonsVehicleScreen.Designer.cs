namespace UI
{
    partial class TestShowButtonsVehicleScreen
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
            this.ShowVehiclesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.VehicleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ShowVehiclesRichTextBox
            // 
            this.ShowVehiclesRichTextBox.Location = new System.Drawing.Point(1101, 12);
            this.ShowVehiclesRichTextBox.Name = "ShowVehiclesRichTextBox";
            this.ShowVehiclesRichTextBox.Size = new System.Drawing.Size(227, 585);
            this.ShowVehiclesRichTextBox.TabIndex = 7;
            this.ShowVehiclesRichTextBox.Text = "";
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
            this.VehicleTableLayoutPanel.Size = new System.Drawing.Size(728, 489);
            this.VehicleTableLayoutPanel.TabIndex = 8;
            // 
            // TestShowButtonsVehicleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 597);
            this.Controls.Add(this.VehicleTableLayoutPanel);
            this.Controls.Add(this.ShowVehiclesRichTextBox);
            this.Name = "TestShowButtonsVehicleScreen";
            this.Text = "TestShowButtonsVehicleScreen";
            this.Load += new System.EventHandler(this.TestShowButtonsVehicleScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox ShowVehiclesRichTextBox;
        private TableLayoutPanel VehicleTableLayoutPanel;
    }
}