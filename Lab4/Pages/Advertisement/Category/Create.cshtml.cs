using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Pages.Advertisement.Category
{
    public class CreateModel : PageModel
    {
        private readonly Lab4.Data.Lab4Context _context;

        public CreateModel(Lab4.Data.Lab4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Categories Categories { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Categories);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
