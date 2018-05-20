using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class PropertyBuyer
    {
        public int ID { get; set; }
        public Property Property { get; set; }
        public DateTime PropertyBuyerCreatedDate { get; set; }
        public int PropertyBuyerCreatedBy { get; set; }
        public DateTime PropertyBuyerUpdatedDate { get; set; }
        public int PropertyBuyerUpdatedBy { get; set; }
    }
}
