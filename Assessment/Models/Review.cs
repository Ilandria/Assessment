using System.ComponentModel.DataAnnotations;

namespace Assessment.Models
{
	public class Review
	{
		// Keeping the order the same as how the fields appear in the CSV file for safety.
		public int ListingId { get; set; }

		// Todo: Make sure it properly sets the primary key in the DB to this instead of ListingId.
		[Key]
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public int ReviewerId { get; set; }

		public string ReviewerName { get; set; } = default!;

		public string Comments { get; set; } = default!;
	}
}
