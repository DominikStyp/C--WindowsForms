using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsFormApp
{
    public partial class AddNewItemsForm : Form
    {
        ListsForm lf = null;
        public AddNewItemsForm(ListsForm lf)
        {
            this.lf = lf;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(addItemTextBox.Text.Length < 1)
            {
                MessageBox.Show("You can't add empty item");
                return;
            }
            lf.addNewItem(addItemTextBox.Text);
        }

    }
}
