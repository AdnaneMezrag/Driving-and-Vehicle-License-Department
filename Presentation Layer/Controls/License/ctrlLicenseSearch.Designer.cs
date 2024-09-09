namespace Driving_and_Vehicle_License_Department_Project.Controls.License
{
    partial class ctrlLicenseSearch
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
            this.ctrlLicenseFilter1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlLicenseFilter();
            this.ctrlLicenseInfo1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlLicenseInfo();
            this.SuspendLayout();
            // 
            // ctrlLicenseFilter1
            // 
            this.ctrlLicenseFilter1.Location = new System.Drawing.Point(0, -1);
            this.ctrlLicenseFilter1.Name = "ctrlLicenseFilter1";
            this.ctrlLicenseFilter1.Size = new System.Drawing.Size(599, 68);
            this.ctrlLicenseFilter1.TabIndex = 0;
            this.ctrlLicenseFilter1.onLicenseID += new System.Action<int>(this.ctrlLicenseFilter1_onLicenseID);
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(-3, 61);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(825, 423);
            this.ctrlLicenseInfo1.TabIndex = 1;
            // 
            // ctrlLicenseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.ctrlLicenseFilter1);
            this.Name = "ctrlLicenseSearch";
            this.Size = new System.Drawing.Size(825, 424);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLicenseFilter ctrlLicenseFilter1;
        private ctrlLicenseInfo ctrlLicenseInfo1;
    }
}
