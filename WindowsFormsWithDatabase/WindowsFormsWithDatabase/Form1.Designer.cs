namespace WindowsFormsWithDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemsList = new System.Windows.Forms.ListBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsWithDatabase.DataSet1();
            this.listsList = new System.Windows.Forms.ListBox();
            this.listsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddNewItem = new System.Windows.Forms.Button();
            this.AddNewList = new System.Windows.Forms.Button();
            this.removeSelectedItem = new System.Windows.Forms.Button();
            this.removeSelectedList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.itemsTableAdapter = new WindowsFormsWithDatabase.DataSet1TableAdapters.ItemsTableAdapter();
            this.listsTableAdapter = new WindowsFormsWithDatabase.DataSet1TableAdapters.ListsTableAdapter();
            this.tableAdapterManager = new WindowsFormsWithDatabase.DataSet1TableAdapters.TableAdapterManager();
            this.itemsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EditItem = new System.Windows.Forms.Button();
            this.EditList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsList
            // 
            this.itemsList.DataSource = this.itemsBindingSource;
            this.itemsList.DisplayMember = "Name";
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(12, 62);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(142, 316);
            this.itemsList.TabIndex = 0;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listsList
            // 
            this.listsList.DataSource = this.listsBindingSource;
            this.listsList.DisplayMember = "Name";
            this.listsList.FormattingEnabled = true;
            this.listsList.Location = new System.Drawing.Point(334, 62);
            this.listsList.Name = "listsList";
            this.listsList.Size = new System.Drawing.Size(138, 316);
            this.listsList.TabIndex = 1;
            this.listsList.SelectedIndexChanged += new System.EventHandler(this.listsList_SelectedIndexChanged);
            this.listsList.MouseHover += new System.EventHandler(this.listsList_MouseHover);
            // 
            // listsBindingSource
            // 
            this.listsBindingSource.DataMember = "Lists";
            this.listsBindingSource.DataSource = this.dataSet1;
            // 
            // AddNewItem
            // 
            this.AddNewItem.Location = new System.Drawing.Point(12, 389);
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.Size = new System.Drawing.Size(97, 23);
            this.AddNewItem.TabIndex = 2;
            this.AddNewItem.Text = "Add new item";
            this.AddNewItem.UseVisualStyleBackColor = true;
            this.AddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // AddNewList
            // 
            this.AddNewList.Location = new System.Drawing.Point(397, 385);
            this.AddNewList.Name = "AddNewList";
            this.AddNewList.Size = new System.Drawing.Size(75, 23);
            this.AddNewList.TabIndex = 3;
            this.AddNewList.Text = "Add new list";
            this.AddNewList.UseVisualStyleBackColor = true;
            this.AddNewList.Click += new System.EventHandler(this.AddNewList_Click);
            // 
            // removeSelectedItem
            // 
            this.removeSelectedItem.Location = new System.Drawing.Point(12, 447);
            this.removeSelectedItem.Name = "removeSelectedItem";
            this.removeSelectedItem.Size = new System.Drawing.Size(125, 23);
            this.removeSelectedItem.TabIndex = 4;
            this.removeSelectedItem.Text = "Remove selected item";
            this.removeSelectedItem.UseVisualStyleBackColor = true;
            this.removeSelectedItem.Click += new System.EventHandler(this.removeSelectedItem_Click);
            // 
            // removeSelectedList
            // 
            this.removeSelectedList.Location = new System.Drawing.Point(345, 447);
            this.removeSelectedList.Name = "removeSelectedList";
            this.removeSelectedList.Size = new System.Drawing.Size(127, 23);
            this.removeSelectedList.TabIndex = 5;
            this.removeSelectedList.Text = "Remove selected list";
            this.removeSelectedList.UseVisualStyleBackColor = true;
            this.removeSelectedList.Click += new System.EventHandler(this.removeSelectedList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "List of items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "List of lists (categories)";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // listsTableAdapter
            // 
            this.listsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.ListsTableAdapter = this.listsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsWithDatabase.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(12, 418);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(103, 23);
            this.EditItem.TabIndex = 8;
            this.EditItem.Text = "Edit selected Item";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // EditList
            // 
            this.EditList.Location = new System.Drawing.Point(369, 414);
            this.EditList.Name = "EditList";
            this.EditList.Size = new System.Drawing.Size(103, 23);
            this.EditList.TabIndex = 9;
            this.EditList.Text = "Edit selected List";
            this.EditList.UseVisualStyleBackColor = true;
            this.EditList.Click += new System.EventHandler(this.EditList_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 482);
            this.Controls.Add(this.EditList);
            this.Controls.Add(this.EditItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeSelectedList);
            this.Controls.Add(this.removeSelectedItem);
            this.Controls.Add(this.AddNewList);
            this.Controls.Add(this.AddNewItem);
            this.Controls.Add(this.listsList);
            this.Controls.Add(this.itemsList);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MyForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.ListBox listsList;
        //labels 
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        // buttons
        private System.Windows.Forms.Button AddNewItem;
        private System.Windows.Forms.Button AddNewList;
        private System.Windows.Forms.Button removeSelectedItem;
        private System.Windows.Forms.Button removeSelectedList;
        // tray icon & tooltips
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip itemsToolTip;
        // table adapters
        private DataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private DataSet1TableAdapters.ListsTableAdapter listsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        // database binding sources
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource listsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button EditList;
    }
}

