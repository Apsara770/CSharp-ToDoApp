using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string task = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                listBoxTasks.Items.Add(task);
                txtTask.Clear();
                txtTask.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listBoxTasks.SelectedItem != null)
            {
                listBoxTasks.Items.Remove(listBoxTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                int index = listBoxTasks.SelectedIndex;
                string task = listBoxTasks.SelectedItem.ToString();
                listBoxTasks.Items[index] = task + " ✔️";
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
