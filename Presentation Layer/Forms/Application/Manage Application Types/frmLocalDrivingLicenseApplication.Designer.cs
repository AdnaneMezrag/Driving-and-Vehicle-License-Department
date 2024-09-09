namespace Driving_and_Vehicle_License_Department_Project.Forms.Application
{
    partial class frmLocalDrivingLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilterApplications = new System.Windows.Forms.TextBox();
            this.cbFilterApplications = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAddApplication = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(86, 460);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 17);
            this.lblRecords.TabIndex = 40;
            this.lblRecords.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "#Records:";
            // 
            // tbFilterApplications
            // 
            this.tbFilterApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFilterApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterApplications.Location = new System.Drawing.Point(246, 158);
            this.tbFilterApplications.Name = "tbFilterApplications";
            this.tbFilterApplications.Size = new System.Drawing.Size(151, 23);
            this.tbFilterApplications.TabIndex = 36;
            this.tbFilterApplications.Visible = false;
            this.tbFilterApplications.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilterUsers_KeyUp);
            // 
            // cbFilterApplications
            // 
            this.cbFilterApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterApplications.BackColor = System.Drawing.Color.White;
            this.cbFilterApplications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterApplications.FormattingEnabled = true;
            this.cbFilterApplications.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilterApplications.Location = new System.Drawing.Point(89, 157);
            this.cbFilterApplications.Name = "cbFilterApplications";
            this.cbFilterApplications.Size = new System.Drawing.Size(151, 24);
            this.cbFilterApplications.TabIndex = 35;
            this.cbFilterApplications.SelectedIndexChanged += new System.EventHandler(this.cbFilterUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Filter By :";
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLDLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.cmsApplications;
            this.dgvLDLApplications.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLDLApplications.Location = new System.Drawing.Point(10, 187);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLDLApplications.Size = new System.Drawing.Size(859, 256);
            this.dgvLDLApplications.TabIndex = 32;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.AddNewApplicationToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.CancelToolStripMenuItem,
            this.toolStripSeparator2,
            this.ScheduleTestToolStripMenuItem,
            this.IssueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsApplications.Name = "cmsPerson";
            this.cmsApplications.Size = new System.Drawing.Size(246, 214);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsUser_Opening);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_Details;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showToolStripMenuItem.Text = "Show Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // AddNewApplicationToolStripMenuItem
            // 
            this.AddNewApplicationToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Add_New_Person;
            this.AddNewApplicationToolStripMenuItem.Name = "AddNewApplicationToolStripMenuItem";
            this.AddNewApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.AddNewApplicationToolStripMenuItem.Text = "Add New Application";
            this.AddNewApplicationToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Cancel_Application;
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.CancelToolStripMenuItem.Text = "Cancel Application";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // ScheduleTestToolStripMenuItem
            // 
            this.ScheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.ScheduleTestToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Schedule_Test;
            this.ScheduleTestToolStripMenuItem.Name = "ScheduleTestToolStripMenuItem";
            this.ScheduleTestToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ScheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
            this.scheduleVisionTestToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Vision_Test;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Written_Test;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Street_Test;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // IssueDrivingLicenseToolStripMenuItem
            // 
            this.IssueDrivingLicenseToolStripMenuItem.Enabled = false;
            this.IssueDrivingLicenseToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Issue_Driving_License__First_Time_;
            this.IssueDrivingLicenseToolStripMenuItem.Name = "IssueDrivingLicenseToolStripMenuItem";
            this.IssueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.IssueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.IssueDrivingLicenseToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_License;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_License_History;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Local Drving License Applications";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Driving_License_Services;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 78);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pbAddApplication
            // 
            this.pbAddApplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAddApplication.BackColor = System.Drawing.Color.Transparent;
            this.pbAddApplication.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Add_Application;
            this.pbAddApplication.Location = new System.Drawing.Point(825, 143);
            this.pbAddApplication.Name = "pbAddApplication";
            this.pbAddApplication.Size = new System.Drawing.Size(44, 39);
            this.pbAddApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddApplication.TabIndex = 38;
            this.pbAddApplication.TabStop = false;
            this.pbAddApplication.Click += new System.EventHandler(this.pbAddApplication_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(789, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed",
            "Canceled"});
            this.cbStatus.Location = new System.Drawing.Point(246, 158);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 24);
            this.cbStatus.TabIndex = 37;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // frmLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAddApplication);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbFilterApplications);
            this.Controls.Add(this.cbFilterApplications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLDLApplications);
            this.Controls.Add(this.label1);
            this.Name = "frmLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAddApplication;
        private System.Windows.Forms.TextBox tbFilterApplications;
        private System.Windows.Forms.ComboBox cbFilterApplications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddNewApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}