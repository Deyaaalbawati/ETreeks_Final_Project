using ETreeks.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
 public  interface IAppointmentRepository
    {
        string createAppointment(Appointment appointment);
        string deleteAppointment(int id);
        string updateAppointment(Appointment appointment);
        string updateAppointmentStatus(int appointmentId, string appointmentStatus);
        List<Appointment> getAppointment();
        List<Appointment> getAppointmentByAccountId(int AccountId);
        List<Appointment> getAppointmentByCourseId(int CourseId);
        public List<AppointmentTeacher> getAppintmentTeacher(int Courseid);

        public List<SerachBetweenTwoDate> SerachBetweenTwoDate(int TeacherId ,DateTime StartDate , DateTime EndDate);

        public List<TeacherDashboardAppintment> getTeacherDashboardAppintment(int TeacherId);
        public List<StudentAppointment> getStudentAppintment(int StudentId);

    }
}
