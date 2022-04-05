using Dapper;
using ETreeks.Core.Common;
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
    }
}
