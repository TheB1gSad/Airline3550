using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Airline3550
{
    internal class AccountingManager
    {
        public List<string[]> getTotals()
        {
            // Set the path of the CSV files
            string flightListFilePath = @"csv\flightList.csv";
            string flightSeatsFilePath = @"csv\flightSeats.csv";

            // Read the flightList.csv file and store the flight prices in a dictionary
            Dictionary<string, int> flightPrices = new Dictionary<string, int>();

            using (var reader = new StreamReader(flightListFilePath))
            {
                // Skip the header row
                reader.ReadLine();

                // Loop through each line of the file
                while (!reader.EndOfStream)
                {
                    // Split the line into its comma-separated values
                    string[] values = reader.ReadLine().Split(',');

                    // Get the flightID and price values
                    string flightID = values[3];
                    int price = int.Parse(values[8]);

                    // Add the flight price to the dictionary
                    flightPrices.Add(flightID, price);
                }
            }

            // Read the flightSeats.csv file and calculate the total amount of money made from each flightID
            // and the percentage of how full each flight was
            List<string[]> results = new List<string[]>();

            using (var reader = new StreamReader(flightSeatsFilePath))
            {
                // Skip the header row
                //reader.ReadLine();

                // Loop through each line of the file
                while (!reader.EndOfStream)
                {
                    // Split the line into its comma-separated values
                    string[] values = reader.ReadLine().Split(',');

                    // Get the flightID and the number of taken seats
                    string flightID = values[0];
                    int numTakenSeats = 0;

                    for (int i = 1; i < values.Length; i++)
                    {
                        if (int.Parse(values[i]) != 0)
                        {
                            numTakenSeats++;
                        }
                    }

                    // Calculate the total amount of money made from the flight
                    int totalAmount = flightPrices[flightID] * numTakenSeats;

                    // Calculate the percentage of how full the flight was
                    double percentageFull = ((double)numTakenSeats / (double)(values.Length - 1)) * 100.0;

                    // Add the flightID, total amount, and percentage full to the results list
                    string[] result = new string[3];
                    result[0] = flightID;
                    result[1] = totalAmount.ToString();
                    result[2] = percentageFull.ToString("0.00") + "%";
                    results.Add(result);
                }
                return results;
            }
        }
    }

}