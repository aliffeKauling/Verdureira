using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppQuitanda.Data;
using WebAppQuitanda.Models;


namespace WebAppQuitanda.Pages.ClienteCRUD
{
    public class ListarModel : PageModel
    {
        private readonly ApplicationDbContext _context;
       

        public IList<Cliente> Clientes { get; set; }

        public ListarModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Clientes = await _context.Clientes.ToListAsync();
        }  
        
        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Listar");
        }
    }
}

