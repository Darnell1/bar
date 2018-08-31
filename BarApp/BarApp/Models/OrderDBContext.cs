using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BarApp.Models
{
    public class OrderDBContext : DbContext
    {
        public DbSet<Menu> menus { get; set; }
    }
}