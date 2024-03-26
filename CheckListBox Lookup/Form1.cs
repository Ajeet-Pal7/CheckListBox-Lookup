using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox_Lookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Size = checkedListBox1.Size;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if(txtInput.Text != "")
            {
                checkedListBox1.Items.Add(txtInput.Text);
            }else
            {
                MessageBox.Show("Please type some word!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                listBox1.Items.AddRange(checkedListBox1.CheckedItems.Cast<object>().ToArray());
            }else
            {
                MessageBox.Show("Please select some items!");
            }
        }
    }
}
