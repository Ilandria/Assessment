using Assessment.Controllers;
using Assessment.Data;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LevelTwoContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("LevelTwoContext") ?? throw new InvalidOperationException("Connection string 'LevelTwoContext' not found.")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapListingEndpoints();
app.Run();
