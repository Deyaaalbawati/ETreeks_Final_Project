using ETreeks.Core.DTO;
using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class AppointmentService : IAppointmentService
    {

        private readonly IAppointmentRepository _appointmentRepository; 
        public AppointmentService(IAppointmentRepository iappointmentRepository)
        {
            _appointmentRepository = iappointmentRepository;
        }

        public string createAppointment(Appointment appointment)
        {
            return _appointmentRepository.createAppointment(appointment);
        }

        public string deleteAppointment(int id)
        {
            return _appointmentRepository.deleteAppointment(id);
        }

        public List<Appointment> getAppointment()
        {
            return _appointmentRepository.getAppointment();
        }

        public List<Appointment> getAppointmentByAccountId(int AccountId)
        {
            return _appointmentRepository.getAppointmentByAccountId(AccountId);
        }


        public List<Appointment> getAppointmentByCourseId(int CourseId)
        {
            return _appointmentRepository.getAppointmentByCourseId(CourseId);
        }

        public string updateAppointment(Appointment appointment)
        {
            return _appointmentRepository.updateAppointment(appointment);
        }

        public List<AppointmentTeacher> getAppintmentTeacher(int Courseid)
        {
            return _appointmentRepository.getAppintmentTeacher(Courseid);
        }

  

        public List<TeacherDashboardAppintment> getTeacherDashboardAppintment(int TeacherId)
        {
            return _appointmentRepository.getTeacherDashboardAppintment(TeacherId);
        }
    }
}
