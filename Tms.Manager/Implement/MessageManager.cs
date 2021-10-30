using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.Common.Entities;
using Tms.DB.Interface;
using Tms.Manager.Interface;

namespace Tms.Manager.Implement
{
    class MessageManager : IMessageManager
    {
        protected readonly IMessageDB _messageDB;
        public MessageManager(IMessageDB managerDB)
        {
            _messageDB = managerDB;
        }
        public long Add(Message message)
        {
            return _messageDB.Add(message);
        }

        public List<Message> GetAll()
        {
            return _messageDB.GetAll();
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
