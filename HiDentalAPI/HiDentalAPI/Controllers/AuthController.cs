using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinesLayer.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiDentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _service;
        public AuthController(IUnitOfWork service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Index() => Ok(_service.AuthService.Test());
    }
}