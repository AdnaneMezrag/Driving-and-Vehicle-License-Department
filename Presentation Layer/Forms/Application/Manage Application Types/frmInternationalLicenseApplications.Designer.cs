namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types
{
    partial class frmInternationalLicenseApplications
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
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.tbFilterApplications = new System.Windows.Forms.TextBox();
            this.cbFilterInternationalLicenses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAddApplication = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(82, 412);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 17);
            this.lblRecords.TabIndex = 51;
            this.lblRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "#Records:";
            // 
            // cbIsActive
            // 
            this.cbIsActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIsActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbIsActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "True",
            "False"});
            this.cbIsActive.Location = new System.Drawing.Point(242, 110);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(151, 24);
            this.cbIsActive.TabIndex = 48;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // tbFilterApplications
            // 
            this.tbFilterApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFilterApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterApplications.Location = new System.Drawing.Point(242, 110);
            this.tbFilterApplications.Name = "tbFilterApplications";
            this.tbFilterApplications.Size = new System.Drawing.Size(151, 23);
            this.tbFilterApplications.TabIndex = 47;
            this.tbFilterApplications.Visible = false;
            this.tbFilterApplications.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilterApplications_KeyUp);
            // 
            // cbFilterInternationalLicenses
            // 
            this.cbFilterInternationalLicenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterInternationalLicenses.BackColor = System.Drawing.Color.White;
            this.cbFilterInternationalLicenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterInternationalLicenses.FormattingEnabled = true;
            this.cbFilterInternationalLicenses.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Driver ID",
            "L.License ID",
            "Is Active"});
            this.cbFilterInternationalLicenses.Location = new System.Drawing.Point(85, 109);
            this.cbFilterInternationalLicenses.Name = "cbFilterInternationalLicenses";
            this.cbFilterInternationalLicenses.Size = new System.Drawing.Size(151, 24);
            this.cbFilterInternationalLicenses.TabIndex = 46;
            this.cbFilterInternationalLicenses.SelectedIndexChanged += new System.EventHandler(this.cbFilterInternationalLicenses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Filter By :";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsApplications;
            this.dgvInternationalLicenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(6, 139);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(859, 256);
            this.dgvInternationalLicenses.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(307, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "International License Applications";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.International_Driver_License;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(396, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 78);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pbAddApplication
            // 
            this.pbAddApplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAddApplication.BackColor = System.Drawing.Color.Transparent;
            this.pbAddApplication.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Add_Application;
            this.pbAddApplication.Location = new System.Drawing.Point(821, 95);
            this.pbAddApplication.Name = "pbAddApplication";
            this.pbAddApplication.Size = new System.Drawing.Size(44, 39);
            this.pbAddApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddApplication.TabIndex = 49;
            this.pbAddApplication.TabStop = false;
            this.pbAddApplication.Click += new System.EventHandler(this.pbAddApplication_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(785, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 44;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsApplications.Name = "cmsPerson";
            this.cmsApplications.Size = new System.Drawing.Size(226, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_Details;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showToolStripMenuItem.Text = "Show Person Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Checked = true;
            this.showLicenseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLicenseToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_License;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License Details";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_License_History;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAddApplication);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.tbFilterApplications);
            this.Controls.Add(this.cbFilterInternationalLicenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Controls.Add(this.label1);
            this.Name = "frmInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInternationalLicenseApplications";
            this.Load += new System.EventHandler(this.frmInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAddApplication;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.TextBox tbFilterApplications;
        private System.Windows.Forms.ComboBox cbFilterInternationalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}