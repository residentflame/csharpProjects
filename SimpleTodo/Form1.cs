using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
namespace SimpleTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<string> TodoItems = new List<string>();
        private void addTask_Click(object sender, EventArgs e)
        {
            // Checks if the text task is not null
            if (!string.IsNullOrEmpty(taskInput.Text))
            {
                // Assigns text box text (textInput) to the Listbox named taskBox
                taskBox.Items.Add(taskInput.Text);

                // Adds text to the TodoItems list 
                TodoItems.Add(taskInput.Text);

                MessageBox.Show("Task added successfully!");
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
            {   // remove selected ListBox item if != null
                taskBox.Items.Remove(taskBox.SelectedItem);
                MessageBox.Show("Item removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
            taskInput.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create an instance of the SaveFileDialog
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Text File|*.txt";
            // Show the dialog and check if the user clicked OK
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)

            {
                var filePath = SaveFileDialog.FileName;

                // Check if the file path is not null
                if (!string.IsNullOrEmpty(filePath))
                {

                    if (TodoItems != null && TodoItems.Count > 0)
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            // Loop through each item in the todoItems list
                            foreach (string todoItem in TodoItems)
                            {
                                writer.WriteLine(todoItem);
                            }
                        }
                        // Notify user the list has been saved
                        MessageBox.Show("List saved to file successfully!");

                        // Show the file save location
                        MessageBox.Show($"File saved at: {filePath}");
                    }
                    else
                    {
                        MessageBox.Show("Please enter at least one item to the list!");
                    }
                }
                else
                {
                    MessageBox.Show("File location not valid!");
                }
            }
            else
            {
                MessageBox.Show("No file location was selected. Please try again.");
            }
        }
    }
}
