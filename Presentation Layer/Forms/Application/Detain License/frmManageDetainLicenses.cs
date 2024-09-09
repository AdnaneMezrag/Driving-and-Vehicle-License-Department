using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Controls.Application;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types;
using Driving_and_Vehicle_License_Department_Project.Forms.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Detain_License
{
    public partial class frmManageDetainLicenses : Form
    {
        public frmManageDetainLicenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataView dvDetainedLicenses = new DataView();

        private void FillDataView()
        {
            DataView dv = clsDetainedLicense.
    GetDetainedLicenseList().DefaultView;

            DataTable dtDetainedLicenses = new DataTable();
            dtDetainedLicenses.Columns.Add("D.ID");
            dtDetainedLicenses.Columns.Add("L.ID");
            dtDetainedLicenses.Columns.Add("D.Date");
            dtDetainedLicenses.Columns.Add("Is Released");
            dtDetainedLicenses.Columns.Add("Fine Fees");
            dtDetainedLicenses.Columns.Add("Release Date");
            dtDetainedLicenses.Columns.Add("N.No");
            dtDetainedLicenses.Columns.Add("Full Name");
            dtDetainedLicenses.Columns.Add("Release App.ID");


            foreach (DataRowView row in dv)
            {

                clsPerson Person = clsDetainedLicense.GetDetainedLicenseByID
                    (int.Parse(row[0].ToString())).License.Application.ApplicationPerson;

                dtDetainedLicenses.Rows.Add(row[0].ToString(),
                    row[1].ToString(), row[2].ToString(), row[5].ToString(), row[3].ToString(),
                    row[6].ToString(), Person.NationalNo,Person.GetFullName(),
                    row[8].ToString()
                    );

            }
            dvDetainedLicenses = dtDetainedLicenses.DefaultView;
        }

        private void ShowDetainedLicense()
        {

            FillDataView();
            dgvDetainedLicenses.DataSource = dvDetainedLicenses;

        }

        public void RefrechDetainedLicensesList()
        {
            FillDataView();
            dgvDetainedLicenses.DataSource = dvDetainedLicenses;
            lblRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void tbFilterDetainedLicenses_KeyUp(object sender, KeyEventArgs e)
        {

            if (tbFilterDetainedLicenses.Text == "")
            {
                dvDetainedLicenses.RowFilter = "";
                dgvDetainedLicenses.DataSource = dvDetainedLicenses;
                return;
            }

            switch (cbFilterDetainedLicenses.SelectedItem.ToString())
            {

                case "Detain ID":
                    dvDetainedLicenses.RowFilter = $"[D.ID] = {tbFilterDetainedLicenses.Text}";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;

                    break;
                case "National No":
                    dvDetainedLicenses.RowFilter = $"[N.No] = '{tbFilterDetainedLicenses.Text}'";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;

                    break;
                case "Full Name":
                    dvDetainedLicenses.RowFilter = $"[Full Name] = '{tbFilterDetainedLicenses.Text}'";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;
                    break;
                case "Release Application ID":
                    dvDetainedLicenses.RowFilter = $"[Release App.ID] = '{tbFilterDetainedLicenses.Text}'";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;
                    break;
            }
        }

        private void cbFilterDetainedLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvDetainedLicenses.RowFilter = "";
            if (cbFilterDetainedLicenses.SelectedIndex == cbFilterDetainedLicenses.FindStringExact("None"))
            {
                cbIsReleased.Visible = false;
                tbFilterDetainedLicenses.Visible = false;
                return;
            }
            if (cbFilterDetainedLicenses.SelectedIndex == cbFilterDetainedLicenses.FindStringExact("Is Released"))
            {
                cbIsReleased.Visible = true;
                tbFilterDetainedLicenses.Visible = false;
                return;
            }

            cbIsReleased.Visible = false;
            tbFilterDetainedLicenses.Visible = true;
            tbFilterDetainedLicenses.Text = "";
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbIsReleased.SelectedItem.ToString())
            {
                case "All":
                    dvDetainedLicenses.RowFilter = "";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;
                    break;
                case "Yes":
                    dvDetainedLicenses.RowFilter = $"[Is Released] = true";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;
                    break;
                case "No":
                    dvDetainedLicenses.RowFilter = $"[Is Released] = false";
                    dgvDetainedLicenses.DataSource = dvDetainedLicenses;
                    break;
            }
        }

        private void pbDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.DataBack += RefrechDetainedLicensesList;
            frm.Show();
        }

        private void frmManageDetainLicenses_Load(object sender, EventArgs e)
        {
            ShowDetainedLicense();
            cbFilterDetainedLicenses.SelectedIndex = 0;
            lblRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
            cbIsReleased.SelectedIndex = 0;
        }

        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {           
            int DetainID = int.Parse(dgvDetainedLicenses.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            int PersonID = clsDetainedLicense.GetDetainedLicenseByID(DetainID).License.Application.ApplicationPerson.PersonID;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.Show();
        }

        private void showLicenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int DetainID = int.Parse(dgvDetainedLicenses.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            int LicenseID = clsDetainedLicense.GetDetainedLicenseByID(DetainID).License.LicenseID;

            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.Show();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int DetainID = int.Parse(dgvDetainedLicenses.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            int PersonID = clsDetainedLicense.GetDetainedLicenseByID(DetainID).License.Application.ApplicationPerson.PersonID;

            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.Show();
        }

        private void pbReleaseLicense_Click(object sender, EventArgs e)
        {
            //Delegation
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.DataBack += RefrechDetainedLicensesList;
            frm.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dgvDetainedLicenses.SelectedCells[0].OwningRow.Cells[1].Value.ToString());

            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.DataBack += RefrechDetainedLicensesList;
            frm.FillLicenseID(LicenseID);
            frm.Show();
        }

        private void cmsDetainedLicenses_Opening(object sender, CancelEventArgs e)
        {
            int DetainID = int.Parse(dgvDetainedLicenses.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            clsDetainedLicense detainedLicense = clsDetainedLicense.GetDetainedLicenseByID(DetainID);
            if(detainedLicense.IsReleased)
            {
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;
            }
        }

    }
}
