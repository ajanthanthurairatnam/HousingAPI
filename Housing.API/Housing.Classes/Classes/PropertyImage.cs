using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.Classes
{
   public class PropertyImage
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string PropertyImageCode { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string PropertyImageName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string PropertyImageLocation { get; set; }
        public Property Property { get; set; }
        public DateTime PropertyImageCreatedDate { get; set; }
        public int PropertyImageCreatedBy { get; set; }
        public DateTime PropertyImageUpdatedDate { get; set; }
        public int PropertyImageUpdatedBy { get; set; }
    }
}
