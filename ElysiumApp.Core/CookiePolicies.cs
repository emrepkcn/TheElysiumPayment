using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Core
{
    public class CookiePolicies
    {
        public int Id { get; set; }
        public bool Mandatory { get; set; }
        public bool Functionality { get; set; }
        public bool PerformanceAnalytics { get; set; }
        public bool PersonalizedAdvertising { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
