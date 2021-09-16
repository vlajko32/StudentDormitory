using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.UserControls
{
    public partial class UCCreateGuest : UserControl
    {
        public UCCreateGuest()
        {
            InitializeComponent();
        }

        private void UCCreateGuest_Load(object sender, EventArgs e)
        {
            cmbCities.DataSource = Communication.Communication.Instance.GetCities();

        }

        private void reset()
        {
            txtName.ResetText();
            txtSurname.ResetText();
            txtIndex.ResetText();
            txtCardNumber.ResetText();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text)
                || string.IsNullOrEmpty(txtIndex.Text) || string.IsNullOrEmpty(txtCardNumber.Text))
            { 
                MessageBox.Show("There are blank fields, please enter all informations.");
                return;
            }
            if (!int.TryParse(txtCardNumber.Text, out int nmb))
            {
                MessageBox.Show("Card number can't contain letters!");
                txtCardNumber.BackColor = Color.LightPink;
                return;
            }
            if (!txtIndex.Text.Contains("/"))
            {
                MessageBox.Show("Bad index format!");
                txtIndex.BackColor = Color.LightPink;
                return;
            }
            Guest guest = new Guest
            {
                GuestName = txtName.Text,
                GuestSurname = txtSurname.Text,
                GCardNumber = Convert.ToInt32(txtCardNumber.Text),
                GIndexNumber = txtIndex.Text,
                City = (City)cmbCities.SelectedItem

            };

            Communication.Communication.Instance.SaveGuest(guest);
            MessageBox.Show("Guest is successfully created!");
            reset();
        }
    }
}
