using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            closeTimer.Interval = 500;
            closeTimer.Tick += new EventHandler(tmrClose_Tick);
            closeTimer.Start();
        }

        private void Splash_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private Timer closeTimer = new Timer();

        private void IntializeComponent()
        {   
 	        throw new NotImplementedException();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Close();
        }
    }
}
