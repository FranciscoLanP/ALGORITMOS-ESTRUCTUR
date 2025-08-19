using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.Models;

namespace Api.Controllers
{
    public class PayrollController : Controller
    {
        private readonly PayrollService _svc;
        public PayrollController(PayrollService svc) => _svc = svc;

        public IActionResult Index()
        {
            ViewBag.Total = _svc.TotalSalaries();
            return View(_svc.GetAll());
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _svc.Register(emp);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var emp = _svc.GetById(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = _svc.GetById(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _svc.Delete(id);
            return RedirectToAction(nameof(Index));
        }

       
        [HttpGet]
        public IActionResult Search(int id)
        {
            var emp = _svc.GetById(id);
            if (emp == null)
            {
                TempData["Error"] = $"Empleado con ID {id} no encontrado.";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Details), new { id });
        }
    }
}
