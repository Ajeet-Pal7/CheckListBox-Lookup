namespace CheckListBox_Lookup
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Allahabad",
            "Ghaziabad",
            "Mathura",
            "Lucknow",
            "Ayodhya",
            "Varanasi",
            "Agara",
            "Kanpur",
            "Jhasi"});
            this.checkedListBox1.Location = new System.Drawing.Point(74, 46);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(417, 211);
            this.checkedListBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(575, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 224);
            this.listBox1.TabIndex = 1;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(156, 361);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(228, 34);
            this.btnAddItems.TabIndex = 2;
            this.btnAddItems.Text = "Add Items to CheckedlistBox";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Checked Items to List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(156, 299);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(228, 26);
            this.txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 537);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "ChecklistBox Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
    }
}

