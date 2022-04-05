using Intex_Semester_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Semester_2.Controllers
{
    public class HomeController : Controller
    {
        private AppIdentityDBContext _logincontext { get; set; }
        private CrashesDbContext _context { get; set; }

        public HomeController(AppIdentityDBContext temp /*CrashesDbContext temp*/)
        {
            _logincontext = temp;
        }
    
        public IActionResult Index()
        {
            var blah = _context.Crashes.ToList();
            return View(blah);
        }


    //get and post methods for the adding crash
    //[HttpGet]
    //public IActionResult Add()
    //{
    //ViewBag.Crashes = crash.ToList();

    //return View();
    //}

    //make sure to add and save changes to the crashes in the database
    //[HttpPost]
    //public IActionResult Add(Crash c)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        crash.Add(c);
    //        crash.SaveChanges();

    //        return View("Confirmation", c);
    //    }
    //    else //validation
    //    {
    //        ViewBag.Crashes = crash.ToList();

    //        return View();
    //    }

    //}

    //edit record
    //[HttpGet]
    //public IActionResult Edit(int crashid)
    //{

    //    ViewBag.Crashes = crash.ToList();

    //    var record = crash.Single(x => x.CRASH_ID == crashid);

    //    return View("Add", record);
    //}

    //        UNCOMMENT EVERYTHING BELOW THIS BRO
    //        //get and post methods for the adding crash
    //        [HttpGet]
    //        public IActionResult Add()
    //        {
    //            ViewBag.Crashes = crash.ToList();

    //            return View();
    //        }

    //        //make sure to add and save changes to the crashes in the database
    //        [HttpPost]
    //        public IActionResult Add(Crash c)
    //        {
    //            if (ModelState.IsValid)
    //            {
    //                crash.Add(c);
    //                crash.SaveChanges();

    //                return View("Confirmation", c);
    //            }
    //            else //validation
    //            {
    //                ViewBag.Crashes = crash.ToList();

    //                return View();
    //            }

    //        }

    //        //edit record
    //        [HttpGet]
    //        public IActionResult Edit(int crashid)
    //        {

    //            ViewBag.Crashes = crash.ToList();

    //            var record = crash.Single(x => x.CRASH_ID == crashid);

    //            return View("Add", record);
    //        }


    //        [HttpPost]
    //        public IActionResult Edit(Crash blah)
    //        {
    //            crash.Update(blah);
    //            crash.SaveChanges();

    //            return RedirectToAction("Index");
    //        }

    //        //delete record
    //        [HttpGet]
    //        public IActionResult Delete(int crashid)
    //        {
    //            var blah = crash.Crashes.Single(x => x.CRASH_ID == crashid);

    //            return View(blah);
    //        }

    //        [HttpPost]
    //        public IActionResult Delete(Crash cr)
    //        {

    //            //blahContext.Crashes.Remove(cr);
    //            foreach (var tatertot in crash.Crashes)
    //            {
    //                if (tatertot.CRASH_ID == cr.CRASH_ID)
    //                {
    //                    crash.Crashes.Remove(tatertot);
    //                }
    //            }
    //            crash.SaveChanges();

    //            return RedirectToAction("Index");
    //        }
}
