using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Notes.Models
{
    public class User
    {
        [Key]
        public long ID { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Note> Notes { get; set; } // one-to-many relationship
    }
}