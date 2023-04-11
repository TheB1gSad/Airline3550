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
	public partial class CustomerMenu : Form
	{
		private LoginScreen login;
		//pass a userData struct from the User class that contains logged in user's credentials/username
		public CustomerMenu(User.userData thisUser, LoginScreen loginScreen)
		{
			login = loginScreen;
			InitializeComponent();


		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

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
	}
}
