namespace Airline3550
{
	public partial class ManageAccount : Form
	{
		public User.userData userData;
		public ManageAccount(User.userData user)
		{
			userData = user;
			InitializeComponent();
		}


		private void formLoaded(object sender, EventArgs e)
		{
			//Set data fields
			firstLabel.Text += userData.firstname;
			lastLabel.Text += userData.lastname;
			ageLabel.Text += userData.age;
			addressLabel.Text += userData.address;
			phoneLabel.Text += userData.phoneNumber;
			userLabel.Text += userData.userName;
			string last4CardNum = userData.cardNumber.Substring(userData.cardNumber.Length - 4, 4);
			string atr = new string('*', (userData.cardNumber.Length - 4));
			cardLabel.Text += atr + last4CardNum;


			//Position the input text boxes to follow the height of the labels
			int padding = firstLabel.Padding.Bottom;
			firstNameField.Location = new Point(firstNameField.Location.X, firstLabel.Bottom - firstNameField.Height - padding);
			lastNameField.Location = new Point(lastNameField.Location.X, lastLabel.Bottom - lastNameField.Height - padding);
			ageField.Location = new Point(ageField.Location.X, ageLabel.Bottom - ageField.Height - padding);
			phoneField.Location = new Point(phoneField.Location.X, phoneLabel.Bottom - phoneField.Height - padding);

		}


		//if a key is pressed and it is enter, check which text field is selected, if none do nothing
		private void keyPressed(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				//Check which text box is focused
				if (firstNameField.Focus())
				{
					//call function to edit first Name
					if (firstNameField.Text.Length > 0)
					{
						userData.firstname = firstNameField.Text;
						firstLabel.Text = "First Name: " + firstNameField.Text;
					}

				}
				else if (lastNameField.Focus())
				{
					// call function to edit last name
				}
				else if (ageField.Focus())
				{
					// call function to edit age
				}
				else if (addressField.Focus())
				{
					// call function to edit address
				}
				else if (phoneField.Focus())
				{
					// call function to edit phone
				}
			}
		}

		private void formResized(object sender, EventArgs e)
		{

			firstLabel.Location = new Point(firstLabel.Location.X, firstLabel.Location.Y);
			lastLabel.Location = new Point(lastLabel.Location.X, lastLabel.Location.Y);
			ageLabel.Location = new Point(ageLabel.Location.X, ageLabel.Location.Y);
			phoneLabel.Location = new Point(phoneLabel.Location.X, phoneLabel.Location.Y);
			addressLabel.Location = new Point(addressLabel.Location.X, addressLabel.Location.Y);


			int padding = firstLabel.Padding.Bottom;
			firstNameField.Location = new Point(firstNameField.Location.X, firstLabel.Bottom - firstNameField.Height - padding);
			lastNameField.Location = new Point(lastNameField.Location.X, lastLabel.Bottom - lastNameField.Height - padding);
			ageField.Location = new Point(ageField.Location.X, ageLabel.Bottom - ageField.Height - padding);
			phoneField.Location = new Point(phoneField.Location.X, phoneLabel.Bottom - phoneField.Height - padding);
			addressField.Location = new Point(addressField.Location.X, addressLabel.Bottom - addressField.Height - padding);
		}
	}
}
