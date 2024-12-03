using Hospital.Wep.Data;
using Hospital.Wep.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Hospital.Wep.Controllers
{
    public class PatientEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var patient =_context.PatientEntries.ToList();
            return View(patient);
        }
        [HttpGet]
        //[AjaxOnly]
        public IActionResult Create()
        {
            return View("FormPatientEntry");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PatientEntryFormViewModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            PatientEntry patient = new()
            {
                Name = model.Name,
                SSN = model.SSN,
                CreatedOn = DateTime.Now,

            };
            _context.PatientEntries.Add(patient);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult Edit()
        //{
        //    var patient = new PatientEntryFormViewModel
        //    {
        //        Id = 1,
        //        Name = "Change your Name"
        //    };
        //    return View(nameof(Create), patient);
        //}
        public IActionResult Edit(int id)
        {
            var patient = _context.PatientEntries.Find(id);

            if (patient is null)
                return NotFound();

            var oldPatient = new PatientEntryFormViewModel
            {
                Id = id,
                Name = patient.Name, SSN = patient.SSN,
            };
            return View("FormPatientEntry", oldPatient);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PatientEntryFormViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var patient = _context.PatientEntries.Find(model.Id);

            if (patient is null)
                return NotFound();

            patient.Name= model.Name;
            patient.SSN= model.SSN;
            patient.LastUpdatedOn = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ToggleStatus(int id)
        {
            var patient = _context.PatientEntries.Find(id);

            if (patient is null)
                return NotFound();

            patient.IsDeleted = !patient.IsDeleted ;
            patient.LastUpdatedOn = DateTime.Now;

            _context.SaveChanges();

            //TODO : AddDays(1)

            return Ok(patient.LastUpdatedOn.ToString());
        }
    }
}
