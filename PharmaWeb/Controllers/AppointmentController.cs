using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;
using PharmaWeb.Service;

namespace PharmaWeb.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _service;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _service = appointmentService;
          
        }


        [Authorize(Policy = "AdminOnly")]
        //Methode return a list about the appointment
        public IActionResult Index()
        {
            return View(_service.GetAllAppointment());
        }

        public IActionResult Succes()
        {
            return View();
        }

        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment appt = new Appointment();
            appt = _service.GetAppointmentId(id.Value);

            if (appt == null)
            {
                return NotFound();
            }

            return View(appt);
        }

       
        public IActionResult Create()
        {
            CreateAppointmentCommand cmd = new CreateAppointmentCommand();
            return View(cmd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Create a new appointment

        public IActionResult Create(CreateAppointmentCommand cmd)
        {
            if (ModelState.IsValid)
            {
                int id = _service.CreateAppointmente(cmd);
                return RedirectToAction("Succes");
            }
            return View(cmd);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "AdminOnly")]
        //Delete an appointment
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _service.DeleteAppointment(id.Value);
            return RedirectToAction("Index");
        }

        [Authorize(Policy = "AdminOnly")]
        //Search a appointment
        public IActionResult Search(string searchString, bool lastNamefilter,bool firstNamefilter)
        {
            var appointements = _service.GetAllAppointment();
            if (!string.IsNullOrEmpty(searchString))
            {
                if (lastNamefilter == true)
                {
                    appointements = appointements.Where(x => x.LastName.Contains(searchString));
                }
                if (firstNamefilter == true)
                {
                    appointements = appointements.Where(x => x.FirstName.Contains(searchString));
                }
                else
                {
                    appointements = appointements.Where(x => x.FirstName.Contains(searchString) || x.LastName.Contains(searchString));
                }
            }

            var AppointementsVM = new SearchViewModel()
            {
                Appointements = appointements.ToList()
            };
            return View(AppointementsVM);
        }



    }
}
