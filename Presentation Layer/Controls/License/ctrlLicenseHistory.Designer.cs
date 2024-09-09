namespace Driving_and_Vehicle_License_Department_Project.Controls.License
{
    partial class ctrlLicenseHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlDriverLicenses1 = new Driving_and_Vehicle_License_Department_Project.Controls.ctrlDriverLicenses();
            this.ctrlPersonSearch1 = new Driving_and_Vehicle_License_Department_Project.Controls.Person.ctrlPersonSearch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.document;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(2, 358);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(836, 230);
            this.ctrlDriverLicenses1.TabIndex = 4;
            // 
            // ctrlPersonSearch1
            // 
            this.ctrlPersonSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPersonSearch1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonSearch1.Location = new System.Drawing.Point(156, 2);
            this.ctrlPersonSearch1.Name = "ctrlPersonSearch1";
            this.ctrlPersonSearch1.Size = new System.Drawing.Size(823, 362);
            this.ctrlPersonSearch1.TabIndex = 1;
            // 
            // ctrlLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlPersonSearch1);
            this.Name = "ctrlLicenseHistory";
            this.Size = new System.Drawing.Size(961, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Person.ctrlPersonSearch ctrlPersonSearch1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ctrlDriverLicenses ctrlDriverLicenses1;
    }
}
