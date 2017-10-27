using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Inventory
    {
        private string ingredient;
        private decimal amount;

        public Inventory() { }

        public Inventory(string ingredient, decimal amount)
        {
            this.Ingredient = ingredient;
            this.Amount = amount;
        }

        public static string ReadTextFile() //the read text file method for inventory.txt
        {
            string line = null;
            string list = null;
            using (StreamReader sr = new StreamReader(@"..\..\Inventory.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    list += line + "\t";
                }
            }
            return list;
        }

        public string Ingredient
        {
            get
            {
                return ingredient;
            }
            set
            {
                ingredient = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public string GetDisplayText()
        {
            return ingredient + "\t" + amount.ToString() + "\n";
        }

    }
}
