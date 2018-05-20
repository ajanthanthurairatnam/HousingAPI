using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class Buyer
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string BuyerCode { get; set; }
        public SystemUser SystemUser { get; set; }
        public DateTime BuyerCreatedDate { get; set; }
        public int BuyerCreatedBy { get; set; }
        public DateTime BuyerUpdatedDate { get; set; }
        public int BuyerUpdatedBy { get; set; }
    }
}
