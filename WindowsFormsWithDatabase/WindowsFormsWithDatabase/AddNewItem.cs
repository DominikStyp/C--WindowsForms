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
    public partial class AddNewItem : Form
    {
        Form1 form;
        public AddNewItem(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string text = NameTextBox.Text.ToString();
            if (text == null || text.Length < 1)
            {
                descriptionLabel.Text = "Name can't be empty";
                return;
            }
            byte listId = getListId();
            if (listId < 1)
            {
                descriptionLabel.Text = "First choose the list";
                return;
            }
            form.manipulatingDatabase.addNewItemsRow(text, listId);
            descriptionLabel.Text = "New item added: " + text;
            form.refreshItemsList();
        }

        private byte getListId()
        {
            return form.getCheckedListId();
        }

    }
}
