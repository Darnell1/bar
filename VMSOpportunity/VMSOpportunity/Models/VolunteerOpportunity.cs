using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VMSOpportunity.Models
{
    public class VolunteerOpportunity
    {
        [Key]
        public String VolunteerID { get; set; }

        [Required(ErrorMessage = "Please give a name of the oppurtunity")]
        public String Opportunity { get; set; }

        [Required(ErrorMessage = "Please give a quick description of the oppurtunity")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Please list what centers the oppurtunity will be held at")]
        public String Center { get; set; }

        [Required(ErrorMessage = "What days will this oppurnity be held on")]
        public String Days { get; set; }

        [Required(ErrorMessage = "What times will this oppurtunity be held at")]
        public String Time { get; set; }

    }
}