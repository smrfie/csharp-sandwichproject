using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{//AUTHOR:       Hannah Christman, Lianna Pais, Ryan Murphy, Max Zhang
 //COURSE:       ISYS 250 502 
 //FORM:         frmOrder
 //PURPOSE:      Creates an order form incorporating the customer information from frmCustomer and displays and processes order information  
 //INPUT:        Order selections and quantity
 //PROCESS:      User chooses a pizza or deli option, choosing other specific bread and crusts options, then form will add all selected items 
 //              together and generates a running subtotal. after the order is complete, the form displays the finished total, including tax
 //OUTPUT:       Gives user the finished total with tax included
 //HONOR CODE:   “On my honor, as an Aggie, I have neither given
 //               nor received unauthorized aid on this academic
 //               work."

    /// <summary>
    /// populates listbox
    /// </summary>
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        string[,] menu = new string[,]{ { "Ham and Swiss", "5.00" }, { "Turkey and Provolone", "5.00" },
                                        { "BLT", "5.00"}, { "Medium Cheese Pizza", "9.50" }, { "Medium Pepperoni Pizza", "9.50"},
                                        { "Medium Supreme Pizza", "9.50"} };
        decimal decGrandTotal = 0m;

        public List<Inventory> inventory = new List<Inventory>(); //making lists for inventory and ingredients
        public List<Ingredients> ingredients = new List<Ingredients>();
        public Inventory[,] arrayInventory = new Inventory[8,2];

        /// <summary>
        /// Loads the form and populates comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadInventories();
            Form customer = new frmCustomer();
            DialogResult selectedButton = customer.ShowDialog();

            if (selectedButton == DialogResult.OK)
            {
                lblCustomerInfo.Text = (string) customer.Tag;
            }
            if(selectedButton == DialogResult.Cancel)
            {
                this.Close();
            }
            
            cboItem.Items.Add("Select your item...");
            cboItem.SelectedIndex = 0;
            cboBread.Enabled = false;
            btnAdd.Enabled = false;
            txtQuantity.Enabled = false;
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                cboItem.Items.Add(menu[i, 0]);
            }

        }

        /// <summary>
        /// Populates the bread combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBread.Enabled = true;
            if(cboItem.SelectedIndex > 0 && cboItem.SelectedIndex < 4)
            {
                cboBread.Items.Clear();
                cboBread.Items.Add("Select your bread...");
                cboBread.SelectedIndex = 0;
                cboBread.Items.Add("White");
                cboBread.Items.Add("Pumpernickel");
                cboBread.Items.Add("Rye");
                cboBread.Items.Add("Sourdough");
                cboBread.Items.Add("Wheat");
                picFood.Image = Properties.Resources.deli;              
            }
            else if (cboItem.SelectedIndex >= 4)
            {
                cboBread.Items.Clear();
                cboBread.Items.Add("Select your crust...");
                cboBread.SelectedIndex = 0;
                cboBread.Items.Add("Original");
                cboBread.Items.Add("Pan");
                cboBread.Items.Add("Thin");
                cboBread.Items.Add("Wheat");
                picFood.Image = Properties.Resources.pizza;
            }
            else
            {
                cboItem.SelectedIndex = 0;
                cboBread.Items.Clear();
                cboBread.Items.Add("Please select a meal.");
                cboBread.SelectedIndex = 0;
                cboBread.Enabled = false;
                picFood.Image = null;
            }          
        }

        /// <summary>
        /// Validates bread combobox to enable rest of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBread_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboBread.SelectedIndex > 0)
            {
                txtQuantity.Enabled = true;
                btnAdd.Enabled = true;
                txtQuantity.Text = "1";
            }
            else
            {
                txtQuantity.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        /// <summary>
        /// Validates item quantity is valid and adds to subtotal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int intQuantity = 0;
            bool result = Int32.TryParse(txtQuantity.Text, out intQuantity);
            if (result)
            {
                intQuantity = Convert.ToInt32(txtQuantity.Text);
            }
            else
            {
                MessageBox.Show("Please put in a valid integer.", "Entry Error");
                txtQuantity.Focus();
            }

            if (intQuantity < 1)
            {
                MessageBox.Show("Quantity not valid.", "Entry Error");
                txtQuantity.Focus();
            }
            else
            {
                decimal decSubtotal = intQuantity * Convert.ToDecimal(menu[cboItem.SelectedIndex - 1, 1]);
                decGrandTotal += decSubtotal;
                lblSubtotal.Text += menu[cboItem.SelectedIndex - 1, 0] + " on " +
                    cboBread.SelectedItem + ", " + intQuantity + "@$" + menu[cboItem.SelectedIndex - 1, 1] + ", total: " +
                    decSubtotal.ToString("c2") + "\n";
                lblRunningTotal.Text = "Subtotal: " + decGrandTotal.ToString("c2"); //without tax
            }

            for(int i = 0; i < inventory.Count; i++)
            {
                if(cboItem.SelectedIndex == 1)
                {
                    if ((inventory[i].Amount - ingredients[i].Ham) != 0)
                    {
                        inventory[i].Amount = inventory[i].Amount - ((decimal)ingredients[i].Ham * intQuantity);
                    }
                    else
                        MessageBox.Show("Not enough ingredients to complete order.", "Processing error");
                }
                else if (cboItem.SelectedIndex == 2)
                {
                    if ((inventory[i].Amount - ingredients[i].Turkey) != 0)
                    {
                        inventory[i].Amount = inventory[i].Amount - ((decimal) ingredients[i].Turkey * intQuantity);
                    }
                    else
                        MessageBox.Show("Not enough ingredients to complete order.", "Processing error");
                }
                else if (cboItem.SelectedIndex == 3)
                {
                    if ((inventory[i].Amount - ingredients[i].BLT) != 0)
                    {
                        inventory[i].Amount = inventory[i].Amount - ((decimal)ingredients[i].BLT * intQuantity);
                    }
                    else
                        MessageBox.Show("Not enough ingredients to complete order.", "Processing error");
                }
                else if (cboItem.SelectedIndex == 4)
                {
                    if ((inventory[i].Amount - ingredients[i].Cheese) != 0)
                    {
                        inventory[i].Amount = inventory[i].Amount - ((decimal)ingredients[i].Cheese * intQuantity);
                    }
                    else
                        MessageBox.Show("Not enough ingredients to complete order.", "Processing error");
                }
                else if (cboItem.SelectedIndex == 5)
                {
                    if ((inventory[i].Amount - ingredients[i].Pepperonni) != 0)
                    {
                        inventory[i].Amount = inventory[i].Amount - ((decimal)ingredients[i].Pepperonni * intQuantity);
                    }
                    else
                        MessageBox.Show("Not enough ingredients to complete order.", "Processing error");
                }
                else if (cboItem.SelectedIndex == 6)
                {
                    if ((inventory[i].Amount - ingredients[i].Supreme) != 0)
                    {
                        inventory[i].Amount = inventory[i].Amount - ((decimal)ingredients[i].Supreme * intQuantity);
                    }
                    else
                        MessageBox.Show("Not enough ingredients to complete order.", "Processing error");
                }
            }
        }

        /// <summary>
        /// Closes out form and alerts user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Do you wish to cancel the order? All data will be lost.", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(button == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Alerts user that they are about to clear their order and clears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("You are about to clear your selections. Is this OK?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (button == DialogResult.Yes)
            {
                decGrandTotal = 0m;
                lblRunningTotal.Text = "Subtotal: ";
                lblSubtotal.Text = null;
                cboItem.SelectedIndex = 0;
                txtQuantity.Text = "1";
            }
        }

        /// <summary>
        /// finishes the order and opens the next form if user chooses to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("The final total of the order is " + (decGrandTotal * 1.0825m).ToString("c2") + 
                "\n\nStart a new order?", "Order Processing", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
            {
                Form customer = new frmCustomer();
                DialogResult selectedButton = customer.ShowDialog();

                if (selectedButton == DialogResult.OK)
                {
                    lblCustomerInfo.Text = (string)customer.Tag;
                }
                if (selectedButton == DialogResult.Cancel)
                {
                    this.Close();
                }

                decGrandTotal = 0m;
                lblRunningTotal.Text = "Subtotal: ";
                lblSubtotal.Text = null;
                cboItem.SelectedIndex = 0;
                txtQuantity.Text = "1";
            }
            if (button == DialogResult.No)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string play = "";
            for (int i = 0; i < inventory.Count; i++)
            {
                play += inventory[i].GetDisplayText();
            }
            Form invent = new frmInventory(inventory);
            DialogResult selectedButton = invent.ShowDialog();
        }
        private void LoadInventories()
        {
            // reading text from Inventory.txt

            string strInventory = Inventory.ReadTextFile();
            string[] inventorytxt = strInventory.Split('\t');
            Inventory q = new Inventory();
            for (int i = 0; i < inventorytxt.Length - 1; i++)
            {
                q = new Inventory(inventorytxt[i], Convert.ToDecimal(inventorytxt[i + 1]));
                i++;
                inventory.Add(q);
            }

            // reading text from Ingredients.txt
            string strIngredients = Ingredients.ReadTextFile();
            string[] ingredientstxt = strIngredients.Split('\t');
            Ingredients p = new Ingredients();
            for (int i = 0; i < ingredientstxt.Length - 1; i++)
            {
                p = new Ingredients(ingredientstxt[i], Convert.ToDecimal(ingredientstxt[i + 1]),
                    Convert.ToDecimal(ingredientstxt[i + 2]), Convert.ToDecimal(ingredientstxt[i + 3]),
                    Convert.ToDecimal(ingredientstxt[i + 4]), Convert.ToDecimal(ingredientstxt[i + 5]),
                    Convert.ToDecimal(ingredientstxt[i + 6]));
                i += 6;
                ingredients.Add(p);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVendor vendor = new frmVendor();
            DialogResult selectedbutton = vendor.ShowDialog();
        }
    }
}
