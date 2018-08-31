using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BarApp.Models
{
    public class AppBarDBContext : DbContext
    {
        public DbSet<Menu> menus { get; set; }
    }
}