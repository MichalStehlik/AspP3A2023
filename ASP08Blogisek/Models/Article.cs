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
        public IdentityUser Author { get; set; }
        public required string AuthorId { get; set; }
    }
}
