namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services
{
    partial class frmNewInternationalLicenseApplication
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
            this.ctrlApplicationInfo1 = new Driving_and_Vehicle_License_Department_Project.Controls.Application.ctrlApplicationInfo();
            this.ctrlLicenseSearch1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlLicenseSearch();
            this.lblShowLicensesHistory = new System.Windows.Forms.Label();
            this.lblShowLicenseInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUpdate
            // 
            this.lblAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddUpdate.AutoSize = true;
            this.lblAddUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdate.Location = new System.Drawing.Point(314, -1);
            this.lblAddUpdate.Name = "lblAddUpdate";
            this.lblAddUpdate.Size = new System.Drawing.Size(280, 24);
            this.lblAddUpdate.TabIndex = 39;
            this.lblAddUpdate.Text = "International License Application";
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(0, 446);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(826, 192);
            this.ctrlApplicationInfo1.TabIndex = 43;
            // 
            // ctrlLicenseSearch1
            // 
            this.ctrlLicenseSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlLicenseSearch1.Location = new System.Drawing.Point(0, 26);
            this.ctrlLicenseSearch1.Name = "ctrlLicenseSearch1";
            this.ctrlLicenseSearch1.Size = new System.Drawing.Size(831, 426);
            this.ctrlLicenseSearch1.TabIndex = 42;
            this.ctrlLicenseSearch1.onLicenseID += new System.Action<int>(this.ctrlLicenseSearch1_onLicenseID);
            // 
            // lblShowLicensesHistory
            // 
            this.lblShowLicensesHistory.AutoSize = true;
            this.lblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicensesHistory.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicensesHistory.Location = new System.Drawing.Point(3, 640);
            this.lblShowLicensesHistory.Name = "lblShowLicensesHistory";
            this.lblShowLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.lblShowLicensesHistory.TabIndex = 44;
            this.lblShowLicensesHistory.Text = "Show Licenses History";
            this.lblShowLicensesHistory.Click += new System.EventHandler(this.lblShowLicensesHistory_Click);
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(123, 640);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lblShowLicenseInfo.TabIndex = 45;
            this.lblShowLicenseInfo.Text = "Show License Info";
            this.lblShowLicenseInfo.Click += new System.EventHandler(this.lblShowLicenseInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(659, 637);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssue.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Issue;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(745, 637);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(80, 24);
            this.btnIssue.TabIndex = 40;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // frmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 663);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicensesHistory);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.ctrlLicenseSearch1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblAddUpdate);
            this.Name = "frmNewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewInternationalLicenseApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddUpdate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private Controls.License.ctrlLicenseSearch ctrlLicenseSearch1;
        private Controls.Application.ctrlApplicationInfo ctrlApplicationInfo1;
        private System.Windows.Forms.Label lblShowLicensesHistory;
        private System.Windows.Forms.Label lblShowLicenseInfo;
    }
}