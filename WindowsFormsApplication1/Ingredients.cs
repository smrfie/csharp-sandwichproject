using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Ingredients
    {
        public string ingredient; //variables for each column in ingredients
        public decimal ham;
        public decimal turkey;
        public decimal blt;
        public decimal cheese;
        public decimal pepperonni;
        public decimal supreme;

        public static string ReadTextFile()
        {
            string line = null;
            string list = null;
            using (StreamReader sr = new StreamReader(@"..\..\Ingredients.txt"))
            {
                while((line = sr.ReadLine()) != null)
                {
                    list += line + "\t";
                }
            }
            return list;
        }

        public Ingredients() { }

        public Ingredients(string ingredient, decimal ham, decimal turkey, decimal blt,
            decimal cheese, decimal pepperonni, decimal supreme)
        {
            this.Ingredient = ingredient;
            this.Ham = ham;
            this.Turkey = turkey;
            this.BLT = blt;
            this.Cheese = cheese;
            this.Pepperonni = pepperonni;
            this.Supreme = supreme;
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

        public decimal Ham
        {
            get
            {
                return ham;
            }
            set
            {
                ham = value;
            }
        }

        public decimal Turkey
        {
            get
            {
                return turkey;
            }
            set
            {
                turkey = value;
            }
        }

        public decimal BLT
        {
            get
            {
                return blt;
            }
            set
            {
                blt = value;
            }
        }

        public decimal Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
            }
        }

        public decimal Pepperonni
        {
            get
            {
                return pepperonni;
            }
            set
            {
                pepperonni = value;
            }
        }

        public decimal Supreme
        {
            get
            {
                return supreme;
            }
            set
            {
                supreme = value;
            }
        }

        public string GetDisplayText()
        {
            return ingredient + "\t" + ham.ToString() + "\t" + turkey.ToString() + "\t" +
                blt.ToString() + "\t" + cheese.ToString() + "\t" + pepperonni.ToString() + "\t" +
                supreme.ToString() + "\n";
        }
    }
}
