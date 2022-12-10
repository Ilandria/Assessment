using Assessment.Models;
using Microsoft.VisualBasic.FileIO;

namespace Assessment.Utils
{
	public static class CsvUtils
	{
		// Todo: Don't hardcode this.
		public const string listingsFilePath = "./CSV/listings.csv";

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
