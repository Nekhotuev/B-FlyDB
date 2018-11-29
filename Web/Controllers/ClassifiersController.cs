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

namespace Web.Controllers
{
    public class ClassifiersController : Controller
    {
        private IAirportService _airportService;
        private IAirportSchemeService _airportSchemeService;
        private ITerminalService _terminalService;
        private IGateService _gateService;

        public ClassifiersController(IAirportService airportService, IAirportSchemeService airportSchemeService, ITerminalService terminalService, IGateService gateService)
        {
            _airportService = airportService;
            _airportSchemeService = airportSchemeService;
            _terminalService = terminalService;
            _gateService = gateService;
        }


        // GET: Airports
        public ActionResult Index()
        {
            return View();
        }

        // GET: Airports
        public ActionResult AirportIndex()
        {
            var airports = _airportService.GetAirports();
            var airport = _airportService.GetAirport(1);
            var airportscheme = _airportSchemeService.GetAirportScheme(1);
            //List<AirportViewModel> airport = Mapper.Map<IEnumerable<Airport>, IEnumerable<AirportViewModel>>(_airportService.GetAirports());
            return View(_airportService.GetAirports());
        }

        // GET: Airports/Create
        public ActionResult AirportCreate()
        {
            ViewData["Terminals"] = _terminalService.GetTerminals();
            ViewData["Gates"] = _gateService.GetGates();
            return View();
        }

        // POST: Airports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportCreate([Bind(Include = "Id,Name,Code")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                _airportService.CreateAirport(airport);
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
            Airport airport = _airportService.GetAirport((int)id);
            if (airport == null)
            {
                return HttpNotFound();
            }
            return View(airport);
        }

        // POST: Airports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AirportEdit([Bind(Include = "Id,Name,Code,City")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                _airportService.UpdateAirport(airport);
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
            Airport airport = _airportService.GetAirport((int)id);
            if (airport == null)
            {
                return HttpNotFound();
            }
            return PartialView(airport);
        }

        // POST: Airports/Delete/5
        [HttpPost, ActionName("AirportDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult AirportDeleteConfirmed(int id)
        {
            _airportService.DeleteAirport(id);
            return RedirectToAction("AirportIndex");
        }
    }
}
