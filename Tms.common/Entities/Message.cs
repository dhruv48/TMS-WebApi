using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tms.Common.Enum.Enum;

namespace Tms.Common.Entities
{
    public class Message:CommonEntity
    {
        [Required]
        public string Name { get; set; }
        public string Messages { get; set; }
        [Required]
        public string Email { get; set; }
        public Subject Subject { get; set; }
    }
}
