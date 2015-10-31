using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fantooface.Controllers
{
    public class SkillTestController : Controller
    {
        //
        // GET: /SkillTest/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /SkillTest/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SkillTest/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SkillTest/Create

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
        // GET: /SkillTest/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SkillTest/Edit/5

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
        // GET: /SkillTest/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SkillTest/Delete/5

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
