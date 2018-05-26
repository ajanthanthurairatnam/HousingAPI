using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Housing.Classes
{
    public class CodePrefix
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string AuditRecordCodePrefix { get; set; }
        public int AuditRecordCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string UserCodeNextNo { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string AgentCodePrefix { get; set; }
        public int AgentCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string AgentCodeNextNo { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string BuyerCodePrefix { get; set; }
        public int BuyerCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string BuyerCodeNextNo { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string PropertyCodePrefix { get; set; }
        public int PropertyCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string PropertyCodeNextNo { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string PropertyImageCodePrefix { get; set; }
        public int PropertyImageCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string PropertyImageCodeNextNo { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string UserCodePrefix { get; set; }
        public int UserCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(3)]
        public string VendorCodePrefix { get; set; }
        public int VendorCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string VendorCodeNextNo { get; set; }
    }
}
