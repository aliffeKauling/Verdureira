using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppQuitanda.Data;
using WebAppQuitanda.Models;

namespace WebAppQuitanda.Pages.ProdutoCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppQuitanda.Data.ApplicationDbContext _context;

        public DetailsModel(WebAppQuitanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.IdProdto == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
