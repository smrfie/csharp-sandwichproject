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
{
    public partial class frmInventory : Form
    {
        public List<Inventory> list = new List<Inventory>();
        public frmInventory(List<Inventory> e)
        {
            InitializeComponent();
            for(int i =0; i < e.Count; i++)
            {
                list.Add(e[i]);
            }   
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                lstInventory.Items.Add(list[i].GetDisplayText());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
