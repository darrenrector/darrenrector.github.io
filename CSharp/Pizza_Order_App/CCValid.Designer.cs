namespace PizzaProject
{
    partial class frmCCValid
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
            this.mtbCardNum = new System.Windows.Forms.MaskedTextBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblimportCC = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbCardNum
            // 
            this.mtbCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCardNum.Location = new System.Drawing.Point(195, 192);
            this.mtbCardNum.Mask = "0000-0000-0000-0000";
            this.mtbCardNum.Name = "mtbCardNum";
            this.mtbCardNum.Size = new System.Drawing.Size(166, 26);
            this.mtbCardNum.TabIndex = 0;
            this.mtbCardNum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCardNum_MaskInputRejected);
            this.mtbCardNum.TextChanged += new System.EventHandler(this.mtbCardNum_TextChanged);
            this.mtbCardNum.Leave += new System.EventHandler(this.mtbCardNum_Leave);
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(195, 239);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(46, 28);
            this.cboMonth.TabIndex = 1;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(275, 239);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(86, 28);
            this.cboYear.TabIndex = 2;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblExpDate.Location = new System.Drawing.Point(51, 242);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(138, 20);
            this.lblExpDate.TabIndex = 5;
            this.lblExpDate.Text = "Expiration Date:";
            this.lblExpDate.Click += new System.EventHandler(this.lblExpDate_Click);
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblCardNum.Location = new System.Drawing.Point(17, 194);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(172, 20);
            this.lblCardNum.TabIndex = 6;
            this.lblCardNum.Text = "Credit Card Number:";
            this.lblCardNum.Click += new System.EventHandler(this.lblCardNum_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(360, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(480, 418);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(95, 38);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblCreditCard.Location = new System.Drawing.Point(84, 152);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(105, 20);
            this.lblCreditCard.TabIndex = 7;
            this.lblCreditCard.Text = "Credit Card:";
            this.lblCreditCard.Click += new System.EventHandler(this.lblCreditCard_Click);
            // 
            // lblimportCC
            // 
            this.lblimportCC.AutoSize = true;
            this.lblimportCC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblimportCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblimportCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimportCC.Location = new System.Drawing.Point(195, 152);
            this.lblimportCC.Name = "lblimportCC";
            this.lblimportCC.Size = new System.Drawing.Size(2, 22);
            this.lblimportCC.TabIndex = 8;
            this.lblimportCC.Click += new System.EventHandler(this.lblimportCC_Click);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblCust.Location = new System.Drawing.Point(98, 110);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(91, 20);
            this.lblCust.TabIndex = 9;
            this.lblCust.Text = "Customer:";
            this.lblCust.Click += new System.EventHandler(this.lblCust_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(195, 108);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(2, 22);
            this.lblCustomerName.TabIndex = 10;
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Goldenrod;
            this.lblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompanyName.Font = new System.Drawing.Font("Papyrus", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Maroon;
            this.lblCompanyName.Location = new System.Drawing.Point(102, -1);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(341, 86);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "MiPi Pizzeria";
            // 
            // frmCCValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(587, 468);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.lblimportCC);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCardNum);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.mtbCardNum);
            this.Name = "frmCCValid";
            this.Text = "Credit Card Validation";
            this.Load += new System.EventHandler(this.frmCCValid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCardNum;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblimportCC;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCompanyName;
    }
}