using Business_Layer;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmPeople : Form
    {

        public frmPeople()
        {
            InitializeComponent();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            DataTable People = clsPerson.GetPeopleListForShow();
            dgvPeople.DataSource = People;
            //dgvPeople.Columns.Remove("PersonID");            
            cbFilterPeople.SelectedIndex = 0;
            lblRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetCountriesList();

            foreach (DataRow dr in dt.Rows)
            {
                cbCountries.Items.Add(dr["CountryName"]);
            }
        }

        private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterPeople.Text = "";
            DataTable People = clsPerson.GetPeopleListForShow();
            dgvPeople.DataSource = People;
            if (cbFilterPeople.SelectedIndex == cbFilterPeople.FindStringExact("Nationality"))
            {
                FillCountriesInComboBox();
                cbCountries.Visible = true;
                tbFilterPeople.Visible = false;
                rbFemale.Visible = false;
                rbMale.Visible = false;
                return;
            }
            cbCountries.Visible = false;

            if (cbFilterPeople.SelectedIndex == cbFilterPeople.FindStringExact("Gendor"))
            {
                rbFemale.Visible = true;
                rbMale.Visible = true;
                tbFilterPeople.Visible = false;

                return;
            }
            rbFemale.Visible = false;
            rbMale.Visible = false;
            if (cbFilterPeople.SelectedIndex == 0)
            {
                tbFilterPeople.Visible = false;
                return;
            }

            tbFilterPeople.Visible = true;

        }

        private void tbFilterPeople_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbFilterPeople.Text == "")
            {
                DataTable People = clsPerson.GetPeopleListForShow();
                dgvPeople.DataSource = People;
                return;
            }
            switch (cbFilterPeople.SelectedIndex)
            {
                case 1:
                    if (int.TryParse(tbFilterPeople.Text.ToString(), out int ID))
                    {
                        dgvPeople.DataSource = clsPerson.FindPersonByID(ID);
                    }
                    break;
                case 2:
                    dgvPeople.DataSource = clsPerson.FindPersonByNationalNo(tbFilterPeople.Text.ToString());
                    break;
                case 3:
                    dgvPeople.DataSource = clsPerson.FindPersonByFirstName(tbFilterPeople.Text.ToString());
                    break;
                case 4:
                    dgvPeople.DataSource = clsPerson.FindPersonBySecondName(tbFilterPeople.Text.ToString());
                    break;
                case 5:
                    dgvPeople.DataSource = clsPerson.FindPersonByThirdName(tbFilterPeople.Text.ToString());
                    break;
                case 6:
                    dgvPeople.DataSource = clsPerson.FindPersonByLastName(tbFilterPeople.Text.ToString());
                    break;
                //case 7:                    
                //dgvPeople.DataSource = clsPerson.FindPersonByNationality(tbFilterPeople.Text.ToString());
                //break;
                //case 8:
                //    if(int.TryParse(tbFilterPeople.Text.ToString() , out int GendorInt))
                //    {
                //    }
                //    break;
                case 9:
                    dgvPeople.DataSource = clsPerson.FindPersonByPhone(tbFilterPeople.Text.ToString());
                    break;
                case 10:
                    dgvPeople.DataSource = clsPerson.FindPersonByEmail(tbFilterPeople.Text.ToString());
                    break;
            }
        }

        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvPeople.DataSource = clsPerson.FindPersonByGendor((clsPerson.enGendor)(0));

        }

        private void rbFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvPeople.DataSource = clsPerson.FindPersonByGendor((clsPerson.enGendor)(1));

        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = clsPerson.FindPersonByNationality(cbCountries.Text);
        }

        public void RefrechPeopleList(int PersonID)
        {
            dgvPeople.DataSource = clsPerson.GetPeopleListForShow();
            lblRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(ctrlAddUpdatePerson.enMode.eAddNew, -1);
            frm.DataBack += RefrechPeopleList;
            frm.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To Get The Person ID From dgvPeople
            //dgvPeople.SelectedCells[0].OwningRow.Cells[0].Value ;
            int PersonID = -1;
            PersonID = int.Parse(dgvPeople.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmPersonDetails frm = new frmPersonDetails(PersonID);
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson addUpdatePersonfrm = new frmAddUpdatePerson(ctrlAddUpdatePerson.enMode.eAddNew, -1);
            addUpdatePersonfrm.DataBack += RefrechPeopleList;
            addUpdatePersonfrm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvPeople.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            frmAddUpdatePerson frm = new frmAddUpdatePerson(ctrlAddUpdatePerson.enMode.eUpdate, PersonID);

            frm.DataBack += RefrechPeopleList;
            frm.Show();

            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvPeople.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            DataTable dtPerson = clsPerson.FindPersonByID(PersonID);
            string ImagePath = dtPerson.Rows[0]["ImagePath"].ToString();

            if (MessageBox.Show("Are You Sure You Want To Delete This Person?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.DeletePersonByID(PersonID))
                {
                    if (ImagePath != "")
                    {
                        File.Delete(ImagePath);

                    }
                    MessageBox.Show("Deleted Successfully");
                    RefrechPeopleList(PersonID);
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pbAddPerson.BackColor = Color.Gainsboro;
        }

        private void pbAddPerson_MouseLeave(object sender, EventArgs e)
        {
            pbAddPerson.BackColor = Color.Transparent;

        }

        //private void PreventUserToEnterLetters()
        //{
        //    if(tbFilterPeople.Text == "")
        //    {
        //        return;
        //    }

        //    char[] txt = tbFilterPeople.Text.ToCharArray();
        //    if (char.IsLetter(txt[txt.Length - 1]))
        //    {
        //        //tbFilterPeople.Text = tbFilterPeople.Text.ToString().Substring(0 , txt.Length - 1);
        //        string txtFilter = tbFilterPeople.Text.ToString().Remove(txt.Length-1,1);
        //        tbFilterPeople.Text =txtFilter;
        //    }
        //}

        private void tbFilterPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterPeople.Text == "Person ID")
            {
                // Check if the key pressed is a control key (like backspace)
                if (!char.IsControl(e.KeyChar))
                {
                    // Check if the key pressed is a digit (0-9)
                    if (!char.IsDigit(e.KeyChar))
                    {
                        // If it's not a control key and not a digit, suppress the key press
                        e.Handled = true;
                    }
                }
            }

        }

    }
}
