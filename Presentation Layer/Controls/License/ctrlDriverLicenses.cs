using Business_Layer;
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

namespace Driving_and_Vehicle_License_Department_Project.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        int _PersonID = -1;
        DataView dvDriverLicenses = new DataView();
        DataView dvInternationalDriverLicenses = new DataView();


        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private void FillLocalDataView()
        {
            DataView dv = clsLicense.
GetLicensesListByPersonID(_PersonID).DefaultView;

            DataTable dtDrivers = new DataTable();
            dtDrivers.Columns.Add("Lic.ID");
            dtDrivers.Columns.Add("App.ID");
            dtDrivers.Columns.Add("Class Name");
            dtDrivers.Columns.Add("Issue Date");
            dtDrivers.Columns.Add("Expiration Date");
            dtDrivers.Columns.Add("Is Active");


            foreach (DataRowView row in dv)
            {
                int LicenseID = int.Parse(row[0].ToString());
                clsLicense License = clsLicense.GetLicenseByID(LicenseID);

                dtDrivers.Rows.Add(LicenseID,
                    License.Application.ApplicationID,
                    License.LicenseClass.ClassName,
                    License.IssueDate,
                    License.ExpirationDate, License.IsActive);

            }
            dvDriverLicenses = dtDrivers.DefaultView;

        }

        private void FillInternationalDataView()
        {
            DataView dv = clsInternationalLicense.
GetInternationalLicensesListByPersonID(_PersonID).DefaultView;

            DataTable dtDrivers = new DataTable();
            dtDrivers.Columns.Add("Int.License ID");
            dtDrivers.Columns.Add("App.ID");
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
                    InternationalLicense.IssuedUsingLocalLicense.LicenseID,
                    InternationalLicense.IssueDate,
                    InternationalLicense.ExpirationDate, InternationalLicense.IsActive);

            }
            dvInternationalDriverLicenses = dtDrivers.DefaultView;

        }

        private void FillDataView()
        {
            //Local
            FillLocalDataView();
            //International
            FillInternationalDataView();
        }

        private void ShowLDLApplication()
        {
            FillDataView();
            dgvLocalLicensesHistory.DataSource = dvDriverLicenses;
            dgvInternationalLicensesHistory.DataSource = dvInternationalDriverLicenses;
        }

        public void RefrechLocalLicensesHistory()
        {
            FillDataView();
            dgvLocalLicensesHistory.DataSource = dvDriverLicenses;
            lblLLRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            dgvInternationalLicensesHistory.DataSource = dvInternationalDriverLicenses;
            lblILRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();
        }

        public void FillDriverLicenses(int PersonID)
        {
            _PersonID = PersonID;
            ShowLDLApplication();
            lblILRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();
            lblLLRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage1)
            {
                int LocalLicense = int.Parse(dgvLocalLicensesHistory.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                frmLicenseInfo frm = new frmLicenseInfo(LocalLicense);
                frm.Show();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                int InternationalLicenseID = int.Parse(dgvInternationalLicensesHistory.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(InternationalLicenseID);
                frm.Show();
            }
        }

    }
}
