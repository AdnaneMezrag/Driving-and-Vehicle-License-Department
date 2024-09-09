namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types
{
    partial class frmIssueDrivingLicense
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
            this.ctrlLDLAppInformation1 = new Driving_and_Vehicle_License_Department_Project.Controls.Application.ctrlLDLAppInformation(this._LDLAppID);
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLDLAppInformation1
            // 
            this.ctrlLDLAppInformation1.Location = new System.Drawing.Point(1, 47);
            this.ctrlLDLAppInformation1.Name = "ctrlLDLAppInformation1";
            this.ctrlLDLAppInformation1.Size = new System.Drawing.Size(804, 375);
            this.ctrlLDLAppInformation1.TabIndex = 0;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(132, 438);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(668, 79);
            this.rtbNotes.TabIndex = 126;
            this.rtbNotes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 125;
            this.label3.Text = "Notes:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(294, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 128;
            this.label1.Text = "Issue Driving License";
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(720, 523);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(80, 24);
            this.btnIssue.TabIndex = 130;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(633, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 129;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Notes;
            this.pictureBox9.Location = new System.Drawing.Point(83, 438);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 127;
            this.pictureBox9.TabStop = false;
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 559);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlLDLAppInformation1);
            this.Name = "frmIssueDrivingLicense";
            this.Text = "frmIssueDrivingLicense";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIssueDrivingLicense_FormClosed);
            this.Load += new System.EventHandler(this.frmIssueDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.Application.ctrlLDLAppInformation ctrlLDLAppInformation1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
    }
}