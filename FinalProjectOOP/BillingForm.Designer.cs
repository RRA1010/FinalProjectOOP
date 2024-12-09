namespace FinalProjectOOP
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            vaccinePriceBox = new TextBox();
            paymentTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            changeTextbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            membershipComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // vaccinePriceBox
            // 
            vaccinePriceBox.Location = new Point(35, 66);
            vaccinePriceBox.Margin = new Padding(5);
            vaccinePriceBox.Name = "vaccinePriceBox";
            vaccinePriceBox.Size = new Size(225, 39);
            vaccinePriceBox.TabIndex = 0;
            // 
            // paymentTextbox
            // 
            paymentTextbox.Location = new Point(35, 167);
            paymentTextbox.Margin = new Padding(5);
            paymentTextbox.Name = "paymentTextbox";
            paymentTextbox.Size = new Size(225, 39);
            paymentTextbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 2;
            label1.Text = "Vaccine Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 130);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 3;
            label2.Text = "Payment";
            // 
            // changeTextbox
            // 
            changeTextbox.BackColor = SystemColors.ControlLightLight;
            changeTextbox.Location = new Point(295, 66);
            changeTextbox.Margin = new Padding(5);
            changeTextbox.Multiline = true;
            changeTextbox.Name = "changeTextbox";
            changeTextbox.ReadOnly = true;
            changeTextbox.Size = new Size(246, 140);
            changeTextbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 29);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 5;
            label3.Text = "Change";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 241);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 6;
            label4.Text = "Date of Payment";
            // 
            // button1
            // 
            button1.Location = new Point(295, 276);
            button1.Name = "button1";
            button1.Size = new Size(246, 146);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 348);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 10;
            label5.Text = "Membership";
            // 
            // membershipComboBox
            // 
            membershipComboBox.FormattingEnabled = true;
            membershipComboBox.Items.AddRange(new object[] { "Member", "Non-Member" });
            membershipComboBox.Location = new Point(36, 383);
            membershipComboBox.Name = "membershipComboBox";
            membershipComboBox.Size = new Size(224, 39);
            membershipComboBox.TabIndex = 11;
            membershipComboBox.Text = "Select Membership";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(35, 278);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 39);
            dateTimePicker1.TabIndex = 12;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 478);
            Controls.Add(dateTimePicker1);
            Controls.Add(membershipComboBox);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(changeTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(paymentTextbox);
            Controls.Add(vaccinePriceBox);
            Font = new Font("Segoe UI", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "BillingForm";
            Text = "Vaccination Information System - Billing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox vaccinePriceBox;
        private TextBox paymentTextbox;
        private Label label1;
        private Label label2;
        private TextBox changeTextbox;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private ComboBox membershipComboBox;
        private DateTimePicker dateTimePicker1;
    }
}