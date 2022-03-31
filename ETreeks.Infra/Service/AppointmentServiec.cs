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

        public string updateAppointment(Appointment appointment)
        {
            return _appointmentRepository.updateAppointment(appointment);
        }
    }
}
