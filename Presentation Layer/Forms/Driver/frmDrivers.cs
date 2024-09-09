using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Forms.Driver
{
    public partial class frmDrivers : Form
    {
        DataView dvDrivers = new DataView();

        public frmDrivers()
        {
            InitializeComponent();
        }
        private void FillDataView()
        {
            DataView dv = clsDriver.
    GetDriversList().DefaultView;

            DataTable dtDrivers = new DataTable();
            dtDrivers.Columns.Add("Driver ID");
            dtDrivers.Columns.Add("Person ID");
            dtDrivers.Columns.Add("National No");
            dtDrivers.Columns.Add("Full Name");
            dtDrivers.Columns.Add("Date");
            dtDrivers.Columns.Add("Active Licenses");


            foreach (DataRowView row in dv)
            {
                int PersonID = int.Parse(row[1].ToString());
                int DriverID = int.Parse(row[0].ToString());
                byte ActiveLicenses = clsLicense.GetActiveLicensesNumber(DriverID);
                clsPerson Person = clsPerson.GetPersonByID(PersonID);


                dtDrivers.Rows.Add(DriverID,
                    PersonID,
                    Person.NationalNo,
                    Person.GetFullName(),
                    row[3],ActiveLicenses);

            }
            dvDrivers = dtDrivers.DefaultView;
        }

        private void ShowLDLApplication()
        {

            FillDataView();
            dgvDrivers.DataSource = dvDrivers;

        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            ShowLDLApplication();
            cbFilterDrivers.SelectedIndex = 0;
            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterDrivers_KeyUp(object sender, KeyEventArgs e)
        {

            if (tbFilterDrivers.Text == "")
            {
                dvDrivers.RowFilter = "";
                dgvDrivers.DataSource = dvDrivers;
                return;
            }

            switch (cbFilterDrivers.SelectedItem.ToString())
            {

                case "Driver ID":
                    dvDrivers.RowFilter = $"[Driver ID] = {tbFilterDrivers.Text}";
                    dgvDrivers.DataSource = dvDrivers;

                    break;
                case "Person ID":
                    dvDrivers.RowFilter = $"[Person ID] = '{tbFilterDrivers.Text}'";
                    dgvDrivers.DataSource = dvDrivers;

                    break;
                case "National No":
                    dvDrivers.RowFilter = $"[National No] = '{tbFilterDrivers.Text}'";
                    dgvDrivers.DataSource = dvDrivers;
                    break;

                case "Full Name":
                    dvDrivers.RowFilter = $"[Full Name] = '{tbFilterDrivers.Text}'";
                    dgvDrivers.DataSource = dvDrivers;
                    break;

            }
        }

        public void RefrechApplicationsList()
        {
            FillDataView();
            dgvDrivers.DataSource = dvDrivers;
            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void cbFilterDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvDrivers.RowFilter = "";
            if (cbFilterDrivers.SelectedIndex == cbFilterDrivers.FindStringExact("None"))
            {
                tbFilterDrivers.Visible = false;
                return;
            }
            tbFilterDrivers.Visible = true;
            tbFilterDrivers.Text = "";
        }
    }
}
