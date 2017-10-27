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
    //AUTHOR:       Hannah Christman, Lianna Pais, Ryan Murphy, Max Zhang
    //COURSE:       ISYS 250 502 
    //FORM:         frmCustomer
    //PURPOSE:      Lets user fill out customer's billing and delivery information  
    //INPUT:        User's name, address, phone number, and subdivision location
    //PROCESS:      User will enter their information and select whether they want a separate delivery address for their order. Form will
    //              run through validation checks to make sure customer's information is entered and valid for delivery. The delivery
    //              address will be the same as the billing address if the customer checks the chkdelivery option. Then the form will move the 
    //              user to frmOrder to finish the order
    //OUTPUT:       Outputs valid customer information to frmOrder
    //HONOR CODE:   “On my honor, as an Aggie, I have neither given
    //               nor received unauthorized aid on this academic
    //               work.”

    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        string strNewCustomer = ""; //defines global variables
        string strValidAddress = "";
        string strValidCity = "";
        string strValidSubdivision = "";
        string msg = "";
        
        /// <summary>
        /// Loads form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            mskPhoneNumber.Mask = "(999) 000-0000";
            mskZipCode.Mask = "00000";
            mskDeliveryZipcode.Mask = "00000";
            gpoDeliveryLocation.Enabled = false;
            chkDelivery.Enabled = false;
        }

        /// <summary>
        /// Validates data so user will be able to proceed to frmOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (rdoDelivery.Checked)
                {
                    if(IsValidDeliveryData())
                    {
                        this.SaveData();
                    }
                }
                else
                {
                    this.SaveData();
                }
            }
        }

        /// <summary>
        /// Checks that the user enters an address that is located in Bryan or College Station
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDelivery.Checked == true)
            {
                if(IsValidData())
                {
                    if (strValidCity == "Bryan" || strValidCity == "College Station")
                    {
                        if (txtState.Text == "TX")
                        {
                            txtDeliveryStreet.Text = strValidAddress;
                            txtDeliveryCity.Text = strValidCity;
                            txtDeliverySubdivision.Text = strValidSubdivision;
                            mskDeliveryZipcode.Text = mskZipCode.Text;
                        }
                        else
                        {
                            MessageBox.Show("Please make sure you are in TX.", "Processing Error");
                            txtState.Focus();
                            chkDelivery.Checked = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("The Billing Address is not in the Bryan College Station area", "Processing Error");
                        txtCity.Focus();
                        chkDelivery.Checked = false;
                    }
                    
                }  
            }
            
        }

        /// <summary>
        /// Validates the user's entered information
        /// </summary>
        /// <returns></returns>
        public bool IsValidData()
        {
            if (txtCustomerName.Text.Trim() != "" && txtCity.Text.Trim() != "" && txtCustomerAddress.Text.Trim() != "" && txtState.Text.Trim() != "" 
                && txtSubdivisionLocation.Text  != "" && mskPhoneNumber.Text.Trim() != "" && mskPhoneNumber.Mask.Length == mskPhoneNumber.Text.Length 
                && mskZipCode.Text != "" && mskZipCode.Mask.Length == mskZipCode.Text.Length)
            {
                strNewCustomer = txtCustomerName.Text.Trim();
                string[] customer = strNewCustomer.Split(' ');
                strNewCustomer = "";
                for (int i = 0; i < customer.Length; i++)
                {
                    string s = "";
                    s += customer[i].Substring(0, 1).ToUpper();
                    s += customer[i].Substring(1).ToLower();
                    strNewCustomer += s + " ";
                }
                strNewCustomer = strNewCustomer.Trim(); //takes off extra space at end of name
                txtCustomerName.Text = strNewCustomer;

                strValidAddress = txtCustomerAddress.Text.Trim();
                string[] address = strValidAddress.Split(' ');
                strValidAddress = "";
                for (int i = 0; i < address.Length; i++)
                {
                    string a = "";
                    a += address[i].Substring(0, 1).ToUpper();
                    a += address[i].Substring(1).ToLower();
                    strValidAddress += a + " ";
                }
                strValidAddress = strValidAddress.TrimEnd();
                txtCustomerAddress.Text = strValidAddress;

                strValidCity = txtCity.Text.Trim();
                string[] city = strValidCity.Split(' ');
                strValidCity = "";
                for (int i = 0; i < city.Length; i++)
                {
                    string a = "";
                    a += city[i].Substring(0, 1).ToUpper();
                    a += city[i].Substring(1).ToLower();
                    strValidCity += a + " ";
                }
                strValidCity = strValidCity.TrimEnd();
                txtCity.Text = strValidCity;

                strValidSubdivision = txtSubdivisionLocation.Text.Trim();
                string[] subdivision = strValidSubdivision.Split(' ');
                strValidSubdivision = "";
                for (int i = 0; i < subdivision.Length; i++)
                {
                    string a = "";
                    a += subdivision[i].Substring(0, 1).ToUpper();
                    a += subdivision[i].Substring(1).ToLower();
                    strValidSubdivision += a + " ";
                }
                strValidSubdivision = strValidSubdivision.TrimEnd();
                txtSubdivisionLocation.Text = strValidSubdivision;

                txtState.Text = txtState.Text.ToUpper();
                if (txtState.Text.Length != 2)
                {
                    MessageBox.Show("Please enter two letters for your state.", "Error");
                    txtState.Focus();
                    return false;
                }

                return true;
            }
            else
            {
                MessageBox.Show("Please make sure the form is filled out completely.", "Entry Error");
                return false; 
            }
        }

        /// <summary>
        /// Validates the user's information for the delivery address
        /// </summary>
        /// <returns></returns>
        public bool IsValidDeliveryData()
        {
            if ( txtDeliveryCity.Text.Trim() != "" && txtDeliveryStreet.Text.Trim() != ""  && txtDeliverySubdivision.Text.Trim()
                != ""  && mskDeliveryZipcode.Text != "" && mskDeliveryZipcode.Mask.Length == mskZipCode.Text.Length)
            {


                string strDeliveryAddress = txtDeliveryStreet.Text.Trim();     
                string[] deliveryAddress = strDeliveryAddress.Split(' ');
                strDeliveryAddress = "";
                for (int i = 0; i < deliveryAddress.Length; i++)
                {
                    string b = "";
                    b += deliveryAddress[i].Substring(0, 1).ToUpper();
                    b += deliveryAddress[i].Substring(1).ToLower();
                    strDeliveryAddress += b + " ";
                }
                txtDeliveryStreet.Text = strDeliveryAddress.TrimEnd();


                string strDeliveryCity = txtDeliveryCity.Text.Trim();
                string[] deliveryCity = strDeliveryCity.Split(' ');
                strDeliveryCity = "";
                for (int i = 0; i < deliveryCity.Length; i++)
                {
                    string b = "";
                    b += deliveryCity[i].Substring(0, 1).ToUpper();
                    b += deliveryCity[i].Substring(1).ToLower();
                    strDeliveryCity += b + " ";
                }
                txtDeliveryCity.Text = strDeliveryCity.TrimEnd();

                string strDeliverySubdivision = txtDeliverySubdivision.Text.Trim();
                string[] deliverySubdivision = strDeliverySubdivision.Split(' ');
                strDeliverySubdivision = "";
                for (int i = 0; i < deliverySubdivision.Length; i++)
                {
                    string b = "";
                    b += deliverySubdivision[i].Substring(0, 1).ToUpper();
                    b += deliverySubdivision[i].Substring(1).ToLower();
                    strDeliverySubdivision += b + " ";
                }
                txtDeliverySubdivision.Text = strDeliverySubdivision.TrimEnd();

                if (txtDeliveryCity.Text != "College Station" && txtDeliveryCity.Text != "Bryan")
                {
                    MessageBox.Show("Deliveries can only be made to the Bryan College Station area.", "Processing Error");
                    return false;
                }

                return true;
            }
            else
            {
                MessageBox.Show("Please make sure the form is filled out completely.", "Entry Error");
                return false;
            }
        }

        /// <summary>
        /// Creates string to output to frmOrder
        /// </summary>
        public void SaveData()
        {
            msg = "Customer: " + strNewCustomer + "\n" +
                    "Address: " + strValidAddress + ", " + strValidCity + ", " + txtState.Text.ToUpper() + " " + mskZipCode.Text +
                    "\nPhone number: " + mskPhoneNumber.Text + "\n" + "Subdivision: " + strValidSubdivision;

            if (rdoDelivery.Checked == true)
            {
                msg += "\n\nDelivery to: \n" + txtDeliveryStreet.Text + ", " + txtDeliveryCity.Text + ", TX "
                    + mskDeliveryZipcode.Text + "\nSubdivision: " + txtDeliverySubdivision.Text;
            }
            else
            {
                msg += "\n\nDelivery not needed.";
            }
                

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (msg == "")
            {
                DialogResult selectedButtons = MessageBox.Show("You must fill out customer information to order." +
                    "\nIf you really want to close, press OK.", "Error", MessageBoxButtons.OKCancel);
                if(selectedButtons == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        /// <summary>
        /// If radio button changes, delivery options will be enabled or disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoDelivery_CheckChanged(object sender, EventArgs e)
        {
            if(rdoDelivery.Checked == false)
            {
                gpoDeliveryLocation.Enabled = false;
                chkDelivery.Enabled = false;
            }
            else
            {
                gpoDeliveryLocation.Enabled = true;
                chkDelivery.Enabled = true;
            }
        }

        /// <summary>
        /// If delivery text changes, delivery checkbox will be unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTextChanged(object sender, EventArgs e)
        {
            chkDelivery.Checked = false;
        }
    }
}
