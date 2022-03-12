using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
  public  interface IAppointmentService
    {
        string createAppointment(Appointment appointment);
        string deleteAppointment(int id);
        string updateAppointment(Appointment appointment);
        List<Appointment> getAppointment();

    }
}
