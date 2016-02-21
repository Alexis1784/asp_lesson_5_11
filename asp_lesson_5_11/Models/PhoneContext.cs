using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace asp_lesson_5_11.Models
{
    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Users { get; set; }
    }
}