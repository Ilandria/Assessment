using Assessment.Models;
using Assessment.Utils;
using Microsoft.EntityFrameworkCore;

namespace Assessment.Data
{
	// Same with the LevelOneController, this is just named this way for clarity on the assessment.
	public class LevelTwoContext : DbContext
	{
		public LevelTwoContext(DbContextOptions<LevelTwoContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Data seeding reference: https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding
			// Side-note: EF Core is cool!
			modelBuilder.Entity<Listing>().HasData(CsvUtils.ReadListingsCsv());
			modelBuilder.Entity<CalendarEntry>().HasData(CsvUtils.ReadCalendarCsv());
			modelBuilder.Entity<Review>().HasData(CsvUtils.ReadReviewsCsv());
		}

		public DbSet<Listing> Listings { get; set; } = default!;

		public DbSet<CalendarEntry> Calendar { get; set; } = default!;

		public DbSet<Review> Reviews { get; set; } = default!;
	}
}
