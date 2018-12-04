using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core.Model;
using Data;
using Service;
using AutoMapper;
using Web.ViewModel;

namespace Web.Controllers
{
    public class ClassifiersController : Controller
    {
        private IAirportService _airportService;
        private IAirportSchemeService _airportSchemeService;
        private ICityService _cityService;
        private ICountryService _countryService;
        private IGateService _gateService;
        private IFlightService _flightService;
        private IPlaneService _planeService;
        private ITerminalService _terminalService;
        private ITimeTableService _timeTableService;

        public ClassifiersController(IAirportService airportService, IAirportSchemeService airportSchemeService, 
            ICityService cityService, ICountryService countryService, IGateService gateService, IFlightService flightService, 
            IPlaneService planeService, ITerminalService terminalService, ITimeTableService timeTableService)
        {
            _airportService = airportService;
            _airportSchemeService = airportSchemeService;
            _cityService = cityService;
            _countryService = countryService;
            _gateService = gateService;
            _flightService = flightService;
            _planeService = planeService;
            _terminalService = terminalService;
            _timeTableService = timeTableService;
        }


        // GET: Empty view
        public ActionResult Index()
        {
            return View();
        }

        //Ajax partial view test action
        public ActionResult AjaxTest()
        {
            return PartialView();
        }

        // GET: Airports
        public ActionResult AirportIndex()
        {
            IEnumerable<AirportViewModel> airports = Mapper.Map<IEnumerable<Airport>, IEnumerable<AirportViewModel>>(_airportService.GetAirports());
            return View(airports);
        }

        // GET: Airports/Create
        public ActionResult AirportCreate()
        {
            AirportViewModel airport = new AirportViewModel();
            airport.Cities = _cityService.GetCities();
            return View(airport);
        }

        // POST: Airports/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportCreate([Bind(Include = "Id,Name,Code,CityId")] AirportViewModel airport)
        {
            if (ModelState.IsValid)
            {
                airport.City = _cityService.GetCity(airport.CityId);
                _airportService.CreateAirport(Mapper.Map<AirportViewModel, Airport>(airport));
                return RedirectToAction("AirportIndex");
            }

            return View(airport);
        }
        
        // GET: Airports/Edit/5
        public ActionResult AirportEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirportViewModel airport = Mapper.Map<Airport, AirportViewModel>(_airportService.GetAirport((int)id));
            if (airport == null)
            {
                return HttpNotFound();
            }
            airport.Cities = _cityService.GetCities();
            return View(airport);
        }

        // POST: Airports/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportEdit([Bind(Include = "Id,Name,Code,CityId")] AirportViewModel airport)
        {
            if (ModelState.IsValid)
            {
                _airportService.UpdateAirport(Mapper.Map<AirportViewModel, Airport>(airport));
                return RedirectToAction("AirportIndex");
            }
            return View(airport);
        }
        
        // GET: Airports/Delete/5
        public ActionResult AirportDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirportViewModel airport = Mapper.Map<Airport, AirportViewModel>(_airportService.GetAirport((int)id));
            if (airport == null)
            {
                return HttpNotFound();
            }
            return PartialView(airport);
        }

        // POST: Airports/DeleteConfirm/5
        [HttpPost, ActionName("AirportDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult AirportDeleteConfirmed(int id)
        {
            _airportService.DeleteAirport(id);
            return RedirectToAction("AirportIndex");
        }
    }
}
