using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SimpleTodo
{
    public partial class Form1 : Form
    {

        // Defines the TodoList list variable
        List<string> TodoItems = new();

        public Form1()
        {
            InitializeComponent();
            LoadDBEntries();
        }

        private void AddDBEntry()
        {
            string taskText = taskInput.Text;

            string connectionString = "Data Source=todo.db";
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO TodoList (Task) VALUES (@Task)";

                    using (var command = new SqliteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Task", taskText);
                        var rowsInserted = command.ExecuteNonQuery();
                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Task has been added successfully!");
                            LoadDBEntries();
                            taskInput.Text = "";
                            taskInput.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add to the database.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDBEntries()
        {

            string connectionString = "Data Source=todo.db";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT Id, Task FROM TodoList";

                using (var command = new SqliteCommand(sql, connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    taskBox.Items.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string task = reader.GetString(1);
                        taskBox.Items.Add($"{id} - {task}");
                    }
                }
            }
        }

        private void UpdateDBEntry()
        {
            var selectedTask = taskBox.SelectedItem.ToString();
            string[] parts = selectedTask.Split(new string[] { " - " }, StringSplitOptions.None);
            int id = int.Parse(parts[0]);
            
            string newTaskText = taskInput.Text;

            string connectionString = "Data Source=todo.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE TodoList SET Task = @Task WHERE Id = @Id";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Task", newTaskText);
                    command.Parameters.AddWithValue("@Id", id);

                    var rowsEdited = command.ExecuteNonQuery();
                    MessageBox.Show("Task updated successfully!");
                }
            }
            LoadDBEntries();
            taskInput.Clear();
        }

        private void DeleteDBEntries()
        {
            if (string.IsNullOrEmpty(taskInput.Text))
            {
                MessageBox.Show("Please select the item you would like to remove");
                return;

            }

            var selectedTask = taskBox.SelectedItem.ToString();
            string[] parts = selectedTask.Split(new string[] { " - " }, StringSplitOptions.None);
            int id = int.Parse(parts[0]);

            string connectionString = "Data Source=todo.db";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM TodoList WHERE Id = @Id";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    var rowDeleted = command.ExecuteNonQuery();
                    MessageBox.Show("The Task has been deleted");
                }
            }

        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskInput.Text))
            {
                MessageBox.Show("Please enter an item.");
                return;
            }
            AddDBEntry();
            taskInput.Focus();
        }
        private void taskRemove_Click(object sender, EventArgs e)
        {
            if (taskBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.");
                return;
            }
            DeleteDBEntries();
            LoadDBEntries();
            taskInput.Focus();
        }

     
        private void UpdateEntryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskInput.Text))
            {
                MessageBox.Show("Please enter an item to edit");
                return;
            }
            UpdateDBEntry();
        }
    }
}
