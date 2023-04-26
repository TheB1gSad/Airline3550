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
using System.Xml;

namespace Airline3550
{
	public partial class ManageFlights_Customer : Form
	{
		List<string> currentFlights = new List<string>();
		List<string> previousFlights = new List<string>();
		List<string[]> userTransactions = new List<string[]>();
		static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
		private static string flightListPath = Path.Combine(executablePath, "flightList.csv");
		private static string transactionlistPath = Path.Combine(executablePath, "userTransactions.csv");
		private CustomerMenu mainMenu;
		CurrentFlightDetails currentFlightDetails = new CurrentFlightDetails();
		Button cancelButton;
		Button printButton;
		Panel buttonPanel;
		RichTextBox flightInfopanel;
		Label previousLabel;
		private int currentRow = -1;

		List<flightInformation> previousFlightsFullData = new List<flightInformation>();
		List<flightInformation> upcomingFlightsFullData = new List<flightInformation>();
		public ManageFlights_Customer(CustomerMenu menu)
		{
			mainMenu = menu;
			InitializeComponent();

			cancelButton = (Button)currentFlightDetails.Controls.Find("cancelFlight", true)[0];
			printButton = (Button)currentFlightDetails.Controls.Find("printBoardingPass", true)[0];
			flightInfopanel = (RichTextBox)currentFlightDetails.Controls.Find("textBox", true)[0];
			cancelButton.Click += cancelFlightClicked;
			printButton.Click += printBoardingPassClicked;
			buttonPanel = (Panel)currentFlightDetails.Controls.Find("buttonPanel", true)[0];




		}

		private void initializeFlightList()
		{
			//Read every flight from list
			string line;
			StreamReader streamReaderA = new StreamReader(transactionlistPath);
			//Read in every transaction line by line, find all that have the user id of this user add to transaction list
			while ((line = streamReaderA.ReadLine()) != null)
			{
				string[] currentLine = line.Split(',');
				if (currentLine[0] == mainMenu.userData.userName)
				{
					userTransactions.Add(currentLine);
				}
			}


			streamReaderA.Close();

			for (int i = 0; i < userTransactions.Count; i++)
			{
				streamReaderA = new StreamReader(flightListPath);
				while ((line = streamReaderA.ReadLine()) != null)
				{
					string[] currentLine = line.Split(',');

					if (currentLine[3] != userTransactions.ToArray()[i][4])
					{
						continue;
					}
					DateTime flightDateTime = DateTime.Parse(currentLine[2] + " " + currentLine[0]);
					//Flight must have already happened
					if (flightDateTime < DateTime.Now)
					{
						previousFlights.Add(String.Join(',', currentLine));
						flightInformation temp = new flightInformation();
						temp.seatNumber = userTransactions[i][6];
						temp.flightNumber = currentLine[3];
						temp.datePurchased = userTransactions[i][1];
						temp.departureCity = currentLine[5];
						temp.arrivalCity = currentLine[6];
						temp.planeType = currentLine[7];
						temp.price = currentLine[8];
						temp.dateOfDep = currentLine[2];
						temp.timeOfDep = currentLine[0];
						temp.timeOfAriv = currentLine[1];
						if (userTransactions[i][5] == "n")
							temp.status = "Completed";
						else
							temp.status = "Canceled";

						previousFlightsFullData.Add(temp);
					}
					//Flight Is Upcoming
					else
					{
						currentFlights.Add(String.Join(',', currentLine));

						flightInformation temp = new flightInformation();
						temp.seatNumber = userTransactions[i][6];
						temp.flightNumber = currentLine[3];
						temp.datePurchased = userTransactions[i][1];
						temp.departureCity = currentLine[5];
						temp.arrivalCity = currentLine[6];
						temp.planeType = currentLine[7];
						temp.price = "$" + currentLine[8];
						temp.dateOfDep = currentLine[2];
						temp.timeOfDep = currentLine[0];
						temp.timeOfAriv = currentLine[1];
						if (userTransactions[i][5] == "n")
							temp.status = "Scheduled";
						else
							temp.status = "Canceled";

						upcomingFlightsFullData.Add(temp);
					}
					break;

				}
				streamReaderA.Close();
			}
			addPreviousFlight(previousFlights);
			addUpcomingFlight(currentFlights);
			streamReaderA.Close();
		}

