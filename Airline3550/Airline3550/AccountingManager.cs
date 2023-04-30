using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Airline3550
{
    internal class AccountingManager
    {
        public string[,] getFlightData()
        {
            // Path to the flightList.csv file
            string flightListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "csv", "flightList.csv");

            // Read all lines from the flightList.csv file
            string[] flightListLines = File.ReadAllLines(flightListPath);

            // Create an array to store flight ID, price, seat information, percentage of seats filled, and cumulative revenue
            string[,] flightData = new string[flightListLines.Length, 6];

            // Loop through each line of the flightList.csv file
            for (int i = 0; i < flightListLines.Length; i++)
            {
                // Split the line by comma
                string[] fields = flightListLines[i].Split(',');

                // Extract flight ID and price from the fields array
                string flightID = fields[3];
                string price = fields[8];

                // Add flight ID and price to the flightData array
                flightData[i, 0] = flightID;
                flightData[i, 1] = price;
            }

            // Path to the flightSeats.csv file
            string flightSeatsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "csv", "flightSeats.csv");

            // Read all lines from the flightSeats.csv file
            string[] flightSeatsLines = File.ReadAllLines(flightSeatsPath);

            // Create a dictionary to store the number of taken seats and total seats for each flight
            var seatData = new Dictionary<string, (int takenSeats, int totalSeats)>();

            // Loop through each line of the flightSeats.csv file
            foreach (string line in flightSeatsLines)
            {
                // Split the line by comma
                string[] fields = line.Split(',');

                // Extract the flight ID and seat data from the fields array
                string flightID = fields[0];
                int[] seats = fields.Skip(1).Select(int.Parse).ToArray();

                // Count the number of taken seats and total seats
                int takenSeats = seats.Count(s => s != 0);
                int totalSeats = seats.Length;

                // Add the seat data to the seatData dictionary
                seatData[flightID] = (takenSeats, totalSeats);
            }

            double cumulativeRevenue = 0;

            // Add the seat data, calculate the percentage of seats filled, and cumulative revenue for each flight
            for (int i = 0; i < flightData.GetLength(0); i++)
            {
                string flightID = flightData[i, 0];
                (int takenSeats, int totalSeats) = seatData.GetValueOrDefault(flightID, (0, 0));

                flightData[i, 2] = $"{takenSeats}/{totalSeats}";

                double price = 0;
                double.TryParse(flightData[i, 1], out price);

                // Calculate the percentage of seats filled
                double percentageFilled = totalSeats > 0 ? (double)takenSeats / totalSeats * 100 : 0;
                flightData[i, 3] = $"{percentageFilled}%";

                // Calculate the cumulative revenue
                cumulativeRevenue += price * takenSeats;
                flightData[i, 4] = cumulativeRevenue.ToString();
            }
            return flightData;
        }
    }

}