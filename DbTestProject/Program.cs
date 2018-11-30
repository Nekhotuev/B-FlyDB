using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Data;
using Data.Infrastructure;
using Data.Repositories;
using Service;

namespace DbTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //DB initialization, create data for classifiers
            using (ClassifiersContext context = new ClassifiersContext())
            {
                //context.Database.CreateIfNotExists();

                //context.Database.Initialize(true);

                var airports = context.Airports.ToList();

                foreach (Airport airport in airports)
                {
                    Console.WriteLine(airport.Name);
                }

                //var dbset = context.Set<Airport>();

                //var cities = context.Cities.ToList();

                //var iarport = airports.FirstOrDefault();

                //Console.WriteLine(iarport.Name + " " + iarport.City.Name);

                //iarport.City = cities.LastOrDefault();

                //dbset.Attach(iarport);
                //context.Entry(iarport).State = EntityState.Modified;
                //context.SaveChanges();

                //var airportttt = context.Airports.FirstOrDefault();
                //Console.WriteLine(airportttt.Name + " " + airportttt.City.Name);
            }

            //TestRepo repo = new TestRepo();
            ////repo.Repo();
            //repo.Service();
            
        }
    }

    public class TestRepo
    {
        private IDbFactory _dbFactory;
        private readonly IAirportRepository _airportRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IUnitOfWork _unitOfWork;
        private IAirportService _airportService;
        private ICityService _cityService;

        public TestRepo()
        {
            _dbFactory = new DbFactory();
            _airportRepository = new AirportRepository(_dbFactory);
            _cityRepository = new CityRepository(_dbFactory);
            _unitOfWork = new UnitOfWork(_dbFactory);
        }

        public void Repo()
        {
            var city = _cityRepository.GetById(3);
            var airport = _airportRepository.GetById(16);

            Console.WriteLine(airport.Name + " - " + airport.City.Name);

            airport.City = city;
            _airportRepository.Update(airport);
            _unitOfWork.Commit();

            var airportNew = _airportRepository.GetById(16);

            Console.WriteLine(airport.Name + " - " + airport.City.Name);
            Console.Read();
        }

        public void Service()
        {
            _airportService = new AirportService(_airportRepository, new AirportSchemeRepository(_dbFactory),
                new CityService(_cityRepository, _unitOfWork), _unitOfWork);
            _cityService = new CityService(_cityRepository, _unitOfWork);

            var airportOld = _airportService.GetAirport(16);
            var city = _cityService.GetCity(8);

            Console.WriteLine(airportOld.Name + " - " + airportOld.City.Name);

            _airportService.UpdateAirport(airportOld);

            var airportNew = _airportService.GetAirport(16);

            Console.WriteLine(airportNew.Name + " - " + airportNew.City.Name);

            Console.ReadKey();
        }
    }
}

