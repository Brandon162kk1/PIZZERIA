using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PIZZERIA.Models;
using PIZZERIA.Data;
using Microsoft.AspNetCore.Authorization;
using System.Dynamic;

namespace PIZZERIA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ConsultasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscarConsultas(string email)
        {   
            var lista = _context.DataConsulta.Include(p => p.Comentario).ToList();

            var query1 = lista;

            if(email != null){
                query1 = query1.Where(p => p.UserID.Contains(email)).ToList();
            }

            var resultado = query1.ToList();

            return View(resultado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}