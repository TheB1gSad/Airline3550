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
			Flight flight = new Flight();
			var config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				// Don't write the header again.
				HasHeaderRecord = false,
			};
			using (var stream = File.Open("C:\\Users\\Ready Player 1\\Source\\Repos\\Airline3550\\Airline3550\\Airline3550\\csv\\flightSeats.csv", FileMode.Append))
			using (var writer = new StreamWriter(stream))
			using (var csv = new CsvWriter(writer, config))
			{
				foreach (Seat seat in flight.seats)
				{
					csv.WriteField(seat.userID);
				}
				csv.NextRecord();
			}
		}
	}
}
