using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Airline3550
{
	public partial class userIDPopup : Form
	{
		private string userID;
		private AccountCreation account;
		public userIDPopup(string userName, AccountCreation accountCreation)
		{
			userID = userName;
			account = accountCreation;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			userIdOut.Text = userID;
			account.Hide();
			this.BringToFront();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			account.loginScreen.Show();
			account.Close();
			this.Close();
		}

		private void userIdOut_Click(object sender, EventArgs e)
		{

		}
	}
}
