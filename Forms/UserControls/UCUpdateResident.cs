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
    public partial class UCUpdateResident : UserControl
    {
        Resident resident;
        public UCUpdateResident(Domain.Resident r)
        {
            InitializeComponent();
            lblHeader.Text = $"{r.ResidentName}'s informations";
            lblName.Text = r.ResidentName;
            lblSurname.Text = r.ResidentSurname;
            lblCity.Text = r.City.Name;
            lblCardNumber.Text = r.CardNumber.ToString();

            cmbFaculty.DataSource = Communication.Communication.Instance.GetFaculties();
            cmbFaculty.SelectedItem = r.Faculty.FacultyID;
            nmbRoom.Value = r.RoomNumber;
            txtIndex.Text = r.IndexNumber;
            resident = r;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Faculty f = (Faculty)cmbFaculty.SelectedItem;
            List<string> values = new List<string>();
            values.Add(nmbRoom.Value.ToString());

            values.Add(f.FacultyID.ToString());
            values.Add($"'{txtIndex.Text}'");


            Communication.Communication.Instance.UpdateResident(resident.ResidentID,values);
            MessageBox.Show($"Resident {resident.ResidentName} {resident.ResidentSurname} is updated!");

            this.Visible = false;
        }
    }
}
