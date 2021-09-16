using Domain;
using Storage;
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
    public partial class UCCreateResident : UserControl
    {
        
        public UCCreateResident()
        {
            InitializeComponent();
        }

      

        private void UCCreateResident_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCities.DataSource = Communication.Communication.Instance.GetCities();
                cmbFaculties.DataSource = Communication.Communication.Instance.GetFaculties();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server is not working!");
                this.Dispose();
            }
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            txtName.ResetText();
            txtSurname.ResetText();
            txtIndex.ResetText();
            txtCardNumber.ResetText();
            nmRoomNumber.ResetText();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text)
                || string.IsNullOrEmpty(txtIndex.Text) || string.IsNullOrEmpty(txtCardNumber.Text)||nmRoomNumber.Value==0)
            {
                MessageBox.Show("There are blank fields, please enter all informations.");
                return;
            }
            if (!int.TryParse(txtCardNumber.Text,out int nmb))
            {
                MessageBox.Show("Card number can't contain letters!");
                txtCardNumber.BackColor = Color.LightPink;
                return;
            }
            if(!txtIndex.Text.Contains("/"))
            {
                MessageBox.Show("Bad index format!");
                txtIndex.BackColor = Color.LightPink;
                return;
            }

            
            
                Resident resident = new Resident
                {

                    ResidentName = txtName.Text,
                    ResidentSurname = txtSurname.Text,
                    IndexNumber = txtIndex.Text,
                    CardNumber = Convert.ToInt32(txtCardNumber.Text),
                    RoomNumber = (int)nmRoomNumber.Value,
                    City = (City)cmbCities.SelectedItem,
                    Faculty = (Faculty)cmbFaculties.SelectedItem

                };

                try
                {
                if (Communication.Communication.Instance.SaveResident(resident))
                {
                    MessageBox.Show("Resident is saved succesfully!");

                    reset();
                }
                else
                {
                    MessageBox.Show("Resident is not saved!");
                }
                
                    
                }
                catch (Exception ex)
                {
                MessageBox.Show("Error while communicating with server!");
               
                }
            
        }
    }
}
