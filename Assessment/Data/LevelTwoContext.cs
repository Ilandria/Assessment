using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessment.Models;

namespace Assessment.Data
{
    public class LevelTwoContext : DbContext
    {
        public LevelTwoContext (DbContextOptions<LevelTwoContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment.Models.Listing> Listing { get; set; } = default!;
    }
}
