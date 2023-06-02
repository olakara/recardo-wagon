using Microsoft.EntityFrameworkCore;
using Movies.Api.Movies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MoviesDbContext>(options => options.UseInMemoryDatabase("Movies"));
var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();
