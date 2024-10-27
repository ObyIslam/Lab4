﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Pages.Advertisement.Category
{
    public class DetailsModel : PageModel
    {
        private readonly Lab4.Data.Lab4Context _context;

        public DetailsModel(Lab4.Data.Lab4Context context)
        {
            _context = context;
        }

        public Categories Categories { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (categories == null)
            {
                return NotFound();
            }
            else
            {
                Categories = categories;
            }
            return Page();
        }
    }
}