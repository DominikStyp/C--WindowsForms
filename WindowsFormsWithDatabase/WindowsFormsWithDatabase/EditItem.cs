using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWithDatabase
{
    public partial class EditItem : Form
    {
        Form1 form;
        public EditItem(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string text = NameTextBox.Text.ToString();
            if (text == null || text.Length < 1)
            {
                descriptionLabel.Text = "Name can't be empty";
                return;
            }
            int itemId = form.getCheckedItemId();
            if(itemId < 1)
            {
                descriptionLabel.Text = "First choose the item (in the left field)";
                return;
            }
            if(!Form1.confirmBox("Editing Item", "Are you sure you want to change name of this item?\n(This is irreversible operation)"))
            {
                return;
            }
            form.manipulatingDatabase.editItemsRow(itemId, text);
            descriptionLabel.Text = "Item name has been changed to: " + text;
            form.refreshItemsList();
        }

        private byte getListId()
        {
            return form.getCheckedListId();
        }

    }
}
