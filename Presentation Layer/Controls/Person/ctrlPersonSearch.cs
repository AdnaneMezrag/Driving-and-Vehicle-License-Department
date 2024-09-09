using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_and_Vehicle_License_Department_Project.Controls.Person
{
    public partial class ctrlPersonSearch : UserControl
    {
        int _PersonID = -1;
        public event Action<int> onPersonID;
        protected virtual void PersonID(int PersonID)
        {
            Action<int> handler = onPersonID;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        public ctrlPersonSearch()
        {
            InitializeComponent();
        }
        
        public void FillPersonDetails(int PersonID)
        {
            this.ctrlPersonDetails1.FillPersonDetails(PersonID);
        }

        public void DisablePersonFilter()
        {
            ctrlPersonFilter1.Enabled = false;
        }

        private void ctrlPersonFilter1_onPersonID(int obj)
        {
            _PersonID = obj;
            ctrlPersonDetails1.FillPersonDetails(obj);
            if (onPersonID != null)
            {
                onPersonID(_PersonID);
            }
        }

    }
}
