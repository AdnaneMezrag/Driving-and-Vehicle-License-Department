namespace Driving_and_Vehicle_License_Department_Project.Forms.License
{
    partial class frmInternationalLicenseInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddUpdate = new System.Windows.Forms.Label();
            this.ctrlInternationalLicenseInfo1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlInternationalLicenseInfo();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.International_Driver_License;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(298, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 103);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddUpdate
            // 
            this.lblAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddUpdate.AutoSize = true;
            this.lblAddUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdate.Location = new System.Drawing.Point(263, 108);
            this.lblAddUpdate.Name = "lblAddUpdate";
            this.lblAddUpdate.Size = new System.Drawing.Size(271, 24);
            this.lblAddUpdate.TabIndex = 34;
            this.lblAddUpdate.Text = "Driver International License Info";
            // 
            // ctrlInternationalLicenseInfo1
            // 
            this.ctrlInternationalLicenseInfo1.Location = new System.Drawing.Point(7, 134);
            this.ctrlInternationalLicenseInfo1.Name = "ctrlInternationalLicenseInfo1";
            this.ctrlInternationalLicenseInfo1.Size = new System.Drawing.Size(823, 278);
            this.ctrlInternationalLicenseInfo1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(748, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 37;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlInternationalLicenseInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddUpdate);
            this.Name = "frmInternationalLicenseInfo";
            this.Text = "frmInternationalLicenseInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddUpdate;
        private Controls.License.ctrlInternationalLicenseInfo ctrlInternationalLicenseInfo1;
        private System.Windows.Forms.Button button1;
    }
}