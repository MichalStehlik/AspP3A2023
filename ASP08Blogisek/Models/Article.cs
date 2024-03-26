using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ASP08Blogisek.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Content { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public ApplicationUser Author { get; set; }
        public required Guid AuthorId { get; set; }
    }
}