		private void addPreviousFlight(List<string> flights)
		{

			RowStyle tempor = previousFlightsTable.RowStyles[0];

			for (int i = 0; i < flights.Count; i++)
			{
				previousFlightsTable.RowStyles.Add(new RowStyle(tempor.SizeType, tempor.Height));
				string[] arr = flights.ToArray()[i].Split(',');
				string output = arr[2] + " " + arr[5] + "->" + arr[6];
				Label label = new Label();
				label.Click += previousClicked;
				label.Text = output;
				label.Dock = DockStyle.Fill;
				previousFlightsTable.RowCount = previousFlightsTable.RowCount + 1;
				previousFlightsTable.Controls.Add(label, 0, previousFlightsTable.RowCount - 1);
			}
		}
		private void addUpcomingFlight(List<string> flights)
		{
			RowStyle tempor = upcomingFlightsTable.RowStyles[0];



			for (int i = 0; i < flights.Count; i++)
			{
				upcomingFlightsTable.RowStyles.Add(new RowStyle(tempor.SizeType, tempor.Height));
				string[] arr = flights.ToArray()[i].Split(',');
				string output = arr[2] + " " + arr[5] + "->" + arr[6];
				Label label = new Label();
				label.Click += upcomingClicked;
				label.Text = output;
				label.Dock = DockStyle.Fill;

				upcomingFlightsTable.RowCount = upcomingFlightsTable.RowCount + 1;
				upcomingFlightsTable.Controls.Add(label, 0, upcomingFlightsTable.RowCount - 1);
			}

		}

