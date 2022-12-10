using Assessment.Models;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace Assessment.Utils
{
	public static class CsvUtils
	{
		public static IEnumerable<Model> ReadCsv<Model>(Func<string[], Model> dtoConverter, string serverFilePath)
		{
			Debug.Assert(dtoConverter != null);

			List<Model> entries = new();

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
						// Delegating parsing to the caller since this is now used for multiple model types.
						entries.Add(dtoConverter(fields));
					}
				}
			}
			catch (Exception)
			{
				// This is pretty hacky, but it will prevent things from crashing if the file isn't found or malformatted.
				entries.Clear();
			}

			return entries;
		}

		// Todo: I don't like this class being aware of data model types, refactor at some point.

		public static IEnumerable<Listing> ReadListingsCsv()
		{
			const string listingsFilePath = "./CSV/listings.csv";

			return ReadCsv(fields =>
			{
				// Todo: This assumes the CSV only contains specific formatting, deal with errors later if I have time.
				return new Listing()
				{
					Id = int.Parse(fields[0]),
					ListingUrl = fields[1],
					Name = fields[2],
					Description = fields[3],
					PropertyType = fields[4]
				};
			}, listingsFilePath);
		}

		public static IEnumerable<CalendarEntry> ReadCalendarCsv()
		{
			const string calendarFilePath = "./CSV/calendar.csv";

			return ReadCsv(fields =>
			{
				// Todo: This assumes the CSV only contains specific formatting, deal with errors later if I have time.
				return new CalendarEntry()
				{
					ListingId = int.Parse(fields[0]),
					Date = DateTime.Parse(fields[1]).Date,
					Available = bool.Parse(fields[2]),
					Price = float.Parse(fields[3].Trim('$'))
				};
			}, calendarFilePath);
		}

		public static IEnumerable<Review> ReadReviewsCsv()
		{
			const string reviewsFilePath = "./CSV/reviews.csv";

			return ReadCsv(fields =>
			{
				// Todo: This assumes the CSV only contains specific formatting, deal with errors later if I have time.
				return new Review()
				{
					ListingId = int.Parse(fields[0]),
					Id = int.Parse(fields[1]),
					Date = DateTime.Parse(fields[2]).Date,
					ReviewerId = int.Parse(fields[3]),
					ReviewerName = fields[4],
					Comments = fields[5]
				};
			}, reviewsFilePath);
		}
	}
}
