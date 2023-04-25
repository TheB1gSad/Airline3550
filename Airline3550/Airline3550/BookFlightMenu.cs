using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Airline3550
{
	public partial class BookFlightMenu : Form
	{
		static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
		private static string flightListPath = Path.Combine(executablePath, "flightList.csv");
		private List<string> departureList = new List<string>();
		private List<string> returnsList = new List<string>();
		private CheckBox departureSelected = null;
		private CheckBox returnSelected = null;
		private CustomerMenu mainMenu;
		private int dSeatNumber;
		private int aSeatNumber;
		public BookFlightMenu(CustomerMenu menu)
		{
			mainMenu = menu;
			InitializeComponent();
			tableLayoutPanel1.ColumnStyles[3].Width = 0;
			departureTable.Capture = true;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				tableLayoutPanel1.ColumnStyles[3].Width = 25;
				returnTableLabel.Visible = true;
				if (returnsList.Count > 0) { returnTable.Visible = true; }
				button1.Text = "Confirm Selections";
			}
			else
			{
				tableLayoutPanel1.ColumnStyles[3].Width = 0;
				returnTable.Visible = false;
				returnTableLabel.Visible = false;
				button1.Text = "Confirm Selection";
			}
		}
		private void table_CheckedChanged(object sender, EventArgs e)
		{

			CheckBox checkBox = sender as CheckBox;

			if (checkBox.Parent == departureTable)
			{

				if (checkBox.Checked)
				{
					if (departureSelected != null)
						departureSelected.Checked = false;
					departureSelected = checkBox;
				}
				else
				{
					departureSelected = null;
				}
			}
			else
			{
				if (checkBox.Checked)
				{
					if (returnSelected != null)
						returnSelected.Checked = false;
					returnSelected = checkBox;
				}
				else
				{
					returnSelected = null;
				}
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

				if (departureD <= DateOnly.FromDateTime(DateTime.Now))
				{
					errorMessage.Text = "Departure Time Cannot Be On Or Before Todays Date"; ;
					return;
				}

				//If there are any existing table entries delete them.
				clearTableEntries();


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
					if (arrivalD <= departureD)
					{
						errorMessage.Text = "Return Date Must Be After Departure Date";
						return;
					}

					StreamReader streamReaderA = new StreamReader(flightListPath);

					string lineA;
					returnsList = new List<string>();
					while ((lineA = streamReaderA.ReadLine()) != null)
					{

						string[] tempstring = lineA.Split(",");

						//Check if the return and departure match the flipped arrival and departure of the user
						if (tempstring[6] != departure.Text)
							continue;
						if (tempstring[5] != arrival.Text)
							continue;

						//Check that dates match
						if (DateOnly.Parse(tempstring[2]) != arrivalD)
							continue;

						//Check if seat is available
						FlightManager flightManager = new FlightManager();
						List<string> seats = flightManager.printManifest(int.Parse(tempstring[3]));
						bool emptySeat = false;
						for (int i = 0; i < seats.Count; i++)
						{
							if (seats.ToArray()[i] == "0")
							{
								emptySeat = true;
								aSeatNumber = i;
								break;
							}
						}
						if (!emptySeat)
						{
							continue;
						}

						tempstring[8] = "$" + tempstring[8];
						lineA = String.Join(",", tempstring);
						returnsList.Add(lineA);

					}
					if (returnsList.Count > 0)
					{
						returnTable.Visible = true;
					}
					else
					{
						returnTable.Visible = false;
					}
					//Make sure to close the stream or else we will get an error
					streamReaderA.Close();
					//Add Dollar sign to Price.


					for (int i = 0; i < returnsList.Count; i++)
					{
						this.addReturnEntry(returnsList[i]);
					}

				}

				StreamReader streamReader = new StreamReader(flightListPath);

				string line;
				departureList = new List<string>();
				while ((line = streamReader.ReadLine()) != null)
				{

					string[] tempstring = line.Split(",");

					//Check if the return and departure match the flipped arrival and departure of the user
					if (tempstring[6] != arrival.Text)
						continue;
					if (tempstring[5] != departure.Text)
						continue;

					//Check if dates match
					if (DateOnly.Parse(tempstring[2]) != departureD)
						continue;

					FlightManager flightManager = new FlightManager();
					List<string> seats = flightManager.printManifest(int.Parse(tempstring[3]));
					bool emptySeat = false;
					for (int i = 0; i < seats.Count; i++)
					{
						if (seats.ToArray()[i] == "0")
						{
							emptySeat = true;
							dSeatNumber = i;
							break;
						}
					}
					if (!emptySeat)
					{
						continue;
					}
					//check if the dates match
					tempstring[8] = "$" + tempstring[8];
					line = String.Join(",", tempstring);
					departureList.Add(line);

				}
				//Make sure to close the stream or else we will get an error
				streamReader.Close();


				if (departureList.Count > 0)
				{
					departureTable.Visible = true;
				}
				else
				{
					departureTable.Visible = false;
				}
				for (int i = 0; i < departureList.Count; i++)
				{
					addDepartureEntry(departureList[i]);
				}

				//No Errors so Clear Error message and suppress key noise
				errorMessage.Text = "";
				e.SuppressKeyPress = true;
			}
		}

		private void clearTableEntries()
		{

			if (departureTable.RowCount > 1)
			{

				while (departureTable.RowCount != 1)
				{
					int i = departureTable.RowCount - 1;



					for (int c = 0; c < departureTable.ColumnCount; c++)
					{
						departureTable.Controls.Remove(departureTable.GetControlFromPosition(c, i));
					}
					departureTable.RowStyles.RemoveAt(i);
					departureTable.RowCount--;
				}
			}
			if (returnTable.RowCount > 1)
			{
				while (returnTable.RowCount != 1)
				{
					int i = returnTable.RowCount - 1;



					for (int c = 0; c < returnTable.ColumnCount; c++)
					{
						returnTable.Controls.Remove(returnTable.GetControlFromPosition(c, i));
					}
					returnTable.RowStyles.RemoveAt(i);
					returnTable.RowCount--;

				}
			}
		}
		private void addReturnEntry(string flightString)
		{
			string[] args = flightString.Split(",");
			RowStyle tempor = returnTable.RowStyles[0];
			returnTable.RowCount = returnTable.RowCount + 1;

			CheckBox checkBox = new CheckBox();
			checkBox.CheckedChanged += table_CheckedChanged;
			returnTable.RowStyles.Add(new RowStyle(tempor.SizeType, tempor.Height));
			returnTable.Controls.Add(checkBox, 0, returnTable.RowCount - 1);
			returnTable.Controls.Add(new Label() { Text = args[5] + "->" + args[6] }, 1, returnTable.RowCount - 1);
			returnTable.Controls.Add(new Label() { Text = args[8] }, 2, returnTable.RowCount - 1);
			returnTable.Controls.Add(new Label() { Text = args[0] }, 3, returnTable.RowCount - 1);
			returnTable.Controls.Add(new Label() { Text = args[1] }, 4, returnTable.RowCount - 1);
			returnTable.Controls.Add(new Label() { Text = args[3] }, 5, returnTable.RowCount - 1);
		}

		private void addDepartureEntry(string flightString)
		{
			string[] args = flightString.Split(",");
			RowStyle tempor = departureTable.RowStyles[0];
			departureTable.RowCount = departureTable.RowCount + 1;

			CheckBox checkBox = new CheckBox();
			checkBox.CheckedChanged += table_CheckedChanged;
			departureTable.RowStyles.Add(new RowStyle(tempor.SizeType, tempor.Height));
			departureTable.Controls.Add(checkBox, 0, departureTable.RowCount - 1);
			departureTable.Controls.Add(new Label() { Text = args[5] + "->" + args[6] }, 1, departureTable.RowCount - 1);
			departureTable.Controls.Add(new Label() { Text = args[8] }, 2, departureTable.RowCount - 1);
			departureTable.Controls.Add(new Label() { Text = args[0] }, 3, departureTable.RowCount - 1);
			departureTable.Controls.Add(new Label() { Text = args[1] }, 4, departureTable.RowCount - 1);
			departureTable.Controls.Add(new Label() { Text = args[3] }, 5, departureTable.RowCount - 1);
		}

		private DialogResult displayCardPaymentConfirmation(int priceInDollars)
		{

			DialogResult result = MessageBox.Show("Confirm Card Transaction of $" + priceInDollars, "",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			return result;
		}

		private DialogResult displayPointsPaymentConfirmation(int priceInPoints, int userPoints)
		{
			DialogResult result = MessageBox.Show("Would You Like To Use " + priceInPoints + " Of Your " + userPoints + " Points?", "Payment Method",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2, 0);

			return result;
		}
		private void button1_Click(object sender, EventArgs e)
		{

			//Get initial info, if round trip we need to add the price for second flight later
			int userPoints = 150000;
			Control dPriceTextBox = departureTable.GetControlFromPosition(2, departureTable.GetPositionFromControl(departureSelected).Row);
			string priceText = dPriceTextBox.Text.Replace("$", "");
			int priceInDollars = int.Parse(priceText);
			int departurePrice = priceInDollars;
			int arrivalPrice = 0;
			int priceInPoints = priceInDollars * 100;





			if (departureSelected == null)
			{
				errorMessage.Text = "No Departure Flight Detected";
				SystemSounds.Beep.Play();
				return;
			}

			string flightIDs = departureTable.GetControlFromPosition(5, departureTable.GetPositionFromControl(departureSelected).Row).Text;
			if (checkBox1.Checked)
			{
				if (returnSelected == null)
				{
					errorMessage.Text = "No Return Flight Detected";
					SystemSounds.Beep.Play();
					return;
				}
				//We have 2 flights selected, recalculate pricees
				Control rPriceTextBox = returnTable.GetControlFromPosition(2, returnTable.GetPositionFromControl(returnSelected).Row);
				string rPriceText = rPriceTextBox.Text.Replace("$", "");
				arrivalPrice = int.Parse(rPriceText);
				priceInDollars += arrivalPrice;
				priceInPoints = priceInDollars * 100;
				string flightReturnID = returnTable.GetControlFromPosition(5, returnTable.GetPositionFromControl(returnSelected).Row).Text;
				//Make the transaction happen
				if (userPoints >= priceInPoints)
				{
					//Make the transaction happen
					DialogResult results = displayPointsPaymentConfirmation(priceInPoints, userPoints);
					if (results == DialogResult.Yes)
					{
						//Purchase complete, add to the database of user transactions with flight ID
						User.completeTransaction(mainMenu.userData.userName, dSeatNumber, true, departurePrice, flightIDs);
						User.completeTransaction(mainMenu.userData.userName, aSeatNumber, true, arrivalPrice, flightReturnID);
					}
					else if (results == DialogResult.No)
					{
						results = displayCardPaymentConfirmation(priceInDollars);
						if (results == DialogResult.OK)
						{
							//Transaction complete
							User.completeTransaction(mainMenu.userData.userName, dSeatNumber, false, departurePrice, flightIDs);
							User.completeTransaction(mainMenu.userData.userName, aSeatNumber, false, arrivalPrice, flightReturnID);
						}
					}
				}
				else
				{
					DialogResult results = displayCardPaymentConfirmation(priceInDollars);
					if (results == DialogResult.OK)
					{
						//Transaction Complete
						User.completeTransaction(mainMenu.userData.userName, dSeatNumber, false, departurePrice, flightIDs);
						User.completeTransaction(mainMenu.userData.userName, aSeatNumber, false, arrivalPrice, flightReturnID);
					}
				}

			}
			else
			{

				//Check If user has enough points, if they do, prompt them with the option to purchase with points

				if (userPoints >= priceInPoints)
				{
					//Make the transaction happen
					DialogResult results = displayPointsPaymentConfirmation(priceInPoints, userPoints);
					if (results == DialogResult.Yes)
					{

						//Purchase complete, add to the database of user transactions with flight ID
						User.completeTransaction(mainMenu.userData.userName, dSeatNumber, true, priceInDollars, flightIDs);

					}
					else if (results == DialogResult.No)
					{
						results = displayCardPaymentConfirmation(priceInDollars);
						if (results == DialogResult.OK)
						{
							//Transaction complete
							User.completeTransaction(mainMenu.userData.userName, dSeatNumber, false, priceInDollars, flightIDs);
						}
					}
				}
				else
				{
					DialogResult results = displayCardPaymentConfirmation(priceInDollars);
					if (results == DialogResult.OK)
					{
						//Transaction Complete
						User.completeTransaction(mainMenu.userData.userName, dSeatNumber, false, priceInDollars, flightIDs);
					}
				}
			}

			//Clear all fields
			clearTableEntries();
			departure.Text = "";
			departureDate.Text = "";
			arrival.Text = "";
			arrivalDate.Text = "";
			errorMessage.Text = "";
		}
	}
}
