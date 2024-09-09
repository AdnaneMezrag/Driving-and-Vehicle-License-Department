//using System.Resources;
namespace Driving_and_Vehicle_License_Department_Project
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterPeople = new System.Windows.Forms.ComboBox();
            this.tbFilterPeople = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(423, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsPerson;
            this.dgvPeople.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPeople.Location = new System.Drawing.Point(17, 173);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPeople.Size = new System.Drawing.Size(930, 268);
            this.dgvPeople.TabIndex = 2;
            // 
            // cmsPerson
            // 
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsPerson.Name = "cmsPerson";
            this.cmsPerson.Size = new System.Drawing.Size(163, 148);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Show_Person_Details;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showToolStripMenuItem.Text = "Show Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Add_New_Person;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem.Text = "Add New Person";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Send_Email;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Phone_Call;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // cbFilterPeople
            // 
            this.cbFilterPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterPeople.FormattingEnabled = true;
            this.cbFilterPeople.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbFilterPeople.Location = new System.Drawing.Point(96, 142);
            this.cbFilterPeople.Name = "cbFilterPeople";
            this.cbFilterPeople.Size = new System.Drawing.Size(151, 24);
            this.cbFilterPeople.TabIndex = 5;
            this.cbFilterPeople.SelectedIndexChanged += new System.EventHandler(this.cbFilterPeople_SelectedIndexChanged);
            // 
            // tbFilterPeople
            // 
            this.tbFilterPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterPeople.Location = new System.Drawing.Point(253, 143);
            this.tbFilterPeople.Name = "tbFilterPeople";
            this.tbFilterPeople.Size = new System.Drawing.Size(151, 23);
            this.tbFilterPeople.TabIndex = 6;
            this.tbFilterPeople.Visible = false;
            this.tbFilterPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterPeople_KeyPress);
            this.tbFilterPeople.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilterPeople_KeyUp);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(254, 144);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 11;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged_1);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(331, 144);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 21);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = false;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged_1);
            // 
            // cbCountries
            // 
            this.cbCountries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCountries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(253, 143);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(151, 24);
            this.cbCountries.TabIndex = 13;
            this.cbCountries.Visible = false;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.pbAddPerson.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Add_Person;
            this.pbAddPerson.Location = new System.Drawing.Point(903, 127);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(44, 39);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddPerson.TabIndex = 14;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbAddPerson.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pbAddPerson.MouseLeave += new System.EventHandler(this.pbAddPerson_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(867, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(422, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "#Records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(93, 454);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 17);
            this.lblRecords.TabIndex = 16;
            this.lblRecords.Text = "1";
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.White_wooden_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 483);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAddPerson);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbFilterPeople);
            this.Controls.Add(this.cbFilterPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeople";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFilterPeople;
        private System.Windows.Forms.TextBox tbFilterPeople;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.PictureBox pbAddPerson;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecords;
    }
}