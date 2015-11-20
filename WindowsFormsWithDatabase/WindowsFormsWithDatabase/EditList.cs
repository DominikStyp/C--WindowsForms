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
    public partial class EditList : Form
    {
        Form1 form;
        public EditList(Form1 form)
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
            byte listId = form.getCheckedListId();
            if(listId < 1)
            {
                descriptionLabel.Text = "First choose the list (in the right field)";
                return;
            }
            if(!Form1.confirmBox("Editing List", "Are you sure you want to change name of this list?\n(This is irreversible operation)"))
            {
                return;
            }
            form.manipulatingDatabase.editListsRow(listId, text);
            descriptionLabel.Text = "List name has been changed to: " + text;
            form.refreshItemsList();
        }

    }
}
