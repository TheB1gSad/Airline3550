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
    internal class LoadEngineer
    {
        /*
         * departureTime in format "hour:00"
         * departure is the 3 letter code of the airport the flight is departing from
         * arrival is the 3 letter code of the airport the flight is arriving at
         */
        public void setFlightRoute(string departureTime, int flightID, string departure, string arrival)
        {

            string[,] airportInfo = new string[10, 2]
            {
                { "Nashville International Airport", "BNA" },                   // 0
                { "Hartsfield–Jackson Atlanta International Airport", "ATL" },  // 1
                { "Dallas/Fort Worth International Airport", "DFW" },           // 2
                { "Denver International Airport", "DEN" },                      // 3
                { "O'Hare International Airport", "ORD" },                      // 4
                { "Los Angeles International Airport", "LAX" },                 // 5
                { "Cleveland Hopkins International Airport", "CLE" },           // 6
                { "Orlando International Airport", "MCO" },                     // 7
                { "Harry Reid International Airport", "LAS" },                  // 8
                { "Phoenix Sky Harbor International Airport", "PHX" },          // 9
            };
            // Airport distance in miles. The indicies in this 2D array corresponds to the airport with the same index in airportInfo. For example, the value at airportDistances[4][6] is the distance between DEN and LAX
            // The distances were found using the haversine formula
            int[,] airportDistances = new int[10, 10]
            {
                {    0,  214,  630, 1011,  410, 1794,  458,  617, 1584, 1445 },
                {  214,    0,  730, 1197,  607, 1942,  563,  405, 1743, 1584 },
                {  630,  730,    0,  640,  801, 1232, 1030,  983, 1053,  865 },
                { 1011, 1197,  640,    0,  886,  860, 1206, 1545,  626,  601 },
                {  410,  606,  801,  886,    0, 1741,  322, 1007, 1510, 1437 },
                { 1794, 1942, 1232,  860, 1741,    0, 2056, 2213,  236,  369 },
                {  458,  563, 1030, 1206,  322, 2056,    0,  903, 1828, 1742 },
                {  617,  404,  983, 1545, 1007, 2213,  903,    0, 2035, 1845 },
                { 1584, 1742, 1053,  626, 1510,  236, 1828, 2035,    0,  255 },
                { 1445, 1583,  865,  601, 1437,  369, 1742, 1845,  255,    0 }
            };
            int indexDistanceDeparture = 0;
            int indexDistanceArrival = 0;
            switch (departure)
            {
                case "BNA": 
                    indexDistanceDeparture = 0;
                    break;
                case "ATL":
                    indexDistanceDeparture = 1;
                    break;
                case "DFW":
                    indexDistanceDeparture = 2;
                    break;
                case "DEN":
                    indexDistanceDeparture = 3;
                    break;
                case "ORD":
                    indexDistanceDeparture = 4;
                    break;
                case "LAX":
                    indexDistanceDeparture = 5;
                    break;
                case "CLE":
                    indexDistanceDeparture = 6;
                    break;
                case "MCO":
                    indexDistanceDeparture = 7;
                    break;
                case "LAS":
                    indexDistanceDeparture = 8;
                    break;
                case "PHX":
                    indexDistanceDeparture = 9;
                    break;

            }
            switch (arrival)
            {
                case "BNA":
                    indexDistanceArrival = 0;
                    break;
                case "ATL":
                    indexDistanceArrival = 1;
                    break;
                case "DFW":
                    indexDistanceArrival = 2;
                    break;
                case "DEN":
                    indexDistanceArrival = 3;
                    break;
                case "ORD":
                    indexDistanceArrival = 4;
                    break;
                case "LAX":
                    indexDistanceArrival = 5;
                    break;
                case "CLE":
                    indexDistanceArrival = 6;
                    break;
                case "MCO":
                    indexDistanceArrival = 7;
                    break;
                case "LAS":
                    indexDistanceArrival = 8;
                    break;
                case "PHX":
                    indexDistanceArrival = 9;
                    break;

            }

            int distance = airportDistances[indexDistanceDeparture, indexDistanceArrival];

            string[] time = departureTime.Split(':');
            int departureHour = Convert.ToInt32(time[0]);
            int arrivalTime = departureHour + Convert.ToInt32(distance / 500.0 + 0.5);
            if (arrivalTime >= 24)
                arrivalTime -= 24;

            int price = 58 + (int)(0.12 * distance);
            if ((departureHour >= 0 && departureHour <= 5) || (arrivalTime >= 0 && arrivalTime <= 5))
                price = Convert.ToInt32(price * 0.8);
            else if (departureHour < 8 || arrivalTime > 19)
                price = Convert.ToInt32(price * 0.9);

            int planeType = 737;
            if (distance < 600) planeType = 737;
            else if (distance < 1100) planeType = 757;
            else planeType = 777;
            var records = new List<Flight>
            {
                new Flight { departureTime = departureTime, arrivalTime = arrivalTime.ToString() + ":00", flightID = flightID, flightDistance = distance, departure = departure, arrival = arrival, planeType = planeType, price = price}
            };

            string filePath = Path.GetDirectoryName(Application.ExecutablePath);
            string filecsv = Path.Combine(filePath, "..", "..", "..", "csv", "flightList.csv");
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open(filecsv, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
