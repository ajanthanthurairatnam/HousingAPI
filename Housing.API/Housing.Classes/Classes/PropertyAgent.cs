using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class PropertyAgent
    {
        public int ID { get; set; }
        public Property Property { get; set; }
        public DateTime PropertyAgentCreatedDate { get; set; }
        public int PropertyAgentCreatedBy { get; set; }
        public DateTime PropertyAgentUpdatedDate { get; set; }
        public int PropertyAgentUpdatedBy { get; set; }
    }
}
