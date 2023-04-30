using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Airline3550
{
	public partial class PlanRoute : Form
	{
		public PlanRoute()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoadEngineer loadEngineer = new LoadEngineer();
			//Check if required boxes are empty
			if (departure.Text.Length == 0)
			{
				errorMessage.Text = "Departure Airport Cannot Be Blank";
				return;
			}

			if (departure.Text.Length != 3)
			{
				errorMessage.Text = "Invalid Departure Airport ID";
				return;
			}

			if (arrival.Text.Length == 0)
			{
				errorMessage.Text = "Arrival Airport Cannot Be Blank";
				return;
			}
			if (arrival.Text.Length != 3)
			{
				errorMessage.Text = "Invalid Arrival Airport ID";
				return;
			}

			if (departureDate.Text.Length == 0)
			{
				errorMessage.Text = "Departure Date Cannot Be Blank";
				return;
			}

			//Check if dates is in proper format and if they are valid
			string[] dateArr = departureDate.Text.Split('/');
			if (dateArr.Length != 3)
			{
				errorMessage.Text = "Invalid Departure Date";
				return;
			}
			if (departureTime.Text.Length > 5)
			{
				errorMessage.Text = "Invalid Departure Time";
				return;
			}
			departureTime.Text = departureTime.Text.Trim();
			int dYear;
			int dMonth;
			int dDay;

			if (!int.TryParse(dateArr[2], out dYear))
			{
				errorMessage.Text = "Invalid Departure Date";
				return;
			}
			if (!int.TryParse(dateArr[0], out dMonth))
			{
				errorMessage.Text = "Invalid Departure Date";
				return;
			}
			if (!int.TryParse(dateArr[1], out dDay))
			{
				errorMessage.Text = "Invalid Departure Date";
				return;
			}

			DateOnly departureD;
			if (!DateOnly.TryParse(departureDate.Text, out departureD))
			{
				errorMessage.Text = "Invalid Departure Date";
				return;
			}

			if (departureD <= DateOnly.FromDateTime(DateTime.Now))
			{
				errorMessage.Text = "Departure Time Cannot Be On Or Before Todays Date"; ;
				return;
			}
			TimeOnly departureT;

			if (departureTime.Text.Length == 0)
			{
				errorMessage.Text = "Departure Time Cannot Be Empty";
			}
			if (!TimeOnly.TryParse(departureTime.Text, out departureT))
			{
				errorMessage.Text = "Invalid Departure Time";
				return;
			}

			if (departureTime.Text.Length == 0)
			{
				errorMessage.Text = "Departure Time Cannot Be Empty";
			}
			//We need to get a flight ID that is available
			string filePath = Path.GetDirectoryName(Application.ExecutablePath);
			string filecsv = Path.Combine(filePath, "flightList.csv");
			string lastLine = null;
			using (var streamReader = new StreamReader(filecsv))
			{
				string line = null;


				while ((line = streamReader.ReadLine()) != null)
				{
					lastLine = line;
				}

			}

			int flightID = int.Parse(lastLine.Split(",")[3]) + 1;
			if (!loadEngineer.setFlightRoute(departureTime.Text, flightID, departure.Text, arrival.Text, departureDate.Text))
			{
				errorMessage.Text = "Invalid Route Selected";
				return;
			}
			departure.Text = "";
			departureDate.Text = "";
			arrival.Text = "";
			departureTime.Text = "";
			errorMessage.Text = "";
		}
	}
}
