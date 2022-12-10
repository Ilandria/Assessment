using Microsoft.EntityFrameworkCore;
using Assessment.Data;
using Assessment.Models;
namespace Assessment.Controllers;

public static class ListingsEndpoints
{
    public static void MapListingEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Listing", async (LevelTwoContext db) =>
        {
            return await db.Listing.ToListAsync();
        })
        .WithName("GetAllListings");

        routes.MapGet("/api/Listing/{id}", async (int Id, LevelTwoContext db) =>
        {
            return await db.Listing.FindAsync(Id)
                is Listing model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetListingById");

        routes.MapPut("/api/Listing/{id}", async (int Id, Listing listing, LevelTwoContext db) =>
        {
            var foundModel = await db.Listing.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateListing");

        routes.MapPost("/api/Listing/", async (Listing listing, LevelTwoContext db) =>
        {
            db.Listing.Add(listing);
            await db.SaveChangesAsync();
            return Results.Created($"/Listings/{listing.Id}", listing);
        })
        .WithName("CreateListing");

        routes.MapDelete("/api/Listing/{id}", async (int Id, LevelTwoContext db) =>
        {
            if (await db.Listing.FindAsync(Id) is Listing listing)
            {
                db.Listing.Remove(listing);
                await db.SaveChangesAsync();
                return Results.Ok(listing);
            }

            return Results.NotFound();
        })
        .WithName("DeleteListing");
    }
}
