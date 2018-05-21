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
   public class Property
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string PropertyCode { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string PropertyShortDescription { get; set; }
        public PropertyType PropertyType { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]        
        public string PropertyDescription { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        public string PropertyFeatures { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string PropertyLocation { get; set; }
        public DateTime PropertyAdvertisementStartDate { get; set; }
        public DateTime PropertyAdvertisementFinishDate { get; set; }
        public bool IsActive { get; set; }
        public decimal PropertyPrice { get; set; }
        public int? Bedrooms { get; set; }
        public int? Restrooms { get; set; }
        public int? CarParks { get; set; }
        public AdvertisementType AdvertisementType { get; set; }
        public DateTime? PropertyAdvertisementStart { get; set; }
        public DateTime? PropertyAdvertisementEnd { get; set; }
        public DateTime PropertyCreatedDate { get; set; }
        public int PropertyCreatedBy { get; set; }
        public DateTime PropertyUpdatedDate { get; set; }
        public int PropertyUpdatedBy { get; set; }
    }
}
