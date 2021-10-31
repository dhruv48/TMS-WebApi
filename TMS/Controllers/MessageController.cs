using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Insert([FromBody]Message message)
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
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_messageManager.GetAll());
        }

        [HttpDelete]
        public void Delete(long Id)
        {
            _messageManager.Delete(Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody]Message message,long Id)
        {
            return Ok(_messageManager.Update(message, Id));
        }

        
    }
}
