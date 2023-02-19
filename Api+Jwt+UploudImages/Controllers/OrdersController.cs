using Api_Jwt_UploudImages.Data.Models;
using Api_Jwt_UploudImages.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Jwt_UploudImages.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController(AppDbContext db)
        {
            _db = db;
        }

        private readonly AppDbContext _db;

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = _db.Orders.Where(x => x.id == 1)
                                 .FirstOrDefault().ordersItems
                                 .FirstOrDefault().items;
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(Order order)
        {
            return Ok(order);
        }
    }
}

