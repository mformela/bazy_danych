using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MFAirlinesNewProject.Models
{
    public class AirlinesContext : DbContext
    {
        public DbSet<Stanowisko> Stanowiska { get; set; }
    }
}