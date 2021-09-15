using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public class MainController
    {
        public MainController()
        {

        }

        public void Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
            }
            catch(SocketException)
            {
                //MessageBox.Show("Greska pri povezivanju sa serverom");
                DialogResult result = MessageBox.Show("Do you want to try again?", "Server is not working!", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                { this.Connect(); }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    
    }
}
