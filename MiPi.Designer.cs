namespace PizzaProject
{
    partial class frmMiPi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiPi));
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCityError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblPhoneNbrError = new System.Windows.Forms.Label();
            this.mtbZipCode = new System.Windows.Forms.MaskedTextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnFindOrder = new System.Windows.Forms.Button();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMaxQuanity = new System.Windows.Forms.Label();
            this.nudQuanity = new System.Windows.Forms.NumericUpDown();
            this.lblQuanity = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkHamburger = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenOlives = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.grpPricing = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTx = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tmrDT = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFileCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainFilePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainFileClearClip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mastercardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.americanExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCustomerInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanity)).BeginInit();
            this.grpToppings.SuspendLayout();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.grpPricing.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.btnAddCustomer);
            this.grpCustomerInfo.Controls.Add(this.lblCityError);
            this.grpCustomerInfo.Controls.Add(this.lblAddressError);
            this.grpCustomerInfo.Controls.Add(this.lblNameError);
            this.grpCustomerInfo.Controls.Add(this.lblPhoneNbrError);
            this.grpCustomerInfo.Controls.Add(this.mtbZipCode);
            this.grpCustomerInfo.Controls.Add(this.cboState);
            this.grpCustomerInfo.Controls.Add(this.txtCity);
            this.grpCustomerInfo.Controls.Add(this.txtAddress2);
            this.grpCustomerInfo.Controls.Add(this.txtAddress1);
            this.grpCustomerInfo.Controls.Add(this.txtName);
            this.grpCustomerInfo.Controls.Add(this.mtbPhone);
            this.grpCustomerInfo.Controls.Add(this.lblZipCode);
            this.grpCustomerInfo.Controls.Add(this.lblState);
            this.grpCustomerInfo.Controls.Add(this.lblCity);
            this.grpCustomerInfo.Controls.Add(this.lblAddress2);
            this.grpCustomerInfo.Controls.Add(this.lblAddress1);
            this.grpCustomerInfo.Controls.Add(this.lblName);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.Location = new System.Drawing.Point(12, 111);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(294, 493);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer &Information";
            this.grpCustomerInfo.Enter += new System.EventHandler(this.grpCustomerInfo_Enter);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(96, 400);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(154, 28);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCityError
            // 
            this.lblCityError.AutoEllipsis = true;
            this.lblCityError.AutoSize = true;
            this.lblCityError.BackColor = System.Drawing.Color.Transparent;
            this.lblCityError.ForeColor = System.Drawing.Color.Maroon;
            this.lblCityError.Location = new System.Drawing.Point(92, 263);
            this.lblCityError.Name = "lblCityError";
            this.lblCityError.Size = new System.Drawing.Size(96, 20);
            this.lblCityError.TabIndex = 17;
            this.lblCityError.Text = "Invalid City";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoEllipsis = true;
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressError.ForeColor = System.Drawing.Color.Maroon;
            this.lblAddressError.Location = new System.Drawing.Point(92, 163);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(132, 20);
            this.lblAddressError.TabIndex = 16;
            this.lblAddressError.Text = "Invalid Address";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoEllipsis = true;
            this.lblNameError.AutoSize = true;
            this.lblNameError.BackColor = System.Drawing.Color.Transparent;
            this.lblNameError.ForeColor = System.Drawing.Color.Maroon;
            this.lblNameError.Location = new System.Drawing.Point(92, 115);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(112, 20);
            this.lblNameError.TabIndex = 15;
            this.lblNameError.Text = "Invalid Name";
            // 
            // lblPhoneNbrError
            // 
            this.lblPhoneNbrError.AutoEllipsis = true;
            this.lblPhoneNbrError.AutoSize = true;
            this.lblPhoneNbrError.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNbrError.ForeColor = System.Drawing.Color.Maroon;
            this.lblPhoneNbrError.Location = new System.Drawing.Point(92, 67);
            this.lblPhoneNbrError.Name = "lblPhoneNbrError";
            this.lblPhoneNbrError.Size = new System.Drawing.Size(184, 20);
            this.lblPhoneNbrError.TabIndex = 14;
            this.lblPhoneNbrError.Text = "Invalid Phone Number";
            // 
            // mtbZipCode
            // 
            this.mtbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbZipCode.Location = new System.Drawing.Point(96, 351);
            this.mtbZipCode.Mask = "00000-9999";
            this.mtbZipCode.Name = "mtbZipCode";
            this.mtbZipCode.Size = new System.Drawing.Size(77, 22);
            this.mtbZipCode.TabIndex = 13;
            this.mtbZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.mtbZipCode_Validating);
            // 
            // cboState
            // 
            this.cboState.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.DropDownWidth = 61;
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.IntegralHeight = false;
            this.cboState.ItemHeight = 20;
            this.cboState.Location = new System.Drawing.Point(96, 296);
            this.cboState.MaxDropDownItems = 10;
            this.cboState.MaxLength = 2;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(61, 28);
            this.cboState.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(96, 234);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(178, 22);
            this.txtCity.TabIndex = 9;
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(96, 186);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(178, 22);
            this.txtAddress2.TabIndex = 7;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(96, 138);
            this.txtAddress1.MaxLength = 25;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(178, 22);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(96, 90);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 22);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.Location = new System.Drawing.Point(96, 42);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(133, 22);
            this.mtbPhone.TabIndex = 1;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPhone.TextChanged += new System.EventHandler(this.mtbPhone_TextChanged_1);
            this.mtbPhone.Leave += new System.EventHandler(this.mtbPhone_Leave);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(6, 357);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(78, 20);
            this.lblZipCode.TabIndex = 12;
            this.lblZipCode.Text = "Zipcode:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(6, 305);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(58, 20);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(9, 240);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 20);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "&City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(6, 192);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(90, 20);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(6, 145);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(90, 20);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address1:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 44);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.btnFindOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOrder.Location = new System.Drawing.Point(606, 405);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(225, 34);
            this.btnFindOrder.TabIndex = 18;
            this.btnFindOrder.Text = "Find Order";
            this.btnFindOrder.UseVisualStyleBackColor = false;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.lblNumber);
            this.grpOrderInfo.Controls.Add(this.lblMaxQuanity);
            this.grpOrderInfo.Controls.Add(this.nudQuanity);
            this.grpOrderInfo.Controls.Add(this.lblQuanity);
            this.grpOrderInfo.Controls.Add(this.grpToppings);
            this.grpOrderInfo.Controls.Add(this.grpSize);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumber);
            this.grpOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderInfo.Location = new System.Drawing.Point(318, 111);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(268, 493);
            this.grpOrderInfo.TabIndex = 1;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Or&der Information";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(176, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(57, 22);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "0";
            // 
            // lblMaxQuanity
            // 
            this.lblMaxQuanity.AutoSize = true;
            this.lblMaxQuanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuanity.Location = new System.Drawing.Point(184, 453);
            this.lblMaxQuanity.Name = "lblMaxQuanity";
            this.lblMaxQuanity.Size = new System.Drawing.Size(70, 16);
            this.lblMaxQuanity.TabIndex = 6;
            this.lblMaxQuanity.Text = "(Max. 10)";
            // 
            // nudQuanity
            // 
            this.nudQuanity.Location = new System.Drawing.Point(125, 451);
            this.nudQuanity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuanity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuanity.Name = "nudQuanity";
            this.nudQuanity.Size = new System.Drawing.Size(50, 26);
            this.nudQuanity.TabIndex = 3;
            this.nudQuanity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuanity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.Location = new System.Drawing.Point(41, 452);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(75, 20);
            this.lblQuanity.TabIndex = 5;
            this.lblQuanity.Text = "&Quanity:";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkHamburger);
            this.grpToppings.Controls.Add(this.chkOnions);
            this.grpToppings.Controls.Add(this.chkPineapple);
            this.grpToppings.Controls.Add(this.chkHam);
            this.grpToppings.Controls.Add(this.chkBlackOlives);
            this.grpToppings.Controls.Add(this.chkGreenOlives);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkCheese);
            this.grpToppings.Location = new System.Drawing.Point(39, 148);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(200, 287);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "&Toppings ($1.00)";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(39, 259);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(106, 20);
            this.chkMushrooms.TabIndex = 9;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkHamburger
            // 
            this.chkHamburger.AutoSize = true;
            this.chkHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHamburger.Location = new System.Drawing.Point(39, 233);
            this.chkHamburger.Name = "chkHamburger";
            this.chkHamburger.Size = new System.Drawing.Size(104, 20);
            this.chkHamburger.TabIndex = 8;
            this.chkHamburger.Text = "Hamburger";
            this.chkHamburger.UseVisualStyleBackColor = true;
            this.chkHamburger.CheckedChanged += new System.EventHandler(this.chkHamburger_CheckedChanged);
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnions.Location = new System.Drawing.Point(39, 207);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(75, 20);
            this.chkOnions.TabIndex = 7;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(39, 181);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(98, 20);
            this.chkPineapple.TabIndex = 6;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.chkPineapple_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(39, 155);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(59, 20);
            this.chkHam.TabIndex = 5;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.chkHam_CheckedChanged);
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlives.Location = new System.Drawing.Point(39, 129);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(114, 20);
            this.chkBlackOlives.TabIndex = 4;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            this.chkBlackOlives.CheckedChanged += new System.EventHandler(this.chkBlackOlives_CheckedChanged);
            // 
            // chkGreenOlives
            // 
            this.chkGreenOlives.AutoSize = true;
            this.chkGreenOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenOlives.Location = new System.Drawing.Point(39, 103);
            this.chkGreenOlives.Name = "chkGreenOlives";
            this.chkGreenOlives.Size = new System.Drawing.Size(117, 20);
            this.chkGreenOlives.TabIndex = 3;
            this.chkGreenOlives.Text = "&Green Olives";
            this.chkGreenOlives.UseVisualStyleBackColor = true;
            this.chkGreenOlives.CheckedChanged += new System.EventHandler(this.chkGreenOlives_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(39, 77);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(99, 20);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(39, 51);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(89, 20);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chkSausage_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.Location = new System.Drawing.Point(39, 25);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(80, 20);
            this.chkCheese.TabIndex = 0;
            this.chkCheese.Text = "C&heese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(39, 47);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 96);
            this.grpSize.TabIndex = 3;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Si&ze";
            // 
            // radLarge
            // 
            this.radLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarge.Location = new System.Drawing.Point(38, 75);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(128, 20);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large ($12.00) ";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedium.Location = new System.Drawing.Point(38, 50);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(138, 20);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium ($10.00)";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radSmall.AutoSize = true;
            this.radSmall.BackColor = System.Drawing.Color.Transparent;
            this.radSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(38, 25);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(115, 20);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small ($8.00)";
            this.radSmall.UseVisualStyleBackColor = false;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(53, 22);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(131, 20);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number: ";
            // 
            // picPizza
            // 
            this.picPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPizza.Image = ((System.Drawing.Image)(resources.GetObject("picPizza.Image")));
            this.picPizza.Location = new System.Drawing.Point(846, 111);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(426, 280);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 2;
            this.picPizza.TabStop = false;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.cboPayment);
            this.grpPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.Location = new System.Drawing.Point(606, 111);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(225, 60);
            this.grpPayment.TabIndex = 3;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Pa&yment";
            // 
            // cboPayment
            // 
            this.cboPayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboPayment.DisplayMember = "Cash";
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Visa",
            "Mastercard",
            "American Express"});
            this.cboPayment.Location = new System.Drawing.Point(10, 22);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(176, 28);
            this.cboPayment.TabIndex = 0;
            this.cboPayment.SelectedIndexChanged += new System.EventHandler(this.cboPayment_SelectedIndexChanged);
            // 
            // grpPricing
            // 
            this.grpPricing.Controls.Add(this.label1);
            this.grpPricing.Controls.Add(this.lblTx);
            this.grpPricing.Controls.Add(this.lblSub);
            this.grpPricing.Controls.Add(this.lblTotal);
            this.grpPricing.Controls.Add(this.lblTax);
            this.grpPricing.Controls.Add(this.lblSubtotal);
            this.grpPricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPricing.Location = new System.Drawing.Point(606, 183);
            this.grpPricing.Name = "grpPricing";
            this.grpPricing.Size = new System.Drawing.Size(225, 150);
            this.grpPricing.TabIndex = 4;
            this.grpPricing.TabStop = false;
            this.grpPricing.Text = "P&ricing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lblTx
            // 
            this.lblTx.AutoSize = true;
            this.lblTx.Location = new System.Drawing.Point(78, 66);
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(57, 20);
            this.lblTx.TabIndex = 9;
            this.lblTx.Text = "label1";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(78, 29);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(62, 20);
            this.lblSub.TabIndex = 8;
            this.lblSub.Text = "label 1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(34, 68);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(38, 16);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(3, 29);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 16);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.chkMute);
            this.grpActions.Controls.Add(this.btnClose);
            this.grpActions.Controls.Add(this.btnReset);
            this.grpActions.Controls.Add(this.btnAccept);
            this.grpActions.Controls.Add(this.btnPrice);
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(606, 515);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(658, 89);
            this.grpActions.TabIndex = 5;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actio&ns";
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMute.Location = new System.Drawing.Point(485, 37);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(75, 28);
            this.chkMute.TabIndex = 4;
            this.chkMute.Text = "M&ute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(355, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 53);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(240, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 53);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Location = new System.Drawing.Point(125, 25);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(92, 53);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrice.Location = new System.Drawing.Point(10, 25);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(92, 53);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblDateTime.Location = new System.Drawing.Point(843, 34);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(351, 27);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Maroon;
            this.lblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompanyName.Font = new System.Drawing.Font("Papyrus", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCompanyName.Location = new System.Drawing.Point(425, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(341, 86);
            this.lblCompanyName.TabIndex = 9;
            this.lblCompanyName.Text = "MiPi Pizzeria";
            // 
            // tmrDT
            // 
            this.tmrDT.Enabled = true;
            this.tmrDT.Interval = 1000;
            this.tmrDT.Tick += new System.EventHandler(this.tmrDT_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Olive;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.paymentToolStripMenuItem,
            this.mnuMainHelp,
            this.mnuMainAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFileCopy,
            this.mnuMainFilePaste,
            this.toolStripSeparator1,
            this.mnuMainFileClearClip,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.mnuMainFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(42, 21);
            this.mnuMainFile.Text = "&File";
            // 
            // mnuMainFileCopy
            // 
            this.mnuMainFileCopy.Name = "mnuMainFileCopy";
            this.mnuMainFileCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuMainFileCopy.Size = new System.Drawing.Size(234, 22);
            this.mnuMainFileCopy.Text = "&Cut                 ";
            // 
            // mnuMainFilePaste
            // 
            this.mnuMainFilePaste.Name = "mnuMainFilePaste";
            this.mnuMainFilePaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuMainFilePaste.Size = new System.Drawing.Size(234, 22);
            this.mnuMainFilePaste.Text = "Pa&ste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuMainFileClearClip
            // 
            this.mnuMainFileClearClip.Name = "mnuMainFileClearClip";
            this.mnuMainFileClearClip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.mnuMainFileClearClip.Size = new System.Drawing.Size(234, 22);
            this.mnuMainFileClearClip.Text = "Clear C&lipboard";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.mastercardToolStripMenuItem,
            this.americanExpressToolStripMenuItem});
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.paymentToolStripMenuItem.Text = "Pay&ment";
            // 
            // cashToolStripMenuItem
            // 
            this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
            this.cashToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cashToolStripMenuItem.Text = "Cash";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.visaToolStripMenuItem.Text = "Visa";
            // 
            // mastercardToolStripMenuItem
            // 
            this.mastercardToolStripMenuItem.Name = "mastercardToolStripMenuItem";
            this.mastercardToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.mastercardToolStripMenuItem.Text = "Mastercard";
            // 
            // americanExpressToolStripMenuItem
            // 
            this.americanExpressToolStripMenuItem.Name = "americanExpressToolStripMenuItem";
            this.americanExpressToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.americanExpressToolStripMenuItem.Text = "American Express";
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(49, 21);
            this.mnuMainHelp.Text = "H&elp";
            // 
            // mnuMainAbout
            // 
            this.mnuMainAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mnuMainAbout.Name = "mnuMainAbout";
            this.mnuMainAbout.Size = new System.Drawing.Size(55, 21);
            this.mnuMainAbout.Text = "Abo&ut";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(606, 450);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(225, 34);
            this.btnAddOrder.TabIndex = 19;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Location = new System.Drawing.Point(864, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(148, 45);
            this.dataGridView2.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 623);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 75);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmMiPi
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1284, 775);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnFindOrder);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.grpOrderInfo);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grpPricing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMiPi";
            this.Text = "MiPi Order Entry Program";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMiPi_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMiPi_FormClosed);
            this.Load += new System.EventHandler(this.frmMiPi_Load);
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanity)).EndInit();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.grpPricing.ResumeLayout(false);
            this.grpPricing.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.MaskedTextBox mtbZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkHamburger;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkGreenOlives;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.Label lblMaxQuanity;
        private System.Windows.Forms.NumericUpDown nudQuanity;
        private System.Windows.Forms.Label lblQuanity;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.GroupBox grpPricing;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCompanyName;
        public System.Windows.Forms.Timer tmrDT;
        private System.Windows.Forms.Label lblPhoneNbrError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblCityError;
        internal System.Windows.Forms.ComboBox cboState;
        internal System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileCopy;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mastercardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem americanExpressToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnFindOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFilePaste;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFileClearClip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTx;
        private System.Windows.Forms.Label label1;
    }
}

