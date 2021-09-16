using Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmMain : Form
    {
        string User;
        public FrmMain(string txtUsername)
        {
            InitializeComponent();
            User = txtUsername;

        }

        private void createUC(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void createResidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUC(new UCCreateResident());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {User}!";
        }


        private void updateResidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUC(new UCResidents());
        }

        private void createGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUC(new UCCreateGuest());
        }

        private void deleteGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUC(new UCDeleteGuest());
        }

        private void createVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUC(new UCCreateVisit());
        }

        private void updateVisitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUC(new UCVisits());
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Communication.Communication.Instance.Disconnect();
        }
    }
}
