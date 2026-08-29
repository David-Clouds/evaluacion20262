using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TecnoGas.Web.Data;
using TecnoGas.Web.Models;

namespace TecnoGas.Web.Controllers
{
    public class SolicitudesController : Controller
    {
        private readonly TecnoGasDbContext _context;

        public SolicitudesController(TecnoGasDbContext context)
        {
            _context = context;
        }

        // GET: Solicitudes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solicitudes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SolicitudServicio solicitud)
        {
            if (ModelState.IsValid)
            {
                solicitud.FechaRegistro = DateTime.Now;
                _context.Add(solicitud);
                await _context.SaveChangesAsync();
                TempData["Mensaje"] = "¡Solicitud registrada correctamente!";
                return RedirectToAction(nameof(Create));
            }

            return View(solicitud);
        }
    }
}