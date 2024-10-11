using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using NorthwindODataApi.Models;

namespace NorthwindODataApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ODataController
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly NorthwindDbContext _context;

        public OrdersController(ILogger<OrdersController> logger, NorthwindDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet, EnableQuery]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Orders.ToListAsync());
        }

        [HttpGet, EnableQuery]
        [Route("{key}")]
        public async Task<IActionResult> Get(string key)
        {
            return Ok(await _context.Orders.SingleOrDefaultAsync(x => x.CustomerId == key));
        }
    }
}
