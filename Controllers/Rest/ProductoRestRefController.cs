using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PIZZERIA.Data;
using PIZZERIA.Models;
using PIZZERIA.Services;


namespace cPIZZERIA.Controllers.Rest
{
    [ApiController]
    [Route("api/productoref")]
    public class ProductoRestRefController : ControllerBase
    {
        private readonly ProductoService _service;


        public ProductoRestRefController(ProductoService service){
             _service = service;
        }


        [HttpPost]
        public Task<Producto> CreateProducto(Producto producto){
            return _service.crearProducto(producto);
        }

    }
}