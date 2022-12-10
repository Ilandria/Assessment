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

		routes.MapGet("/api/listing/{id}", async (int Id, LevelTwoContext db) =>
		{
			return await db.Listings.FindAsync(Id)
				is Listing model
					? Results.Ok(model)
					: Results.NotFound();
		})
		.WithName("GetListingById");

		routes.MapPut("/api/listing/{id}", async (int Id, Listing listing, LevelTwoContext db) =>
		{
			var foundModel = await db.Listings.FindAsync(Id);

			if (foundModel is null)
			{
				return Results.NotFound();
			}

			// Todo: Update model properties here.

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

		routes.MapDelete("/api/listing/{id}", async (int Id, LevelTwoContext db) =>
		{
			if (await db.Listings.FindAsync(Id) is Listing listing)
			{
				db.Listings.Remove(listing);
				await db.SaveChangesAsync();
				return Results.Ok(listing);
			}

			return Results.NotFound();
		})
		.WithName("DeleteListing");
	}
}
