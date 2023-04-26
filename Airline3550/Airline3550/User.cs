using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Airline3550;


// Test
public static class User

{
	static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
	private static string userInformationPath = Path.Combine(executablePath, "credentials.csv");
	private static string userTransactionsPath = Path.Combine(executablePath, "userTransactions.csv");

	public struct userData
	{
		public string userName;
		public string credentials;
		public string firstname;
		public string lastname;
		public string address;
		public string age;
		public string phoneNumber;
		public string cardNumber;
		public string pointsTotal;
	};

	public static userData validateCredentials(string username, string password)
	{
		password = hashPassword(password);
		userData thisUser = new userData();
		thisUser.userName = username;
		thisUser.credentials = "";
		thisUser.firstname = "";
		thisUser.lastname = "";
		thisUser.address = "";
		thisUser.age = "";
		thisUser.phoneNumber = "";
		thisUser.cardNumber = "";


		var data = File.ReadAllLines(userInformationPath);
		var usersData = from line in data.Skip(0)
						let columns = line.Split(',')
						select new
						{
							username = columns[0],
							password = columns[1],
							clearanceLevel = columns[2],
							firsname = columns[3],
							lastname = columns[4],
							age = columns[5],
							address = columns[6],
							phoneNumber = columns[7],
							cardNumber = columns[8],
							pointsTotal = columns[9]

						};

		//this line made my head hurt
		var user = usersData.FirstOrDefault(u => u.username == username);

		if (user != null && user.password == password)
		{
			thisUser.credentials = user.clearanceLevel;
			thisUser.firstname = user.firsname;
			thisUser.lastname = user.lastname;
			thisUser.address = user.address;
			thisUser.age = user.age;
			thisUser.phoneNumber = user.phoneNumber;
			thisUser.cardNumber = user.cardNumber;
			thisUser.pointsTotal = user.pointsTotal;
		}

		return thisUser;
	}

	private static string hashPassword(string password)
	{
		using (SHA256 sha256 = SHA256.Create())
		{
			byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
			return BitConverter.ToString(hashedPassword).Replace("-", "").ToLower();
		}

	}
	public static string createCustomerAccount(string firstname, string lastname, string password, string address, string age, string phoneNumber, string cardNumber)
	{

		Random rand = new Random();
		string username = "";
		var data = File.ReadAllLines(userInformationPath);

		var usersData = from line in data.Skip(0)
						let columns = line.Split(',')
						select new
						{
							username = columns[0],
							password = columns[1],
							clearanceLevel = columns[2]


						};
		var user = usersData.FirstOrDefault(u => u.username == username);
		do
		{
			username = rand.Next(100000, 999999).ToString();
			//this line made my head hurt
			user = usersData.FirstOrDefault(u => u.username == username);

		} while (user != null);
		password = hashPassword(password);
		File.AppendAllText(userInformationPath, Environment.NewLine + username + "," + password + "," + "customer" + "," + firstname + "," + lastname + "," + age + "," + address + "," + phoneNumber + "," + cardNumber +",0");
		return username;
	}



	public static void updatePassword(string username, string password)
	{

		/*
		 * We must Read in the data line by line until we find the line with their user
		 * name, once we do we append it to a temporary file and then overwrite the original
		 * with the new file. This code doesn't look bad but is annoying.
		 */


		string temporaryFilePath = Path.GetTempFileName();
		StreamReader streamReader = new StreamReader(userInformationPath);
		StreamWriter streamWriter = new StreamWriter(temporaryFilePath);

		string line;
		bool firstRun = true;
		while ((line = streamReader.ReadLine()) != null)
		{
			if (line.Contains(username))
			{
				string[] tempstring = line.Split(",");

				//double check we are at the right user
				if (tempstring[0] == username)
				{

					tempstring[1] = hashPassword(password);
					line = String.Join(",", tempstring);
				}

			}
			if (firstRun)
			{
				streamWriter.Write(line);
				firstRun = false;
			}
			else
			{
				streamWriter.WriteLine();
				streamWriter.Write(line);
			}
		}

		//Make sure to close the stream or else we will get an error
		streamReader.Close();
		streamWriter.Close();

		//Delete the original and replace with the new file
		File.Delete(userInformationPath);
		File.Move(temporaryFilePath, userInformationPath);

	}

