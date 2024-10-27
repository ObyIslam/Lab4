using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Pages.Advertisement.Supplier
{
    public class EditModel : PageModel
    {
        private readonly Lab4.Data.Lab4Context _context;

        public EditModel(Lab4.Data.Lab4Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Suppliers Suppliers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suppliers =  await _context.Suppliers.FirstOrDefaultAsync(m => m.ID == id);
            if (suppliers == null)
            {
                return NotFound();
            }
            Suppliers = suppliers;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Suppliers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliersExists(Suppliers.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SuppliersExists(int id)
        {
            return _context.Suppliers.Any(e => e.ID == id);
        }
    }
}
