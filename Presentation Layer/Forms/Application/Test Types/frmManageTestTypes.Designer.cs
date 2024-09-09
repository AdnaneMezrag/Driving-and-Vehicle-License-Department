namespace Driving_and_Vehicle_License_Department_Project.Forms.Application
{
    partial class frmManageTestTypes
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblAddUpdate = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "#Records:";
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypes.ContextMenuStrip = this.cmsTestTypes;
            this.dgvTestTypes.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTestTypes.Location = new System.Drawing.Point(30, 194);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTestTypes.Size = new System.Drawing.Size(825, 256);
            this.dgvTestTypes.TabIndex = 35;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editToolStripMenuItem1,
            this.toolStripSeparator2});
            this.cmsTestTypes.Name = "cmsPerson";
            this.cmsTestTypes.Size = new System.Drawing.Size(181, 60);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(91, 6);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(91, 6);
            // 
            // lblAddUpdate
            // 
            this.lblAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddUpdate.AutoSize = true;
            this.lblAddUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblAddUpdate.Location = new System.Drawing.Point(304, 143);
            this.lblAddUpdate.Name = "lblAddUpdate";
            this.lblAddUpdate.Size = new System.Drawing.Size(276, 36);
            this.lblAddUpdate.TabIndex = 34;
            this.lblAddUpdate.Text = "Manage Test Types";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(104, 475);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(17, 17);
            this.lblRecords.TabIndex = 38;
            this.lblRecords.Text = "1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(775, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::Driving_and_Vehicle_License_Department_Project.Properties.Resources.Manage_Test_Types;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(367, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 136);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.lblAddUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecords);
            this.Name = "frmManageTestTypes";
            this.Text = "frmManageTestTypes";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblAddUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecords;
    }
}