using DBController;
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
    public partial class UCResidents : UserControl
    {
        
        public UCResidents()
        {
            InitializeComponent();
        }

        private void UCResidents_Load(object sender, EventArgs e)
        {
            try
            {
                dgvResidents.DataSource = Communication.Communication.Instance.GetResidents();
            }catch(Exception ex)
            {
                MessageBox.Show("Server is not working!");
                this.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "where";
            if(!string.IsNullOrEmpty(txtFindCardNmb.Text))
            {
                query += $" CardNumber = {txtFindCardNmb.Text}";
            }
            if(!string.IsNullOrEmpty(txtFindName.Text))
            {
                if (query.Length > 10)
                { query += ","; }

                query += $" ResidentName = '{txtFindName.Text}'";
            }
            if (!string.IsNullOrEmpty(txtFindSurname.Text))
            {
                if (query.Length > 10)
                { query += ","; }

                query += $" ResidentSurname = '{txtFindSurname.Text}'";
            }
            dgvResidents.DataSource = Communication.Communication.Instance.GetResidentsWhere(query);
            if(dgvResidents.Rows.Count==0)
            {
                MessageBox.Show("There is no resident with that parameters!");
                dgvResidents.DataSource = Communication.Communication.Instance.GetResidents();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvResidents.SelectedRows.Count == 0)
            {
                   MessageBox.Show("Guest has not been selected!");
                   return;
                
            }
            string NameSurname = $"{(string)dgvResidents.SelectedRows[0].Cells[1].Value} {(string)dgvResidents.SelectedRows[0].Cells[2].Value}";
            if (Communication.Communication.Instance.DeleteResident((int)dgvResidents.SelectedRows[0].Cells[0].Value))
            {
                dgvResidents.DataSource = Communication.Communication.Instance.GetResidents();
                MessageBox.Show($"Resident {NameSurname} is deleted!");
            }
            else
            {
                MessageBox.Show($"Resident {NameSurname} cannot be deleted!");
            }
            
        }

        private void dgvResidents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Resident r = dgvResidents.SelectedRows[0].DataBoundItem as Resident;
            KreirajUC(new UCUpdateResident(r));
            
        }
        private void KreirajUC(UserControl user)
        {
            this.Controls.Clear();
            user.Parent = this;
            user.Dock = DockStyle.Fill;
        }

        #region
        private void txtFindSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFindName_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtFindCardNmb_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFindCardNmb.ResetText();
            txtFindName.ResetText();
            txtFindSurname.ResetText();
            dgvResidents.DataSource = Communication.Communication.Instance.GetResidents();
        }
    }
}
