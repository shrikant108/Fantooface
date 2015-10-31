using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fantooface.Controllers
{
    public class TutorialController : Controller
    {
        //
        // GET: /Tutorial/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Tutorial/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Tutorial/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tutorial/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Tutorial/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tutorial/Edit/5

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

        //
        // GET: /Tutorial/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tutorial/Delete/5

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
