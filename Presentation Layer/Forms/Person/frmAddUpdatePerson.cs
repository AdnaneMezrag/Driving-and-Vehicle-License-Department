using System;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class frmAddUpdatePerson : Form
    {

        public ctrlAddUpdatePerson.enMode Mode = ctrlAddUpdatePerson.enMode.eAddNew;

        public int _PersonID = -1;

        public delegate void DataBackEventHandler(int PersonID);
        public event DataBackEventHandler DataBack;

        public frmAddUpdatePerson(ctrlAddUpdatePerson.enMode Mode, int PersonID)
        {

            InitializeComponent();
            this.Mode = Mode;
            _PersonID = PersonID;
            this.ctrlAddUpdatePerson1.Mode = this.Mode;
            this.ctrlAddUpdatePerson1._PersonID = this._PersonID;
        }

        private void ctrlAddUpdatePerson1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlAddUpdatePerson1_onSaveComplete(bool obj , int PersonID)
        {
            _PersonID = PersonID;
            if (obj)
            {
                DataBack?.Invoke(this._PersonID);
            }
        }

        private void ctrlAddUpdatePerson1_onClose()
        {
            this.Close();
        }

    }
}
