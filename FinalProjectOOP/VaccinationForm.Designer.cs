namespace FinalProjectOOP
{
    partial class VaccinationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationForm));
            vaccineTypeComboBox = new ComboBox();
            vaccineDateTimePicker = new DateTimePicker();
            administerComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // vaccineTypeComboBox
            // 
            vaccineTypeComboBox.FormattingEnabled = true;
            vaccineTypeComboBox.Items.AddRange(new object[] { "BCG", "HEPA B", "OPV", "IPV", "PENTA DPT 5-IN-1", "PCV", "PPV", "MMR", "MR", "ROTAVIRUS", "JE", "TD", "HPV", "INFLUENZA", "COVID", "CHICKENPOX" });
            vaccineTypeComboBox.Location = new Point(30, 76);
            vaccineTypeComboBox.Name = "vaccineTypeComboBox";
            vaccineTypeComboBox.Size = new Size(192, 39);
            vaccineTypeComboBox.TabIndex = 0;
            vaccineTypeComboBox.Text = "Select Vaccine";
            // 
            // vaccineDateTimePicker
            // 
            vaccineDateTimePicker.CustomFormat = "MM/dd/yyy hh:mm tt";
            vaccineDateTimePicker.Format = DateTimePickerFormat.Custom;
            vaccineDateTimePicker.Location = new Point(31, 197);
            vaccineDateTimePicker.Name = "vaccineDateTimePicker";
            vaccineDateTimePicker.Size = new Size(471, 39);
            vaccineDateTimePicker.TabIndex = 2;
            // 
            // administerComboBox
            // 
            administerComboBox.FormattingEnabled = true;
            administerComboBox.Items.AddRange(new object[] { "DR. DELA CRUZ", "DR. KAZAMA", "DR. USANAGI", "NURSE CHELLE", "NURSE JHIMERLIN", "NURSE RAY" });
            administerComboBox.Location = new Point(310, 76);
            administerComboBox.Name = "administerComboBox";
            administerComboBox.Size = new Size(192, 39);
            administerComboBox.Sorted = true;
            administerComboBox.TabIndex = 1;
            administerComboBox.Text = "Select Choices";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 15, 0, 15);
            label1.Size = new Size(157, 62);
            label1.TabIndex = 3;
            label1.Text = "Vaccine Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 11);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 15, 0, 15);
            label2.Size = new Size(194, 62);
            label2.TabIndex = 4;
            label2.Text = "Administered By:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 132);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 15, 0, 15);
            label3.Size = new Size(261, 62);
            label3.TabIndex = 5;
            label3.Text = "Date of Administration:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(30, 344);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(275, 110);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // VaccinationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 481);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(administerComboBox);
            Controls.Add(vaccineDateTimePicker);
            Controls.Add(vaccineTypeComboBox);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "VaccinationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vaccination Information System - Vaccination";
            Load += vaccination_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox vaccineTypeComboBox;
        private DateTimePicker vaccineDateTimePicker;
        private ComboBox administerComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
    }
}