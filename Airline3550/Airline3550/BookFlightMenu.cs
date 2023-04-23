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
	public partial class BookFlightMenu : Form
	{
		public BookFlightMenu()
		{
			InitializeComponent();
			tableLayoutPanel1.ColumnStyles[3].Width = 0;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				tableLayoutPanel1.ColumnStyles[3].Width = 25;
				tableLayoutPanel4.Visible = true;
				returnTableLabel.Visible = true;
				button1.Text = "Confirm Selections";
			}
			else
			{
				tableLayoutPanel1.ColumnStyles[3].Width = 0;
				tableLayoutPanel4.Visible = false;
				returnTableLabel.Visible = false;
				button1.Text = "Confirm Selection";
			}
		}

		private void keyDown(object sender, KeyEventArgs e)
		{
			//Check if the key was enter
			if (e.KeyCode == Keys.Enter)
			{
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

				DateOnly departureD = new DateOnly(dYear, dMonth, dDay);

				//Round Trip
				if (checkBox1.Checked)
				{


					if (arrivalDate.Text.Length == 0)
					{
						errorMessage.Text = "Arrival Date Cannot Be Blank";
						return;
					}

					//Check if dates is in proper format and if they are valid
					string[] temp = arrivalDate.Text.Split('/');
					if (temp.Length != 3)
					{
						errorMessage.Text = "Invalid Return Date";
						return;
					}


					int aYear;
					int aMonth;
					int aDay;
					if (!int.TryParse(temp[2], out aYear))
					{
						errorMessage.Text = "Invalid Return Date";
						return;
					}
					if (!int.TryParse(temp[0], out aMonth))
					{
						errorMessage.Text = "Invalid Return Date";
						return;
					}
					if (!int.TryParse(temp[1], out aDay))
					{
						errorMessage.Text = "Invalid Return Date";
						return;
					}

					DateOnly arrivalD = new DateOnly(aYear, aMonth, aDay);

					//Check if return date is after departure
					if (arrivalD < departureD)
					{
						errorMessage.Text = "Return Date Must Be On Or After Departure Date";
						return;
					}


					//Search For Airport Codes for return date

					//Display results
				}

				//Search for airport codes for departure date

				//Display results

				//No Errors so Clear Error message and suppress key noise
				errorMessage.Text = "";
				e.SuppressKeyPress = true;
			}
		}
	}
}
