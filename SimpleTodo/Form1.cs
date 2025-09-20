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
           
            if (!string.IsNullOrEmpty(taskInput.Text))
            {
                TodoItems.Add(taskInput.Text);

                taskBox.Items.Add(taskInput.Text);

                MessageBox.Show("Task added successfully!");

                taskInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item.");

                taskInput.Focus();
            }
        }

        private void taskRemove_Click(object sender, EventArgs e)
        {
            if (taskBox.SelectedItem != null)

            {   
                TodoItems.Remove(taskBox.SelectedIndex.ToString());

                taskBox.DataSource = null;
                taskBox.DataSource = TodoItems;

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
            if (TodoItems.Count == 0)
            {
                MessageBox.Show("Please enter at least one item to the list!");
                return;
            }


            SaveFileDialog SaveFileDialog = new SaveFileDialog
            {
                Filter = "Text File|*.txt",
                Title = "Save your To-Do list"
            };

            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("File save was canceled.");
                return;
            }

            var filePath = SaveFileDialog.FileName;

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                    // Loop through each item in the todoItems list
                    foreach (var item in taskBox.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                MessageBox.Show("List saved to file successfully!");
                taskBox.Items.Clear();
                TodoItems.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Text File|*.txt";
                fileDialog.Title = "Select a File to Load";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Clear existing items from the listbox and the list
                        taskBox.Items.Clear();
                        TodoItems.Clear();

                        using (StreamReader reader = new StreamReader(fileDialog.FileName))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                taskBox.Items.Add(line);
                                TodoItems.Add(line);
                            }
                        }
                        MessageBox.Show("File loaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("File load was canceled.");
                }
            }
        }
    }
}
