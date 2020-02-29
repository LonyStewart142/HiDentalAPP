using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinesLogic.UnitOfWork;
using Commons.Helpers;
using DataLayer.Enums;
using DataLayer.Models;
using DataLayer.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HiDentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly IUnitOfWork _service;
        private readonly DefaultValue _settings;
        public PatientController(IUnitOfWork clientUserService)
        {
            _service = clientUserService;
           
        }

        //Add Patient
        [HttpPost("create")]
        public async Task<IActionResult> Create(Patient model)
        {
            var response = new ResponseContenido();

            if (ModelState.IsValid)
            {
                if (await _service.PatientService.Add(model))
                {
                    // BasicNotification("Articulo agregado", NotificationType.success);
                    response.OK = true;
                    response.Mensajes.Add("Paciente registrado correctamente");
                    return  Ok(response);
                }

                response.Errores.Add("Ha ocurrido un error");
                return Ok(response);
               // BasicNotification("Ocurrio un error intente de nuevo", NotificationType.error);
            }
            
            return Ok(new {response,model });
        }


    }
}
