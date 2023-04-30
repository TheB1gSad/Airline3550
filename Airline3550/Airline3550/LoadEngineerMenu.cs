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
	public partial class LoadEngineerMenu : Form
	{
		private LoginScreen login;
		public User.userData userData;
		private ManageAccount manageAccount;
		private PlanRoute planRoute;
		//pass a userData struct from the User class that contains logged in user's credentials/username
		public LoadEngineerMenu(User.userData thisUser, LoginScreen loginScreen)
		{
			login = loginScreen;
			userData = thisUser;
			planRoute = new PlanRoute();
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

		private void LoadEngineerMenu_FormClosing(object sender, FormClosingEventArgs e)
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
			planRoute.Hide();
			userData = manageAccount.userData;
			label1.Text = "Welcome To Airline 3550 " + userData.firstname;
		}

		private void planRouteClicked(object sender, EventArgs e)
		{
			if (!planRoute.Visible)
			{

				hideAllMenus();
				label1.Hide();
				planRoute.TopLevel = false;
				menuLabel.Controls.Add(planRoute);
				planRoute.Dock = DockStyle.Fill;
				planRoute.Show();
			}
			else
			{
				hideAllMenus();
				label1.Show();
			}
		}
	}
}
