using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }   

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        public bool IsRead { get; set; }

    }
}
