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
	public partial class PrintFinancialData : Form
	{
		public PrintFinancialData()
		{
			InitializeComponent();

		}



		private void button1_Click(object sender, EventArgs e)
		{

			//Clear Table
			clearTableEntries();
			//Begin Printing Financial data
			AccountingManager accountingManager = new AccountingManager();
			string[,] data = accountingManager.getFlightData();

			flightID.Hide();
			percentageFullTable.Hide();
			totalRevenueTable.Hide();
			string flightIDs = "";
			string percentageFullText = "";
			string currentRevenueText = "";
			for (int i = 2; i < data.GetLength(0) / 2; i++)
			{
				int currentRevenue = int.Parse(data[i, 2].Split("/")[0]) * int.Parse(data[i, 1]);
				flightIDs += data[i, 0] + "\n";
				if (data[i, 3].Length > 6)
					data[i, 3] = data[i, 3].Substring(0, 5) + "%";

				percentageFullText += data[i, 3] + "\n";

				currentRevenueText += "$" + currentRevenue.ToString() + "\n";

			}
			flightID.Text += flightIDs;
			totalRevenue.Text = "Total Revenue: $" + data[data.GetLength(0) - 1, 4];
			percentageFullTable.Text += percentageFullText;
			totalRevenueTable.Text += currentRevenueText;
			flightID.Show();
			percentageFullTable.Show();
			totalRevenueTable.Show();


		}

		private void clearTableEntries()
		{

			flightID.Text = "Flight ID\n";
			percentageFullTable.Text = "Percentage Full\n";
			totalRevenueTable.Text = "Total Revenue\n";

		}
	}
}

