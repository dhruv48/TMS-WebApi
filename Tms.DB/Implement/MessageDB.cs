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
                string query = string.Format(@"INSERT INTO tms.feedback(name,email,subject,message)
                       VALUES(@name,@email,@subject,@messages)");
                return connection.Execute(query, message);
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Delete(long Id)
        {
            try
            {
                string query = "DELETE from tms.feedback where id = @id";
                connection.Execute(query, new { id = Id });
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Message> GetAll()
        {
            try
            {
                string query = string.Format(@"Select * from tms.feedback where isactive");
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

        public long Update(Message message, long Id)
        {
            try
            {
                string query = string.Format(@"Update tms.feedback SET name= @name,message=@messages,subject=@subject,email=@email WHERE id =@id");
                return connection.Execute(query, message);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
