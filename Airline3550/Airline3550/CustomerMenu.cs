﻿using System;
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
	public partial class CustomerMenu : Form
	{
		private LoginScreen login;
		private User.userData userData;
		private ManageAccount manageAccount;
		//pass a userData struct from the User class that contains logged in user's credentials/username
		public CustomerMenu(User.userData thisUser, LoginScreen loginScreen)
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

		private void customerMenus1_Load(object sender, EventArgs e)
		{

		}


		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void logout_Clicked(object sender, EventArgs e)
		{
			login.Show();
			this.Close();

		}

		private void CustomerMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Check if the login screen is visible, if it's not then
			//the user must have closed the program so kill it
			if (!login.Visible)
				login.Close();

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

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
			userData = manageAccount.userData;
			label1.Text = "Welcome To Airline 3550 " + userData.firstname;
		}

		private void manageFlightsClick(object sender, EventArgs e)
		{
			hideAllMenus();
		}

		private void bookFlightClick(object sender, EventArgs e)
		{
			hideAllMenus();
		}
	}
}
