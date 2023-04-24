using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;
using CsvHelper;


public class Airport
{
    public string name { get; set; }
    public string code { get; set; }
    public List<Flight> flights { get; set; }
    [Ignore]
    static int currentFlightID = 0;
}
public class AirportGraph
{
    public static int flightT = 8; // Flight time (hour)
    public static int currentFlightID = 0;
    public static List<Airport> createAirportGraph()
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
        int[][] index = {
            new int[] { 5, 1, 2, 4, 6, 7},
            new int[] { 6, 0, 2, 3, 4, 5, 7 },
            new int[] { 6, 0, 1, 3, 5, 8, 9},
            new int[] { 5, 1, 2, 4, 8, 9},
            new int[] { 4, 0, 1, 3, 6},
            new int[] { 4, 1, 2, 8, 9},
            new int[] { 3, 0, 4, 7},
            new int[] { 3, 0, 1, 6},
            new int[] { 4, 2, 3, 5, 9},
            new int[] { 5, 2, 3, 4, 5, 8},
        };
        List<Airport> airports = new List<Airport>();
        for (int i = 0; i < 10; i++)
        {
            List<Flight> flights = new List<Flight>();
            for (int j = 1; j < index[i][0] + 1; j++)
            {
                DateTime start = DateTime.Now;
                DateTime end = start.AddDays(182);
                DateOnly startDate = DateOnly.FromDateTime(start);
                DateOnly endDate = DateOnly.FromDateTime(end);
                while (startDate <= endDate)
                {
                    int distance = airportDistances[i, index[i][j]];
                    int arrivalT = flightT + Convert.ToInt32(distance / 500.0 + 0.5);
                    int price = 58 + (int)(0.12 * distance);
                    if (arrivalT == flightT) arrivalT++;

                    if (distance < 600)
                    {
                        List<Seat> seats = new List<Seat>();
                        for (int seatID = 0; seatID < 189; seatID++)
                        {
                            seats.Add(new Seat() { seatID = seatID, available = true });
                        }
                        if ((flightT >= 0 && flightT <= 5) || (arrivalT >= 0 && arrivalT <= 5))
                            price = Convert.ToInt32(price * 0.8);
                        else if (flightT < 8 || arrivalT > 19)
                            price = Convert.ToInt32(price * 0.9);
                        flights.Add(new Flight() { departureTime = flightT.ToString() + ":00", arrivalTime = arrivalT.ToString() + ":00", departureDate = startDate.ToString(), flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 737, seats = seats, price = price });
                        currentFlightID++;

                        List<Seat> seats2 = new List<Seat>();
                        for (int seatID = 0; seatID < 189; seatID++)
                        {
                            seats2.Add(new Seat() { seatID = seatID, available = true });
                        }
                        arrivalT += 8;
                        if (arrivalT >= 24) arrivalT -= 24;
                        if ((flightT + 8 >= 0 && flightT + 8 <= 5) || (arrivalT >= 0 && arrivalT <= 5))
                            price = Convert.ToInt32(price * 0.8);
                        else if (flightT + 8 < 8 || arrivalT > 19)
                            price = Convert.ToInt32(price * 0.9);
                        flights.Add(new Flight() { departureTime = (flightT + 8).ToString() + ":00", arrivalTime = arrivalT.ToString() + ":00", departureDate = startDate.ToString(), flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 737, seats = seats2, price = price });
                        currentFlightID++;
                        //flightT++;
                        //if (flightT == 16)
                        //    flightT = 0;

                    }
                    else if (distance < 1100)
                    {
                        List<Seat> seats = new List<Seat>();
                        for (int seatID = 0; seatID < 200; seatID++)
                        {
                            seats.Add(new Seat() { seatID = seatID, available = true });
                        }
                        if ((flightT >= 0 && flightT <= 5) || (arrivalT >= 0 && arrivalT <= 5))
                            price = Convert.ToInt32(price * 0.8);
                        else if (flightT < 8 || arrivalT > 19)
                            price = Convert.ToInt32(price * 0.9);
                        flights.Add(new Flight() { departureTime = flightT.ToString() + ":00", arrivalTime = arrivalT.ToString() + ":00", departureDate = startDate.ToString(), flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 757, seats = seats, price = price });
                        currentFlightID++;

                        List<Seat> seats2 = new List<Seat>();
                        for (int seatID = 0; seatID < 200; seatID++)
                        {
                            seats2.Add(new Seat() { seatID = seatID, available = true });
                        }
                        //flights.Add(new Flight((flightT + 8).ToString() + ":00", currentFlightID, distance, airportInfo[i, 1], airportInfo[j, 1], 757, seats2, 58 + (int)(0.12 * distance)));
                        arrivalT += 8;
                        if (arrivalT >= 24) arrivalT -= 24;
                        if ((flightT + 8 >= 0 && flightT + 8 <= 5) || (arrivalT >= 0 && arrivalT <= 5))
                            price = Convert.ToInt32(price * 0.8);
                        else if (flightT + 8 < 8 || arrivalT > 19)
                            price = Convert.ToInt32(price * 0.9);
                        flights.Add(new Flight() { departureTime = (flightT + 8).ToString() + ":00", arrivalTime = arrivalT.ToString() + ":00", departureDate = startDate.ToString(), flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 757, seats = seats2, price = price });

                        currentFlightID++;
                        //flightT++;
                        //if (flightT == 16)
                        //    flightT = 0;
                    }
                    else
                    {
                        List<Seat> seats = new List<Seat>();
                        for (int seatID = 0; seatID < 312; seatID++)
                        {
                            seats.Add(new Seat() { seatID = seatID, available = true });
                        }
                        if ((flightT >= 0 && flightT <= 5) || (arrivalT >= 0 && arrivalT <= 5))
                            price = Convert.ToInt32(price * 0.8);
                        else if (flightT < 8 || arrivalT > 19)
                            price = Convert.ToInt32(price * 0.9);
                        flights.Add(new Flight() { departureTime = flightT.ToString() + ":00", arrivalTime = arrivalT.ToString() + ":00", departureDate = startDate.ToString(), flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 777, seats = seats, price = price });
                        currentFlightID++;

                        List<Seat> seats2 = new List<Seat>();
                        for (int seatID = 0; seatID < 312; seatID++)
                        {
                            seats2.Add(new Seat() { seatID = seatID, available = true });
                        }
                        arrivalT += 8;
                        if (arrivalT >= 24) arrivalT -= 24;
                        if ((flightT + 8 >= 0 && flightT + 8 <= 5) || (arrivalT >= 0 && arrivalT <= 5))
                            price = Convert.ToInt32(price * 0.8);
                        else if (flightT + 8 < 8 || arrivalT > 19)
                            price = Convert.ToInt32(price * 0.9);
                        flights.Add(new Flight() { departureTime = (flightT + 8).ToString() + ":00", arrivalTime = arrivalT.ToString() + ":00", departureDate = startDate.ToString(), flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 777, seats = seats2, price = price });
                        currentFlightID++;
                        //flightT++;
                        //if (flightT == 16)
                        //    flightT = 0;
                    }
                    startDate = startDate.AddDays(1);

                }
                flightT++;
                if (flightT == 16)
                    flightT = 0;
            }
            airports.Add(new Airport() { name = airportInfo[i, 0], code = airportInfo[i, 1], flights = flights });
        }
        return airports;
    }
    public static List<Airport> readAirportGraph()
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
        List<Airport> airports = new List<Airport>();
        for (int i = 0; i < 10; i++)
        {
            airports.Add(new Airport() { name = airportInfo[i, 0], code = airportInfo[i, 1], flights = new List<Flight>() });
        }
        var csvFlightsConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = true
        };
        var csvSeatsConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = false
        };
        string filePathFlights = Path.GetDirectoryName(Application.ExecutablePath);
        string fileCsvFlights = Path.Combine(filePathFlights, "..", "..", "..", "csv", "flightList.csv");
        string filePathSeats = Path.GetDirectoryName(Application.ExecutablePath);
        string fileCsvSeats = Path.Combine(filePathSeats, "..", "..", "..", "csv", "flightSeats.csv");
        using (var streamFlightsReader = File.OpenText(fileCsvFlights))
        using (var csvFlightsReader = new CsvReader(streamFlightsReader, csvFlightsConfig))
        {
            int flightID;
            int flightIDSeat;
            int userID;
            string departure;

            while (csvFlightsReader.Read())
            {
                if (csvFlightsReader.TryGetField<int>(3, out flightID))
                {
                    using (var streamSeatsReader = File.OpenText(fileCsvSeats))
                    using (var csvSeatsReader = new CsvReader(streamSeatsReader, csvSeatsConfig))
                    {
                        while (csvSeatsReader.Read())
                        {
                            if (csvSeatsReader.TryGetField<int>(0, out flightIDSeat))
                            {
                                if (flightID == flightIDSeat)
                                {
                                    List<Seat> seats = new List<Seat>();
                                    int seatID = 0;
                                    while (csvSeatsReader.TryGetField<int>(seatID + 1, out userID))
                                    {
                                        if (userID != 0)
                                        {
                                            seats.Add(new Seat() { seatID = seatID, available = false, userID = userID });
                                        }
                                        else
                                        {
                                            seats.Add(new Seat() { seatID = seatID, available = true, userID = userID });
                                        }
                                        seatID++;
                                    }
                                    csvFlightsReader.TryGetField<string>(5, out departure);
                                    foreach (Airport airport in airports)
                                    {
                                        if (airport.code.Equals(departure))
                                        {
                                            string departureTime;
                                            string arrivalTime;
                                            string departureDate;
                                            int flightDistance;
                                            string arrival;
                                            int planeType;
                                            int price;
                                            csvFlightsReader.TryGetField<string>(0, out departureTime);
                                            csvFlightsReader.TryGetField<string>(1, out arrivalTime);
                                            csvFlightsReader.TryGetField<string>(2, out departureDate);
                                            csvFlightsReader.TryGetField<int>(4, out flightDistance);
                                            csvFlightsReader.TryGetField<string>(6, out arrival);
                                            csvFlightsReader.TryGetField<int>(7, out planeType);
                                            csvFlightsReader.TryGetField<int>(8, out price);
                                            airport.flights.Add(new Flight() { departureTime = departureTime, arrivalTime = arrivalTime, departureDate = departureDate, flightID = flightID, flightDistance = flightDistance, departure = departure, arrival = arrival, planeType = planeType, price = price, seats = seats });
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                        
                }
            }
        }
        
        return airports;
    }

}

public class Flight
{
    public string departureTime { get; set; }
    public string arrivalTime { get; set; }
    public string departureDate { get; set; }
    public int flightID { get; set; }
    public int flightDistance { get; set; }
    public string departure { get; set; }
    public string arrival { get; set; }
    public int planeType { get; set; }
    public int price { get; set; }
    [Ignore]
    public List<Seat> seats { get; set; }
}

public class Seat
{
    public int seatID { get; set; }
    public bool available { get; set; }
    public int userID { get; set; } = 0;
}