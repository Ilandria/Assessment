using Assessment.Models;
using Assessment.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Controllers
{
	// Note: This does not use the DB connection that was created in level two. Each endpoint call reads the CSV from disk.

	// This controller naming is just for clarity on the test.
	[Route("api/[controller]")]
	[ApiController]
	public class LevelOneController : ControllerBase
	{
		// Todo: Come back and add tests after level 2.

		[HttpGet("~/listing")]
		public Listing? GetListing(int id)
		{
			// Todo: Probably don't want to hard-code this here...
			IEnumerable<Listing> listings = CsvUtils.ReadListingsCsv();

			return listings.SingleOrDefault(listing => listing.Id == id);
		}

		[HttpGet("~/listings")]
		public IEnumerable<Listing> GetListings(int pageNum = 1, int resultsPerPage = 2, string? propertyType = null)
		{
			// Todo: Probably don't want to hard-code this here...
			IEnumerable<Listing> listings = CsvUtils.ReadListingsCsv();

			// Basic filtering by property type. This lets us use one endpoint for both cases pretty intuitively.
			if (!string.IsNullOrWhiteSpace(propertyType))
			{
				listings = listings.Where(listing => string.Compare(listing.PropertyType, propertyType) == 0);
			}

			// Basic sanity limits for pagination (min 1 per page, max 10 per page, can't be on a page num below 1).
			const int maxPageSize = 10;
			pageNum = Math.Max(1, pageNum);
			resultsPerPage = Math.Min(Math.Max(1, resultsPerPage), maxPageSize);

			return listings.Skip(resultsPerPage * (pageNum - 1)).Take(resultsPerPage).ToList();
		}
	}
}
