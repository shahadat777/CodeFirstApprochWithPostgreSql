using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UMS.Models
{
    public class UMSContext : DbContext
    {
        public UMSContext (DbContextOptions<UMSContext> options)
            : base(options)
        {
        }

        public DbSet<UMS.Models.Student> Student { get; set; }
    }
}
