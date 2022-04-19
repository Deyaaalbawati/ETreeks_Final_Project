using Dapper;
using ETreeks.Core.Common;
using ETreeks.Core.DTO;
using ETreeks.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {

        private readonly IDbContext _context;
        public AppointmentRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createAppointment(Appointment appointment)
        {
            var p = new DynamicParameters();
            p.Add("AcoountIdPac", appointment.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("CourseIdPac", appointment.Courseid, dbType: System.Data.DbType.Decimal);

            p.Add("StartDatePac", appointment.Startdate, dbType: System.Data.DbType.DateTime);
            p.Add("EndDatePac", appointment.Enddate, dbType: System.Data.DbType.DateTime);

            p.Add("AppointmentStatusPac", appointment.Appointmentstatus, dbType: System.Data.DbType.String);

            p.Add("HourePac", appointment.Houre, dbType: System.Data.DbType.String);


            var result = _context.connection.ExecuteAsync("AppointmentPackage.createAppointment", p, commandType: CommandType.StoredProcedure);

            return "createAppointment Successed";
        }

        public string deleteAppointment(int id)
        {
            var p = new DynamicParameters();
            p.Add("AppointmentIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("AppointmentPackage.deleteAppointment", p, commandType: CommandType.StoredProcedure);
            return "deleteAppointment Successed";
        }

        public List<Appointment> getAppointment()
        {
            IEnumerable<Appointment> result = _context.connection.Query<Appointment>("AppointmentPackage.getAppointment", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Appointment> getAppointmentByAccountId(int AccountId)
        {
            var p = new DynamicParameters();
            p.Add("AccountIdPac", AccountId, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.Query<Appointment>("AppointmentPackage.getAppointmentByAccountId", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Appointment> getAppointmentByCourseId(int CourseId)
        {
            var p = new DynamicParameters();
            p.Add("CourseIdPac", CourseId, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.Query<Appointment>("AppointmentPackage.getAppointmentByCourseId", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateAppointment(Appointment appointment)
        {
            var p = new DynamicParameters();
            p.Add("AppointmentIdPac", appointment.Appointmentid, dbType: System.Data.DbType.Decimal);
            p.Add("AcoountIdPac", appointment.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("CourseIdPac", appointment.Courseid, dbType: System.Data.DbType.Decimal);

            p.Add("StartDatePac", appointment.Startdate, dbType: System.Data.DbType.DateTime);
            p.Add("EndDatePac", appointment.Enddate, dbType: System.Data.DbType.DateTime);

            p.Add("AppointmentStatusPac", appointment.Appointmentstatus, dbType: System.Data.DbType.String);

            p.Add("HourePac", appointment.Houre, dbType: System.Data.DbType.String);


            var result = _context.connection.ExecuteAsync("AppointmentPackage.updateAppointment", p, commandType: CommandType.StoredProcedure);

            return "updateAppointment Successed";
        }

        public string updateAppointmentStatus(int appointmentId, string appointmentStatus)
        {
            var p = new DynamicParameters();
            p.Add("AppointmentIdPac", appointmentId, dbType: System.Data.DbType.Decimal);
            p.Add("AppointmentStatusPac", appointmentStatus, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("AppointmentPackage.updateAppointmentStatus", p, commandType: CommandType.StoredProcedure);
            return "updateAppointment Status Successed";
        }


        public List<AppointmentTeacher> getAppintmentTeacher(int Courseid)
        {
            var p = new DynamicParameters();
            p.Add("CourseIdPac", Courseid, dbType: System.Data.DbType.Decimal);
            IEnumerable<AppointmentTeacher> result = _context.connection.Query<AppointmentTeacher>("AppintmentTeacher", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public List<TeacherDashboardAppintment> getTeacherDashboardAppintment(int TeacherId)
        {
            var p = new DynamicParameters();
            p.Add("TeacherIdPac", TeacherId, dbType: System.Data.DbType.Decimal);
            IEnumerable<TeacherDashboardAppintment> result = _context.connection.Query<TeacherDashboardAppintment>("TeacherDashboardAppintment", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

    }
}
