using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using PIZZERIA.Data;
using PIZZERIA.Models;

namespace PIZZERIA.Controllers.Rest
{
    [ApiController]
    [Route("api/producto")]
    public class ProductoRestController : ControllerBase
    {
         private readonly ApplicationDbContext _context;

        public ProductoRestController(ApplicationDbContext context){
             _context = context;
        }

        [HttpGet]
        public IEnumerable<Producto> ListProductos()
        {
             var listProductos=_context.DataProductos.OrderBy(s => s.Id).ToList();   
             return listProductos.ToArray();
        }


    }
}