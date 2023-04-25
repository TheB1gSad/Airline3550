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
		private CurrentFlightDetails currentFlightDetails = new CurrentFlightDetails();
		private CustomerMenu mainMenu;
		public ManageFlights_Customer(CustomerMenu menu)
		{
			mainMenu = menu;
			InitializeComponent();
			initializeFlightList();

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
					}
					//Flight Is Upcoming
					else
					{
						currentFlights.Add(String.Join(',', currentLine));
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
			previousFlightsTable.RowStyles.Add(new RowStyle(tempor.SizeType, tempor.Height));
			for (int i = 0; i < flights.Count; i++)
			{
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

			upcomingFlightsTable.RowStyles.Add(new RowStyle(tempor.SizeType, tempor.Height));
			for (int i = 0; i < flights.Count; i++)
			{
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

		private void upcomingClicked(object sender, EventArgs e)
		{
			Label l = sender as Label;
			int row = upcomingFlightsTable.GetRow(l);
			panel2.Controls.Add(currentFlightDetails);
			currentFlightDetails.Dock = DockStyle.Fill;
			currentFlightDetails.Show();


		}

		private void previousClicked(object sender, EventArgs e)
		{
			Label l = sender as Label;
			int row = previousFlightsTable.GetRow(l);
		}
	}
}