		private void cancelFlightClicked(object sender, EventArgs e)
		{
			MessageBox.Show("Confirm Flight Cancelation"
				, "",
				   MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

		}
		private void printBoardingPassClicked(object sender, EventArgs e)
		{


			flightInformation data = upcomingFlightsFullData[currentRow];
			string textData = (
				"Name: " + mainMenu.userData.firstname + " " + mainMenu.userData.lastname +
				"\nUser ID Number: " + mainMenu.userData.userName +
				"\nFlight Number: " + data.flightNumber +
				"\nSeat Number: " + data.seatNumber +
				"\nOrigin: " + data.departureCity +
				"\nDestination: " + data.arrivalCity +
				"\nDeparture Time: " + data.timeOfDep +
				"\nArrival Time: " + data.timeOfAriv);


			MessageBox.Show("This Is Your Boarding Pass\n\n" + textData
				, "",
				   MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}
		private void upcomingClicked(object sender, EventArgs e)
		{

			Label l = sender as Label;
			int row = upcomingFlightsTable.GetRow(l) - 1;
			if (previousLabel != null)
			{
				previousLabel.BackColor = Color.White;
			}
			l.BackColor = Color.LightBlue;
			currentRow = row;
			buttonPanel.Show();
			DateTime time = DateTime.Parse(upcomingFlightsFullData[currentRow].dateOfDep + " " + upcomingFlightsFullData[currentRow].timeOfDep);
			TimeSpan threshold = TimeSpan.FromDays(1);
			if (time.Subtract(DateTime.Now) > threshold)
			{
				printButton.Enabled = false;
			}
			else
			{
				printButton.Enabled = true;
			}



			panel2.Controls.Add(currentFlightDetails);
			currentFlightDetails.Dock = DockStyle.Fill;
			instructionSideLabel.Hide();
			flightInfopanel.Text =
				"Flight Summary:\n\n" +
				"Date Purchased: " + upcomingFlightsFullData[row].datePurchased +
				"\nRoute: " + upcomingFlightsFullData[row].departureCity + "->" + upcomingFlightsFullData[row].arrivalCity +
				"\nStatus: " + upcomingFlightsFullData[row].status +
				"\nFlight Number: " + upcomingFlightsFullData[row].flightNumber +
				"\nDate Of Departure: " + upcomingFlightsFullData[row].dateOfDep +
				"\nTime Of Departure: " + upcomingFlightsFullData[row].timeOfDep +
				"\nTime Of Arrival: " + upcomingFlightsFullData[row].timeOfAriv +
				"\nSeat Number: " + upcomingFlightsFullData[row].seatNumber +
				"\n";
			currentFlightDetails.Show();
			previousLabel = l;


		}

		private void previousClicked(object sender, EventArgs e)
		{
			buttonPanel.Hide();
			Label l = sender as Label;
			int row = previousFlightsTable.GetRow(l) - 1;
			if (previousLabel != null)
			{
				previousLabel.BackColor = Color.White;
			}
			l.BackColor = Color.LightBlue;
			panel2.Controls.Add(currentFlightDetails);
			currentFlightDetails.Dock = DockStyle.Fill;
			instructionSideLabel.Hide();
			flightInfopanel.Text =
			"Flight Summary:\n\n" +
			"Date Purchased: " + previousFlightsFullData[row].datePurchased +
			"\nRoute: " + previousFlightsFullData[row].departureCity + "->" + previousFlightsFullData[row].arrivalCity +
			"\nStatus: " + previousFlightsFullData[row].status +
			"\nFlight Number: " + previousFlightsFullData[row].flightNumber +
			"\nDate Of Departure: " + previousFlightsFullData[row].dateOfDep +
			"\nTime Of Departure: " + previousFlightsFullData[row].timeOfDep +
			"\nTime Of Arrival: " + previousFlightsFullData[row].timeOfAriv +
			"\nSeat Number: " + previousFlightsFullData[row].seatNumber +
			"\n";
			currentFlightDetails.Show();
			currentRow = row;
			previousLabel = l;
		}

		private void clearTable(TableLayoutPanel table)
		{
			if (table.RowCount > 1)
			{
				while (table.RowCount != 1)
				{
					int i = table.RowCount - 1;
					table.Controls.Remove(table.GetControlFromPosition(0, i));
					table.RowStyles.RemoveAt(i);
					table.RowCount--;

				}
			}

		}

		private void manageFlightsLoade(object sender, EventArgs e)
		{
			clearTable(upcomingFlightsTable);
			clearTable(previousFlightsTable);
			currentFlights = new List<string>();
			previousFlights = new List<string>();
			userTransactions = new List<string[]>();
			upcomingFlightsFullData = new List<flightInformation>();
			previousFlightsFullData = new List<flightInformation>();
			initializeFlightList();
			Button cancel = (Button)currentFlightDetails.Controls.Find("cancelFlight", true)[0];
			Button print = (Button)currentFlightDetails.Controls.Find("printBoardingPass", true)[0];

			print.Width = print.Parent.Width / 2;
			cancel.Width = cancel.Parent.Width / 2;
		}

		private void windowResized(object sender, EventArgs e)
		{
			Button cancel = (Button)currentFlightDetails.Controls.Find("cancelFlight", true)[0];
			Button print = (Button)currentFlightDetails.Controls.Find("printBoardingPass", true)[0];

			print.Width = print.Parent.Width / 2;
			cancel.Width = cancel.Parent.Width / 2;
		}

		private void tabChanged(object sender, EventArgs e)
		{
			instructionSideLabel.Show();
			currentFlightDetails.Hide();
		}

		private struct flightInformation
		{
			public string seatNumber;
			public string flightNumber;
			public string datePurchased;
			public string departureCity;
			public string arrivalCity;
			public string planeType;
			public string price;
			public string dateOfDep;
			public string timeOfDep;
			public string timeOfAriv;
			public string status; //Canceled, Purchased, Completed
		}
	}
}
