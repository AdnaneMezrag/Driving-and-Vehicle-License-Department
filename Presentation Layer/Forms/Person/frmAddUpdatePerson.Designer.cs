namespace Driving_and_Vehicle_License_Department_Project
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.ctrlAddUpdatePerson1 = new Driving_and_Vehicle_License_Department_Project.ctrlAddUpdatePerson();
            this.SuspendLayout();
            // 
            // ctrlAddUpdatePerson1
            // 
            this.ctrlAddUpdatePerson1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlAddUpdatePerson1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlAddUpdatePerson1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlAddUpdatePerson1.BackgroundImage")));
            this.ctrlAddUpdatePerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlAddUpdatePerson1.Location = new System.Drawing.Point(1, 0);
            this.ctrlAddUpdatePerson1.Name = "ctrlAddUpdatePerson1";
            this.ctrlAddUpdatePerson1.Size = new System.Drawing.Size(871, 424);
            this.ctrlAddUpdatePerson1.TabIndex = 0;
            this.ctrlAddUpdatePerson1.onSaveComplete += new System.Action<bool, int>(this.ctrlAddUpdatePerson1_onSaveComplete);
            this.ctrlAddUpdatePerson1.onClose += new System.Action(this.ctrlAddUpdatePerson1_onClose);
            this.ctrlAddUpdatePerson1.Load += new System.EventHandler(this.ctrlAddUpdatePerson1_Load);
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 421);
            this.Controls.Add(this.ctrlAddUpdatePerson1);
            this.Name = "frmAddUpdatePerson";
            this.Text = "frmAddUpdatePerson";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAddUpdatePerson ctrlAddUpdatePerson1;
    }
}