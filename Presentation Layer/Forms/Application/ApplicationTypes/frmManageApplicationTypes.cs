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
    public partial class frmManageApplicationTypes : Form
    {
        DataView dvApplicationTypes = new DataView();

        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            DataTable ApplicationTypes = clsApplicationType.GetApplicationTypesList();
            dvApplicationTypes = ApplicationTypes.DefaultView;
            dgvApplicationTypes.DataSource = dvApplicationTypes;
            lblRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        public void RefrechApplicationTypesList(int ApplicationType)
        {
            DataTable dtUsers = clsApplicationType.GetApplicationTypesList();
            dvApplicationTypes = dtUsers.DefaultView;
            dgvApplicationTypes.DataSource = dvApplicationTypes;
            lblRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = int.Parse(dgvApplicationTypes.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            frmUpdateApplicationType frm = new frmUpdateApplicationType(ApplicationTypeID);
            frm.DataBack += RefrechApplicationTypesList;

            frm.Show();

            //frm.DataBack += RefrechApplicationTypesList;
        }
    }
}
