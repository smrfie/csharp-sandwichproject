using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        private List<Vendor> vendors = null; //creates vendor list, as well as a count
        private int intCount = 0;            //boolean is to notify form that information has changed
        private bool blnChange = false;
        /// <summary>
        /// Load method populates combo box, as well as populates textboxes with Vendor information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVendor_Load(object sender, EventArgs e)
        {
            cboDays.Items.Add("10");
            cboDays.Items.Add("15");
            cboDays.Items.Add("20");
            FillVendorForm(intCount);
        }
        /// <summary>
        /// Sets all vendor variables to current textboxes, combo box matches DefaultDiscount, makes sure
        /// the TextChanged (Change) function does not fire upon changing textboxes
        /// </summary>
        /// <param name="pos"></param>
        private void FillVendorForm(int pos)
        {
            vendors = VendorDB.GetVendors();
            txtName.Text = vendors[pos].Name;
            txtAddress.Text = vendors[pos].Address;
            txtCity.Text = vendors[pos].City;
            txtState.Text = vendors[pos].State;
            txtZip.Text = vendors[pos].Zip;
            txtPhone.Text = vendors[pos].Phone;
            txtYTD.Text = vendors[pos].YTD.ToString();
            txtComments.Text = vendors[pos].Comment;
            txtContact.Text = vendors[pos].Contact;
            cboDays.SelectedItem = vendors[pos].DefaultDiscount.ToString();
            blnChange = false;
        }
        /// <summary>
        /// Validation method that calls on Validator class
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            return Validator.IsPresent(txtName) &&
                   Validator.IsPresent(txtAddress) &&
                   Validator.IsPresent(txtCity) &&
                   Validator.IsPresent(txtState) &&
                   Validator.IsPresent(txtZip) &&
                   Validator.IsPresent(txtPhone) &&
                   Validator.IsPresent(txtYTD) &&
                   Validator.IsDecimal(txtYTD) &&
                   Validator.IsPresent(txtContact);
        }
        /// <summary>
        /// Next button that cycles through the Vendor List, as well as calls upon Save actions w/o clicking save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (blnChange == true)
            {
                if (IsValidData())
                {
                    DialogResult button = MessageBox.Show("There is unsaved data on this form. Would you like to save?",
                        "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (button == DialogResult.Yes)
                    {
                        SaveVendors();
                        intCount++;
                        if (intCount == vendors.Count)
                            intCount = 0;

                        FillVendorForm(intCount);
                        blnChange = false;
                    }
                    if (button == DialogResult.No)
                    {
                        intCount++;
                        if (intCount == vendors.Count)
                            intCount = 0;

                        FillVendorForm(intCount);
                        blnChange = false;
                    }
                }
            }
            else
            {
                if (IsValidData())
                {
                    intCount++;
                    if (intCount == vendors.Count)
                        intCount = 0;

                    FillVendorForm(intCount);
                }
            }
        }
        /// <summary>
        /// Previous button that cycles through the Vendor List, as well as calls upon Save action w/o clicking the save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (blnChange == true)
            {
                if (IsValidData())
                {
                    DialogResult button = MessageBox.Show("There is unsaved data on this form. Would you like to save?",
                    "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (button == DialogResult.Yes)
                    {
                        if (IsValidData())
                        {
                            SaveVendors();
                            if (intCount == 0)
                                intCount = vendors.Count() - 1;
                            else
                                intCount--;

                            FillVendorForm(intCount);
                            blnChange = false;
                        }
                    }
                    if (button == DialogResult.No)
                    {
                        if (IsValidData())
                        {
                            if (intCount == 0)
                                intCount = vendors.Count - 1;
                            else
                                intCount--;

                            FillVendorForm(intCount);
                            blnChange = false;
                        }
                    }
                }
            }
            else
            {
                if (IsValidData())
                {
                    if (intCount == 0)
                        intCount = vendors.Count - 1;
                    else
                        intCount--;

                    FillVendorForm(intCount);
                }
            }
        }
        /// <summary>
        /// Checks to see if any Textboxes / the CBO Box have changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change(object sender, EventArgs e)
        {
            blnChange = true;
        }
        /// <summary>
        /// Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveVendors();
            }
        }
        /// <summary>
        /// Closes program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Method that saves texboxes to the current Vendor
        /// </summary>
        private void SaveVendors()
        {
            vendors[intCount].Name = txtName.Text;
            vendors[intCount].Address = txtAddress.Text;
            vendors[intCount].City = txtCity.Text;
            vendors[intCount].State = txtState.Text;
            vendors[intCount].Zip = txtZip.Text;
            vendors[intCount].Phone = txtPhone.Text;
            vendors[intCount].YTD = Convert.ToDecimal(txtYTD.Text);
            vendors[intCount].Comment = txtComments.Text;
            vendors[intCount].Contact = txtContact.Text;
            vendors[intCount].DefaultDiscount = Convert.ToInt32(cboDays.SelectedItem);
            VendorDB.SaveVendors(vendors);
            blnChange = false;
        }
    }
}
