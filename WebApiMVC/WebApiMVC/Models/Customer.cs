using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMVC.Models
{
    public class Customer
    {

        [Display(Name = "CustomerId")]
        public int CustomerId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "MobileNo")]
        public string MobileNo { get; set; }
        [Display(Name = "Birthdate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //[Display(Prompt = "MM/DD/YYYY")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Display(Name = "EmailId")]
        public string EmailId { get; set; }
    }
}