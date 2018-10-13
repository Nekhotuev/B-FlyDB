using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using B_FlyDB.Model;

namespace B_FlyDB.DAL
{
    public class ClassifiersInitializer : CreateDatabaseIfNotExists<ClassifiersContext>
    {
        protected override void Seed(ClassifiersContext context)
        {
            //Service class initialization zone
            ServiceClass economyClass = new ServiceClass() { Name = "Economy class" };
            ServiceClass businessClass = new ServiceClass() { Name = "Business class"};
            context.ServiceClasses.Add(economyClass);
            context.ServiceClasses.Add(businessClass);
            context.SaveChanges();

            //Plane initialization zone
            Plane a319Plane = new Plane()
            {
                FirstBCSeat = "A", LastBCSeat = "D", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 1, LastBCSeatRow = 6,
                FirstECSeatRow = 7, LastECSeatRow = 25, Manufacturer = "Airbus", PlaneModel = "A319",
                PlaneModification = "100 with Business class", FuelConsumptionPerKm = 3.615
            };
            Plane a320PlaneEc = new Plane()
            {
                FirstBCSeat = "-", LastBCSeat = "-", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 0, LastBCSeatRow = 0,
                FirstECSeatRow = 1, LastECSeatRow = 30, Manufacturer = "Airbus", PlaneModel = "A320",
                PlaneModification = "200 without Business class", FuelConsumptionPerKm = 4.698
            };
            Plane a320Plane = new Plane()
            {
                FirstBCSeat = "A", LastBCSeat = "D", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 1, LastBCSeatRow = 7,
                FirstECSeatRow = 8, LastECSeatRow = 30, Manufacturer = "Airbus", PlaneModel = "A320",
                PlaneModification = "200 with Business class", FuelConsumptionPerKm = 4.698
            };
            Plane a321PlaneEc = new Plane()
            {
                FirstBCSeat = "-", LastBCSeat = "-", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 0, LastBCSeatRow = 0,
                FirstECSeatRow = 1, LastECSeatRow = 39, Manufacturer = "Airbus", PlaneModel = "A321",
                PlaneModification = "100 without Business class", FuelConsumptionPerKm = 5.85
            };
            Plane a321Plane = new Plane()
            {
                FirstBCSeat = "A", LastBCSeat = "D", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 1, LastBCSeatRow = 7,
                FirstECSeatRow = 8, LastECSeatRow = 39, Manufacturer = "Airbus", PlaneModel = "A321",
                PlaneModification = "100 with Business class", FuelConsumptionPerKm = 5.85
            };
            Plane b737PlaneEc = new Plane()
            {
                FirstBCSeat = "-", LastBCSeat = "-", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 0, LastBCSeatRow = 0, 
                FirstECSeatRow = 1, LastECSeatRow = 28, Manufacturer = "Boeing", PlaneModel = "737",
                PlaneModification = "800 without Business class", FuelConsumptionPerKm = 4.6536
            };
            Plane b737Plane = new Plane()
            {
                FirstBCSeat = "A", LastBCSeat = "D", FirstECSeat = "A", LastECSeat = "F", FirstBCSeatRow = 1, LastBCSeatRow = 5,
                FirstECSeatRow = 6, LastECSeatRow = 28, Manufacturer = "Boeing", PlaneModel = "737",
                PlaneModification = "800 with Business class", FuelConsumptionPerKm = 4.6536
            };
            context.Planes.AddRange(new List<Plane>()
                {a319Plane, a320Plane, a320PlaneEc, a321Plane, a321PlaneEc, b737Plane, b737PlaneEc});
            context.SaveChanges();



            //Country initialization zone
            Country russiaCountry = new Country() { Name = "Russia" };
            Country franceCountry = new Country() { Name = "France" };
            Country netherlandsCountry = new Country() { Name = "Netherlands" };
            Country germanyCountry = new Country() { Name = "Germany" };
            context.Countries.AddRange(new List<Country>() { russiaCountry, franceCountry,
                netherlandsCountry, germanyCountry });

            //City initialization zone
            City moscowCity = new City() { Name = "Moscow", Country = russiaCountry };
            City volgogradCity = new City() { Name = "Volgograd", Country = russiaCountry };
            City saratovCity = new City() { Name = "Saratov", Country = russiaCountry };
            City sochiCity = new City() { Name = "Sochi", Country = russiaCountry };
            City amsterdamCity = new City() { Name = "Amsterdam", Country = netherlandsCountry };
            City parisCity = new City() { Name = "Paris", Country = franceCountry };
            City berlinCity = new City() { Name = "Berlin", Country = germanyCountry };
            City frankfurtCity = new City() { Name = "Frankfurt", Country = germanyCountry };
            context.Cities.AddRange(new List<City>() { moscowCity, volgogradCity, saratovCity,
                sochiCity, amsterdamCity, parisCity, berlinCity, frankfurtCity });
            context.SaveChanges();

            //Airport initialization zone
            Airport domodedovoAirport = new Airport() { Name = "Domodedovo", Code = "DME", Country = russiaCountry, City = moscowCity};
            Airport vnukovoAirport = new Airport() { Name = "Vnukovo", Code = "VKO", Country = russiaCountry, City = moscowCity };
            Airport scheremetevoAirport = new Airport() { Name = "Scheremetevo", Code = "SVO", Country = russiaCountry, City = moscowCity };
            Airport volgAirport = new Airport() { Name = "Volgograd airport", Code = "VGO", Country = russiaCountry, City = volgogradCity };
            Airport saratovAirport = new Airport() { Name = "Saratov airport", Code = "SAO", Country = russiaCountry, City = saratovCity};
            Airport sochiAirport = new Airport() { Name = "Sochi airport", Code = "SCH", Country = russiaCountry, City = sochiCity};
            Airport schipholAirport = new Airport() { Name = "Schiphol", Code = "SPL", Country = netherlandsCountry, City = amsterdamCity};
            Airport sharlDeGollAirport = new Airport() { Name = "Sharl-De-Goll airport", Code = "SGD", Country = franceCountry, City = parisCity};
            Airport schonefieldAirport = new Airport() { Name = "Schonefield", Code = "SCF", Country = germanyCountry, City = berlinCity};
            Airport frankfurtOnMaineAirport = new Airport() { Name = "Frankfurt on Meine", Code = "FOM", Country = germanyCountry, City = frankfurtCity};
            context.Airports.AddRange(new List<Airport>()
            {
                domodedovoAirport, vnukovoAirport, scheremetevoAirport, volgAirport,
                saratovAirport, sochiAirport, schipholAirport, sharlDeGollAirport, schonefieldAirport,
                frankfurtOnMaineAirport
            });

            //Terminal initialization zone
            Terminal aTerminal = new Terminal() { Name = "A"};
            Terminal bTerminal = new Terminal() { Name = "B"};
            Terminal cTerminal = new Terminal() { Name = "C"};
            Terminal dTerminal = new Terminal() { Name = "D"};
            Terminal eTerminal = new Terminal() { Name = "E"};
            context.Terminals.AddRange(new List<Terminal>() {aTerminal, bTerminal, cTerminal, dTerminal, eTerminal});

            //Gate initialization zone
            Gate gate1 = new Gate() { Name = "1"};
            Gate gate2 = new Gate() { Name = "2" };
            Gate gate3 = new Gate() { Name = "3" };
            Gate gate4 = new Gate() { Name = "4" };
            Gate gate5 = new Gate() { Name = "5" };
            Gate gate6 = new Gate() { Name = "6" };
            Gate gate7 = new Gate() { Name = "7" };
            Gate gate8 = new Gate() { Name = "8" };
            Gate gate9 = new Gate() { Name = "9" };
            Gate gate10 = new Gate() { Name = "10" };
            Gate gate11 = new Gate() { Name = "11" };
            Gate gate12 = new Gate() { Name = "12" };
            Gate gate13 = new Gate() { Name = "13" };
            Gate gate14 = new Gate() { Name = "14" };
            Gate gate15 = new Gate() { Name = "15"};
            context.Gates.AddRange(new List<Gate>()
            {
                gate1, gate2, gate3, gate4, gate5, gate6, gate6, gate7, gate8, gate9, gate10, gate1, gate12, gate13,
                gate14, gate15
            });
            context.SaveChanges();
            
            //random generation of airport schemes for all airports
            List<Airport> Airports = context.Airports.ToList();
            List<Terminal> Terminals = context.Terminals.ToList();
            List<Gate> Gates = context.Gates.ToList();
            Random random = new Random();
            foreach (Airport airport in Airports)
            {
                foreach (Terminal terminal in Terminals)
                {
                    int gatesCount = random.Next(5, 15);
                    for (int i = 0; i < gatesCount; i++)
                    {
                        AirportScheme airportScheme = new AirportScheme() { Airport = airport, Terminal = terminal,
                            Gate = Gates[i] };
                        context.AirportSchemes.Add(airportScheme);
                    }
                }
            }
            context.SaveChanges();
        }
    }
}