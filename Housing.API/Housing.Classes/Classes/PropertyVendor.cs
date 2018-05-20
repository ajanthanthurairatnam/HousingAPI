using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class PropertyVendor
    {
        public int ID { get; set; }
        public Property Property { get; set; }
        public DateTime PropertyVendorCreatedDate { get; set; }
        public int PropertyVendorCreatedBy { get; set; }
        public DateTime PropertyVendorUpdatedDate { get; set; }
        public int PropertyVendorUpdatedBy { get; set; }
    }
}
