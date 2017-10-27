namespace WindowsFormsApplication1
{
    partial class frmVendor
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
            this.cboDays = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYTD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDays
            // 
            this.cboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDays.FormattingEnabled = true;
            this.cboDays.Location = new System.Drawing.Point(113, 309);
            this.cboDays.Name = "cboDays";
            this.cboDays.Size = new System.Drawing.Size(95, 21);
            this.cboDays.TabIndex = 47;
            this.cboDays.TextChanged += new System.EventHandler(this.Change);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Payment Period:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(228, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(108, 340);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 43;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(21, 340);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(108, 276);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 41;
            this.txtContact.Tag = "Contact";
            this.txtContact.TextChanged += new System.EventHandler(this.Change);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Contact:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(108, 243);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(156, 20);
            this.txtComments.TabIndex = 39;
            this.txtComments.Tag = "Comments";
            this.txtComments.TextChanged += new System.EventHandler(this.Change);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Comments:";
            // 
            // txtYTD
            // 
            this.txtYTD.Location = new System.Drawing.Point(108, 210);
            this.txtYTD.Name = "txtYTD";
            this.txtYTD.Size = new System.Drawing.Size(156, 20);
            this.txtYTD.TabIndex = 37;
            this.txtYTD.Tag = "YTD";
            this.txtYTD.TextChanged += new System.EventHandler(this.Change);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "YTD:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(108, 177);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 35;
            this.txtPhone.Tag = "Phone";
            this.txtPhone.TextChanged += new System.EventHandler(this.Change);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phone:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(108, 144);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 33;
            this.txtZip.Tag = "Zip";
            this.txtZip.TextChanged += new System.EventHandler(this.Change);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Zip:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(108, 111);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 31;
            this.txtState.Tag = "State";
            this.txtState.TextChanged += new System.EventHandler(this.Change);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(108, 78);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 29;
            this.txtCity.Tag = "City";
            this.txtCity.TextChanged += new System.EventHandler(this.Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 45);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 20);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Tag = "Address";
            this.txtAddress.TextChanged += new System.EventHandler(this.Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 25;
            this.txtName.Tag = "Name";
            this.txtName.TextChanged += new System.EventHandler(this.Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 406);
            this.Controls.Add(this.cboDays);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYTD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmVendor";
            this.Text = "frmVendor";
            this.Load += new System.EventHandler(this.frmVendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYTD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}