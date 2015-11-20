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
        public int currentChedkedItemId = 0;

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
            //listsList.DataSource = listsBindingSource;
            // Due to DataTable throws InvalidConstraintException on .Fill (Foreign key problem)
            //this.dataSet1.Lists.ChildRelations.Clear();
            //this.dataSet1.Lists.Load(this.listsTableAdapter.GetData())
            //this.dataSet1.Lists.ChildRelations.Clear();
            this.dataSet1.EnforceConstraints = false;
            this.listsTableAdapter.Fill(this.dataSet1.Lists);
            this.dataSet1.EnforceConstraints = true;
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

        private void d(object d)
        {
            MessageBox.Show(d.ToString());
        }

        public static bool confirmBox(string title, string text)
        {
            DialogResult dr = MessageBox.Show(text, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            return dr == DialogResult.Yes;
        }

    }


}
