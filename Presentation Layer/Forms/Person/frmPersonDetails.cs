using System;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmPersonDetails : Form
    {
        private int _PersonID;
        
        public frmPersonDetails(int PersonID)
        {           
            InitializeComponent();
            _PersonID = PersonID;
            this.ctrlPersonDetails1._PersonID = _PersonID;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
