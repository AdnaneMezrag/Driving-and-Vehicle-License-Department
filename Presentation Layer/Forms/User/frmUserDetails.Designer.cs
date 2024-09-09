namespace Driving_and_Vehicle_License_Department_Project
{
    partial class frmUserDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlUserDetails2 = new Driving_and_Vehicle_License_Department_Project.ctrlUserDetails(this._UserID);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(733, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlUserDetails2
            // 
            this.ctrlUserDetails2.Location = new System.Drawing.Point(-5, -4);
            this.ctrlUserDetails2.Name = "ctrlUserDetails2";
            this.ctrlUserDetails2.Size = new System.Drawing.Size(835, 390);
            this.ctrlUserDetails2.TabIndex = 37;
            this.ctrlUserDetails2.Load += new System.EventHandler(this.ctrlUserDetails2_Load);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 443);
            this.Controls.Add(this.ctrlUserDetails2);
            this.Controls.Add(this.button1);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserDetails ctrlUserDetails1;
        private System.Windows.Forms.Button button1;
        private ctrlUserDetails ctrlUserDetails2;
    }
}