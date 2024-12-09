namespace FinalProjectOOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dateTimeLabel2 = new Label();
            currentUserTextbox = new TextBox();
            closeButton = new Button();
            label1 = new Label();
            dateTimeLabel = new Label();
            logoutButton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            billingButton = new Button();
            vaccinationButton = new Button();
            patientInfoButton = new Button();
            headingLabel = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            patientsToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            vaccinationToolStripMenuItem = new ToolStripMenuItem();
            billingToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.7421646F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2578373F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1563, 864);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dateTimeLabel2);
            panel1.Controls.Add(currentUserTextbox);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimeLabel);
            panel1.Controls.Add(logoutButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1267, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 854);
            panel1.TabIndex = 0;
            // 
            // dateTimeLabel2
            // 
            dateTimeLabel2.AutoSize = true;
            dateTimeLabel2.Font = new Font("Segoe UI", 10F);
            dateTimeLabel2.Location = new Point(18, 149);
            dateTimeLabel2.Margin = new Padding(5, 0, 5, 0);
            dateTimeLabel2.Name = "dateTimeLabel2";
            dateTimeLabel2.Size = new Size(117, 23);
            dateTimeLabel2.TabIndex = 13;
            dateTimeLabel2.Text = "dateTimeHere";
            // 
            // currentUserTextbox
            // 
            currentUserTextbox.Enabled = false;
            currentUserTextbox.Location = new Point(18, 59);
            currentUserTextbox.Name = "currentUserTextbox";
            currentUserTextbox.Size = new Size(236, 39);
            currentUserTextbox.TabIndex = 12;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(34, 779);
            closeButton.Margin = new Padding(5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(220, 50);
            closeButton.TabIndex = 11;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "Current User:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 10F);
            dateTimeLabel.Location = new Point(18, 112);
            dateTimeLabel.Margin = new Padding(5, 0, 5, 0);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(117, 23);
            dateTimeLabel.TabIndex = 9;
            dateTimeLabel.Text = "dateTimeHere";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(34, 719);
            logoutButton.Margin = new Padding(5);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(220, 50);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(billingButton);
            panel2.Controls.Add(vaccinationButton);
            panel2.Controls.Add(patientInfoButton);
            panel2.Controls.Add(headingLabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 5);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 854);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(7, 519);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 328);
            panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1242, 328);
            dataGridView1.TabIndex = 7;
            // 
            // billingButton
            // 
            billingButton.Location = new Point(16, 393);
            billingButton.Name = "billingButton";
            billingButton.Size = new Size(340, 91);
            billingButton.TabIndex = 6;
            billingButton.Text = "Billing";
            billingButton.UseVisualStyleBackColor = true;
            billingButton.Click += billingButton_Click;
            // 
            // vaccinationButton
            // 
            vaccinationButton.Location = new Point(16, 296);
            vaccinationButton.Name = "vaccinationButton";
            vaccinationButton.Size = new Size(340, 91);
            vaccinationButton.TabIndex = 5;
            vaccinationButton.Text = "Vaccination";
            vaccinationButton.UseVisualStyleBackColor = true;
            vaccinationButton.Click += vaccinationButton_Click;
            // 
            // patientInfoButton
            // 
            patientInfoButton.Location = new Point(16, 199);
            patientInfoButton.Name = "patientInfoButton";
            patientInfoButton.Size = new Size(340, 91);
            patientInfoButton.TabIndex = 4;
            patientInfoButton.Text = "Patient Information";
            patientInfoButton.UseVisualStyleBackColor = true;
            patientInfoButton.Click += patientInfoButton_Click;
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headingLabel.Location = new Point(173, 14);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(336, 92);
            headingLabel.TabIndex = 1;
            headingLabel.Text = "Vaccination \r\nInformation System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { patientsToolStripMenuItem, vaccinationToolStripMenuItem, billingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1563, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            patientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informationToolStripMenuItem });
            patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            patientsToolStripMenuItem.Size = new Size(74, 24);
            patientsToolStripMenuItem.Text = "Patients";
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(170, 26);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += patientInfoButton_Click;
            // 
            // vaccinationToolStripMenuItem
            // 
            vaccinationToolStripMenuItem.Name = "vaccinationToolStripMenuItem";
            vaccinationToolStripMenuItem.Size = new Size(99, 24);
            vaccinationToolStripMenuItem.Text = "Vaccination";
            vaccinationToolStripMenuItem.Click += vaccinationButton_Click;
            // 
            // billingToolStripMenuItem
            // 
            billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            billingToolStripMenuItem.Size = new Size(65, 24);
            billingToolStripMenuItem.Text = "Billing";
            billingToolStripMenuItem.Click += billingButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 892);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vaccination Information System";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button logoutButton;
        private Label dateTimeLabel;
        private Panel panel2;
        private Label label1;
        private Button closeButton;
        private TextBox currentUserTextbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem patientsToolStripMenuItem;
        private ToolStripMenuItem vaccinationToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label headingLabel;
        private Button patientInfoButton;
        private Button vaccinationButton;
        private Button billingButton;
        private ToolStripMenuItem informationToolStripMenuItem;
        private Label dateTimeLabel2;
        public DataGridView dataGridView1;
        private ToolStripMenuItem billingToolStripMenuItem;
        private Panel panel3;
    }
}