namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Detain_License
{
    partial class frmReleaseDetainedLicense
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
            this.ctrlLicenseSearch1 = new Driving_and_Vehicle_License_Department_Project.Controls.License.ctrlLicenseSearch();
            this.lblAddUpdate = new System.Windows.Forms.Label();
            this.lblShowLicenseInfo = new System.Windows.Forms.Label();
            this.lblShowLicensesHistory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblRApplicationID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLicenseSearch1
            // 
            this.ctrlLicenseSearch1.Location = new System.Drawing.Point(1, 15);
            this.ctrlLicenseSearch1.Name = "ctrlLicenseSearch1";
            this.ctrlLicenseSearch1.Size = new System.Drawing.Size(825, 424);
            this.ctrlLicenseSearch1.TabIndex = 0;
            this.ctrlLicenseSearch1.onLicenseID += new System.Action<int>(this.ctrlLicenseSearch1_onLicenseID);
            // 
            // lblAddUpdate
            // 
            this.lblAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddUpdate.AutoSize = true;
            this.lblAddUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdate.Location = new System.Drawing.Point(329, -1);
            this.lblAddUpdate.Name = "lblAddUpdate";
            this.lblAddUpdate.Size = new System.Drawing.Size(230, 24);
            this.lblAddUpdate.TabIndex = 41;
            this.lblAddUpdate.Text = "Release Detained License";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(122, 641);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(95, 13);
            this.lblShowLicenseInfo.TabIndex = 94;
            this.lblShowLicenseInfo.Text = "Show License Info";
            this.lblShowLicenseInfo.Click += new System.EventHandler(this.lblShowLicenseInfo_Click);
            // 
            // lblShowLicensesHistory
            // 
            this.lblShowLicensesHistory.AutoSize = true;
            this.lblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicensesHistory.ForeColor = System.Drawing.Color.Navy;
            this.lblShowLicensesHistory.Location = new System.Drawing.Point(5, 641);
            this.lblShowLicensesHistory.Name = "lblShowLicensesHistory";
            this.lblShowLicensesHistory.Size = new System.Drawing.Size(114, 13);
            this.lblShowLicensesHistory.TabIndex = 93;
            this.lblShowLicensesHistory.Text = "Show Licenses History";
            this.lblShowLicensesHistory.Click += new System.EventHandler(this.lblShowLicensesHistory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.lblRApplicationID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTotalFees);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lblFineFees);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblApplicationFees);
            this.groupBox2.Controls.Add(this.lblLicenseID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblDetainDate);
            this.groupBox2.Controls.Add(this.lblDetainID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 183);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain Info";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.PersonID;
            this.pictureBox6.Location = new System.Drawing.Point(595, 132);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 104;
            this.pictureBox6.TabStop = false;
            // 
            // lblRApplicationID
            // 
            this.lblRApplicationID.AutoSize = true;
            this.lblRApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblRApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRApplicationID.Location = new System.Drawing.Point(634, 144);
            this.lblRApplicationID.Name = "lblRApplicationID";
            this.lblRApplicationID.Size = new System.Drawing.Size(28, 16);
            this.lblRApplicationID.TabIndex = 103;
            this.lblRApplicationID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 101;
            this.label3.Text = "R.Application ID:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(228, 144);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(28, 16);
            this.lblTotalFees.TabIndex = 100;
            this.lblTotalFees.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 98;
            this.label8.Text = "Total Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Fees;
            this.pictureBox3.Location = new System.Drawing.Point(183, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 99;
            this.pictureBox3.TabStop = false;
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(634, 104);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(28, 16);
            this.lblFineFees.TabIndex = 97;
            this.lblFineFees.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Fine Fees:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Fees;
            this.pictureBox2.Location = new System.Drawing.Point(595, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(228, 103);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(28, 16);
            this.lblApplicationFees.TabIndex = 94;
            this.lblApplicationFees.Text = "???";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(634, 24);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(28, 16);
            this.lblLicenseID.TabIndex = 93;
            this.lblLicenseID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "License ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.License_Class;
            this.pictureBox1.Location = new System.Drawing.Point(595, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(634, 66);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(28, 16);
            this.lblCreatedBy.TabIndex = 89;
            this.lblCreatedBy.Text = "???";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(228, 66);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(28, 16);
            this.lblDetainDate.TabIndex = 87;
            this.lblDetainDate.Text = "???";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(228, 29);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(28, 16);
            this.lblDetainID.TabIndex = 81;
            this.lblDetainID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Detain ID:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.profile;
            this.pictureBox10.Location = new System.Drawing.Point(595, 52);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(33, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 80;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.PersonID;
            this.pictureBox4.Location = new System.Drawing.Point(183, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Birth_Date1;
            this.pictureBox8.Location = new System.Drawing.Point(183, 52);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 78;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Application Fees:";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Fees;
            this.pictureBox12.Location = new System.Drawing.Point(183, 91);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(33, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 74;
            this.pictureBox12.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(437, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 20);
            this.label14.TabIndex = 73;
            this.label14.Text = "Created By:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 70;
            this.label12.Text = "Detain Date:";
            // 
            // btnRenew
            // 
            this.btnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenew.Enabled = false;
            this.btnRenew.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Release;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(741, 634);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(80, 24);
            this.btnRenew.TabIndex = 95;
            this.btnRenew.Text = "Release";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(655, 634);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAddUpdate);
            this.Controls.Add(this.ctrlLicenseSearch1);
            this.Name = "frmReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReleaseDetainedLicense";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReleaseDetainedLicense_FormClosed);
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.License.ctrlLicenseSearch ctrlLicenseSearch1;
        private System.Windows.Forms.Label lblAddUpdate;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Label lblShowLicenseInfo;
        private System.Windows.Forms.Label lblShowLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRApplicationID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}