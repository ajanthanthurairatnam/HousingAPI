using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class Agent
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string AgentCode { get; set; }
        public SystemUser SystemUser { get; set; }
        public DateTime AgentCreatedDate { get; set; }
        public int AgentCreatedBy { get; set; }
        public DateTime AgentUpdatedDate { get; set; }
        public int AgentUpdatedBy { get; set; }
    }
}
