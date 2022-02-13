using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppQuitanda.Models;

namespace WebAppQuitanda.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppQuitanda.Models.Produto> Produto { get; set; }
        public DbSet<WebAppQuitanda.Models.Cliente> Clientes { get; set; }

    }
}
