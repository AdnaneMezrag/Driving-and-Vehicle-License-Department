using Driving_and_Vehicle_License_Department_Project.Controls.Application;

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types
{
    partial class frmScheduleTest
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
            this.ctrlScheduleTest1 = new Driving_and_Vehicle_License_Department_Project.Controls.Application.ctrlScheduleTest((ctrlScheduleTest.enTestType)this.TestType, this._LDLAppID, this._TestAppointmentID);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(5, 7);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(446, 642);
            this.ctrlScheduleTest1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(199, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 34;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmScheduleTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScheduleTest_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Application.ctrlScheduleTest ctrlScheduleTest1;
        private System.Windows.Forms.Button button1;
    }
}