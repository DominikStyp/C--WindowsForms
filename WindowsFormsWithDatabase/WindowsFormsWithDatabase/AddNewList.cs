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
    public partial class AddNewList : Form
    {
        Form1 form;
        public AddNewList(Form1 form)
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
            form.manipulatingDatabase.addNewListsRow(text);
            descriptionLabel.Text = "New list added: " + text;
            form.refreshItemsList();
            form.refreshListsList();
        }
    }
}
