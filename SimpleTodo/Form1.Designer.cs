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
            taskRemove = new Button();
            SuspendLayout();
            // 
            // taskInput
            // 
            taskInput.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskInput.Location = new Point(54, 44);
            taskInput.Margin = new Padding(6);
            taskInput.Name = "taskInput";
            taskInput.Size = new Size(196, 44);
            taskInput.TabIndex = 0;
            // 
            // addTask
            // 
            addTask.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTask.Location = new Point(263, 41);
            addTask.Name = "addTask";
            addTask.Size = new Size(118, 47);
            addTask.TabIndex = 1;
            addTask.Text = "Add item";
            addTask.UseVisualStyleBackColor = true;
            addTask.Click += addTask_Click;
            // 
            // taskBox
            // 
            taskBox.FormattingEnabled = true;
            taskBox.Location = new Point(54, 111);
            taskBox.Name = "taskBox";
            taskBox.Size = new Size(327, 265);
            taskBox.TabIndex = 2;
            // 
            // taskRemove
            // 
            taskRemove.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskRemove.Location = new Point(54, 402);
            taskRemove.Name = "taskRemove";
            taskRemove.Size = new Size(327, 75);
            taskRemove.TabIndex = 3;
            taskRemove.Text = "Remove item";
            taskRemove.UseVisualStyleBackColor = true;
            taskRemove.Click += taskRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(447, 537);
            Controls.Add(taskRemove);
            Controls.Add(taskBox);
            Controls.Add(addTask);
            Controls.Add(taskInput);
            Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
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
        private Button taskRemove;
    }
}
