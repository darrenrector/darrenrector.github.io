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
    public partial class frmCCValid : Form
    {
        public frmCCValid()
        {
            InitializeComponent();
            this.mtbCardNum.TextChanged += new EventHandler(this.mtbCardNum_TextChanged);
            this.mtbCardNum.Leave += new EventHandler(this.mtbCardNum_Leave);
        }

        

        private void mtbCardNum_TextChanged(object sender, EventArgs e)
        {
            if (this.mtbCardNum.Text.Length == 0x10)
            {
                this.cboMonth.Focus();
                this.valCC();
            }
        }

        private void valCC()
        {
            this.btnAccept.Enabled = false;
            if (Convert.ToInt16(this.cboYear.SelectedItem) > DateTime.Now.Year)
            {
                this.btnAccept.Enabled = true;
            }
            else if (Convert.ToInt16(this.cboMonth.SelectedItem) > DateTime.Now.Month)
            {
                this.btnAccept.Enabled = true;

            }
        }

        private void mtbCardNum_Leave(object sender, EventArgs e)
        {
            if(this.mtbCardNum.Text.Length != 0x10)
            {
                this.mtbCardNum.ForeColor = Color.Red;
            }
            else
            {
                this.mtbCardNum.ForeColor = Color.Black;
            }
        }

        private void frmCCValid_Load(object sender, EventArgs e)
        {
            this.cboMonth.SelectedItem = DateTime.Now.Month.ToString("00");
            int year = DateTime.Now.Year;
            int num2 = year + 9;
            for(int i = year; i<num2; i++)
            {
                this.cboYear.Items.Add(i.ToString());
            }
            this.cboYear.SelectedIndex = 0;
            this.lblCustomerName.Text = Globals.glbCustName;
            this.btnAccept.Enabled = false;
        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
            Globals.blnValidCC = true;
            base.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.valCC();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.valCC();
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblCust_Click(object sender, EventArgs e)
        {

        }

        private void lblCreditCard_Click(object sender, EventArgs e)
        {

        }

        private void lblCardNum_Click(object sender, EventArgs e)
        {

        }

        private void lblExpDate_Click(object sender, EventArgs e)
        {

        }

        private void mtbCardNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblimportCC_Click(object sender, EventArgs e)
        {

        }





    }
}
