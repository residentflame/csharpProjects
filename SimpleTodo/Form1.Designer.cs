namespace SimpleTodo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskInput = new TextBox();
            addTask = new Button();
            taskBox = new ListBox();
            btnSave = new Button();
            btnLoad = new Button();
            btnRemove = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // taskInput
            // 
            taskInput.CausesValidation = false;
            taskInput.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskInput.Location = new Point(101, 143);
            taskInput.Margin = new Padding(3, 4, 3, 4);
            taskInput.Name = "taskInput";
            taskInput.Size = new Size(465, 57);
            taskInput.TabIndex = 0;
            taskInput.TextAlign = HorizontalAlignment.Center;
            // 
            // addTask
            // 
            addTask.BackColor = Color.RoyalBlue;
            addTask.FlatAppearance.BorderSize = 0;
            addTask.FlatStyle = FlatStyle.Flat;
            addTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTask.ForeColor = Color.White;
            addTask.Location = new Point(581, 169);
            addTask.Margin = new Padding(2);
            addTask.Name = "addTask";
            addTask.Size = new Size(113, 27);
            addTask.TabIndex = 1;
            addTask.Text = "Add";
            addTask.UseVisualStyleBackColor = false;
            addTask.Click += addTask_Click;
            // 
            // taskBox
            // 
            taskBox.BorderStyle = BorderStyle.FixedSingle;
            taskBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskBox.FormattingEnabled = true;
            taskBox.Location = new Point(214, 237);
            taskBox.Margin = new Padding(2);
            taskBox.Name = "taskBox";
            taskBox.Size = new Size(238, 149);
            taskBox.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(469, 329);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 48);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save List";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.RoyalBlue;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(469, 266);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(113, 45);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load List";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.RoyalBlue;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(581, 139);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(113, 26);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += taskRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 59);
            label1.Name = "label1";
            label1.Size = new Size(216, 47);
            label1.TabIndex = 7;
            label1.Text = "Simple ToDo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(780, 439);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(taskBox);
            Controls.Add(addTask);
            Controls.Add(taskInput);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple ToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taskInput;
        private Button addTask;
        private ListBox taskBox;
        private Button btnSave;
        private Button btnLoad;
        private Button btnRemove;
        private Label label1;
    }
}
