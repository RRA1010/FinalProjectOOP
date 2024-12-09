namespace FinalProjectOOP
{
    partial class PatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            firstNameTextbox = new TextBox();
            label1 = new Label();
            midNameTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lastNameTextbox = new TextBox();
            suffixTextbox = new TextBox();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            registerButton = new Button();
            birthdateTimePicker = new DateTimePicker();
            label7 = new Label();
            sexComboBox = new ComboBox();
            SuspendLayout();
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(229, 111);
            firstNameTextbox.Margin = new Padding(5);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(201, 39);
            firstNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 114);
            label1.Margin = new Padding(5, 0, 5, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // midNameTextbox
            // 
            midNameTextbox.Location = new Point(229, 210);
            midNameTextbox.Margin = new Padding(5);
            midNameTextbox.Name = "midNameTextbox";
            midNameTextbox.Size = new Size(201, 39);
            midNameTextbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19F);
            label2.Location = new Point(14, 9);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(305, 45);
            label2.TabIndex = 3;
            label2.Text = "Patient Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 213);
            label3.Margin = new Padding(5, 0, 5, 20);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 4;
            label3.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 301);
            label4.Margin = new Padding(5, 0, 5, 20);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 5;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 394);
            label5.Margin = new Padding(5, 0, 5, 20);
            label5.Name = "label5";
            label5.Size = new Size(79, 32);
            label5.TabIndex = 6;
            label5.Text = "Suffix:";
            // 
            // lastNameTextbox
            // 
            lastNameTextbox.Location = new Point(229, 298);
            lastNameTextbox.Margin = new Padding(5);
            lastNameTextbox.Name = "lastNameTextbox";
            lastNameTextbox.Size = new Size(201, 39);
            lastNameTextbox.TabIndex = 7;
            // 
            // suffixTextbox
            // 
            suffixTextbox.Location = new Point(229, 391);
            suffixTextbox.Margin = new Padding(5);
            suffixTextbox.Name = "suffixTextbox";
            suffixTextbox.Size = new Size(201, 39);
            suffixTextbox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 113);
            label6.Margin = new Padding(5, 0, 5, 20);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 9;
            label6.Text = "Birthdate:";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(498, 301);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(274, 129);
            registerButton.TabIndex = 14;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // birthdateTimePicker
            // 
            birthdateTimePicker.CustomFormat = "MM/dd/yyyy";
            birthdateTimePicker.Format = DateTimePickerFormat.Custom;
            birthdateTimePicker.Location = new Point(621, 107);
            birthdateTimePicker.Name = "birthdateTimePicker";
            birthdateTimePicker.Size = new Size(151, 39);
            birthdateTimePicker.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(479, 213);
            label7.Margin = new Padding(5, 0, 5, 20);
            label7.Name = "label7";
            label7.Size = new Size(56, 32);
            label7.TabIndex = 16;
            label7.Text = "Sex:";
            // 
            // sexComboBox
            // 
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Female", "Male" });
            sexComboBox.Location = new Point(621, 210);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(151, 39);
            sexComboBox.TabIndex = 18;
            sexComboBox.Text = "Female";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 493);
            Controls.Add(sexComboBox);
            Controls.Add(label7);
            Controls.Add(birthdateTimePicker);
            Controls.Add(registerButton);
            Controls.Add(label6);
            Controls.Add(suffixTextbox);
            Controls.Add(lastNameTextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(midNameTextbox);
            Controls.Add(label1);
            Controls.Add(firstNameTextbox);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vaccination Information System - Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextbox;
        private Label label1;
        private TextBox midNameTextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox lastNameTextbox;
        private TextBox suffixTextbox;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button registerButton;
        private DateTimePicker birthdateTimePicker;
        private Label label7;
        private ComboBox sexComboBox;
    }
}