using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppQuitanda.Data;
using WebAppQuitanda.Models;

namespace WebAppQuitanda.Pages.ClienteCRUD
{
    public class IncluirModel : PageModel
    {
        private ApplicationDbContext _context;

        [BindProperty]
        public Cliente Cliente { get; set; }

        public IncluirModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var cliente = new Cliente();
            if (await TryUpdateModelAsync<Cliente>(cliente, "cliente", obj => obj.Nome, obj => obj.DataNascimento, obj => obj.Email, obj => obj.CPF))
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Listar");
            }
            return Page();
        }
    }
}
