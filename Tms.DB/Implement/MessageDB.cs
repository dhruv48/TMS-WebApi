using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.Common.Entities;
using Tms.DB.Infrastructure;
using Tms.DB.Interface;

namespace Tms.DB.Implement
{
    public class MessageDB : BaseDB, IMessageDB
    {
        public MessageDB(IConfiguration configuration) : base(configuration)
        {

        }
        public long Add(Message message)
        {
            try
            {
                string query = string.Format(@"INSERT INTO tms.feedback(name,subject,email,message)
                       VALUES(@name,@subject,@email,@message)returning id");
                return connection.Execute(query, message);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Message> GetAll()
        {
            try
            {
                string query = string.Format(@"Select * from tms.message where isactive");
                return connection.Query<Message>(query).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Message GetBy(long Id)
        {
            throw new NotImplementedException();
        }

        public long Update(Message obj)
        {
            throw new NotImplementedException();
        }
    }
}
