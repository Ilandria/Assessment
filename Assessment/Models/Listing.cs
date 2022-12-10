namespace Assessment.Models
{
	public class Listing
	{
		// Keeping the order the same as how the fields appear in the CSV file for safety.
		public int Id { get; set; } = default!;

		public string ListingUrl { get; set; } = default!;

		public string Name { get; set; } = default!;

		public string Description { get; set; } = default!;

		public string PropertyType { get; set; } = default!;
	}
}
