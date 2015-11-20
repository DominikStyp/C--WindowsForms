using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public readonly ManipulatingDatabase manipulatingDatabase;
        public byte currentCheckedListId = 0;

        public Form1()
        {
            InitializeComponent();
            manipulatingDatabase = new ManipulatingDatabase()
            {
                dataSet1 = this.dataSet1,
                itemsTableAdapter = this.itemsTableAdapter,
                listsTableAdapter = this.listsTableAdapter
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Items' table. You can move, or remove it, as needed.
            /*
             * How to create custom FillBy method
                1) double click on DataSet1.xsd in the right panel
                2) click on table, then Add -> Query
                3) In SQL query field (What data should table load?) add your condition like: WHERE Name = @Name
                4) Next
                5) Add your suffixes to the methods ex. FillByName, GetDataByName
                6) Next, Finish
             */
            this.listsTableAdapter.Fill(this.dataSet1.Lists);
            if(listsList.Items.Count > 0)
            {
                refreshItemsList();
            }
        }


        // only way to refresh ListBox in case data in database has changed is another assign binding source to DataSource
        public void refreshItemsList()
        {
            currentCheckedListId = getCheckedListId();
            if (currentCheckedListId > 0)
            {
                itemsList.DataSource = itemsBindingSource;
                this.itemsTableAdapter.FillByListId(this.dataSet1.Items, currentCheckedListId);
            }
        }
        // only way to refresh ListBox in case data in database has changed is another assign binding source to DataSource
        public void refreshListsList()
        {
            listsList.DataSource = listsBindingSource;
            // Due to DataTable throws InvalidConstraintException on .Fill (Foreign key problem)
            this.dataSet1.Lists.ChildRelations.Clear();
            this.listsTableAdapter.Fill(this.dataSet1.Lists);
        }

        private void listsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshItemsList();
        }
        
        public byte getCheckedListId()
        {
            String valueOfItem = "";
            try {
                DataRowView drv = (DataRowView)listsList.SelectedItem; //get selected item object DataRowView
                valueOfItem = drv["Id"].ToString(); //get specified field
            } catch(System.Exception)
            {
                return 0;
            }
            return Byte.Parse(valueOfItem);
        }

        public int getCheckedItemId()
        {
            String valueOfItem = "";
            try
            {
                DataRowView drv = (DataRowView)itemsList.SelectedItem; //get selected item object DataRowView
                valueOfItem = drv["Id"].ToString(); //get specified field
            }
            catch (System.Exception)
            {
                return 0;
            }
            return Int32.Parse(valueOfItem);
        }

        private void AddNewList_Click(object sender, EventArgs e)
        {
            new AddNewList(this).Show();
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            if(currentCheckedListId < 0)
            {
                MessageBox.Show("First you have to choose list to add an item.\nIf there is none, you must create it.");
                return;
            }
            new AddNewItem(this).Show();
        }

        private void d(object d)
        {
            MessageBox.Show(d.ToString());
        }

        private void itemsList_MouseHover(object sender, EventArgs e)
        {
            itemsToolTip.Show("List of Items.\nEvery item must be assigned to one list.\nFirst you have to create and choose list to add new item.", itemsList);
        }

        private void listsList_MouseHover(object sender, EventArgs e)
        {
            itemsToolTip.Show("List of items lists.\nThere must be at least one list if you wan't to add an item.", listsList);
        }


        private bool confirmBox(string title, string text)
        {
            DialogResult dr = MessageBox.Show(text, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            return dr == DialogResult.Yes;
        }

        private void removeSelectedItem_Click(object sender, EventArgs e)
        {
            int id = getCheckedItemId();
            if(id < 1)
            {
                MessageBox.Show("Please choose an item");
                return;
            }
            if(confirmBox("Delete an item", "Do you want to remove this item from database?"))
            {
                manipulatingDatabase.removeItemsRow(id);
                refreshItemsList();
            }
        }

        private void removeSelectedList_Click(object sender, EventArgs e)
        {
            byte id = getCheckedListId();
            if (id < 1)
            {
                MessageBox.Show("Please choose a list");
                return;
            }
            if (confirmBox("Delete whole list", "Do you want to remove this list (and items binded to it) from database?"))
            {
                manipulatingDatabase.removeListsRow(id);
                refreshListsList();
                refreshItemsList();
            }
        }


        /******************************** TRAY ICON **********************/
        /******************************** TRAY ICON **********************/
        /******************************** TRAY ICON **********************/
        /******************************** TRAY ICON **********************/

        //  The NotifyIcon object
        // private System.Windows.Forms.NotifyIcon notifyIcon1;



        // REMEMBER: First you have to define Resize event in Designer
        private void MyForm_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
            notifyIcon1.BalloonTipText = "You have successfully minimized your form.";
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
