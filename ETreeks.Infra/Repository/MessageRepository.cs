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
    public class MessageRepository : IMessageRepository
    {

        private readonly IDbContext _context;
        public MessageRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createMessage(Message message)
        {
            var p = new DynamicParameters();
            p.Add("SubjectPac", message.Subject, dbType: System.Data.DbType.String);
            p.Add("MessageBodyPac", message.Messagebody, dbType: System.Data.DbType.String);
            p.Add("SenderEmailPac", message.Senderemail, dbType: System.Data.DbType.String);
            p.Add("RecevieremailPac", message.Recevieremail, dbType: System.Data.DbType.String);


            var result = _context.connection.ExecuteAsync("MessagePackage.createMessage", p, commandType: CommandType.StoredProcedure);

            return "createMessage Successed";
        }

        public string deleteMessage(int id)
        {
            var p = new DynamicParameters();
            p.Add("MessageIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("MessagePackage.deleteMessage", p, commandType: CommandType.StoredProcedure);
            return "deleteMessage Successed";
        }

        public List<Message> getMessage()
        {
            IEnumerable<Message> result = _context.connection.Query<Message>("MessagePackage.getMessage", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateMessage(Message message)
        {
            var p = new DynamicParameters();
            p.Add("MessageIdPac", message.Messageid, dbType: System.Data.DbType.Decimal);
            p.Add("SubjectPac", message.Subject, dbType: System.Data.DbType.String);
            p.Add("MessageBodyPac", message.Messagebody, dbType: System.Data.DbType.String);
            p.Add("SenderEmailPac", message.Senderemail, dbType: System.Data.DbType.String);
            p.Add("RecevieremailPac", message.Recevieremail, dbType: System.Data.DbType.String);


            var result = _context.connection.ExecuteAsync("MessagePackage.updateMessage", p, commandType: CommandType.StoredProcedure);

            return "updateMessage Successed";
        }
    }
}
