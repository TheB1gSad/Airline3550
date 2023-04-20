using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CsvHelper.Configuration.Attributes;


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
                int distance = airportDistances[i, index[i][j]];
                if (distance < 600)
                {
                    List<Seat> seats = new List<Seat>();
                    for (int seatID = 0; seatID < 189; seatID++)
                    {
                        seats.Add(new Seat() { seatID = seatID, available = true });
                    }
                    flights.Add(new Flight() { flightTime = flightT.ToString() + ":00", flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 737, seats = seats, price = 58 + (int)(0.12 * distance) });
                    currentFlightID++;

                    List<Seat> seats2 = new List<Seat>();
                    for (int seatID = 0; seatID < 189; seatID++)
                    {
                        seats2.Add(new Seat() { seatID = seatID, available = true });
                    }
                    flights.Add(new Flight() { flightTime = (flightT + 8).ToString() + ":00", flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 737, seats = seats2, price = 58 + (int)(0.12 * distance) });
                    currentFlightID++;
                    flightT++;
                    if (flightT == 16)
                        flightT = 0;

                }
                else if (distance < 1100)
                {
                    List<Seat> seats = new List<Seat>();
                    for (int seatID = 0; seatID < 200; seatID++)
                    {
                        seats.Add(new Seat() { seatID = seatID, available = true });
                    }
                    flights.Add(new Flight() { flightTime = flightT.ToString() + ":00", flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 757, seats = seats, price = 58 + (int)(0.12 * distance) });
                    currentFlightID++;

                    List<Seat> seats2 = new List<Seat>();
                    for (int seatID = 0; seatID < 200; seatID++)
                    {
                        seats2.Add(new Seat() { seatID = seatID, available = true });
                    }
                    //flights.Add(new Flight((flightT + 8).ToString() + ":00", currentFlightID, distance, airportInfo[i, 1], airportInfo[j, 1], 757, seats2, 58 + (int)(0.12 * distance)));
                    flights.Add(new Flight() { flightTime = (flightT + 8).ToString() + ":00" , flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 757, seats = seats2, price = 58 + (int)(0.12 * distance) });

                    currentFlightID++;
                    flightT++;
                    if (flightT == 16)
                        flightT = 0;
                }
                else
                {
                    List<Seat> seats = new List<Seat>();
                    for (int seatID = 0; seatID < 312; seatID++)
                    {
                        seats.Add(new Seat() { seatID = seatID, available = true });
                    }
                    flights.Add(new Flight() { flightTime = flightT.ToString() + ":00", flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 777, seats = seats, price = 58 + (int)(0.12 * distance) });
                    currentFlightID++;

                    List<Seat> seats2 = new List<Seat>();
                    for (int seatID = 0; seatID < 312; seatID++)
                    {
                        seats2.Add(new Seat() { seatID = seatID, available = true });
                    }
                    flights.Add(new Flight() { flightTime = (flightT + 8).ToString() + ":00", flightID = currentFlightID, flightDistance = distance, departure = airportInfo[i, 1], arrival = airportInfo[j, 1], planeType = 777, seats = seats2, price = 58 + (int)(0.12 * distance) });
                    currentFlightID++;
                    flightT++;
                    if (flightT == 16)
                        flightT = 0;
                }
            }
            airports.Add(new Airport() { name = airportInfo[i, 0], code = airportInfo[i, 1], flights = flights });
        }
        return airports;
    }
}

public class Flight
{
    public string flightTime { get; set; }
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
}