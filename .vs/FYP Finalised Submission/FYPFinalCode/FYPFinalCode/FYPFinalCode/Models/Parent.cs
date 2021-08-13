using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FYPFinalCode.Models
{
    public partial class Parent
    {
        public int ParentId { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string ParentEmail { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password must be 5 characters or more")]
        public string ParentEmailPass { get; set; }
        public string ParentEntryPass { get; set; }
        public string ParentName { get; set; }
        public string ParentMobileNo { get; set; }
        public int ParentVc { get; set; }

     
    }
}
