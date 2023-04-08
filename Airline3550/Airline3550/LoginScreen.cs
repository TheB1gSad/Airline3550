namespace Airline3550
{
	public partial class LoginScreen : Form
	{
		public LoginScreen()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}



		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (usernameField.Text == "" && passwordField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Username and Password";
			}
			else if (usernameField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Username";
			}
			else if (passwordField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Password";
			}
			else
			{
				//If we made it here there is some text in both username and password
				//Begin Checking credentials
				//Call function to hash user's password
				//Call function to check csv for username and hashed password combination
				User.userData thisUser = User.validateCredentials(usernameField.Text, passwordField.Text);
				if (thisUser.credentials != "")
				{
					//create an instance of MainMenu, pass it our user info and then display it
					MainMenu mainMenu = new MainMenu(thisUser);
					this.Hide();
					mainMenu.Show();
					mainMenu.FormClosed += (s, args) => this.Close();

				}
				else
				{
					credentialsErrorMessage.Text = "Invalid Credentials, Please Try Again.";
				}

			}
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}