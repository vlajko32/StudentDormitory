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
            cmbCities.DataSource = Communication.Communication.Instance.GetCities();
            cmbFaculties.DataSource = Communication.Communication.Instance.GetFaculties();
        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
