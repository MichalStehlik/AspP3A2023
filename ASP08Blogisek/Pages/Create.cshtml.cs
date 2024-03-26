using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP08Blogisek.Data;
using ASP08Blogisek.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ASP08Blogisek.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ASP08Blogisek.Data.ApplicationDbContext _context;

        public CreateModel(ASP08Blogisek.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CreateArticleIM Input { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Articles == null || Input == null)
            {
                return Page();
            }

            Guid userId = Guid.Parse(User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault()!.Value);

            Article article = new Article {
                Title = Input.Title,
                Content = Input.Content,
                Created = DateTime.Now,
                AuthorId = userId
            };
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

    public class CreateArticleIM
    {
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Content { get; set; }
    }
}
