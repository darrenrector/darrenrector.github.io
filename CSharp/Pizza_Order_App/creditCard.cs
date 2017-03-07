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
    public partial class frmcreditCard : Form
    {
        public frmcreditCard()
        {
            InitializeComponent();
        }

        private void cboExMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboExMonth.SelectedIndex = 1;
        }

        private void frmcreditCard_Load(object sender, EventArgs e)
        {



        }
    }
}
