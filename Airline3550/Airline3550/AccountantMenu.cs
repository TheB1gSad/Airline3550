using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline3550
{
	public partial class AccountantMenu : Form
	{
		private LoginScreen login;
		public User.userData userData;
		private ManageAccount manageAccount;
		private PrintFinancialData printFinancial = new PrintFinancialData();
		//pass a userData struct from the User class that contains logged in user's credentials/username
		public AccountantMenu(User.userData thisUser, LoginScreen loginScreen)
		{
			login = loginScreen;
			userData = thisUser;
			manageAccount = new ManageAccount(userData);
			InitializeComponent();


		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
			label1.Text += userData.firstname;
		}

		private void logout_Clicked(object sender, EventArgs e)
		{
			login.Show();
			this.Close();

		}

		private void FlightManagerClosing(object sender, FormClosingEventArgs e)
		{
			//Check if the login screen is visible, if it's not then
			//the user must have closed the program so kill it
			if (!login.Visible)
				login.Close();

		}


		private void manageAccountClicked(object sender, EventArgs e)
		{

			if (!manageAccount.Visible)
			{

				hideAllMenus();
				label1.Hide();
				manageAccount.TopLevel = false;
				menuLabel.Controls.Add(manageAccount);
				manageAccount.Dock = DockStyle.Fill;
				manageAccount.Show();
			}
			else
			{
				hideAllMenus();
				label1.Show();
			}

		}

		//When this method is called, all menus in the menu field will be hidden.
		private void hideAllMenus()
		{
			manageAccount.Hide();
			printFinancial.Hide();
			userData = manageAccount.userData;
			label1.Text = "Welcome To Airline 3550 " + userData.firstname;
		}

		private void finanncialMenu(object sender, EventArgs e)
		{
			if (!printFinancial.Visible)
			{

				hideAllMenus();
				label1.Hide();
				printFinancial.TopLevel = false;
				menuLabel.Controls.Add(printFinancial);
				printFinancial.Dock = DockStyle.Fill;
				printFinancial.Show();
			}
			else
			{
				hideAllMenus();
				label1.Show();
			}
		}
	}
}
