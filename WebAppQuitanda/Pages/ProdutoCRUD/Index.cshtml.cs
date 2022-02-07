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
    public class IndexModel : PageModel
    {
        private readonly WebAppQuitanda.Data.ApplicationDbContext _context;

        public IndexModel(WebAppQuitanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
