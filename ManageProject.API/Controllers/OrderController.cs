using ManageProject.API.Database;
using ManageProject.API.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ManageProject.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
        public readonly DataContext _context;
        public OrderController (DataContext context){
            _context = context;
        }

    

    [HttpGet]
    public async Task<ActionResult<List<Order>>> Get(int userId) {

        var orders = await _context.Orders
            .Where(item => item.UserId == userId)
            .ToListAsync();
        return orders;
    }

    [HttpPost]
        public async Task<ActionResult<List<Order>>> Create(Order order) {

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return await Get(order.UserId);
    }
}
