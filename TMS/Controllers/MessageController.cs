using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tms.Common.Entities;
using Tms.Manager.Interface;

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageManager _messageManager;
        public MessageController(IMessageManager messageManager)
        {
            _messageManager = messageManager;
        }

        [HttpPost]
        public IActionResult Insert(Message message)
        {
            if(ModelState.IsValid)
            {
                if(message != null)
                {
                    return Ok(_messageManager.Add(message));
                }
                else
                {
                    return Ok(false);
                }
            }
            else
            {
                return Ok(false);
            }
        }

        public IActionResult GetAll()
        {
            return Ok(_messageManager.GetAll());
        }
    }
}
