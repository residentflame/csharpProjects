using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace SimpleTodo
{
    public partial class Form1 : Form
    {

        // Defines the TodoList list variable
        List<string> TodoItems = new();

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

                // Adds text to the TodoItems list 
                TodoItems.Add(taskInput.Text);

                MessageBox.Show("Task added successfully!");

                taskInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item.");

                // Turns the focus to the textbox
            }
            taskInput.Focus();
        }

        private void taskRemove_Click(object sender, EventArgs e)
        {
            var selectedItem = taskBox.SelectedItem;
            if (taskBox.SelectedItem != null)

            {   // remove selected ListBox item if != null
                taskBox.Items.Remove(selectedItem);
                TodoItems.Remove(selectedItem.ToString());

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
            SaveFileDialog SaveFileDialog = new SaveFileDialog 
            {
                Filter = "Text File|*.txt"
            };

            // Show the dialog and check if the user clicked OK
            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("No file location was selected. Please try again.");
                return;
            }

            var filePath = SaveFileDialog.FileName;
            
            if (string.IsNullOrEmpty(filePath) )
            {
                MessageBox.Show("File location not valid!");
                return;
            }

            if (TodoItems == null || TodoItems.Count == 0) 
            {
                MessageBox.Show("Please enter at least one item to the list!");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                    // Loop through each item in the todoItems list
                    foreach (var item in taskBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                // Notify user the list has been saved
                MessageBox.Show("List saved to file successfully!");
                // Show the file save location
                MessageBox.Show($"File saved at: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
            taskBox.Items.Clear(); // Reset
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Text File|*.txt";
                fileDialog.Title = "Select a File";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = fileDialog.FileName;

                    using (StreamReader reader = new StreamReader(selectedFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            taskBox.Items.Add(line);
                            TodoItems.Add(line); // Sync with list
                        }
                    }
                }
                

            }
        }
    }
}