	/*
	 * Very similar to updatePassword except we are replacing the whole line at once.
	 */
	public static void updateInfo(userData data)
	{
		/*
		 * We must Read in the data line by line until we find the line with their user
		 * name, once we do we append it to a temporary file and then overwrite the original
		 * with the new file. This code doesn't look bad but is annoying.
		 */

		string username = data.userName;
		string temporaryFilePath = Path.GetTempFileName();
		StreamReader streamReader = new StreamReader(userInformationPath);
		StreamWriter streamWriter = new StreamWriter(temporaryFilePath);

		string line;
		bool firstRun = true;
		while ((line = streamReader.ReadLine()) != null)
		{
			if (line.Contains(username))
			{
				string[] tempstring = line.Split(",");

				//double check we are at the right user
				if (tempstring[0] == username)

				{
					//Update all the data with the new data we got from the user

					//We Start at 3 since 0-2 we don't need to change
					tempstring[3] = data.firstname;
					tempstring[4] = data.lastname;
					tempstring[5] = data.age;
					tempstring[6] = data.address;
					tempstring[7] = data.phoneNumber;
					tempstring[8] = data.cardNumber;

					line = String.Join(",", tempstring);
				}

			}
			if (firstRun)
			{
				streamWriter.Write(line);
				firstRun = false;
			}
			else
			{
				streamWriter.WriteLine();
				streamWriter.Write(line);
			}
		}

		//Make sure to close the stream or else we will get an error
		streamReader.Close();
		streamWriter.Close();

		//Delete the original and replace with the new file
		File.Delete(userInformationPath);
		File.Move(temporaryFilePath, userInformationPath);
	}

	public static void completeTransaction(string userID,int seatNumber, bool pointsUsed, int priceInDollars,string flightID)
	{
		//Add transaction to csv in the format userID,pointsUser(y/n),priceInDollars,flightID(s),canceled(y/n);
		
		//If there are multiple flightIDs they will be seperated by a -
		
		var file = File.ReadAllLines(userTransactionsPath);

		//Create array for transaction data
		string points;
		if(pointsUsed)
		{
			points = "y";
			decrementPoints(priceInDollars*100, userID);
		}
		else
		{
			incrementPoints(priceInDollars * 100, userID);
			points = "n";
		}

		//Book The Seat in the seat list csv
		FlightManager flightManager = new FlightManager();
		flightManager.bookSeat(seatNumber, int.Parse(flightID), userID);


		string today = DateTime.Now.ToString("M/dd/yyyy");
		string[] args =
		{
			userID,today,points,priceInDollars.ToString(),flightID,"n",seatNumber.ToString()
		};
		string output = String.Join(",", args);
		File.AppendAllText(userTransactionsPath,Environment.NewLine+ output);

		


	}

	private static void decrementPoints(int decAmount, string userID)
	{

	}
	private static void incrementPoints(int incAmount, string userID)
	{

	}
	/*
	 Probably Should Have written this method earlier but oh well
	 */
	public static userData getUserInfo(string userID)
	{
		userData userData= new userData(); ;

		//Find user id in table
		StreamReader streamReader = new StreamReader(userInformationPath);

		string line;
		while ((line = streamReader.ReadLine()) != null)
		{
			if (line.Contains(userID))
			{
				string[] user = line.Split(',');
				if (user[0] != userID)
					continue;
				userData.userName = userID;
				userData.firstname = user[3];
				userData.lastname = user[4];
				userData.age= user[5];	
				userData.address= user[6];
				userData.phoneNumber = user[7];
				userData.cardNumber = user[8];
				userData.pointsTotal = user[9];
				break;

			}
			
		}
		return userData;
	}
	public static void cancelBooking(string userID, string flightID)
	{
		//Find line with flightID and userID, replace cancled with y

	}
}
