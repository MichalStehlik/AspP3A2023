using Microsoft.AspNetCore.Identity;

namespace ASP08Blogisek.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Article> Articles { get; set; }
    }
}
