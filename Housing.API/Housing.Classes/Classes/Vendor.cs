using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class Vendor
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string VendorCode { get; set; }
        public SystemUser SystemUser { get; set; }
        public DateTime VendorCreatedDate { get; set; }
        public int VendorCreatedBy { get; set; }
        public DateTime VendorUpdatedDate { get; set; }
        public int VendorUpdatedBy { get; set; }
    }
}
