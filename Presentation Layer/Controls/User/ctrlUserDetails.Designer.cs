using Business_Layer;

namespace Driving_and_Vehicle_License_Department_Project
{
    partial class ctrlUserDetails
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
            this.ctrlUserDetails1 = new Driving_and_Vehicle_License_Department_Project.ctrlUserLoginInformation();
            this.ctrlPersonDetails1 = new Driving_and_Vehicle_License_Department_Project.ctrlPersonDetails();

            this.SuspendLayout();
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Location = new System.Drawing.Point(19, 310);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(803, 66);
            this.ctrlUserDetails1.TabIndex = 39;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(19, 15);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(802, 292);
            this.ctrlPersonDetails1.TabIndex = 38;
            // 
            // ctrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlUserDetails1);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "ctrlUserDetails";
            this.Size = new System.Drawing.Size(835, 390);
            this.Load += new System.EventHandler(this.ctrlUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserLoginInformation ctrlUserDetails1;
        private ctrlPersonDetails ctrlPersonDetails1;
    }
}
