namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services
{
    partial class frmReplacementForLostOrDamagedLicense
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
            this.lblReplacementFor = new System.Windows.Forms.Label();
            this.ctrlLicenseSearch1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlLicenseSearch();
            this.ctrlApplicationInfoForLicenseReplacement1 = new Driving_and_Vehicle_License_Department_Project.Controls.Application.ctrlApplicationInfoForLicenseReplacement();
            this.lblShowLicenseInfo = new System.Windows.Forms.Label();
            this.lblShowLicensesHistory = new System.Windows.Forms.Label();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReplacementFor
            // 
            this.lblReplacementFor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReplacementFor.AutoSize = true;
            this.lblReplacementFor.BackColor = System.Drawing.Color.Transparent;
            this.lblReplacementFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacementFor.ForeColor = System.Drawing.Color.Red;
            this.lblReplacementFor.Location = new System.Drawing.Point(272, 1);
            this.lblReplacementFor.Name = "lblReplacementFor";
            this.lblReplacementFor.Size = new System.Drawing.Size(314, 24);
            this.lblReplacementFor.TabIndex = 41;
            this.lblReplacementFor.Text = "Replacement For Damaged License";
            // 
            // ctrlLicenseSearch1
            // 
            this.ctrlLicenseSearch1.Location = new System.Drawing.Point(2, 28);
            this.ctrlLicenseSearch1.Name = "ctrlLicenseSearch1";
            this.ctrlLicenseSearch1.Size = new System.Drawing.Size(825, 424);
            this.ctrlLicenseSearch1.TabIndex = 42;
            this.ctrlLicenseSearch1.onLicenseID += new System.Action<int>(this.ctrlLicenseSearch1_onLicenseID);
            // 
            // ctrlApplicationInfoForLicenseReplacement1
            // 
            this.ctrlApplicationInfoForLicenseReplacement1.Location = new System.Drawing.Point(0, 448);
            this.ctrlApplicationInfoForLicenseReplacement1.Name = "ctrlApplicationInfoForLicenseReplacement1";
            this.ctrlApplicationInfoForLicenseReplacement1.Size = new System.Drawing.Size(826, 168);
            this.ctrlApplicationInfoForLicenseReplacement1.TabIndex = 43;
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(121, 627);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(120, 13);
            this.lblShowLicenseInfo.TabIndex = 53;
            this.lblShowLicenseInfo.Text = "Show New License Info";
            this.lblShowLicenseInfo.Click += new System.EventHandler(this.lblShowLicenseInfo_Click);
            // 
            // lblShowLicensesHistory
            // 
            this.lblShowLicensesHistory.AutoSize = true;
            this.lblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicensesHistory.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicensesHistory.Location = new System.Drawing.Point(1, 627);
            this.lblShowLicensesHistory.Name = "lblShowLicensesHistory";
            this.lblShowLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.lblShowLicensesHistory.TabIndex = 52;
            this.lblShowLicensesHistory.Text = "Show Licenses History";
            this.lblShowLicensesHistory.Click += new System.EventHandler(this.lblShowLicensesHistory_Click);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Location = new System.Drawing.Point(603, 30);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(217, 60);
            this.gbReplacementFor.TabIndex = 54;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(10, 38);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(85, 17);
            this.rbLostLicense.TabIndex = 56;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(10, 17);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(111, 17);
            this.rbDamagedLicense.TabIndex = 55;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(659, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenew.Enabled = false;
            this.btnRenew.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Replace;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(745, 620);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(80, 24);
            this.btnRenew.TabIndex = 50;
            this.btnRenew.Text = "Replace";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // frmReplacementForLostOrDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 651);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.ctrlApplicationInfoForLicenseReplacement1);
            this.Controls.Add(this.ctrlLicenseSearch1);
            this.Controls.Add(this.lblReplacementFor);
            this.Name = "frmReplacementForLostOrDamagedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReplacementForLostOrDamagedLicense";
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReplacementFor;
        private Controls.License.ctrlLicenseSearch ctrlLicenseSearch1;
        private Controls.Application.ctrlApplicationInfoForLicenseReplacement ctrlApplicationInfoForLicenseReplacement1;
        private System.Windows.Forms.Label lblShowLicenseInfo;
        private System.Windows.Forms.Label lblShowLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}