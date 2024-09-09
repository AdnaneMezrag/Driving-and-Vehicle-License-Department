using Business_Layer;
using Driving_and_Vehicle_License_Department_Project.Forms.Application.Driving_License_Services;
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

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application.Manage_Application_Types
{
    public partial class frmInternationalLicenseApplications : Form
    {
        public frmInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        DataView dvInternationalDriverLicenses = new DataView();

        private void FillInternationalDataView()
        {
            DataView dv = clsInternationalLicense.GetInternationalLicensesList().DefaultView;

            DataTable dtDrivers = new DataTable();
            dtDrivers.Columns.Add("Int.License ID");
            dtDrivers.Columns.Add("App.ID");
            dtDrivers.Columns.Add("Driver ID");
            dtDrivers.Columns.Add("L.License ID");
            dtDrivers.Columns.Add("Issue Date");
            dtDrivers.Columns.Add("Expiration Date");
            dtDrivers.Columns.Add("Is Active");


            foreach (DataRowView row in dv)
            {
                int InternationalLicenseID = int.Parse(row[0].ToString());
                clsInternationalLicense InternationalLicense = clsInternationalLicense.
                    GetInternationalLicenseByID(InternationalLicenseID);

                dtDrivers.Rows.Add(InternationalLicenseID,
                    InternationalLicense.Application.ApplicationID,
                    InternationalLicense.Driver.DriverID,
                    InternationalLicense.IssuedUsingLocalLicense.LicenseID,
                    InternationalLicense.IssueDate,
                    InternationalLicense.ExpirationDate, InternationalLicense.IsActive) ;

            }
            dvInternationalDriverLicenses = dtDrivers.DefaultView;

        }

        private void FillDataView()
        {
            FillInternationalDataView();
        }

        private void ShowLDLApplication()
        {
            FillDataView();
            dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
        }

        public void RefrechLocalLicensesHistory()
        {
            FillDataView();
            dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
            lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        public void FillDriverLicenses()
        {
            ShowLDLApplication();
            lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void frmInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            ShowLDLApplication();
            cbFilterInternationalLicenses.SelectedIndex = 0;
            lblRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
            cbIsActive.SelectedIndex = 0;

        }

        private void pbAddApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterApplications_KeyUp(object sender, KeyEventArgs e)
        {

            if (tbFilterApplications.Text == "")
            {
                dvInternationalDriverLicenses.RowFilter = "";
                dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
                return;
            }

            switch (cbFilterInternationalLicenses.SelectedItem.ToString())
            {

                case "Int.License ID":
                    dvInternationalDriverLicenses.RowFilter = $"[Int.License ID] = {tbFilterApplications.Text}";
                    dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;

                    break;
                case "Driver ID":
                    dvInternationalDriverLicenses.RowFilter = $"[Driver ID] = '{tbFilterApplications.Text}'";
                    dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;

                    break;
                case "L.License ID":
                    dvInternationalDriverLicenses.RowFilter = $"[L.License ID] = '{tbFilterApplications.Text}'";
                    dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
                    break;

            }
        }

        private void cbFilterInternationalLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvInternationalDriverLicenses.RowFilter = "";
            if (cbFilterInternationalLicenses.SelectedIndex == cbFilterInternationalLicenses.FindStringExact("None"))
            {
                cbIsActive.Visible = false;
                tbFilterApplications.Visible = false;
                return;
            }
            if (cbFilterInternationalLicenses.SelectedIndex == cbFilterInternationalLicenses.FindStringExact("Is Active"))
            {
                cbIsActive.Visible = true;
                tbFilterApplications.Visible = false;
                return;
            }

            cbIsActive.Visible = false;
            tbFilterApplications.Visible = true;
            tbFilterApplications.Text = "";
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.SelectedItem.ToString())
            {
                case "All":
                    dvInternationalDriverLicenses.RowFilter = "";
                    dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
                    break;
                case "True":
                    dvInternationalDriverLicenses.RowFilter = $"[Is Active] = '{true}'";
                    dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
                    break;
                case "False":
                    dvInternationalDriverLicenses.RowFilter = $"[Is Active] = '{false}'";
                    dgvInternationalLicenses.DataSource = dvInternationalDriverLicenses;
                    break;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = int.Parse(dgvInternationalLicenses.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
            int PersonID = clsApplication.GetApplicationByID(ApplicationID).ApplicationPerson.PersonID;
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.Show();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = int.Parse(dgvInternationalLicenses.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(InternationalLicenseID);
            frm.Show();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = int.Parse(dgvInternationalLicenses.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
            int PersonID = clsApplication.GetApplicationByID(ApplicationID).ApplicationPerson.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.Show();
        }

    }
}
