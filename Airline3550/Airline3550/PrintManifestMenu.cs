using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Airline3550
{
	public partial class PrintManifestMenu : Form
	{
		public PrintManifestMenu()
		{
			InitializeComponent();
			seatNumberText.Text += "\n";
			userIDText.Text += "\n";
			passengerNameText.Text += "\n";
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			int flightId;
			if (flightIDInput.Text.Length == 0)
			{
				ErrorMessage.Text = "Flight ID Cannot Be Blank";
				return;
			}
			if (int.TryParse(flightIDInput.Text, out flightId))
				printManifest(flightId);
			else
			{
				ErrorMessage.Text = "Invalid Flight ID";
				return;
			}
			ErrorMessage.Text = "";
		}

		private void printManifest(int flightID)
		{
			seatNumberText.Text = "Seat Number\n";
			passengerNameText.Text = "Passenger Name\n";
			userIDText.Text = "Passenger UID\n";
			FlightManager manager = new FlightManager();
			List<string> userIDsPerSeat = manager.printManifest(flightID);

			int TotalSeats = userIDsPerSeat.ToArray().Length;
			string[] userIDArr = userIDsPerSeat.ToArray();
			Cursor.Current = Cursors.WaitCursor;
			tableLayoutPanel3.Hide();
			for (int i = 1; i < TotalSeats; i++)
			{
				addRow(i, userIDArr[i]);

			}
			Cursor.Current = Cursors.Default;
			tableLayoutPanel3.Show();
		}

		private void addRow(int seatNum, string userID)
		{
			//Get passenger name
			User.userData data = User.getUserInfo(userID);
			if (data.userName == null)
				userID = "";
			string name = data.firstname + " " + data.lastname;
			if (data.firstname == null)
			{
				name = "";
			}


			seatNumberText.Text += seatNum.ToString() + "\n";
			userIDText.Text += userID + "\n";
			passengerNameText.Text += name + "\n";
		}
	}
}
