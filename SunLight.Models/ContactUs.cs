using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SunLight.Models
{
   public  class ContactUs
    {
        [Required, Display(Name = "Name")]
        public string Name { get; set; }

        [Required, Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required, Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Required, Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

       [Display(Name="Department")]
        public string Department { get; set; }
    }
}
