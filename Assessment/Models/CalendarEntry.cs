using System.ComponentModel.DataAnnotations;

namespace Assessment.Models
{
	public class CalendarEntry
	{
		// Keeping the order the same as how the fields appear in the CSV file for safety.
		public int ListingId { get; set; }

		public DateTime Date { get; set; }

		public bool Available { get; set; }

		public float Price { get; set; }

		// Todo: Make sure it properly sets the primary key in the DB to this instead of ListingId.
		[Key]
		public int Id { get; set; }
	}
}
