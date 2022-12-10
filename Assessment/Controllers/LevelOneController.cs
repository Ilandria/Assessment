using Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;

namespace Assessment.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LevelOneController : ControllerBase
	{
		private const string listingsFilePath = "./CSV/listings.csv";

		[HttpGet("~/listing")]
		public Listing? GetListing(int id, string serverFilePath = listingsFilePath)
		{
			// Todo: Probably don't want to hard-code this here...
			IEnumerable<Listing> listings = ReadListingsCsv(serverFilePath);

			return listings.SingleOrDefault(listing => listing.Id == id);
		}

		[HttpGet("~/listings")]
		public IEnumerable<Listing> GetListings(int pageNum = 1, int resultsPerPage = 2, string serverFilePath = listingsFilePath)
		{
			// Todo: Probably don't want to hard-code this here...
			IEnumerable<Listing> listings = ReadListingsCsv(serverFilePath);

			// Basic sanity limits for pagination (min 1 per page, max 10 per page, can't be on a page num below 1).
			const int maxPageSize = 10;
			pageNum = Math.Max(1, pageNum);
			resultsPerPage = Math.Min(Math.Max(1, resultsPerPage), maxPageSize);

			return listings.Skip(resultsPerPage * (pageNum - 1)).Take(resultsPerPage).ToList();
		}

		public static IEnumerable<Listing> ReadListingsCsv(string serverFilePath)
		{
			List<Listing> listings = new();

			try
			{
				using TextFieldParser parser = new(serverFilePath);

				parser.SetDelimiters(",");
				parser.HasFieldsEnclosedInQuotes = true;

				// This assumes the file has headers. This works for now...
				parser.ReadLine();

				while (!parser.EndOfData)
				{
					string[]? fields = parser.ReadFields();

					if (fields != null)
					{
						// Todo: This assumes the CSV only contains valid formatting, deal with errors later if I have time.
						listings.Add(new Listing()
						{
							Id = int.Parse(fields[0]),
							ListingUrl = fields[1],
							Name = fields[2],
							Description = fields[3],
							PropertyType = fields[4]
						});
					}
				}
			}
			catch (Exception)
			{
				// This is pretty hacky, but it will prevent things from crashing if the file isn't found or malformatted.
				listings.Clear();
			}

			return listings;
		}
	}
}
