using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Notes.Models
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
        : base(options) {  }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}