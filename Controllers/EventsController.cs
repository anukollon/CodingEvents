using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
    
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);
            return Redirect("/Events");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            //EventData.Delete()
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("/Events/Delete")]
        public IActionResult DeleteEvents(int[] eventIds)
        {
            foreach(int id in eventIds)
            {
                EventData.Delete(id);
            }
            return Redirect("/Events");
        }

        [HttpGet]

        public IActionResult Edit(int Id)
        {
            // controller code will go here
            ViewBag.eventToEdit = EventData.GetById(Id);
            return View();

        }

        [HttpPost]
        [Route("/Events/Edit")]
        public IActionResult Edit(int id, string name, string description)
        {
            //Console.WriteLine("Inside post submit method");
            // controller code will go here
            EventData.Update(id, name, description);

            return Redirect("/Events");
        }
    }
}
