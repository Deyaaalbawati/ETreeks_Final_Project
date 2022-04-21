using ETreeks.Core.DTO;
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



        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateAppointmentStatus/{appointmentid}/{appointmentstatus}")]
        public string updateAppointmentStatus( int appointmentid, string appointmentstatus)
        {
            return _appointmentService.updateAppointmentStatus(appointmentid, appointmentstatus);
        }




        [HttpGet("GetAppointmentByAccountId/{AccountId}")]
        [ProducesResponseType(typeof(List<Appointment>), StatusCodes.Status200OK)]
        [Route("GetAppointmentByAccountId")]
        public List<Appointment> getAppointmentByAccountId(int AccountId)
        {
            return _appointmentService.getAppointmentByAccountId(AccountId);
        }


        [HttpGet("GetAppointmentByCourseId/{CourseId}")]
        [ProducesResponseType(typeof(List<Appointment>), StatusCodes.Status200OK)]
        [Route("GetAppointmentByCourseId")]
        public List<Appointment> getAppointmentByCourseId(int CourseId)
        {
            return _appointmentService.getAppointmentByCourseId(CourseId);
        }



        [HttpGet("GetAppointmentTeacher/{CourseId}")]
        [ProducesResponseType(typeof(List<AppointmentTeacher>), StatusCodes.Status200OK)]
        [Route("GetAppointmentTeacher")]
        public List<AppointmentTeacher> getAppintmentTeacher(int CourseId)
        {
            return _appointmentService.getAppintmentTeacher(CourseId);
        }

        [HttpGet("TeacherDashboardAppintment/{TeacherId}")]
        [ProducesResponseType(typeof(List<TeacherDashboardAppintment>), StatusCodes.Status200OK)]
        [Route("TeacherDashboardAppintment")]
        public List<TeacherDashboardAppintment> getTeacherDashboardAppintment(int TeacherId)
        {
            return _appointmentService.getTeacherDashboardAppintment(TeacherId);
        }



        [HttpGet("StudentAppointment/{StudentId}")]
        [ProducesResponseType(typeof(List<StudentAppointment>), StatusCodes.Status200OK)]
        [Route("StudentAppointment")]
        public List<StudentAppointment> getStudentAppointment(int StudentId)
        {
            return _appointmentService.getStudentAppintment(StudentId);
        }



        [HttpGet("SerachBetweenTwoDate/{TeacherId}/{StartDate}/{EndDate}")]
        [ProducesResponseType(typeof(List<SerachBetweenTwoDate>), StatusCodes.Status200OK)]
        [Route("SerachBetweenTwoDate")]
        public List<SerachBetweenTwoDate> SerachBetweenTwoDate(int TeacherId,DateTime StartDate,DateTime EndDate)
        {
            return _appointmentService.SerachBetweenTwoDate(TeacherId, StartDate, EndDate);
        }


    }
}
