using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BarApp.Models
{
    public class Menu
    {
        [Key]
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageThmbnailUrl { get; set; }
    }
}