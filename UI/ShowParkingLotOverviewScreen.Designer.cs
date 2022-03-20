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
            this.EditRowsTextBox = new System.Windows.Forms.TextBox();
            this.EditColumnsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateTableButton = new System.Windows.Forms.Button();
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
            this.VehicleTableLayoutPanel.Size = new System.Drawing.Size(1574, 905);
            this.VehicleTableLayoutPanel.TabIndex = 8;
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.IndianRed;
            this.InfoButton.Location = new System.Drawing.Point(1580, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(35, 29);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // EditRowsTextBox
            // 
            this.EditRowsTextBox.Location = new System.Drawing.Point(1580, 89);
            this.EditRowsTextBox.Name = "EditRowsTextBox";
            this.EditRowsTextBox.Size = new System.Drawing.Size(125, 27);
            this.EditRowsTextBox.TabIndex = 9;
            // 
            // EditColumnsTextBox
            // 
            this.EditColumnsTextBox.Location = new System.Drawing.Point(1580, 167);
            this.EditColumnsTextBox.Name = "EditColumnsTextBox";
            this.EditColumnsTextBox.Size = new System.Drawing.Size(125, 27);
            this.EditColumnsTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1580, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1580, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edit columns";
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Location = new System.Drawing.Point(1580, 228);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(125, 29);
            this.UpdateTableButton.TabIndex = 13;
            this.UpdateTableButton.Text = "Update table";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click);
            // 
            // ShowParkingLotOverviewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 906);
            this.Controls.Add(this.UpdateTableButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditColumnsTextBox);
            this.Controls.Add(this.EditRowsTextBox);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.VehicleTableLayoutPanel);
            this.Name = "ShowParkingLotOverviewScreen";
            this.Text = "TestShowButtonsVehicleScreen";
            this.Load += new System.EventHandler(this.ShowButtonsVehicleScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel VehicleTableLayoutPanel;
        private Button InfoButton;
        private TextBox EditRowsTextBox;
        private TextBox EditColumnsTextBox;
        private Label label1;
        private Label label2;
        private Button UpdateTableButton;
    }
}