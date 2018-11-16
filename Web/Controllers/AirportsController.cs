﻿using System;
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

namespace Web.Controllers
{
    public class AirportsController : Controller
    {
        private IAirportService _airportService;
        private IAirportSchemeService _airportSchemeService;
        private ITerminalService _terminalService;
        private IGateService _gateService;

        public AirportsController(IAirportService airportService, IAirportSchemeService airportSchemeService, ITerminalService terminalService, IGateService gateService)
        {
            _airportService = airportService;
            _airportSchemeService = airportSchemeService;
            _terminalService = terminalService;
            _gateService = gateService;
        }


        // GET: Airports
        public ActionResult Index()
        {
            return View(_airportService.GetAirports());
        }

        // GET: Airports/Details/5
        public ActionResult Details(int? id)
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

        // GET: Airports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Airports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Code")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                _airportService.CreateAirport(airport);
                return RedirectToAction("Index");
            }

            return View(airport);
        }

        // GET: Airports/Edit/5
        public ActionResult Edit(int? id)
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
        public ActionResult Edit([Bind(Include = "Id,Name,Code")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                _airportService.UpdateAirport(airport);
                return RedirectToAction("Index");
            }
            return View(airport);
        }

        // GET: Airports/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Airports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _airportService.DeleteAirport(id);
            return RedirectToAction("Index");
        }
    }
}