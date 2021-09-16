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
    public partial class UCVisits : UserControl
    {
        public UCVisits()
        {
            InitializeComponent();
        }

        private void UCVisits_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = Communication.Communication.Instance.GetVisits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server is not working!");
                this.Dispose();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Communication.Communication.Instance.DeleteVisit((int)dataGridView1.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show($"Visit is deleted!");
                dataGridView1.DataSource = Communication.Communication.Instance.GetVisits();
            }
            else
            {
                MessageBox.Show($"Visit cannot be deleted!");
            }
        }
    }
}
