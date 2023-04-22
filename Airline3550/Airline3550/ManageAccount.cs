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

				//Keep track if any valid changes were made
				bool infoChanged = false;

				User.userData tempUserDat = userData;


				if (panel2.Focus())
				{
					//call function to edit first Name

					//Check which boxes have data in them, then check if
					//those boxes are valid before updating the data
					if (firstNameField.Text.Length > 0)
					{
						tempUserDat.firstname = firstNameField.Text;
						firstNameField.Text = "";
						infoChanged = true;

					}

					if (lastNameField.Text.Length > 0)
					{
						tempUserDat.lastname = lastNameField.Text;
						lastNameField.Text = "";
						infoChanged = true;
					}

					if (ageField.Text.Length > 0)
					{
						int temp;

						if (!int.TryParse(ageField.Text, out temp))
						{
							personalInfoerrorLabel.Text = "Invalid Age Entered";
							return;
						}

						tempUserDat.age = ageField.Text;
						ageField.Text = "";
						infoChanged = true;
					}

					if (phoneField.Text.Length > 0)
					{
						if (phoneField.Text.Length != 10)
						{
							personalInfoerrorLabel.Text = "Phone Number Must Be 10 Numbers in Length";
							return;
						}
						else
						{
							long temp;
							if (!long.TryParse(phoneField.Text, out temp))
							{
								personalInfoerrorLabel.Text = "Invalid Phone Number";
								return;
							}
							tempUserDat.phoneNumber = phoneField.Text;
							phoneField.Text = "";
							infoChanged = true;
						}
					}

					if (addressField.Text.Length > 0)
					{
						tempUserDat.address = addressField.Text;
						addressField.Text = "";
						infoChanged = true;
					}

					if (infoChanged)
					{
						firstLabel.Text = "First Name: " + tempUserDat.firstname;
						lastLabel.Text = "Last Name: " + tempUserDat.lastname;
						ageLabel.Text = "Age: " + tempUserDat.age;
						phoneLabel.Text = "Phone Number: " + tempUserDat.phoneNumber;
						phoneLabel.Text = "Address: " + tempUserDat.address;
						personalInfoerrorLabel.Text = "";
					}

				}

				if (panel3.Focus())
				{

					//Check Card Number
					if (cardNumberField.Text.Length > 14)
					{
						long temp;
						if (!long.TryParse(cardNumberField.Text, out temp))
						{
							securityErrorMessage.Text = "Invalid Card Number";
							return;
						}
						tempUserDat.cardNumber = cardNumberField.Text;


						securityErrorMessage.Text = "";
						cardNumberField.Text = "";

						infoChanged = true;
					}
					else if (cardNumberField.Text.Length > 0)
					{
						securityErrorMessage.Text = "Card Number Is Too Short";
					}

					//Check Password
					if (currPassword.Text.Length > 0)
					{
						if (User.validateCredentials(userData.userName, currPassword.Text).credentials != "")
						{
							if (newPassword.Text.Length > 0)
							{
								if (newPassword.Text == newPassword2.Text)
								{
									//We are good to go ahead and begin replacing password.
									User.updatePassword(userData.userName, newPassword2.Text);

									//Clear all of our field to show that the change was succesful
									currPassword.Text = "";
									newPassword.Text = "";
									newPassword2.Text = "";
									securityErrorMessage.Text = "";
								}
								else
								{
									securityErrorMessage.Text = "New Passwords Do Not Match";
								}
							}
							else
							{
								securityErrorMessage.Text = "New Password Field Cannot Be Blank";
							}
						}
						else
						{
							securityErrorMessage.Text = "Invalid Credentials";
						}
					}
					else if (newPassword.Text.Length > 0 || newPassword2.Text.Length > 0)
					{
						securityErrorMessage.Text = "Please Enter Current Password to Update Your Password";
					}

					//Check if the user succesfully updated anything, this reduces calls to update function
					if (infoChanged)
					{
						string last4CardNum = tempUserDat.cardNumber.Substring(tempUserDat.cardNumber.Length - 4, 4);
						string atr = new string('*', (tempUserDat.cardNumber.Length - 4));
						cardLabel.Text = "Card Number: " + atr + last4CardNum;


						userData = tempUserDat;
						User.updateInfo(userData);
					}
				}
				e.SuppressKeyPress = true;
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

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
