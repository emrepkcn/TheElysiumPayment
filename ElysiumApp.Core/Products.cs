using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Core
{
    public class Products:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int ProductLabelId { get; set; }
        public int LangId { get; set; }
    }
}
