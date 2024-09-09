namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types
{
    partial class frmTestAppointment
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
            this.lblTestAppointment = new System.Windows.Forms.Label();
            this.pbTestAppointment = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.df = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.takeExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlLDLAppInformation2 = new Driving_and_Vehicle_License_Department_Project.Controls.Application.ctrlLDLAppInformation(this._LDLAppID);
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTestAppointment
            // 
            this.lblTestAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTestAppointment.AutoSize = true;
            this.lblTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblTestAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAppointment.ForeColor = System.Drawing.Color.Red;
            this.lblTestAppointment.Location = new System.Drawing.Point(295, 3);
            this.lblTestAppointment.Name = "lblTestAppointment";
            this.lblTestAppointment.Size = new System.Drawing.Size(215, 24);
            this.lblTestAppointment.TabIndex = 32;
            this.lblTestAppointment.Text = "Vision Test Appointment";
            // 
            // pbTestAppointment
            // 
            this.pbTestAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.pbTestAppointment.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Vision_Test;
            this.pbTestAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTestAppointment.Location = new System.Drawing.Point(353, 31);
            this.pbTestAppointment.Name = "pbTestAppointment";
            this.pbTestAppointment.Size = new System.Drawing.Size(110, 77);
            this.pbTestAppointment.TabIndex = 33;
            this.pbTestAppointment.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.appointment;
            this.pictureBox8.Location = new System.Drawing.Point(777, 486);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 79;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // df
            // 
            this.df.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.df.AutoSize = true;
            this.df.BackColor = System.Drawing.Color.Transparent;
            this.df.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.df.Location = new System.Drawing.Point(12, 654);
            this.df.Name = "df";
            this.df.Size = new System.Drawing.Size(82, 17);
            this.df.TabIndex = 82;
            this.df.Text = "#Records:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(736, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 81;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.AllowUserToDeleteRows = false;
            this.dgvTestAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvTestAppointments.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTestAppointments.Location = new System.Drawing.Point(15, 521);
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            this.dgvTestAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTestAppointments.Size = new System.Drawing.Size(795, 133);
            this.dgvTestAppointments.TabIndex = 80;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editToolStripMenuItem1,
            this.toolStripSeparator2,
            this.takeExamToolStripMenuItem});
            this.cmsAppointments.Name = "cmsPerson";
            this.cmsAppointments.Size = new System.Drawing.Size(130, 60);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // takeExamToolStripMenuItem
            // 
            this.takeExamToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Take_Exam;
            this.takeExamToolStripMenuItem.Name = "takeExamToolStripMenuItem";
            this.takeExamToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.takeExamToolStripMenuItem.Text = "Take Exam";
            this.takeExamToolStripMenuItem.Click += new System.EventHandler(this.takeExamToolStripMenuItem_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Appointments:";
            // 
            // ctrlLDLAppInformation2
            // 
            this.ctrlLDLAppInformation2.Location = new System.Drawing.Point(13, 112);
            this.ctrlLDLAppInformation2.Name = "ctrlLDLAppInformation2";
            this.ctrlLDLAppInformation2.Size = new System.Drawing.Size(804, 372);
            this.ctrlLDLAppInformation2.TabIndex = 84;
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(91, 655);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 17);
            this.lblRecords.TabIndex = 85;
            this.lblRecords.Text = "0";
            // 
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 683);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.ctrlLDLAppInformation2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.df);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pbTestAppointment);
            this.Controls.Add(this.lblTestAppointment);
            this.Name = "frmTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisionTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTestAppointment_FormClosed);
            this.Load += new System.EventHandler(this.frmVisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Application.ctrlLDLAppInformation ctrlLDLAppInformation1;
        private System.Windows.Forms.Label lblTestAppointment;
        private System.Windows.Forms.PictureBox pbTestAppointment;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label df;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTestAppointments;
        private System.Windows.Forms.Label label2;
        private Controls.Application.ctrlLDLAppInformation ctrlLDLAppInformation2;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem takeExamToolStripMenuItem;
        private System.Windows.Forms.Label lblRecords;
    }
}