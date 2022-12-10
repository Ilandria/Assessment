using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment.Models
{
	public class CalendarEntry
	{
		// Keeping the order the same as how the fields appear in the CSV file for safety.
		public int ListingId { get; set; }

		public DateTime Date { get; set; }

		public bool Available { get; set; }

		public float Price { get; set; }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
	}
}
