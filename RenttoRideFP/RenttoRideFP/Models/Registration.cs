using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RenttoRideFP.Models
{
    [MetadataType(typeof(customerMeta))]
    public partial class customer_acc
    {
        public class customerMeta { 
        [Required]
        [Display(Name ="First Name")]
        public string customer_firstname { get; set; }

        [Required]
        [Display(Name ="Middle Name")]
        public string customer_middlename { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string customer_lastname { get; set; }

        [Required]
        [Display(Name = "Suffix")]
        public string customer_namesuffix { get; set; }

        [Required]
        [Display(Name = "Contact")]
        public string customer_contact { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string customer_email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string customer_password { get; set; }
        }


    }

}