using AutoMapper;
using Snacklager.Data;
using Snacklager.Logic;
using Snacklager.Logic.Contracts;
using Snacklager.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI;

namespace Snacklager.Web.Controllers
{
    public class SnackController : Controller
    {
        private readonly IRepository<Snack> _snackRepo = new Repository<Snack>(); 

        // GET: Snack
        [OutputCache(Duration = 10, VaryByParam = "none", Location = OutputCacheLocation.ServerAndClient)]
        public ActionResult Index()
        {
            var snacksDb = _snackRepo.GetAll();

            var snacksVm = Mapper.Map<List<SnackDisplayVm>>(snacksDb);

            return View(snacksVm);
        }

        // GET: Snack/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Snack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Snack/Create
        [HttpPost]
        public ActionResult Create(SnackCreateVm snackVm)
        {
            if (!ModelState.IsValid)
            {
                return View(snackVm);
            }

            try
            {
                var snackDb = Mapper.Map<Snack>(snackVm);
                _snackRepo.Insert(snackDb);
                _snackRepo.SaveAll();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                throw ex;

                return View(snackVm);
            }
        }

        // GET: Snack/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Snack/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Snack/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Snack/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
