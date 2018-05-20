using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Housing.Classes
{
    public class SystemUser
    {
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string SystemUserCode { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string SystemUserName { get; set; }       
        public UserType SystemUseType { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(5)]
        public string SystemUserTitle { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string SystemUserFirstName { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string SystemUserLastName { get; set; }       
        public Gender SystemUserGender { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string SystemUserEmail { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string SystemUserMobile { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string SystemUserLandLine { get; set; }
        public DateTime SystemUserCreatedDate { get; set; }
        public int SystemUserCreatedBy { get; set; }
        public DateTime SystemUserUpdatedDate { get; set; }
        public int SystemUserUpdatedBy { get; set; }
    }
}
