using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace VMS.Models
{
    public class UserAccount
    {
        [Required(ErrorMessage = "Please enter a first name")]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Please enter a username")]
        public String UserName { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Please state what centers you would like to work for")]
        public String Centers { get; set; }
        [Required(ErrorMessage = "Please list your skills/interest")]
        public String Skills { get; set; }
        [Required(ErrorMessage = "Please state what times you are available")]
        public String Availability { get; set; }
        [Required(ErrorMessage = "Please give your current address")]
        public String Address { get; set; }
        [Required(ErrorMessage = "Please your most up to date number")]
        public String Number { get; set; }
        [Required(ErrorMessage = "Please enter a first name")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please list the levels of education received")]
        public String Education { get; set; }
        [Required(ErrorMessage = "Please list any licenses received")]
        public String Licenses { get; set; }
        [Required(ErrorMessage = "Please enter a emergency contact name")]
        public String ContactName { get; set; }
        [Required(ErrorMessage = "Please enter a emergency contact number")]
        public String ContactPhone { get; set; }
        [Required(ErrorMessage = "Please enter a emergency contact address")]
        public String ContactAddress { get; set; }
        [Required(ErrorMessage = "Please state whether you have a drivers license")]
        public String DriversLicense { get; set; }
        [Required(ErrorMessage = "Please state whether you have a social security card")]
        public String SocialSecurity { get; set; }
        public String ApprovalStatus { get; set; }
    }
}
