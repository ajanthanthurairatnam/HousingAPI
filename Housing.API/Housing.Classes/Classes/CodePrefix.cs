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
        public string UserCodePrefix { get; set; }      
        public int UserCodeIncrementBy { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string UserCodeNextNo { get; set; }
    }
}
