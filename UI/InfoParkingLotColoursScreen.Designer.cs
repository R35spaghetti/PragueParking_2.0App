namespace UI
{
    partial class InfoParkingLotColoursScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoParkingLotColoursScreen));
            this.InfoAboutOverViewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OkCloseMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoAboutOverViewRichTextBox
            // 
            this.InfoAboutOverViewRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoAboutOverViewRichTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoAboutOverViewRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.InfoAboutOverViewRichTextBox.Location = new System.Drawing.Point(30, 21);
            this.InfoAboutOverViewRichTextBox.Name = "InfoAboutOverViewRichTextBox";
            this.InfoAboutOverViewRichTextBox.Size = new System.Drawing.Size(1243, 303);
            this.InfoAboutOverViewRichTextBox.TabIndex = 10;
            this.InfoAboutOverViewRichTextBox.Text = resources.GetString("InfoAboutOverViewRichTextBox.Text");
            // 
            // OkCloseMeButton
            // 
            this.OkCloseMeButton.Location = new System.Drawing.Point(597, 339);
            this.OkCloseMeButton.Name = "OkCloseMeButton";
            this.OkCloseMeButton.Size = new System.Drawing.Size(116, 34);
            this.OkCloseMeButton.TabIndex = 1;
            this.OkCloseMeButton.Text = "OK";
            this.OkCloseMeButton.UseVisualStyleBackColor = true;
            this.OkCloseMeButton.Click += new System.EventHandler(this.OkCloseMeButton_Click);
            // 
            // InfoParkingLotColoursScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 387);
            this.Controls.Add(this.OkCloseMeButton);
            this.Controls.Add(this.InfoAboutOverViewRichTextBox);
            this.Name = "InfoParkingLotColoursScreen";
            this.Text = "InfoParkingLotColoursScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox InfoAboutOverViewRichTextBox;
        private Button OkCloseMeButton;
    }
}