namespace FinalProjectOOP
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUser = usernameTextBox.Text;
            string inputPassword = passwordTextBox.Text;

            if (inputUser == "admin" && inputPassword == "1234")
            {
                MainForm dashboardForm = new MainForm(usernameTextBox.Text);
                dashboardForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The username or password doesn't exist!");
            }


        }
    }
}
