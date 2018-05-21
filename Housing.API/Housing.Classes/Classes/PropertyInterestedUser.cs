using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class PropertyInterestedUser
    {
        public int ID { get; set; }
        public Property Property { get; set; }
        public SystemUser SystemUser { get; set; }
        public DateTime PropertyInterestedUserCreatedDate { get; set; }
        public int PropertyInterestedUserCreatedBy { get; set; }
        public DateTime PropertyInterestedUserUpdatedDate { get; set; }
        public int PropertyInterestedUserUpdatedBy { get; set; }

    }
}
