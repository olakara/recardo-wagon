﻿using Microsoft.EntityFrameworkCore;

namespace Movies.Api.Movies;

public class MoviesDbContext : DbContext
{
    public MoviesDbContext(DbContextOptions<MoviesDbContext> options): base(options)
    {
        
    }
    
    public DbSet<Movie> Movies { get; set; }
}