using Business_Layer;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmUsers : Form
    {
        //This may cause a problem if that happen, you should use a data table instead.
        DataView dvUsers = new DataView();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, System.EventArgs e)
        {
            DataTable Users = clsUser.GetUsersListForShow();
            dvUsers = Users.DefaultView;
            dgvUsers.DataSource = dvUsers;
            //dgvPeople.Columns.Remove("PersonID");            
            cbFilterUsers.SelectedIndex = 0;
            lblRecords.Text = dgvUsers.Rows.Count.ToString();
            cbIsActive.SelectedIndex = 0;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void RefrechUsersList()
        {
            DataTable dtUsers = clsUser.GetUsersListForShow();
            dvUsers = dtUsers.DefaultView;
            dgvUsers.DataSource = dvUsers;
            lblRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void tbFilterPeople_KeyUp(object sender, KeyEventArgs e)
        {

            if (tbFilterUsers.Text == "")
            {
                dvUsers.RowFilter = "";
                dgvUsers.DataSource = dvUsers;
                return;
            }

            switch (cbFilterUsers.SelectedItem.ToString())
            {

                case "User ID":
                    dvUsers.RowFilter = $"UserID = {tbFilterUsers.Text}";
                    dgvUsers.DataSource = dvUsers;

                    break;
                case "Person ID":
                    dvUsers.RowFilter = $"PersonID = {tbFilterUsers.Text}";
                    dgvUsers.DataSource = dvUsers;
                    break;
                case "UserName":
                    dvUsers.RowFilter = $"UserName = '{tbFilterUsers.Text}'";
                    dgvUsers.DataSource = dvUsers;
                    break;
                case "Full Name":
                    dvUsers.RowFilter = $"FullName = '{tbFilterUsers.Text}'";
                    dgvUsers.DataSource = dvUsers;
                    break;

            }
            lblRecords.Text = dvUsers.Count.ToString();
        }

        private void pbAddPerson_MouseEnter(object sender, System.EventArgs e)
        {
            pbAddUser.BackColor = Color.Gainsboro;

        }

        private void pbAddPerson_MouseLeave(object sender, System.EventArgs e)
        {
            pbAddUser.BackColor = Color.Transparent;

        }

        private void cbFilterUsers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefrechUsersList();
            if (cbFilterUsers.SelectedIndex == cbFilterUsers.FindStringExact("None"))
            {
                cbIsActive.Visible = false;
                tbFilterUsers.Visible = false;
                return;
            }
            if (cbFilterUsers.SelectedIndex == cbFilterUsers.FindStringExact("Is Active"))
            {
                cbIsActive.Visible = true;
                tbFilterUsers.Visible = false;
                return;
            }

            cbIsActive.Visible = false;
            tbFilterUsers.Visible = true;
            tbFilterUsers.Text = "";

            }

        private void pbAddUser_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(frmAddUpdateUser.enMode.eAddNew , -1);
            frm.DataBack += RefrechUsersList;
            frm.Show();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (cbIsActive.SelectedItem.ToString())
            {
                case "All":
                    dvUsers.RowFilter = "";
                    dgvUsers.DataSource = dvUsers;
                    break;
                case "Yes":
                    dvUsers.RowFilter = $"IsActive = {true}";
                    dgvUsers.DataSource = dvUsers;
                    break;
                case "No":
                    dvUsers.RowFilter = $"IsActive = {false}";
                    dgvUsers.DataSource = dvUsers;
                    break;
            }
            lblRecords.Text = dvUsers.Count.ToString();
        }

        public void RefrechUsersList(int PersonID)
        {
            DataTable dtUsers = clsUser.GetUsersListForShow();
            dvUsers = dtUsers.DefaultView;
            dgvUsers.DataSource = dvUsers;
            lblRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void showToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int UserID = -1;
            UserID = int.Parse(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmUserDetails frm = new frmUserDetails(UserID);
            
            frm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            int UserID = int.Parse(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            frmAddUpdateUser frm = new frmAddUpdateUser(frmAddUpdateUser.enMode.eUpdate , UserID);
            frm.DataBack += RefrechUsersList;

            frm.Show();

            //frm.DataBack += RefrechUsersList;
        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int UserID = int.Parse(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            if (MessageBox.Show("Are You Sure You Want To Delete This User?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUserByUserID(UserID))
                {

                    MessageBox.Show("Deleted Successfully");
                    RefrechUsersList(UserID);
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int UserID = -1;
            UserID = int.Parse(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            frmChangePassword frmChangePassword = new frmChangePassword(UserID);
            frmChangePassword.Show();
        }

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(frmAddUpdateUser.enMode.eAddNew, -1);
            frm.DataBack += RefrechUsersList;

            frm.Show();
        }

    }
}
