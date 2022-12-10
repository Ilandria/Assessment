using Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;

namespace Assessment.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LevelOneController : ControllerBase
	{
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
						// Todo: Parse things!
						//listings.Add();
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
