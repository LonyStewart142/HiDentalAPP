using DatabaseLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HiDentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public IActionResult Index() => Ok("HI 💥💥💥");        
    }
}
