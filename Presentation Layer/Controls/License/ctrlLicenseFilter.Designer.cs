namespace Driving_and_Vehicle_License_Department_Project.Controls.License
{
    partial class ctrlLicenseFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPersonSearcher = new System.Windows.Forms.PictureBox();
            this.tbFilterPeople = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonSearcher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPersonSearcher);
            this.groupBox1.Controls.Add(this.tbFilterPeople);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 60);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // pbPersonSearcher
            // 
            this.pbPersonSearcher.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonSearcher.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Person_Searcher;
            this.pbPersonSearcher.Location = new System.Drawing.Point(534, 14);
            this.pbPersonSearcher.Name = "pbPersonSearcher";
            this.pbPersonSearcher.Size = new System.Drawing.Size(38, 29);
            this.pbPersonSearcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonSearcher.TabIndex = 18;
            this.pbPersonSearcher.TabStop = false;
            this.pbPersonSearcher.Click += new System.EventHandler(this.pbPersonSearcher_Click);
            // 
            // tbFilterPeople
            // 
            this.tbFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterPeople.Location = new System.Drawing.Point(180, 19);
            this.tbFilterPeople.Name = "tbFilterPeople";
            this.tbFilterPeople.Size = new System.Drawing.Size(302, 23);
            this.tbFilterPeople.TabIndex = 16;
            this.tbFilterPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterPeople_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "License ID:";
            // 
            // ctrlLicenseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlLicenseFilter";
            this.Size = new System.Drawing.Size(599, 68);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonSearcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPersonSearcher;
        private System.Windows.Forms.TextBox tbFilterPeople;
        private System.Windows.Forms.Label label2;
    }
}
