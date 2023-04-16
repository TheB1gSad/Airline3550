using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			if (usernameField.Text.Length < 3)
			{
				credentialsErrorMessage.Text = "Username must be 3 characters or more in length";
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
				if (!User.createCustomerAccount(usernameField.Text, passwordField.Text))
				{
					credentialsErrorMessage.Text = "Username already exist";
				}
				else
				{
					loginScreen.Show();
					this.Close();
				}
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
			usernameField.Location = new Point(Width / 2 - usernameField.Size.Width / 2, usernameField.Location.Y);
			passwordField.Location = new Point(Width / 2 - passwordField.Size.Width / 2, passwordField.Location.Y);
			secondPasswordField.Location = new Point(Width / 2 - secondPasswordField.Size.Width / 2, secondPasswordField.Location.Y);
			label1.Location = new Point(Width / 2 - label1.Size.Width / 2, label1.Location.Y);
			label2.Location = new Point(Width / 2 - label2.Size.Width / 2, label2.Location.Y);
			linkLabel1.Location = new Point(Width / 2 - linkLabel1.Size.Width / 2, linkLabel1.Location.Y);
			label4.Location = new Point(Width / 2 - label4.Size.Width / 2, label4.Location.Y);
			button1.Location = new Point(Width / 2 - button1.Size.Width / 2, button1.Location.Y);
			credentialsErrorMessage.Location = new Point(Width / 2 - credentialsErrorMessage.Size.Width/2, credentialsErrorMessage.Location.Y);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void AccountCreation_Activated(object sender, EventArgs e)
		{
			usernameField.Location = new Point(Width / 2 - usernameField.Size.Width / 2, usernameField.Location.Y);
			credentialsErrorMessage.Location = new Point(Width / 2 - credentialsErrorMessage.Size.Width/2 , credentialsErrorMessage.Location.Y);
			passwordField.Location = new Point(Width / 2 - passwordField.Size.Width / 2, passwordField.Location.Y);
			secondPasswordField.Location = new Point(Width / 2 - secondPasswordField.Size.Width / 2, secondPasswordField.Location.Y);
			label1.Location = new Point(Width / 2 - label1.Size.Width / 2, label1.Location.Y);
			label2.Location = new Point(Width / 2 - label2.Size.Width / 2, label2.Location.Y);
			linkLabel1.Location = new Point(Width / 2 - linkLabel1.Size.Width / 2, linkLabel1.Location.Y);
			label4.Location = new Point(Width / 2 - label4.Size.Width / 2, label4.Location.Y);
			button1.Location = new Point(Width / 2 - button1.Size.Width / 2, button1.Location.Y);
		}
	}
	
}
