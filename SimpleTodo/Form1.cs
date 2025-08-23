using System.Windows.Forms;

namespace SimpleTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            // Checks if the text task is not null
            if (!string.IsNullOrEmpty(taskInput.Text))
            {
                // Assigns text box text (textInput) to the Listbox named taskBox
                taskBox.Items.Add(taskInput.Text);
                MessageBox.Show($"Task added successfully!");
                taskInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item.");
            }
            // Turns the focus to the textbox
            taskInput.Focus();
        }

        private void taskRemove_Click(object sender, EventArgs e)
        {
            // Checks if the list task is selected
            if (taskBox.SelectedItem != null)
            {    
                taskBox.Items.Remove(taskBox.SelectedItem);
                MessageBox.Show("Item removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
            taskInput.Focus();
        }

    }
}
