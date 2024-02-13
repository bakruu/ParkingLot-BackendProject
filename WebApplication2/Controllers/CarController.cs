using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public int Id = 0;
        [HttpGet("Prices")]
        public async Task<IActionResult> GetPrice()
        {
            var subscribtions = new List<Subscription>() {
                new Subscription
            {
                CarType=CarType.Commercial,
                Price=20,
                Id=1
            },
                new Subscription
            {
                CarType=CarType.Motorcycle,
                Price=10,
                Id=2
            },
                 new Subscription
            {
                CarType=CarType.Personal,
                Price=15,
                Id=3
            },
                };
            return await Task.FromResult(Ok(subscribtions));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Car car)
        {
            var ticket = new Ticket()
            {
                CarId = car.Id,
                Id = Id++,
                StartDate = DateTime.Now,
                Car = car
            };
            return Ok(ticket);
        }
    }
}
