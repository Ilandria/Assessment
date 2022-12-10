using Assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Data
{
	// Same with the LevelOneController, this is just named this way for clarity on the assessment.
	public class LevelTwoContext : DbContext
	{
		public LevelTwoContext(DbContextOptions<LevelTwoContext> options) : base(options)
		{
		}

		public DbSet<Listing> Listings { get; set; } = default!;
	}
}
