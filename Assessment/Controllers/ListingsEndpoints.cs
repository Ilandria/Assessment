using Microsoft.EntityFrameworkCore;
using Assessment.Data;
using Assessment.Models;
namespace Assessment.Controllers;

// Test only asks for Listings table endpoints, endpoints for other tables would look similar though.
public static class ListingsEndpoints
{
	public static void MapListingEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapGet("/api/listing", async (LevelTwoContext db) =>
		{
			return await db.Listings.ToListAsync();
		})
		.WithName("GetAllListings");

		routes.MapGet("/api/listing/{id}", async (int id, LevelTwoContext db) =>
		{
			return await db.Listings.FindAsync(id)
				is Listing model
					? Results.Ok(model)
					: Results.NotFound();
		})
		.WithName("GetListingById");

		routes.MapPut("/api/listing/{id}", async (int id, Listing listing, LevelTwoContext db) =>
		{
			var foundModel = await db.Listings.FindAsync(id);

			if (foundModel is null)
			{
				return Results.NotFound();
			}

			// Todo: Is there a way to hide the visibility of the primary key (Listing.Id) from Swagger schema docs?
			foundModel.ListingUrl = $"{listing.ListingUrl}";
			foundModel.Name = $"{listing.Name}";
			foundModel.Description = $"{listing.Description}";
			foundModel.PropertyType = $"{listing.PropertyType}";

			await db.SaveChangesAsync();

			return Results.NoContent();
		})
		.WithName("UpdateListing");

		routes.MapPost("/api/listing/", async (Listing listing, LevelTwoContext db) =>
		{
			db.Listings.Add(listing);
			await db.SaveChangesAsync();
			return Results.Created($"/listings/{listing.Id}", listing);
		})
		.WithName("CreateListing");

		routes.MapDelete("/api/listing/{id}", async (int id, LevelTwoContext db) =>
		{
			if (await db.Listings.FindAsync(id) is Listing listing)
			{
				db.Listings.Remove(listing);

				// Do we want to delete review/calendar entries related to the listing, or keep them for historical purposes? Assuming delete for now...
				// Todo: A bit of research says that RemoveRange loads the entire table into memory. Definitely not sustainable, but this solution is simple for now.
				db.Reviews.RemoveRange(db.Reviews.Where(review => review.ListingId == listing.Id));
				db.Calendar.RemoveRange(db.Calendar.Where(calendarEntry => calendarEntry.ListingId == listing.Id));

				await db.SaveChangesAsync();
				return Results.Ok(listing);
			}

			return Results.NotFound();
		})
		.WithName("DeleteListing");
	}
}
