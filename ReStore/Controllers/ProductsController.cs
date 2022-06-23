using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReStore.Data;
using ReStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;
        public ProductsController(StoreContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() {

            return await context.Products.ToListAsync();
           
        }
        [HttpGet("{id}")] // api//products//3
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await context.Products.FindAsync(id);
        }

    }
}
