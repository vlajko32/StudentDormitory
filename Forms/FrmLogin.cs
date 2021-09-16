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

namespace Forms
{
    public partial class FrmLogin : Form
    {
        MainController main = new MainController();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { Communication.Communication.Instance.Connect(); }
            catch (Exception)
            { 
                MessageBox.Show("Error while communicating with server");
                return;
            }
            try
            {
                User u = Communication.Communication.Instance.Login(txtUsername, txtPassword);
                if (u != null)
                {
                    FrmMain frmMain = new FrmMain(txtUsername.Text);
                    this.Visible = false;
                    frmMain.ShowDialog();
                    this.Visible = true;

                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server does not work!");
               
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Communication.Communication.Instance.Connect();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
