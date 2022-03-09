namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpdatePrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceWindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UpdatePrice
            // 
            this.UpdatePrice.Location = new System.Drawing.Point(281, 84);
            this.UpdatePrice.Name = "UpdatePrice";
            this.UpdatePrice.Size = new System.Drawing.Size(133, 29);
            this.UpdatePrice.TabIndex = 1;
            this.UpdatePrice.Text = "Update price";
            this.UpdatePrice.UseVisualStyleBackColor = true;
            this.UpdatePrice.Click += new System.EventHandler(this.UpdatePrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click below to see current rental prices";
            // 
            // PriceWindow
            // 
            this.PriceWindow.Location = new System.Drawing.Point(12, 47);
            this.PriceWindow.Name = "PriceWindow";
            this.PriceWindow.ReadOnly = true;
            this.PriceWindow.Size = new System.Drawing.Size(241, 120);
            this.PriceWindow.TabIndex = 3;
            this.PriceWindow.Text = "";
            this.PriceWindow.Click += new System.EventHandler(this.PriceWindow_TextChanged);
            this.PriceWindow.TextChanged += new System.EventHandler(this.PriceWindow_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PriceWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdatePrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button UpdatePrice;
        private Label label1;
        private RichTextBox PriceWindow;
    }
}