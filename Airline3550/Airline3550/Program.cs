using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
namespace Airline3550
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new LoginScreen());
            List<Airport> airports = AirportGraph.createAirportGraph();
            using (var writer = new StreamWriter("flightList.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(airports[0].flights);
            }
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open("flightList.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                for (int i = 1; i < airports.Count; i++)
                {
                    csv.WriteRecords(airports[i].flights);
                }
            }

        }
	}
}