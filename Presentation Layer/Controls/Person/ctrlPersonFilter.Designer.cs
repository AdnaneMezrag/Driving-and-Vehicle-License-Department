namespace Driving_and_Vehicle_License_Department_Project
{
    partial class ctrlPersonFilter
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
            this.tbFilterPeople = new System.Windows.Forms.TextBox();
            this.cbFilterPeople = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPersonSearcher = new System.Windows.Forms.PictureBox();
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonSearcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilterPeople
            // 
            this.tbFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterPeople.Location = new System.Drawing.Point(347, 20);
            this.tbFilterPeople.Name = "tbFilterPeople";
            this.tbFilterPeople.Size = new System.Drawing.Size(151, 23);
            this.tbFilterPeople.TabIndex = 16;
            this.tbFilterPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterPeople_KeyPress);
            // 
            // cbFilterPeople
            // 
            this.cbFilterPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterPeople.FormattingEnabled = true;
            this.cbFilterPeople.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFilterPeople.Location = new System.Drawing.Point(159, 19);
            this.cbFilterPeople.Name = "cbFilterPeople";
            this.cbFilterPeople.Size = new System.Drawing.Size(151, 24);
            this.cbFilterPeople.TabIndex = 15;
            this.cbFilterPeople.SelectedIndexChanged += new System.EventHandler(this.cbFilterPeople_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPersonSearcher);
            this.groupBox1.Controls.Add(this.pbAddPerson);
            this.groupBox1.Controls.Add(this.tbFilterPeople);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFilterPeople);
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 60);
            this.groupBox1.TabIndex = 17;
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
            this.pbPersonSearcher.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbPersonSearcher.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pbPersonSearcher.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.pbAddPerson.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Add_Person;
            this.pbAddPerson.Location = new System.Drawing.Point(594, 14);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(38, 29);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddPerson.TabIndex = 17;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            this.pbAddPerson.MouseEnter += new System.EventHandler(this.pbAddPerson_MouseEnter);
            this.pbAddPerson.MouseLeave += new System.EventHandler(this.pbAddPerson_MouseLeave);
            // 
            // ctrlPersonFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlPersonFilter";
            this.Size = new System.Drawing.Size(804, 63);
            this.Load += new System.EventHandler(this.ctrlPersonFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonSearcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilterPeople;
        private System.Windows.Forms.ComboBox cbFilterPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPersonSearcher;
        private System.Windows.Forms.PictureBox pbAddPerson;
    }
}
