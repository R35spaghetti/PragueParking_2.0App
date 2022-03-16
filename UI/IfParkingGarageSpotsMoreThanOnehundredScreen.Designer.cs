namespace UI
{
    partial class IfParkingGarageSpotsMoreThanOnehundredScreen
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehiclesDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberPlateDataGridViewTextBoxColumn,
            this.parkingSpotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiclesDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(977, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // vehiclesDBBindingSource
            // 
            this.vehiclesDBBindingSource.DataSource = typeof(GhostSheriffsDatabaseAccess.VehiclesDB);
            // 
            // numberPlateDataGridViewTextBoxColumn
            // 
            this.numberPlateDataGridViewTextBoxColumn.DataPropertyName = "NumberPlate";
            this.numberPlateDataGridViewTextBoxColumn.HeaderText = "NumberPlate";
            this.numberPlateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberPlateDataGridViewTextBoxColumn.Name = "numberPlateDataGridViewTextBoxColumn";
            this.numberPlateDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // IfParkingGarageSpotsMoreThanOnehundredScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 814);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IfParkingGarageSpotsMoreThanOnehundredScreen";
            this.Text = "IfParkingGarageSpotsMoreThanOnehundredScreen";
            this.Load += new System.EventHandler(this.IfParkingGarageSpotsMoreThanOnehundredScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private BindingSource vehiclesDBBindingSource;
    }
}