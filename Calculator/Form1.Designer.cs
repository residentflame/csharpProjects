namespace Calculator
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
            textBox1 = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnAdd = new Button();
            btnZero = new Button();
            btnDivide = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(56, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 37);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOne
            // 
            btnOne.Anchor = AnchorStyles.Bottom;
            btnOne.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(57, 55);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 35);
            btnOne.TabIndex = 1;
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += NumberButton_Click;
            // 
            // btnTwo
            // 
            btnTwo.Anchor = AnchorStyles.Bottom;
            btnTwo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(137, 55);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 35);
            btnTwo.TabIndex = 2;
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += NumberButton_Click;
            // 
            // btnThree
            // 
            btnThree.Anchor = AnchorStyles.Bottom;
            btnThree.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(218, 55);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 35);
            btnThree.TabIndex = 3;
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += NumberButton_Click;
            // 
            // btnFour
            // 
            btnFour.Anchor = AnchorStyles.Bottom;
            btnFour.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(57, 96);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 35);
            btnFour.TabIndex = 4;
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += NumberButton_Click;
            // 
            // btnFive
            // 
            btnFive.Anchor = AnchorStyles.Bottom;
            btnFive.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(138, 96);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 35);
            btnFive.TabIndex = 5;
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += NumberButton_Click;
            // 
            // btnSix
            // 
            btnSix.Anchor = AnchorStyles.Bottom;
            btnSix.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(219, 96);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(75, 35);
            btnSix.TabIndex = 6;
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += NumberButton_Click;
            // 
            // btnSeven
            // 
            btnSeven.Anchor = AnchorStyles.Bottom;
            btnSeven.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(56, 137);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 35);
            btnSeven.TabIndex = 7;
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += NumberButton_Click;
            // 
            // btnEight
            // 
            btnEight.Anchor = AnchorStyles.Bottom;
            btnEight.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(138, 137);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 35);
            btnEight.TabIndex = 8;
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += NumberButton_Click;
            // 
            // btnNine
            // 
            btnNine.Anchor = AnchorStyles.Bottom;
            btnNine.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(219, 137);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 35);
            btnNine.TabIndex = 9;
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += NumberButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(56, 178);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Tag = "";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnOperand_Click;
            // 
            // btnZero
            // 
            btnZero.Anchor = AnchorStyles.Bottom;
            btnZero.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(137, 178);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 35);
            btnZero.TabIndex = 11;
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += NumberButton_Click;
            // 
            // btnDivide
            // 
            btnDivide.Anchor = AnchorStyles.Bottom;
            btnDivide.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(219, 178);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 35);
            btnDivide.TabIndex = 12;
            btnDivide.Tag = "";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnOperand_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Anchor = AnchorStyles.Bottom;
            btnSubtract.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(57, 219);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 35);
            btnSubtract.TabIndex = 13;
            btnSubtract.Tag = "";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BtnOperand_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Anchor = AnchorStyles.Bottom;
            btnMultiply.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(138, 219);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 35);
            btnMultiply.TabIndex = 14;
            btnMultiply.Tag = "";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnOperand_Click;
            // 
            // btnEquals
            // 
            btnEquals.Anchor = AnchorStyles.Bottom;
            btnEquals.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(219, 219);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 35);
            btnEquals.TabIndex = 15;
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += BtnOperand_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(57, 260);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(237, 52);
            btnClear.TabIndex = 16;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(354, 324);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivide);
            Controls.Add(btnZero);
            Controls.Add(btnAdd);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnAdd;
        private Button btnZero;
        private Button btnDivide;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnEquals;
        private Button btnClear;
    }
}
