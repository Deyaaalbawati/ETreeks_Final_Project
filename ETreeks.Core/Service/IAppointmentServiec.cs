using ETreeks.Core.DTO;
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
        string updateAppointmentStatus(int appointmentId, string appointmentStatus);
        List<Appointment> getAppointment();
        List<Appointment> getAppointmentByAccountId(int AccountId);
        List<Appointment> getAppointmentByCourseId(int CourseId);
        public List<AppointmentTeacher> getAppintmentTeacher(int Courseid);

        public List<TeacherDashboardAppintment> getTeacherDashboardAppintment(int TeacherId);
        public List<SerachBetweenTwoDate> SerachBetweenTwoDate(int TeacherId, DateTime StartDate, DateTime EndDate);

        public List<StudentAppointment> getStudentAppintment(int StudentId);



    }
}
