using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VMSOpportunity.Models
{
    public class VolunteerOpportunityDBContext : DbContext
    {
        public DbSet<VolunteerOpportunity> VO { get; set; }
    }
}