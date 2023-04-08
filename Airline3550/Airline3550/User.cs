using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;
using System.Drawing.Text;
using System.Collections.Concurrent;
using System.Reflection;

// Test
public static class User

{
	static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
	private static string dataPath = Path.Combine(executablePath, "credentials.csv");

	public struct userData
	{
		public string userName;
		public string credentials;
	};

	public static userData validateCredentials(string username, string password)
	{
		password = hashPassword(password);
		userData thisUser;
		thisUser.userName = username;
		thisUser.credentials = "";
		
	
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
		if (user !=null && user.password ==password)
		{
			thisUser.credentials = user.clearanceLevel;
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
}
