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

        // GET: Airports
        public ActionResult AirportIndex(int pageNumber = 1)
        {
            int pageSize = 10;
            ViewData["PageNumber"] = pageNumber;

            IEnumerable<AirportViewModel> airports = Mapper.Map<IEnumerable<Airport>, IEnumerable<AirportViewModel>>(_airportService.GetAirports(pageNumber, pageSize, out var totalPages));

            ViewData["TotalPages"] = totalPages;

            return PartialView(airports);
        }

        //GET: airports names for autocomplete search
        public ActionResult AirportSearch(string term)
        {
            //send airport collection and work with it, get names from it and use values from it
            //IEnumerable<AirportViewModel> airports = Mapper.Map<IEnumerable<Airport>, IEnumerable<AirportViewModel>>(_airportService.GetAirports(term));
            //add in json id and pass it like a dictionary id - name, then open pass id in edit method if something were choosen in autocomplete field.
            return Json(_airportService.GetAirportNames(term), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AirportIndexFull(int pageNumber = 1)
        {
            int pageSize = 10;
            ViewData["PageNumber"] = pageNumber;

            IEnumerable<AirportViewModel> airports = Mapper.Map<IEnumerable<Airport>, IEnumerable<AirportViewModel>>(_airportService.GetAirports(pageNumber, pageSize, out var totalPages));

            ViewData["TotalPages"] = totalPages;
            return View("AirportIndex", airports);
        }

        // GET: Airports/Create
        public ActionResult AirportCreate()
        {
            AirportViewModel airport = new AirportViewModel();
            airport.Cities = _cityService.GetCities();
            return PartialView(airport);
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
                return RedirectToAction("AirportIndexFull");
            }

            return PartialView(airport);
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
            return PartialView(airport);
        }

        // POST: Airports/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportEdit([Bind(Include = "Id,Name,Code,CityId")] AirportViewModel airport)
        {
            if (ModelState.IsValid)
            {
                _airportService.UpdateAirport(Mapper.Map<AirportViewModel, Airport>(airport));
                return RedirectToAction("AirportIndexFull");
            }
            return PartialView(airport);
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
            return RedirectToAction("AirportIndexFull");
        }

        // GET: Airports
        public ActionResult TerminalIndex()
        {
            IEnumerable<TerminalViewModel> terminals = Mapper.Map<IEnumerable<Terminal>, IEnumerable<TerminalViewModel>>(_terminalService.GetTerminals());
            return PartialView(terminals);
        }
    }
}
