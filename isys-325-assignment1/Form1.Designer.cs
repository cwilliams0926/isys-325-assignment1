namespace isys_325_assignment1
{
    partial class Assignment1
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
            firstName = new TextBox();
            hoursWorked = new TextBox();
            lastName = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            hoursWorkedLabel = new Label();
            summarizeButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(61, 116);
            firstName.Name = "firstName";
            firstName.Size = new Size(185, 23);
            firstName.TabIndex = 0;
            // 
            // hoursWorked
            // 
            hoursWorked.Location = new Point(542, 116);
            hoursWorked.Name = "hoursWorked";
            hoursWorked.Size = new Size(185, 23);
            hoursWorked.TabIndex = 1;
            // 
            // lastName
            // 
            lastName.Location = new Point(298, 116);
            lastName.Name = "lastName";
            lastName.Size = new Size(185, 23);
            lastName.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(61, 98);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += label1_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(298, 98);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new Point(542, 98);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(83, 15);
            hoursWorkedLabel.TabIndex = 5;
            hoursWorkedLabel.Text = "Hours Worked";
            // 
            // summarizeButton
            // 
            summarizeButton.Location = new Point(61, 202);
            summarizeButton.Name = "summarizeButton";
            summarizeButton.Size = new Size(115, 23);
            summarizeButton.TabIndex = 6;
            summarizeButton.Text = "Summarize";
            summarizeButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(182, 202);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(115, 23);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // Assignment1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(summarizeButton);
            Controls.Add(hoursWorkedLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(lastName);
            Controls.Add(hoursWorked);
            Controls.Add(firstName);
            Name = "Assignment1";
            Text = "Assignment1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private TextBox hoursWorked;
        private TextBox lastName;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label hoursWorkedLabel;
        private Button summarizeButton;
        private Button clearButton;
    }
}
