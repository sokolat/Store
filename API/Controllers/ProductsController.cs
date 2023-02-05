using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context ;
        public ProductsController(StoreContext context)
        {
            _context = context ;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts(){
            return await _context.Products.ToListAsync() ;
        }   

        [HttpGet("Id")]
         public async Task<ActionResult<Product>> getProduct(int Id){
            return await _context.Products.FindAsync(Id) ;
        }
    }
}