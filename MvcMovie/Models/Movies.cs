using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        // The Movie class contains an Id field, 
        // which is required by the database for the primary key.
        public int Id { get; set; } 
        public string Title { get; set; }

        // The DataType attribute on ReleaseDate specifies the type of the data (Date). 
        // The user is not required to enter time information in the date field.
        // Only the date is displayed, not time information.
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
// A database context class is needed to coordinate EF Core functionality (Create, Read, Update, Delete) for the Movie model. 
// The database context is derived from Microsoft.EntityFrameworkCore.DbContext and specifies the entities to include in the data model.