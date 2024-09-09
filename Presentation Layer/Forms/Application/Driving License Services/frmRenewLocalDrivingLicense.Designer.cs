namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services
{
    partial class frmRenewLocalDrivingLicense
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
            this.lblAddUpdate = new System.Windows.Forms.Label();
            this.lblShowLicenseInfo = new System.Windows.Forms.Label();
            this.lblShowLicensesHistory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.ctrlApplicationNewLicenseInfo1 = new Driving_and_Vehicle_License_Department_Project.Controls.Application.ctrlApplicationNewLicenseInfo();
            this.ctrlLicenseSearch1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlLicenseSearch();
            this.SuspendLayout();
            // 
            // lblAddUpdate
            // 
            this.lblAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddUpdate.AutoSize = true;
            this.lblAddUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdate.Location = new System.Drawing.Point(291, -2);
            this.lblAddUpdate.Name = "lblAddUpdate";
            this.lblAddUpdate.Size = new System.Drawing.Size(239, 24);
            this.lblAddUpdate.TabIndex = 40;
            this.lblAddUpdate.Text = "Renew License Application";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(120, 682);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(120, 13);
            this.lblShowLicenseInfo.TabIndex = 49;
            this.lblShowLicenseInfo.Text = "Show New License Info";
            this.lblShowLicenseInfo.Click += new System.EventHandler(this.lblShowLicenseInfo_Click);
            // 
            // lblShowLicensesHistory
            // 
            this.lblShowLicensesHistory.AutoSize = true;
            this.lblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicensesHistory.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicensesHistory.Location = new System.Drawing.Point(0, 682);
            this.lblShowLicensesHistory.Name = "lblShowLicensesHistory";
            this.lblShowLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.lblShowLicensesHistory.TabIndex = 48;
            this.lblShowLicensesHistory.Text = "Show Licenses History";
            this.lblShowLicensesHistory.Click += new System.EventHandler(this.lblShowLicensesHistory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(660, 673);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenew.Enabled = false;
            this.btnRenew.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Renew;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(746, 673);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(80, 24);
            this.btnRenew.TabIndex = 46;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlApplicationNewLicenseInfo1
            // 
            this.ctrlApplicationNewLicenseInfo1.Location = new System.Drawing.Point(0, 423);
            this.ctrlApplicationNewLicenseInfo1.Name = "ctrlApplicationNewLicenseInfo1";
            this.ctrlApplicationNewLicenseInfo1.Size = new System.Drawing.Size(837, 249);
            this.ctrlApplicationNewLicenseInfo1.TabIndex = 50;
            // 
            // ctrlLicenseSearch1
            // 
            this.ctrlLicenseSearch1.Location = new System.Drawing.Point(3, 18);
            this.ctrlLicenseSearch1.Name = "ctrlLicenseSearch1";
            this.ctrlLicenseSearch1.Size = new System.Drawing.Size(825, 404);
            this.ctrlLicenseSearch1.TabIndex = 0;
            this.ctrlLicenseSearch1.onLicenseID += new System.Action<int>(this.ctrlLicenseSearch1_onLicenseID);
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 698);
            this.Controls.Add(this.ctrlApplicationNewLicenseInfo1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lblAddUpdate);
            this.Controls.Add(this.ctrlLicenseSearch1);
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewLocalDrivingLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.License.ctrlLicenseSearch ctrlLicenseSearch1;
        private System.Windows.Forms.Label lblAddUpdate;
        private System.Windows.Forms.Label lblShowLicenseInfo;
        private System.Windows.Forms.Label lblShowLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
        private Controls.Application.ctrlApplicationNewLicenseInfo ctrlApplicationNewLicenseInfo1;
    }
}