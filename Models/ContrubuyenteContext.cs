using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRnc.Models
{
    public class ContrubuyenteContext : DbContext
    {
      
        public ContrubuyenteContext(DbContextOptions<ContrubuyenteContext> options) : base(options)
        {

        }

        public DbSet<Contribuyente> Contribuyentes { get; set; }
    }
}
