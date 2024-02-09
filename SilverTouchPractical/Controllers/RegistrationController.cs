using Microsoft.AspNetCore.Mvc;
using SilverTouchPractical.Data;
using SilverTouchPractical.Models;

namespace SilverTouchPractical.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Registration> registrationList = _context.Registrations.ToList();
            return View(registrationList);
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Registration registration)
        {
            if (ModelState.IsValid)
            {
                _context.Registrations.Add(registration);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registration);
        }

        public IActionResult Edit(int? id)
        {
            Registration? registration;
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                registration = _context.Registrations.FirstOrDefault(r => r.ID == id);
                if (registration == null)
                {
                    return NotFound();
                }
            }

            return View(registration);
        }

        [HttpPost]
        public IActionResult Edit(Registration registration)
        {
            if (ModelState.IsValid)
            {
                _context.Registrations.Update(registration);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registration);
        }

        public IActionResult Delete(int? id)
        {
            Registration? registration;
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                registration = _context.Registrations.FirstOrDefault(r => r.ID == id);
                if (registration == null)
                {
                    return NotFound();
                }
            }

            return View(registration);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteForm(int? id)
        {
            Registration? registration;
            if (id != null)
            {
                registration = _context.Registrations.Find(id);
                if (registration != null)
                {
                    _context.Registrations.Remove(registration);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }


    }
}
