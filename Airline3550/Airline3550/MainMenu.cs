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
	public partial class MainMenu : Form
	{
		//pass a userData struct from the User class that contains logged in user's credentials/username
		public MainMenu(User.userData thisUser)
		{
			
			InitializeComponent();
			if (thisUser.credentials == "customer")
			{
				this.customerMenus1.Show();
			}
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
	}
}
