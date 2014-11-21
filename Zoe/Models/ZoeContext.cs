using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Zoe.Models
{
    public class ZoeContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<SurgeryType> SurgeryTypes { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
    }
}