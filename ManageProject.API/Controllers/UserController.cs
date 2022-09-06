using ManageProject.API.Database;
using ManageProject.API.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ManageProject.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
        public readonly DataContext _context;
        

        public UserController (DataContext context){
            _context = context;
        }

    

    [HttpGet]
    public IEnumerable<User> Get()
    {
        // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        // {
        //     Date = DateTime.Now.AddDays(index),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        // })
        // .ToArray();
        return _context.Users.ToList();
    }
}
