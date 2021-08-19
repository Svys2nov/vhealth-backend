using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Svys2nov.VHealth.Domain;

namespace Svys2nov.VHealth.Vehicles.API.Controllers
{
    [Route("user/{userId:int}/vehicles")]
    public class VehiclesController : Controller
    {
        [HttpGet]
        public Task<IActionResult> GetVehicles(int userId)
        {
            var vehicles = Database.Vehicles.Where(vehicle => vehicle.UserId == userId);
            IActionResult result = Ok(vehicles);
            
            return Task.FromResult(result);
        }
    }
}