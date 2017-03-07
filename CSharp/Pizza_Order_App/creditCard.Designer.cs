namespace PizzaProject
{
    partial class frmcreditCard
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.mtbCCNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.cboExMonth = new System.Windows.Forms.ComboBox();
            this.cboExYear = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblExMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Maroon;
            this.lblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCompanyName.Font = new System.Drawing.Font("Papyrus", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCompanyName.Location = new System.Drawing.Point(218, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(341, 86);
            this.lblCompanyName.TabIndex = 10;
            this.lblCompanyName.Text = "MiPi Pizzeria";
            // 
            // mtbCCNumber
            // 
            this.mtbCCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCCNumber.Location = new System.Drawing.Point(278, 144);
            this.mtbCCNumber.Mask = "0000-0000-0000-0000";
            this.mtbCCNumber.Name = "mtbCCNumber";
            this.mtbCCNumber.Size = new System.Drawing.Size(169, 26);
            this.mtbCCNumber.TabIndex = 1;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.Location = new System.Drawing.Point(146, 147);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(127, 20);
            this.lblCreditCard.TabIndex = 12;
            this.lblCreditCard.Text = "Credit number:";
            // 
            // cboExMonth
            // 
            this.cboExMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExMonth.FormattingEnabled = true;
            this.cboExMonth.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboExMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboExMonth.Location = new System.Drawing.Point(278, 199);
            this.cboExMonth.Name = "cboExMonth";
            this.cboExMonth.Size = new System.Drawing.Size(89, 21);
            this.cboExMonth.TabIndex = 2;
            this.cboExMonth.SelectedIndexChanged += new System.EventHandler(this.cboExMonth_SelectedIndexChanged);
            // 
            // cboExYear
            // 
            this.cboExYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExYear.FormattingEnabled = true;
            this.cboExYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboExYear.Location = new System.Drawing.Point(406, 199);
            this.cboExYear.Name = "cboExYear";
            this.cboExYear.Size = new System.Drawing.Size(89, 21);
            this.cboExYear.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Silver;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(531, 448);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 45);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(686, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblExMonth
            // 
            this.lblExMonth.AutoSize = true;
            this.lblExMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExMonth.Location = new System.Drawing.Point(140, 197);
            this.lblExMonth.Name = "lblExMonth";
            this.lblExMonth.Size = new System.Drawing.Size(135, 20);
            this.lblExMonth.TabIndex = 17;
            this.lblExMonth.Text = "Expiration date:";
            // 
            // frmcreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(824, 505);
            this.Controls.Add(this.lblExMonth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboExYear);
            this.Controls.Add(this.cboExMonth);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.mtbCCNumber);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "frmcreditCard";
            this.Text = "Credit Card Verification";
            this.Load += new System.EventHandler(this.frmcreditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.MaskedTextBox mtbCCNumber;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.ComboBox cboExMonth;
        private System.Windows.Forms.ComboBox cboExYear;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblExMonth;
    }
}