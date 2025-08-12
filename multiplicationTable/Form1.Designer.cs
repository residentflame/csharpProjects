namespace MultiplicationTable
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
            generateTable = new Button();
            multiplicationNum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // generateTable
            // 
            generateTable.Anchor = AnchorStyles.Bottom;
            generateTable.BackColor = SystemColors.ButtonHighlight;
            generateTable.Font = new Font("Noto Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateTable.ForeColor = SystemColors.ActiveCaptionText;
            generateTable.Location = new Point(10, 329);
            generateTable.Name = "generateTable";
            generateTable.Size = new Size(419, 56);
            generateTable.TabIndex = 0;
            generateTable.Text = "Generate Multiplication Table";
            generateTable.UseVisualStyleBackColor = false;
            generateTable.Click += generateTable_Click;
            // 
            // multiplicationNum
            // 
            multiplicationNum.Location = new Point(10, 51);
            multiplicationNum.Name = "multiplicationNum";
            multiplicationNum.Size = new Size(217, 23);
            multiplicationNum.TabIndex = 1;
            multiplicationNum.KeyDown += multiplicationNum_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 2;
            label1.Text = "Enter a number: ";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(441, 397);
            Controls.Add(label1);
            Controls.Add(multiplicationNum);
            Controls.Add(generateTable);
            Name = "Form1";
            Text = "Multiplication Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateTable;
        private TextBox multiplicationNum;
        private Label label1;
    }
}
