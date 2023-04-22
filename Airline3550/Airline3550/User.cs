using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Sockets;


// Test
public static class User

{
	static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
	private static string dataPath = Path.Combine(executablePath, "credentials.csv");

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
	};

	public static userData validateCredentials(string username, string password)
	{
		password = hashPassword(password);
		userData thisUser;
		thisUser.userName = username;
		thisUser.credentials = "";

		thisUser.firstname = "";
		thisUser.lastname="";
		thisUser.address="";
		thisUser.age="";
		thisUser.phoneNumber="";
		thisUser.cardNumber="";


		var data = File.ReadAllLines(dataPath);
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
							cardNumber = columns[8]
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
		var data = File.ReadAllLines(dataPath);

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
		File.AppendAllText(dataPath, Environment.NewLine + username + "," + password + "," + "customer" + "," +firstname + "," + lastname + "," + age + "," + address + "," + phoneNumber + "," + cardNumber);
		return username;
	}


}
