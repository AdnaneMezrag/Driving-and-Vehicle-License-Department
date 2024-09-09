namespace Driving_and_Vehicle_License_Department_Project.Controls.Person
{
    partial class ctrlPersonSearch
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
            this.ctrlPersonFilter1 = new Driving_and_Vehicle_License_Department_Project.ctrlPersonFilter();
            this.ctrlPersonDetails1 = new Driving_and_Vehicle_License_Department_Project.ctrlPersonDetails();
            this.SuspendLayout();
            // 
            // ctrlPersonFilter1
            // 
            this.ctrlPersonFilter1.Location = new System.Drawing.Point(3, 2);
            this.ctrlPersonFilter1.Name = "ctrlPersonFilter1";
            this.ctrlPersonFilter1.Size = new System.Drawing.Size(804, 63);
            this.ctrlPersonFilter1.TabIndex = 8;
            this.ctrlPersonFilter1.onPersonID += new System.Action<int>(this.ctrlPersonFilter1_onPersonID);
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlPersonDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 70);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(808, 294);
            this.ctrlPersonDetails1.TabIndex = 7;
            // 
            // ctrlPersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonFilter1);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "ctrlPersonSearch";
            this.Size = new System.Drawing.Size(823, 388);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonFilter ctrlPersonFilter1;
        private ctrlPersonDetails ctrlPersonDetails1;
    }
}
