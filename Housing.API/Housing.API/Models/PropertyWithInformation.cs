using Housing.Classes;
using Housing.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Housing.API.Models
{
    public class PropertyWithInformation
    {
        public int ID { get; set; }       
        public string PropertyCode { get; set; }       
        public string PropertyShortDescription { get; set; }
        public int PropertyTypeID { get; set; }       
        public string PropertyTypeDescription { get; set; }
        public DateTime PropertyTypeCreatedDate { get; set; }
        public int PropertyTypeCreatedBy { get; set; }
        public DateTime PropertyTypeUpdatedDate { get; set; }
        public int PropertyTypeUpdatedBy { get; set; }
        public string PropertyDescription { get; set; }       
        public string PropertyFeatures { get; set; }      
        public string PropertyLocation { get; set; }
        public bool IsActive { get; set; }
        public decimal PropertyPrice { get; set; }
        public int? Bedrooms { get; set; }
        public int? Restrooms { get; set; }
        public int? CarParks { get; set; }
        public int AdvertisementTypeID { get; set; }
        public string AdvertisementTypeDescription { get; set; }
       public DateTime? PropertyAdvertisementStartDate { get; set; }
        public DateTime? PropertyAdvertisementFinishDate { get; set; }
        public DateTime PropertyCreatedDate { get; set; }
        public int PropertyCreatedBy { get; set; }
        public DateTime PropertyUpdatedDate { get; set; }
        public int PropertyUpdatedBy { get; set; }
    }
}