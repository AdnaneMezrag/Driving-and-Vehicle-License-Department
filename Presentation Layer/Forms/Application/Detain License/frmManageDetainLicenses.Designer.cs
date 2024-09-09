namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Detain_License
{
    partial class frmManageDetainLicenses
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbDetainLicense = new System.Windows.Forms.PictureBox();
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            this.tbFilterDetainedLicenses = new System.Windows.Forms.TextBox();
            this.cbFilterDetainedLicenses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmsDetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbReleaseLicense = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetainLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cmsDetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReleaseLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Detain_License_01;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(403, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 78);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(81, 414);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 17);
            this.lblRecords.TabIndex = 51;
            this.lblRecords.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "#Records:";
            // 
            // pbDetainLicense
            // 
            this.pbDetainLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.pbDetainLicense.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Detain_License_01;
            this.pbDetainLicense.Location = new System.Drawing.Point(820, 101);
            this.pbDetainLicense.Name = "pbDetainLicense";
            this.pbDetainLicense.Size = new System.Drawing.Size(44, 39);
            this.pbDetainLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetainLicense.TabIndex = 49;
            this.pbDetainLicense.TabStop = false;
            this.pbDetainLicense.Click += new System.EventHandler(this.pbDetainLicense_Click);
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIsReleased.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbIsReleased.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(241, 115);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(151, 24);
            this.cbIsReleased.TabIndex = 48;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // tbFilterDetainedLicenses
            // 
            this.tbFilterDetainedLicenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFilterDetainedLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterDetainedLicenses.Location = new System.Drawing.Point(241, 116);
            this.tbFilterDetainedLicenses.Name = "tbFilterDetainedLicenses";
            this.tbFilterDetainedLicenses.Size = new System.Drawing.Size(151, 23);
            this.tbFilterDetainedLicenses.TabIndex = 47;
            this.tbFilterDetainedLicenses.Visible = false;
            this.tbFilterDetainedLicenses.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilterDetainedLicenses_KeyUp);
            // 
            // cbFilterDetainedLicenses
            // 
            this.cbFilterDetainedLicenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterDetainedLicenses.BackColor = System.Drawing.Color.White;
            this.cbFilterDetainedLicenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterDetainedLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterDetainedLicenses.FormattingEnabled = true;
            this.cbFilterDetainedLicenses.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.cbFilterDetainedLicenses.Location = new System.Drawing.Point(84, 115);
            this.cbFilterDetainedLicenses.Name = "cbFilterDetainedLicenses";
            this.cbFilterDetainedLicenses.Size = new System.Drawing.Size(151, 24);
            this.cbFilterDetainedLicenses.TabIndex = 46;
            this.cbFilterDetainedLicenses.SelectedIndexChanged += new System.EventHandler(this.cbFilterDetainedLicenses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Filter By :";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(785, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 44;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmsDetainedLicenses;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(5, 145);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(859, 256);
            this.dgvDetainedLicenses.TabIndex = 43;
            // 
            // cmsDetainedLicenses
            // 
            this.cmsDetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmsDetainedLicenses.Name = "cmsPerson";
            this.cmsDetainedLicenses.Size = new System.Drawing.Size(226, 120);
            this.cmsDetainedLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDetainedLicenses_Opening);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_Details;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showToolStripMenuItem.Text = "Show Person Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click_1);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Checked = true;
            this.showLicenseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLicenseToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_License;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License Details";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click_1);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_License_History;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click_1);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Release_Detained;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(370, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Detained Licenses";
            // 
            // pbReleaseLicense
            // 
            this.pbReleaseLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbReleaseLicense.BackColor = System.Drawing.Color.Transparent;
            this.pbReleaseLicense.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Release_Detained;
            this.pbReleaseLicense.Location = new System.Drawing.Point(766, 101);
            this.pbReleaseLicense.Name = "pbReleaseLicense";
            this.pbReleaseLicense.Size = new System.Drawing.Size(44, 39);
            this.pbReleaseLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReleaseLicense.TabIndex = 53;
            this.pbReleaseLicense.TabStop = false;
            this.pbReleaseLicense.Click += new System.EventHandler(this.pbReleaseLicense_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // frmManageDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 438);
            this.Controls.Add(this.pbReleaseLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbDetainLicense);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.tbFilterDetainedLicenses);
            this.Controls.Add(this.cbFilterDetainedLicenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.label1);
            this.Name = "frmManageDetainLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDetainLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetainLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cmsDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReleaseLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbDetainLicense;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.TextBox tbFilterDetainedLicenses;
        private System.Windows.Forms.ComboBox cbFilterDetainedLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbReleaseLicense;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}