using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Airport
{
    public Airport(string name, string code, List<Flight> flights)
    {
        this.name = name;
        this.code = code;
        this.flights = flights;
    }
    private string name;
    private string code;
    List<Flight> flights;
    static List<Airport> createAirportGraph()
    {
        string[,] airportInfo = new string[10, 2] 
        {
            { "Nashville International Airport", "BNA" },
            { "Hartsfield–Jackson Atlanta International Airport", "ATL" },
            { "Dallas/Fort Worth International Airport", "DFW" },
            { "Denver International Airport", "DEN" },
            { "O'Hare International Airport", "ORD" },
            { "Los Angeles International Airport", "LAX" },
            { "Cleveland Hopkins International Airport", "CLE" },
            { "Orlando International Airport", "MCO" },
            { "Harry Reid International Airport", "LAS" },
            { "Phoenix Sky Harbor International Airport", "PHX" },
        };
        // Airport distance in miles. The indicies in this 2D array corresponds to the airport with the same index in airportInfo. For example, the value at airportDistances[4][6] is the distance between DEN and LAX
        // The distances were found using the haversine formula
        double[,] airportDistances = new double[10, 10]
        {
            {       0,  213.88,  630.29, 1011.47,  409.83, 1793.57,  457.84,  617.41, 1583.89, 1445.45 },
            {  213.88,       0,  729.96, 1197.14,  606.59, 1942.30,  563.14,  404.89, 1742.89, 1583.81 },
            {  630.29,  729.96,       0,  640.94,  801.83, 1232.17, 1030.11,  983.55, 1053.05,  865.85 },
            { 1011.47, 1197.14,  640.94,       0,  886.16,  860.44, 1206.01, 1545.16,  626.85,  601.32 },
            {  409.83,  606.59,  801.83,  886.16,       0, 1741.03,  322.05, 1007.21, 1510.78, 1437.21 },
            { 1793.57, 1942.30, 1232.17,  860.44, 1741.03,       0, 2056.69, 2213.65,  236.27,  369.45 },
            {  457.84,  563.14, 1030.11, 1206.01,  322.05, 2056.69,       0,  903.69, 1828.38, 1742.86 },
            {  617.41,  404.89,  983.55, 1545.16, 1007.21, 2213.65,  903.69,       0, 2035.91, 1845.26 },
            { 1583.89, 1742.89, 1053.05,  626.85, 1510.78,  236.27, 1828.38, 2035.91,       0,  255.58 },
            { 1445.45, 1583.81,  865.85,  601.32, 1437.21,  369.45, 1742.86, 1845.26,  255.58,       0 }
        };
    }
}

public class Flight
{
    public Flight(int flightID, int flightDistance, Airport departure, Airport arrival, int planeType, List<Seat> seats, int price)
    {
        this.flightID = flightID;
        this.flightDistance = flightDistance;
        this.departure = departure;
        this.arrival = arrival;
        this.planeType = planeType;
        this.seats = seats;
        this.price = price;
    }
    private int flightID;
    private int flightDistance;
    private Airport departure;
    private Airport arrival;
    private int planeType;
    List<Seat> seats;
    private int price;
}

public class Seat
{
    public Seat(int seatID, bool available)
    {
        this.seatID = seatID;
        this.available = available;
    }
    private int seatID;
    private bool available;
}