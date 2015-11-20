using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWithDatabase
{

    // ---------------- EVENTS ---------------------------------------
    // ---------------- EVENTS ---------------------------------------
    // ---------------- EVENTS ---------------------------------------
    // ---------------- EVENTS ---------------------------------------
    // ---------------- EVENTS ---------------------------------------
    // ---------------- EVENTS ---------------------------------------
    // ---------------- EVENTS ---------------------------------------


    public partial class Form1 : Form
    {

        private void listsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshItemsList();
        }


        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentChedkedItemId = getCheckedItemId();
        }


        private void AddNewList_Click(object sender, EventArgs e)
        {
            new AddNewList(this).Show();
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            if (currentCheckedListId < 0)
            {
                MessageBox.Show("First you have to choose list to add an item.\nIf there is none, you must create it.");
                return;
            }
            new AddNewItem(this).Show();
        }



        private void EditList_Click(object sender, EventArgs e)
        {
            if (currentCheckedListId < 0)
            {
                MessageBox.Show("First you have to choose list to edit it.\nIf there is none, you must create it.");
                return;
            }
            new EditList(this).Show();
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            if (currentChedkedItemId < 0)
            {
                MessageBox.Show("First you have to choose item to edit it.\nIf there is none, you must create it.");
                return;
            }
            new EditItem(this).Show();
        }

        private void itemsList_MouseHover(object sender, EventArgs e)
        {
            itemsToolTip.Show("List of Items.\nEvery item must be assigned to one list.\nFirst you have to create and choose list to add new item.", itemsList, 5);
        }

        private void listsList_MouseHover(object sender, EventArgs e)
        {
            itemsToolTip.Show("List of items lists.\nThere must be at least one list if you wan't to add an item.", listsList, 5);
        }

        private void removeSelectedItem_Click(object sender, EventArgs e)
        {
            int id = getCheckedItemId();
            if (id < 1)
            {
                MessageBox.Show("Please choose an item");
                return;
            }
            if (confirmBox("Delete an item", "Do you want to remove this item from database?"))
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
