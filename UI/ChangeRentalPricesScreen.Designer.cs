namespace UI
{
    partial class ChangeRentalPricesScreen
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
            this.CarRentalPriceTextbox = new System.Windows.Forms.TextBox();
            this.MCRentalPriceTextbox = new System.Windows.Forms.TextBox();
            this.SubmitNewRentalPrices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CarRentalPriceTextbox
            // 
            this.CarRentalPriceTextbox.Location = new System.Drawing.Point(12, 55);
            this.CarRentalPriceTextbox.Name = "CarRentalPriceTextbox";
            this.CarRentalPriceTextbox.Size = new System.Drawing.Size(189, 27);
            this.CarRentalPriceTextbox.TabIndex = 0;
            // 
            // MCRentalPriceTextbox
            // 
            this.MCRentalPriceTextbox.Location = new System.Drawing.Point(313, 55);
            this.MCRentalPriceTextbox.Name = "MCRentalPriceTextbox";
            this.MCRentalPriceTextbox.Size = new System.Drawing.Size(189, 27);
            this.MCRentalPriceTextbox.TabIndex = 1;
            // 
            // SubmitNewRentalPrices
            // 
            this.SubmitNewRentalPrices.Location = new System.Drawing.Point(190, 88);
            this.SubmitNewRentalPrices.Name = "SubmitNewRentalPrices";
            this.SubmitNewRentalPrices.Size = new System.Drawing.Size(135, 29);
            this.SubmitNewRentalPrices.TabIndex = 2;
            this.SubmitNewRentalPrices.Text = "Submit";
            this.SubmitNewRentalPrices.UseVisualStyleBackColor = true;
            this.SubmitNewRentalPrices.Click += new System.EventHandler(this.SubmitNewRentalPrices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a new car rental price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter a new mc rental price";
            // 
            // ChangeRentalPricesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitNewRentalPrices);
            this.Controls.Add(this.MCRentalPriceTextbox);
            this.Controls.Add(this.CarRentalPriceTextbox);
            this.Name = "ChangeRentalPricesScreen";
            this.Text = "ChangeRentalPricesScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeRentalPricesScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CarRentalPriceTextbox;
        private TextBox MCRentalPriceTextbox;
        private Button SubmitNewRentalPrices;
        private Label label1;
        private Label label2;
    }
}