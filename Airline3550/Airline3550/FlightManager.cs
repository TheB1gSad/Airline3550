using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;

namespace Airline3550
{
    internal class FlightManager
    {
        public List<string> printManifest(int flightID)
        {
            List<string> seatList = new List<string>();
            string filePathSeats = Path.GetDirectoryName(Application.ExecutablePath);
            string fileCsvSeats = Path.Combine(filePathSeats, "..", "..", "..", "csv", "flightSeats.csv");
            using (var streamSeatsReader = File.OpenText(fileCsvSeats))
            {
                string line;
                while ((line = streamSeatsReader.ReadLine()) != null)
                {
                    if (Convert.ToInt32(line.Split(',')[0]) == flightID)
                    {
                        string[] seats = line.Split(',');
                        seatList = seats.ToList();
                        break;
                    }

                } 
            }
                return seatList;
        }
    }
}
