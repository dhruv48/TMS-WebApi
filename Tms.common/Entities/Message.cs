using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tms.Common.Enum.Enum;

namespace Tms.Common.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Messages { get; set; }
        public string Email { get; set; }
        public Subject Subject { get; set; }
    }
}
