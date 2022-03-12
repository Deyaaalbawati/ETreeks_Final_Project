using ETreeks.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace ETreeks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService iappointmentService)
        {
            _appointmentService = iappointmentService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateAppointment")]
        public string createAppointment([FromBody] Appointment appointment)
        {
            return _appointmentService.createAppointment(appointment);
        }

        [HttpDelete]
        [Route("DeleteAppointment/{id}")]
        public string deleteAppointment(int id)
        {
            return _appointmentService.deleteAppointment(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Appointment>), StatusCodes.Status200OK)]
        [Route("GetAppointment")]
        public List<Appointment> getAppointment()
        {
            return _appointmentService.getAppointment();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateAppointment")]
        public string updateAppointment([FromBody] Appointment appointment)
        {
            return _appointmentService.updateAppointment(appointment);
        }
    }
}
