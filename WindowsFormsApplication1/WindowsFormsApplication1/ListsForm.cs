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
    public partial class ListsForm : Form
    {
        private List<String> list1 = new List<String>();
        private List<String> list2 = new List<String>();
        private BindingSource list1bind = new BindingSource();
        private BindingSource list2bind = new BindingSource();

        private void fill()
        {
            addNewItem("Item1");
            addNewItem("Item2");
        }

        public void addNewItem(string item) {
            list1.Add(item);
            refreshBindings();
        }


        private void bindLists()
        {
            // first we need to tell binder from where to get data
            list1bind.DataSource = list1;
            list2bind.DataSource = list2;
            // second we need to link GUI objects to binders
            listBox1.DataSource = list1bind;
            listBox2.DataSource = list2bind;
        }

        private void refreshBindings()
        {
            list1bind.ResetBindings(true);
            list2bind.ResetBindings(true);
        }

        public ListsForm()
        {
            InitializeComponent();
            fill();
            bindLists();
            d("xxxxxxxxxxxxxxxxxx");
        }

        private void MoveRightEVT(object sender, EventArgs e)
        {
            moveFromToList(list1, listBox1, list2);
        }

        private void MoveLeftEVT(object sender, EventArgs e)
        {
            moveFromToList(list2, listBox2, list1);
        }


        private void moveFromToList(List<String> listFrom, ListBox listBoxFrom, List<String> listTo)
        {
            string selectedItem = (string)listBoxFrom.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }
            listFrom.Remove(selectedItem);
            listTo.Add(selectedItem);
            refreshBindings();
        }


        /**
         *   DEBUGGING methods
         *
         **/
        private void d(string d)
        {
            System.Diagnostics.Debug.WriteLine(d);
        }
        private void m(string m)
        {
            MessageBox.Show(m);
        }



        /******************************** TRAY ICON **********************/
        /******************************** TRAY ICON **********************/
        /******************************** TRAY ICON **********************/
        /******************************** TRAY ICON **********************/

        //  The NotifyIcon object
       // private System.Windows.Forms.NotifyIcon notifyIcon1;

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

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

        private void addNewButton_Click(object sender, EventArgs e)
        {
            //Instantiating new form and show it
            new AddNewItemsForm(this).Show();
        }
    }
}
