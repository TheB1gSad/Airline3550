using System.Media;
using System.Windows.Forms;

namespace Airline3550
{
	public partial class LoginScreen : Form
	{
		public LoginScreen()
		{

			InitializeComponent();
			this.BringToFront();
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			AccountCreation accountCreation = new AccountCreation(this);
			accountCreation.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (usernameField.Text == "" && passwordField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Username and Password";
				SystemSounds.Beep.Play();
			}
			else if (usernameField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Username";
				SystemSounds.Beep.Play();
			}
			else if (passwordField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Password";
				SystemSounds.Beep.Play();
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

					if (thisUser.credentials == "customer")
					{
						CustomerMenu mainMenu = new CustomerMenu(thisUser, this);
						this.Hide();
						usernameField.Text = "";
						passwordField.Text = "";
						credentialsErrorMessage.Text = "";
						mainMenu.Show();
					}
					else if (thisUser.credentials == "loadengineer")
					{
						LoadEngineerMenu mainMenu = new LoadEngineerMenu(thisUser, this);
						this.Hide();
						usernameField.Text = "";
						passwordField.Text = "";
						credentialsErrorMessage.Text = "";
						mainMenu.Show();
					}
					else if(thisUser.credentials =="flightmanager")
					{
						FlightManagerMenu mainMenu = new FlightManagerMenu(thisUser, this);
						this.Hide();
						usernameField.Text = "";
						passwordField.Text = "";
						credentialsErrorMessage.Text = "";
						mainMenu.Show();

					}

				}
				else
				{
					SystemSounds.Beep.Play();
					credentialsErrorMessage.Text = "Invalid Credentials, Please Try Again.";
				}

			}
		}

		private void LoginScreen_Load(object sender, EventArgs e)
		{
			usernameField.Location = new Point(Width / 2 - usernameField.Size.Width / 2, usernameField.Location.Y);
			passwordField.Location = new Point(Width / 2 - passwordField.Size.Width / 2, passwordField.Location.Y);
			createAccount.Location = new Point(Width / 2 - createAccount.Size.Width / 2, createAccount.Location.Y);
			label1.Location = new Point(Width / 2 - label1.Size.Width / 2, label1.Location.Y);
			label2.Location = new Point(Width / 2 - label2.Size.Width / 2, label2.Location.Y);
			button1.Location = new Point(Width / 2 - button1.Size.Width / 2, button1.Location.Y);
			credentialsErrorMessage.Location = new Point(Width / 2 - credentialsErrorMessage.Size.Width / 2, credentialsErrorMessage.Location.Y);
		}

		private void LoginScreen_Resize(object sender, EventArgs e)
		{
			usernameField.Location = new Point(Width / 2 - usernameField.Size.Width / 2, usernameField.Location.Y);
			passwordField.Location = new Point(Width / 2 - passwordField.Size.Width / 2, passwordField.Location.Y);
			createAccount.Location = new Point(Width / 2 - createAccount.Size.Width / 2, createAccount.Location.Y);
			label1.Location = new Point(Width / 2 - label1.Size.Width / 2, label1.Location.Y);
			label2.Location = new Point(Width / 2 - label2.Size.Width / 2, label2.Location.Y);
			button1.Location = new Point(Width / 2 - button1.Size.Width / 2, button1.Location.Y);
			credentialsErrorMessage.Location = new Point(Width / 2 - credentialsErrorMessage.Size.Width / 2, credentialsErrorMessage.Location.Y);
		}
	}
}