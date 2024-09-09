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

namespace Driving_and_Vehicle_License_Department_Project.Forms.Application
{
    public partial class frmManageTestTypes : Form
    {
        DataView dvTestTypes = new DataView();

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        public void RefrechTestTypesList(int TestType)
        {
            DataTable dtUsers = clsTestType.GetTestTypeList();
            dvTestTypes = dtUsers.DefaultView;
            dgvTestTypes.DataSource = dvTestTypes;
            lblRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void frmManageTestTypes_Load_1(object sender, EventArgs e)
        {
            DataTable TestTypes = clsTestType.GetTestTypeList();
            dvTestTypes = TestTypes.DefaultView;
            dgvTestTypes.DataSource = dvTestTypes;
            lblRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void editToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int TestTypeID = int.Parse(dgvTestTypes.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            frmUpdateTestType frm = new frmUpdateTestType(TestTypeID);
            frm.DataBack += RefrechTestTypesList;

            frm.Show();

            //frm.DataBack += RefrechTestTypesList;
        }
    }
}
