namespace ListsFormApp
{
    partial class AddNewItemsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addItemTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new item to the list:";
            // 
            // addItemTextBox
            // 
            this.addItemTextBox.Location = new System.Drawing.Point(13, 36);
            this.addItemTextBox.Name = "addItemTextBox";
            this.addItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.addItemTextBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(15, 63);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 94);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.addItemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewItemsForm";
            this.Text = "AddNewItemsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addItemTextBox;
        private System.Windows.Forms.Button addItemButton;
    }
}