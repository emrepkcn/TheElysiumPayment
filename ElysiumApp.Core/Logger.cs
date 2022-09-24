using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Core
{
    public class Logger
    {
        public int Id { get; set; }
        public string Exception { get; set; }
        public string Title { get; set; }
        public string IpAddress { get; set; }
        public int LogCritial { get; set; }
        public string UserId { get; set; }
    }

}
