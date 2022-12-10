using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment.Models
{
	public class Review
	{
		// Keeping the order the same as how the fields appear in the CSV file for safety.
		public int ListingId { get; set; }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public int ReviewerId { get; set; }

		public string ReviewerName { get; set; } = default!;

		public string Comments { get; set; } = default!;
	}
}
