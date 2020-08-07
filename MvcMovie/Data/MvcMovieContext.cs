using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
// The preceding code creates a DbSet<Movie> property for the entity set. 
// In Entity Framework terminology, an entity set typically corresponds to a database table. 
// An entity corresponds to a row in the table.