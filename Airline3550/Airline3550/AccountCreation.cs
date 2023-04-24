using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Airline3550
{
	public partial class AccountCreation : Form
	{
		public LoginScreen loginScreen;
		public AccountCreation(LoginScreen screen)
		{
			loginScreen = screen;
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void AccountCreation_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			long temp;
			if (firstName.Text.Length < 1)
			{
				credentialsErrorMessage.Text = "First Name Field Cannot Be Blank";
			}
			else if (lastName.Text.Length < 1)
			{
				credentialsErrorMessage.Text = "Last Name Field Cannot Be Blank";
			}
			else if (address.Text.Length < 1)
			{
				credentialsErrorMessage.Text = "Address Field Cannot Be Blank";
			}
			else if (age.Text.Length < 1)
			{
				credentialsErrorMessage.Text = "Age Field Cannot Be Blank";
			}
			else if (!long.TryParse(age.Text, out temp))
			{
				credentialsErrorMessage.Text = "Age Must Be A Number";
				return;
			}
			else if (phoneNumber.Text.Length < 10)
			{
				credentialsErrorMessage.Text = "Phone Number Is Too Short";
			}
			else if (phoneNumber.Text.Length > 10)
			{
				credentialsErrorMessage.Text = "Phone Number Is Too Long";
			}
			else if (!long.TryParse(phoneNumber.Text, out temp))
			{
				credentialsErrorMessage.Text = "Invalid Phone Number";
				return;
			}
			else if (cardNumber.Text.Length < 15)
			{
				credentialsErrorMessage.Text = "Card Number Must Be At Least 15 Characters Long";
			}
			else if (!long.TryParse(cardNumber.Text, out temp))
			{
				credentialsErrorMessage.Text = "Invalid Card Number";
				return;
			}
			else if (passwordField.Text.Length < 3)
			{
				credentialsErrorMessage.Text = "Password must be 3 characters or more in length";
			}
			else if (passwordField.Text != secondPasswordField.Text)
			{
				credentialsErrorMessage.Text = "Passwords do not match";
			}
			else
			{
				//User input is correct
				userIDPopup popup = new userIDPopup(User.createCustomerAccount(firstName.Text, lastName.Text, passwordField.Text, address.Text, age.Text, phoneNumber.Text, cardNumber.Text), this);
				popup.Show();


			}
		}

		private void credentialsErrorMessage_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			loginScreen.Show();
			this.Close();
		}

		private void AccountCreation_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Check if the login screen is visible, if it's not then
			//the user must have closed the program so kill it
			if (!loginScreen.Visible)
				loginScreen.Close();

		}

		private void AccountCreation_Resized(object sender, EventArgs e)
		{
			firstName.Location = new Point(Width / 2 - firstName.Size.Width / 2, firstName.Location.Y);
			credentialsErrorMessage.Location = new Point(Width / 2 - credentialsErrorMessage.Size.Width / 2, credentialsErrorMessage.Location.Y);
			passwordField.Location = new Point(Width / 2 - passwordField.Size.Width / 2, passwordField.Location.Y);
			secondPasswordField.Location = new Point(Width / 2 - secondPasswordField.Size.Width / 2, secondPasswordField.Location.Y);
			label1.Location = new Point(Width / 2 - firstName.Size.Width / 2, label1.Location.Y);
			label2.Location = new Point(Width / 2 - firstName.Size.Width / 2, label2.Location.Y);
			linkLabel1.Location = new Point(Width / 2 - linkLabel1.Size.Width / 2, linkLabel1.Location.Y);
			label4.Location = new Point(Width / 2 - firstName.Size.Width / 2, label4.Location.Y);
			button1.Location = new Point(Width / 2 - button1.Size.Width / 2, button1.Location.Y);
			label3.Location = new Point(Width / 2 - label3.Size.Width / 2, label3.Location.Y);
			lastName.Location = new Point(Width / 2 - lastName.Size.Width / 2, lastName.Location.Y);
			address.Location = new Point(Width / 2 - address.Size.Width / 2, address.Location.Y);
			age.Location = new Point(Width / 2 - age.Size.Width / 2, age.Location.Y);
			cardNumber.Location = new Point(Width / 2 - cardNumber.Size.Width / 2, cardNumber.Location.Y);
			phoneNumber.Location = new Point(Width / 2 - phoneNumber.Size.Width / 2, phoneNumber.Location.Y);
			label5.Location = new Point(Width / 2 - firstName.Size.Width / 2, label5.Location.Y);
			label6.Location = new Point(Width / 2 - firstName.Size.Width / 2, label6.Location.Y);
			label7.Location = new Point(Width / 2 - firstName.Size.Width / 2, label7.Location.Y);
			label8.Location = new Point(Width / 2 - firstName.Size.Width / 2, label8.Location.Y);
			label9.Location = new Point(Width / 2 - firstName.Size.Width / 2, label9.Location.Y);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void AccountCreation_Activated(object sender, EventArgs e)
		{
			firstName.Location = new Point(Width / 2 - firstName.Size.Width / 2, firstName.Location.Y);
			credentialsErrorMessage.Location = new Point(Width / 2 - credentialsErrorMessage.Size.Width / 2, credentialsErrorMessage.Location.Y);
			passwordField.Location = new Point(Width / 2 - passwordField.Size.Width / 2, passwordField.Location.Y);
			secondPasswordField.Location = new Point(Width / 2 - secondPasswordField.Size.Width / 2, secondPasswordField.Location.Y);
			label1.Location = new Point(Width / 2 - firstName.Size.Width / 2, label1.Location.Y);
			label2.Location = new Point(Width / 2 - firstName.Size.Width / 2, label2.Location.Y);
			linkLabel1.Location = new Point(Width / 2 - linkLabel1.Size.Width / 2, linkLabel1.Location.Y);
			label4.Location = new Point(Width / 2 - firstName.Size.Width / 2, label4.Location.Y);
			button1.Location = new Point(Width / 2 - button1.Size.Width / 2, button1.Location.Y);
			label3.Location = new Point(Width / 2 - label3.Size.Width / 2, label3.Location.Y);
			lastName.Location = new Point(Width / 2 - lastName.Size.Width / 2, lastName.Location.Y);
			address.Location = new Point(Width / 2 - address.Size.Width / 2, address.Location.Y);
			age.Location = new Point(Width / 2 - age.Size.Width / 2, age.Location.Y);
			cardNumber.Location = new Point(Width / 2 - cardNumber.Size.Width / 2, cardNumber.Location.Y);
			phoneNumber.Location = new Point(Width / 2 - phoneNumber.Size.Width / 2, phoneNumber.Location.Y);
			label5.Location = new Point(Width / 2 - firstName.Size.Width / 2, label5.Location.Y);
			label6.Location = new Point(Width / 2 - firstName.Size.Width / 2, label6.Location.Y);
			label7.Location = new Point(Width / 2 - firstName.Size.Width / 2, label7.Location.Y);
			label8.Location = new Point(Width / 2 - firstName.Size.Width / 2, label8.Location.Y);
			label9.Location = new Point(Width / 2 - firstName.Size.Width / 2, label9.Location.Y);

		}

		private void cardNumber_TextChanged(object sender, EventArgs e)
		{

		}
	}

}
