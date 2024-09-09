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

namespace Driving_and_Vehicle_License_Department_Project
{
    public partial class ctrlPersonFilter : UserControl
    {

        public event Action<int> onPersonID;
        protected virtual void PersonID(int PersonID)
        {
            Action<int> handler = onPersonID;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public ctrlPersonFilter()
        {
            InitializeComponent();
        }

        private void SendPersonID(int ID)
        {
            if (onPersonID != null)
            {
                onPersonID(ID);
            }
        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson addUpdatePersonfrm = new frmAddUpdatePerson(ctrlAddUpdatePerson.enMode.eAddNew, -1);
            addUpdatePersonfrm.DataBack += SendPersonID;
            addUpdatePersonfrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int PersonID = -1;
            switch (cbFilterPeople.Text)
            {
                case "National No":
                    clsPerson Person = clsPerson.GetPersonByNationalNo(tbFilterPeople.Text);
                    if (Person == null)
                    {
                        MessageBox.Show("Person With Such National No Doesen't Exist");
                    }
                    else
                    {
                        //Send National No To The Person Details Control
                        PersonID = Person.PersonID;

                    }

                    break;

                case "Person ID":
                    if(tbFilterPeople.Text == "")
                    {
                        break;
                    }
                    if (!clsPerson.DoesPersonExistByPersonID(int.Parse(tbFilterPeople.Text)))
                    {
                        MessageBox.Show("Person With Such Person ID Doesen't Exist");
                    }
                    else
                    {
                        //Send National No To The Person Details Control
                        PersonID = int.Parse(tbFilterPeople.Text);
                    }
                    break;
            }
            if (onPersonID != null)
            {
                onPersonID(PersonID);
            }
        }

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
        
        private void pbAddPerson_MouseEnter(object sender, EventArgs e)
        {
            pbAddPerson.BackColor = Color.Gainsboro;

        }

        private void pbAddPerson_MouseLeave(object sender, EventArgs e)
        {
            pbAddPerson.BackColor = Color.Transparent;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pbPersonSearcher.BackColor = Color.Gainsboro;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pbPersonSearcher.BackColor = Color.Transparent;

        }

        private void ctrlPersonFilter_Load(object sender, EventArgs e)
        {
            cbFilterPeople.SelectedIndex = 0;

        }

        private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterPeople.Text = "";
        }
    }
}
