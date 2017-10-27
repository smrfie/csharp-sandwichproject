namespace WindowsFormsApplication1
{
    partial class frmCustomer
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSubdivisionLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpoDeliveryLocation = new System.Windows.Forms.GroupBox();
            this.mskDeliveryZipcode = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDeliverySubdivision = new System.Windows.Forms.TextBox();
            this.txtDeliveryCity = new System.Windows.Forms.TextBox();
            this.txtDeliveryStreet = new System.Windows.Forms.TextBox();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskZipCode = new System.Windows.Forms.MaskedTextBox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.rdoPickUp = new System.Windows.Forms.RadioButton();
            this.gpoDeliveryLocation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(146, 77);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtSubdivisionLocation
            // 
            this.txtSubdivisionLocation.Location = new System.Drawing.Point(146, 205);
            this.txtSubdivisionLocation.Name = "txtSubdivisionLocation";
            this.txtSubdivisionLocation.Size = new System.Drawing.Size(100, 20);
            this.txtSubdivisionLocation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Subdivision Location:";
            // 
            // gpoDeliveryLocation
            // 
            this.gpoDeliveryLocation.Controls.Add(this.mskDeliveryZipcode);
            this.gpoDeliveryLocation.Controls.Add(this.label8);
            this.gpoDeliveryLocation.Controls.Add(this.label10);
            this.gpoDeliveryLocation.Controls.Add(this.label11);
            this.gpoDeliveryLocation.Controls.Add(this.label12);
            this.gpoDeliveryLocation.Controls.Add(this.txtDeliverySubdivision);
            this.gpoDeliveryLocation.Controls.Add(this.txtDeliveryCity);
            this.gpoDeliveryLocation.Controls.Add(this.txtDeliveryStreet);
            this.gpoDeliveryLocation.Location = new System.Drawing.Point(9, 332);
            this.gpoDeliveryLocation.Name = "gpoDeliveryLocation";
            this.gpoDeliveryLocation.Size = new System.Drawing.Size(325, 153);
            this.gpoDeliveryLocation.TabIndex = 3;
            this.gpoDeliveryLocation.TabStop = false;
            this.gpoDeliveryLocation.Text = "Delivery Location:";
            // 
            // mskDeliveryZipcode
            // 
            this.mskDeliveryZipcode.Location = new System.Drawing.Point(158, 89);
            this.mskDeliveryZipcode.Name = "mskDeliveryZipcode";
            this.mskDeliveryZipcode.Size = new System.Drawing.Size(100, 20);
            this.mskDeliveryZipcode.TabIndex = 2;
            this.mskDeliveryZipcode.TextChanged += new System.EventHandler(this.DeliveryTextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Subdivision Location:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Zip Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "City:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Address:";
            // 
            // txtDeliverySubdivision
            // 
            this.txtDeliverySubdivision.Location = new System.Drawing.Point(158, 120);
            this.txtDeliverySubdivision.Name = "txtDeliverySubdivision";
            this.txtDeliverySubdivision.Size = new System.Drawing.Size(100, 20);
            this.txtDeliverySubdivision.TabIndex = 3;
            this.txtDeliverySubdivision.TextChanged += new System.EventHandler(this.DeliveryTextChanged);
            // 
            // txtDeliveryCity
            // 
            this.txtDeliveryCity.Location = new System.Drawing.Point(157, 56);
            this.txtDeliveryCity.Name = "txtDeliveryCity";
            this.txtDeliveryCity.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryCity.TabIndex = 1;
            this.txtDeliveryCity.TextChanged += new System.EventHandler(this.DeliveryTextChanged);
            // 
            // txtDeliveryStreet
            // 
            this.txtDeliveryStreet.Location = new System.Drawing.Point(157, 23);
            this.txtDeliveryStreet.Name = "txtDeliveryStreet";
            this.txtDeliveryStreet.Size = new System.Drawing.Size(132, 20);
            this.txtDeliveryStreet.TabIndex = 0;
            this.txtDeliveryStreet.TextChanged += new System.EventHandler(this.DeliveryTextChanged);
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(9, 309);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(218, 17);
            this.chkDelivery.TabIndex = 2;
            this.chkDelivery.Text = "Delivery Address same as Billing Address";
            this.chkDelivery.UseVisualStyleBackColor = true;
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkDelivery_CheckedChanged);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(146, 45);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(132, 20);
            this.txtCustomerAddress.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(146, 13);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(132, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(253, 488);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(6, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "HC, LP, RM, MZ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(146, 109);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(43, 20);
            this.txtState.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskZipCode);
            this.groupBox1.Controls.Add(this.mskPhoneNumber);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtSubdivisionLocation);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // mskZipCode
            // 
            this.mskZipCode.Location = new System.Drawing.Point(146, 141);
            this.mskZipCode.Name = "mskZipCode";
            this.mskZipCode.Size = new System.Drawing.Size(100, 20);
            this.mskZipCode.TabIndex = 4;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(146, 173);
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.mskPhoneNumber.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoDelivery);
            this.groupBox2.Controls.Add(this.rdoPickUp);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery Options";
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Location = new System.Drawing.Point(86, 19);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(63, 17);
            this.rdoDelivery.TabIndex = 1;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            this.rdoDelivery.CheckedChanged += new System.EventHandler(this.rdoDelivery_CheckChanged);
            // 
            // rdoPickUp
            // 
            this.rdoPickUp.AutoSize = true;
            this.rdoPickUp.Checked = true;
            this.rdoPickUp.Location = new System.Drawing.Point(7, 20);
            this.rdoPickUp.Name = "rdoPickUp";
            this.rdoPickUp.Size = new System.Drawing.Size(63, 17);
            this.rdoPickUp.TabIndex = 0;
            this.rdoPickUp.TabStop = true;
            this.rdoPickUp.Text = "Pick Up";
            this.rdoPickUp.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(382, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDelivery);
            this.Controls.Add(this.gpoDeliveryLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Details";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.gpoDeliveryLocation.ResumeLayout(false);
            this.gpoDeliveryLocation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSubdivisionLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpoDeliveryLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDeliverySubdivision;
        private System.Windows.Forms.TextBox txtDeliveryCity;
        private System.Windows.Forms.TextBox txtDeliveryStreet;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.RadioButton rdoPickUp;
        private System.Windows.Forms.MaskedTextBox mskDeliveryZipcode;
        private System.Windows.Forms.MaskedTextBox mskZipCode;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
    }
}