using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PizzaProject
{
    public partial class frmMiPi : Form
    {
        //Class Variables
        //---------------------------
        SqlConnection connSQL;
        SqlDataAdapter adaptSQL;
        DataTable dtCust;
        DataTable dtOrder;
        Boolean blnOK = true;
        string strSQL;
        string strDataSrc = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Pizza.mdf;";
        string strSQLparms = "Integrated Security=True;Connect Timeout=30";
        //----------------------------

        float sglPrice = 0.0f;
        const Single sgltaxRate = 0.07f;
        bool blnPhone;
        bool blnName;
        bool blnAddress1;
        bool blnCity;
        bool blnZipCode;

        public frmMiPi()
        {
            InitializeComponent();
            
        }

        private void CustSearch()
        {
            // Get a connection to the database
            string strConn = strDataSrc + strSQLparms;
            connSQL = new SqlConnection(strConn);
            try
            {
                connSQL.Open();
            }
            catch
            {
                blnOK = false;
                MessageBox.Show("Unable to open PIZZA database connection");
            }

            if (blnOK)
            {
                string strPhone = mtbPhone.Text;
                dtCust = new DataTable();
                strSQL = "SELECT * FROM Customers WHERE CustPhone = '" + strPhone + "';";
                try
                {
                    adaptSQL = new SqlDataAdapter(strSQL, connSQL);
                    adaptSQL.Fill(dtCust);
                    adaptSQL.Dispose();
                    dataGridView1.DataSource = dtCust;
                }
                catch
                {
                    blnOK = false;
                    dtCust.Dispose();
                }
                finally
                {
                    connSQL.Close();
                    connSQL.Dispose();
                    nudQuanity.Focus();
                    btnAccept.Enabled = true;

                }
                if (dtCust.Rows.Count > 0)  
                {
                    txtName.Text = dtCust.Rows[0]["CustName"].ToString();
                    txtAddress1.Text = dtCust.Rows[0]["CustAddress1"].ToString();
                    txtAddress2.Text = dtCust.Rows[0]["CustAddress2"].ToString();
                    txtCity.Text = dtCust.Rows[0]["CustCity"].ToString();
                    cboState.Text = dtCust.Rows[0]["CustState"].ToString();
                    mtbZipCode.Text = dtCust.Rows[0]["CustZip"].ToString();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }
        
        private void frmMiPi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgRes;
            dlgRes = MessageBox.Show("Do you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgRes == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }

        private void frmMiPi_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Order form close completed!");

            ResetForm();
        }



        private void Pricing() //Dynamic pricing
        {
            if (radSmall.Checked)
            { sglPrice = 8.0f; }
            else if (radMedium.Checked)
            { sglPrice = 10.0f; }
            else
            { sglPrice = 12.0f; }

            if (chkCheese.Checked)
                sglPrice += 1.0f;
            if (chkBlackOlives.Checked)
                sglPrice += 1.0f;
            if (chkGreenOlives.Checked)
                sglPrice += 1.0f;
            if (chkHam.Checked)
                sglPrice += 1.0f;
            if (chkHamburger.Checked)
                sglPrice += 1.0f;
            if (chkMushrooms.Checked)
                sglPrice += 1.0f;
            if (chkOnions.Checked)
                sglPrice += 1.0f;
            if (chkPepperoni.Checked)
                sglPrice += 1.0f;
            if (chkPineapple.Checked)
                sglPrice += 1.0f;
            if (chkSausage.Checked)
                sglPrice += 1.0f;

            sglPrice *= Convert.ToSingle(nudQuanity.Value);

            lblSub.Text = sglPrice.ToString("c");

            Single sglTax;

            sglTax = sglPrice * sgltaxRate;

            lblTx.Text = sglTax.ToString("c");

            Single sglTotal;

            sglTotal = sglPrice + sglTax;

            label1.Text = sglTotal.ToString("c");
        }
        
        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkPineapple_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkGreenOlives_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void frmMiPi_Load(object sender, EventArgs e)
        {

            string strFilePath = Application.StartupPath + "/../../StateAbbrev.txt";
            string strState;
            try
            {
                FileStream fsState = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
                StreamReader srStates = new StreamReader(fsState);

                while (!srStates.EndOfStream)
                {
                    strState = srStates.ReadLine();
                    cboState.Items.Add(strState);
                }
            }
            catch
            {
                MessageBox.Show("Error Reading States File!");
            }

            ResetForm();
                                                
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            int counter = int.Parse(lblNumber.Text);
            counter++;
            lblNumber.Text = counter.ToString("d4");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt) | *.txt";
            sfd.ShowDialog();
            try
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txtName.Text);
                sw.WriteLine(lblNumber.Text);
                sw.WriteLine(label1.Text);
                sw.Close();
            }
            catch
            {
                txtName.Clear();
                MessageBox.Show("Data Successfully Written", "File IO");
            }
            ResetForm();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Pricing();

        }

        private void grpCustomerInfo_Enter(object sender, EventArgs e)
        {
            lblPhoneNbrError.Visible = false;
            lblNameError.Visible = false;
            lblAddressError.Visible = false;
            lblCityError.Visible = false;
        }

        private void tmrDT_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length < 10)
            {
                lblPhoneNbrError.Visible = true;  //turn on error label
                mtbPhone.SelectAll();             //highlight text
                mtbPhone.Focus();                 //place focus back in box
            }
            else
            {
                lblPhoneNbrError.Visible = false;
                blnPhone = true;
                acceptCheck();
            }
        }

        private void acceptCheck()
       {
            if (blnPhone && blnName && blnZipCode && blnCity && blnAddress1)
                btnAccept.Enabled = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 5)
            {
                lblNameError.Visible = true;      //turn on error label
                txtName.SelectAll();             //highlight text
                txtName.Focus();                 //place focus back in box
            }
            else
            {
                lblNameError.Visible = false;
                blnName = true;
                acceptCheck();
            }
        }

        private void txtAddress1_Leave(object sender, EventArgs e)
        {
            if (txtAddress1.Text.Length < 5)
            {
                lblAddressError.Visible = true;      //turn on error label
                txtAddress1.SelectAll();             //highlight text
                txtAddress1.Focus();                 //place focus back in box
            }

            else
            {
                lblAddressError.Visible = false;
                blnAddress1 = true;
                acceptCheck();
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Length < 2)
            {
                lblCityError.Visible = true;      //turn on error label
                txtCity.SelectAll();             //highlight text
                txtCity.Focus();                 //place focus back in box
            }

            else
            {
                lblCityError.Visible = false;
                blnCity = true;
                acceptCheck();
            }
        }

        private void mtbZipCode_Validating(object sender, CancelEventArgs e)
        {
            if (mtbZipCode.Text.Length == 5 | mtbZipCode.Text.Length == 9)
            {
                mtbZipCode.ForeColor = Color.Black;
                blnZipCode = true;
                acceptCheck();
            }
            else
            {
                mtbZipCode.ForeColor = Color.Red;
                e.Cancel = true;
                
            }
        }

        private void ResetForm()
        {
            foreach (Control c in grpCustomerInfo.Controls)
            {

                if (c is TextBox)                                  // Clear All Text Boxes
                {
                    ((TextBox)c).Clear();
                }
                else if (c is MaskedTextBox)                         //Clear All MaskedTextBoxes
                {
                    ((MaskedTextBox)c).Text = "";
                }
                else if (c is ComboBox)                               //Clear ComboBox
                {
                    ((ComboBox)c).Text = "";
                }

            }

            foreach (Control a in grpOrderInfo.Controls)          //Clear Numeric UpDown
            {
                if (a is NumericUpDown)
                {
                    ((NumericUpDown)a).Value = 1;
                }
            }

            foreach (Control x in grpSize.Controls)
            {

                if (x is RadioButton)                              //Clear all Radio Buttons
                {
                    ((RadioButton)x).Checked = false;
                }
            }

            foreach (Control i in grpToppings.Controls)            //Clear all Checkboxes
            {
                if (i is CheckBox)
                {
                    ((CheckBox)i).Checked = false;
                }
            }

            foreach (Control c in grpPayment.Controls)              //Clear combobox
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }

            foreach (Control y in grpPricing.Controls)              //Clear combobox
            {
                if (y is TextBox)                                  // Clear All Text Boxes
                {
                    ((TextBox)y).Clear();
                }
            }

            mtbPhone.Focus();
            blnPhone = false;
            blnName = false;
            blnCity = false;
            blnAddress1 = false;
            blnZipCode = false;
            btnAccept.Enabled = false;
            cboState.SelectedItem = "MN";
            cboPayment.SelectedItem = "CASH";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkBlackOlives_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length == 10)
            {
                CustSearch();
            }
        }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPayment.SelectedItem = "CASH";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider1.SetError(txtName, "Only letters allowed");
                e.Handled = true;
                txtName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbPhone_TextChanged_1(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length == 10)
            {
                CustSearch();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string strConn = strDataSrc + strSQLparms;
            SqlDataAdapter adaptSQL = new SqlDataAdapter(strSQL, connSQL);
            SqlCommand cmdCust = new SqlCommand();
            SqlCommandBuilder cmdBld = new SqlCommandBuilder(adaptSQL);
            DataRow newCust;
            newCust = dtCust.NewRow();   //datCust is the datatable
            newCust["CustPhone"] = mtbPhone.Text;
            newCust["CustName"] = txtName.Text;
            newCust["CustAddress1"] = txtAddress1.Text;
            newCust["CustAddress2"] = txtAddress2.Text;
            newCust["CustCity"] = txtCity.Text;
            newCust["CustState"] = cboState.Text;
            newCust["CustZip"] = mtbZipCode.Text;
            try
            {
                dtCust.Rows.Add(newCust);   //Add datarow to table
                cmdBld.GetUpdateCommand();   //collect updates to datatable
                adaptSQL.Update(dtCust);
                MessageBox.Show("Customer Added!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Customer Add Failed!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
    }

     