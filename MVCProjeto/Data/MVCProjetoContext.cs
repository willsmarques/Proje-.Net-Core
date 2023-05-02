using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProjeto.Models;

namespace MVCProjeto.Data
{
    public class MVCProjetoContext : DbContext
    {
        public MVCProjetoContext (DbContextOptions<MVCProjetoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProjeto.Models.Department> Department { get; set; } = default!;
    }
}
