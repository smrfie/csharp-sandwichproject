using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{   //AUTHOR:       Hannah Christman, Lianna Pais, Ryan Murphy, Max Zhang
    //FORM:         Validator.cs
    //PURPOSE:      A Validator class that can be called upon to validate textboxes.
    //INPUT:        Class is called upon in another program, transfers a TextBox with the call.
    //PROCESS:      Checks to see if Textboxes are populated / can be converted to decimal.
    //OUTPUT:       True/False statement if Textbox passes validation.
    class Validator
    {
        private static string title = "Entry Error";
        /// <summary>
        /// pulls the Tag from the textbox and makes it the Title if false is declared
        /// </summary>
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        /// <summary>
        /// IsPresent makes sure the TextBox is populated
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Decimal calls to make sure the YTD can be converted to decimal
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
