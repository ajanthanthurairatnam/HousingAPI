using Housing.Classes.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class AuditRecord
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string AuditRecordCode { get; set; }
        public AuditTable AuditTable { get; set; }
        public AuditType AuditType { get; set; }
        public string AuditPreviousRecord { get; set; }
        public string AuditCurrentRecord { get; set; }
        public DateTime AuditCreatedDate { get; set; }
        public int AuditCreatedBy { get; set; }       
    }
}
