using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIZZERIA.Models;
using PIZZERIA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PIZZERIA.Controllers
{

    public class ContactoController : Controller
    {
        private readonly ILogger<CatalogoController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ContactoController(ApplicationDbContext context,
        ILogger<CatalogoController> logger, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Consultas()
        {
            return View(_context.DataContactos.ToList());
        }
        [HttpPost]
        public IActionResult Enviar(Contacto objContacto)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){
               ViewData["Message"] = "Por favor debe loguearse antes de comunicarase con nosotros";
            }else{
               _context.Add(objContacto);
               _context.SaveChanges();
               ViewData["Message"] = "En las proximas horas nos estaremos comunicando contigo. Gracias";
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}