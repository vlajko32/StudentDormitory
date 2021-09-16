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
    public partial class UCCreateVisit : UserControl
    {
        public UCCreateVisit()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cmbResident.DataSource = Communication.Communication.Instance.GetResidentsWhere($"where RoomNumber={numericUpDown1.Value}");
        }

        private void UCCreateVisit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Communication.Communication.Instance.GetGuests();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Guest has not been selected!");
                return;
            }
            Visit v = new Visit();
            Resident r = (Resident)cmbResident.SelectedItem;
            Guest g = (Guest)dataGridView1.SelectedRows[0].DataBoundItem as Guest;
            v.Resident = r;
            v.Guest = g;
            v.Date = new DateTime();
            v.Date = DateTime.Now;
            if(Communication.Communication.Instance.CreateVisit(v))
            {
                MessageBox.Show("Visit created!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error while creating visit!");
            }
        }
    }
}
