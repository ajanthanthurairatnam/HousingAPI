using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
    public class PropertyType
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string PropertyTypeDescription { get; set; }
        public DateTime PropertyTypeCreatedDate { get; set; }
        public int PropertyTypeCreatedBy { get; set; }
        public DateTime PropertyTypeUpdatedDate { get; set; }
        public int PropertyTypeUpdatedBy { get; set; }
    }
}
