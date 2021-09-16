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
    public partial class UCDeleteGuest : UserControl
    {
        public UCDeleteGuest()
        {
            InitializeComponent();
        }

        private void UCDeleteGuest_Load(object sender, EventArgs e)
        {
            try
            {
                dgvGuests.DataSource = Communication.Communication.Instance.GetGuests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server is not working!");
                this.Dispose();
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFindCardNmb.Text))
            {
                dgvGuests.DataSource = Communication.Communication.Instance.GetGuestsWhere($"where CardNumber = '{txtFindCardNmb.Text}'");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvGuests.DataSource = Communication.Communication.Instance.GetGuests();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count ==0)
            {
                MessageBox.Show("Guest has not been selected!");
                return;
            }
            string deleted = $"{(string)dgvGuests.SelectedRows[0].Cells[1].Value} {(string)dgvGuests.SelectedRows[0].Cells[2].Value}";
            if(Communication.Communication.Instance.DeleteGuests((int)dgvGuests.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show($"Guest {deleted} is deleted!");
                dgvGuests.DataSource = Communication.Communication.Instance.GetGuests();
            }
            else
            {
                MessageBox.Show($"Guest {deleted} cannot be deleted!");
            }
           
        }
    }
}
