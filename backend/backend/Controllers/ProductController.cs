using Microsoft.AspNetCore.Mvc;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly TestMultitenantsaasDatabaseContext _db;
        private readonly ILogger<ProductController> _logger;

        public ProductController(
            ILogger<ProductController> logger, 
            TestMultitenantsaasDatabaseContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "GetProduct")]
        public async Task<List<Product>> Get()
        {
            return await _db.Products.ToListAsync();
        }
    }
}
