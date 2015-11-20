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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.ListBox listsList;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        public DataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        public DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button AddNewItem;
        private System.Windows.Forms.Button AddNewList;
        public DataSet1 dataSet1;
        private DataSet1TableAdapters.ListsTableAdapter listsTableAdapter;
        private System.Windows.Forms.BindingSource listsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip itemsToolTip;
        private System.Windows.Forms.Button removeSelectedItem;
        private System.Windows.Forms.Button removeSelectedList;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

